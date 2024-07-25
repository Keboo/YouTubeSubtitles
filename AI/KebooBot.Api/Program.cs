using DocumentFormat.OpenXml.Wordprocessing;
using KebooBot.Api;
using Microsoft.AspNetCore.Mvc;
using Microsoft.KernelMemory;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAiServices();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.MapGet("/casey", () =>
{
    return "AI IS BETTER";
})
.WithName("GetWeatherForecast")
.WithOpenApi();

app.MapGet("/ingest", async ([FromServices] IKernelMemory memory) =>
{
    var files = Directory.EnumerateFiles(@"D:\Dev\YouTubeSubtitles\Subtitles")
        .Where(x => Path.GetExtension(x) == ".md")
        //.Where(x => Path.GetFileName(x) == "_dhQL.md")
        .Take(3)
        .ToList();

    try
    {
        foreach (var file in files)
        {
            await memory.ImportDocumentAsync(new DocumentUploadRequest()
            {
                Files = [new DocumentUploadRequest.UploadedFile(Path.GetFileName(file), File.OpenRead(file))],
                DocumentId = Path.GetFileName(file)
            });
        }
    }
    catch
    {
        throw;
    }

    return "Memory is the key";
})
.WithName("DoStuff")
.WithOpenApi();




app.Run();

internal record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
