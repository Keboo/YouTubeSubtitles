using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Runtime.Versioning;

namespace Keboo.Editor;

[SupportedOSPlatform("windows")]
public static class ThumbnailGenerator
{
    public const int MaxTitleLines = 3;

    // Layout is expressed relative to the 1668x936 reference layout of VideoBackground.png.
    private const float ReferenceWidth = 1668f;
    private const float ReferenceHeight = 936f;
    // Font sizes in the design are expressed against this ratio of the reference layout.
    private const float FontScale = 1.8f;

    private const float CenterX = 848f / ReferenceWidth;
    private const float ProjectCenterY = 75f / ReferenceHeight;
    private const float TechCenterY = 882f / ReferenceHeight;
    // Safe title area: inside the green border and clear of the logo and the top/bottom boxes.
    private static readonly RectangleF TitleArea = new(
        200f / ReferenceWidth, 220f / ReferenceHeight,
        1300f / ReferenceWidth, 520f / ReferenceHeight);

    private const float TitleMaxSize = 72f;
    private const float TitleMinSize = 55f;

    private static readonly Color TextColor = ColorTranslator.FromHtml("#EDF4E0");

    public static FileInfo GetDefaultBackground() =>
        new(Path.Combine(AppContext.BaseDirectory, "Assets", "VideoBackground.png"));

    public static bool TryGenerate(
        FileInfo backgroundFile,
        string title,
        string project,
        string tech,
        Stream output,
        out string error)
    {
        error = string.Empty;
        if (!backgroundFile.Exists)
        {
            error = $"Background image '{backgroundFile.FullName}' was not found.";
            return false;
        }

        using var installedFonts = new InstalledFontCollection();
        foreach (string family in new[] { "Roboto Medium", "Roboto Condensed" })
        {
            if (!installedFonts.Families.Any(x => string.Equals(x.Name, family, StringComparison.OrdinalIgnoreCase)))
            {
                error = $"Font '{family}' is not installed.";
                return false;
            }
        }

        using var background = new Bitmap(backgroundFile.FullName);
        using var bitmap = new Bitmap(background.Width, background.Height, PixelFormat.Format32bppArgb);
        using var g = Graphics.FromImage(bitmap);
        g.SmoothingMode = SmoothingMode.AntiAlias;
        g.InterpolationMode = InterpolationMode.HighQualityBicubic;
        g.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
        g.DrawImage(background, 0, 0, bitmap.Width, bitmap.Height);

        float scale = bitmap.Width / ReferenceWidth * FontScale;
        using var brush = new SolidBrush(TextColor);
        using var centered = new StringFormat(StringFormat.GenericTypographic)
        {
            Alignment = StringAlignment.Center,
            LineAlignment = StringAlignment.Center
        };

        DrawBoxText(g, brush, centered, project, "Roboto Condensed", 36f * scale,
            new PointF(CenterX * bitmap.Width, ProjectCenterY * bitmap.Height));
        DrawBoxText(g, brush, centered, tech, "Roboto Condensed", 24f * scale,
            new PointF(CenterX * bitmap.Width, TechCenterY * bitmap.Height));

        var area = new RectangleF(
            TitleArea.X * bitmap.Width, TitleArea.Y * bitmap.Height,
            TitleArea.Width * bitmap.Width, TitleArea.Height * bitmap.Height);

        if (!TryLayoutTitle(g, title, scale, area, out var font, out var lines))
        {
            error = $"Title '{title}' does not fit in {MaxTitleLines} lines at font size {TitleMinSize}.";
            return false;
        }

        using (font)
        {
            float lineHeight = font.GetHeight(g);
            float top = area.Y + (area.Height - lineHeight * lines.Count) / 2f;
            float centerX = CenterX * bitmap.Width;
            for (int i = 0; i < lines.Count; i++)
            {
                g.DrawString(lines[i], font, brush,
                    new RectangleF(centerX - area.Width / 2f, top + i * lineHeight, area.Width, lineHeight),
                    centered);
            }
        }

        bitmap.Save(output, ImageFormat.Png);
        return true;
    }

    private static void DrawBoxText(Graphics g, Brush brush, StringFormat format, string text, string family, float size, PointF center)
    {
        using var font = new Font(family, size, FontStyle.Regular, GraphicsUnit.Pixel);
        g.DrawString(text, font, brush, center, format);
    }

    private static bool TryLayoutTitle(Graphics g, string title, float scale, RectangleF area, out Font font, out List<string> lines)
    {
        for (float size = TitleMaxSize; size >= TitleMinSize; size -= 1f)
        {
            var candidate = new Font("Roboto Medium", size * scale, FontStyle.Regular, GraphicsUnit.Pixel);
            var wrapped = Wrap(g, title, candidate, area.Width);
            if (wrapped is not null && wrapped.Count <= MaxTitleLines && wrapped.Count * candidate.GetHeight(g) <= area.Height)
            {
                font = candidate;
                lines = wrapped;
                return true;
            }
            candidate.Dispose();
        }

        font = null!;
        lines = [];
        return false;
    }

    // Returns null when a single word is wider than the available width.
    private static List<string>? Wrap(Graphics g, string text, Font font, float maxWidth)
    {
        List<string> lines = [];
        string current = string.Empty;
        foreach (string word in text.Split(' ', StringSplitOptions.RemoveEmptyEntries))
        {
            string next = current.Length == 0 ? word : $"{current} {word}";
            if (Measure(g, next, font) <= maxWidth)
            {
                current = next;
                continue;
            }

            if (current.Length == 0 || Measure(g, word, font) > maxWidth)
            {
                return null;
            }

            lines.Add(current);
            current = word;
        }

        if (current.Length > 0)
        {
            lines.Add(current);
        }
        return lines;
    }

    private static float Measure(Graphics g, string text, Font font) =>
        g.MeasureString(text, font, PointF.Empty, StringFormat.GenericTypographic).Width;
}
