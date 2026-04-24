namespace Keboo.Editor;

internal readonly record struct YouTubePublishedDateRange(DateOnly StartDate, DateOnly EndDate)
{
    public DateTimeOffset PublishedAfter => GetPublishedAfter(StartDate);

    public DateTimeOffset PublishedBefore => GetPublishedBefore(EndDate);

    public bool Includes(DateTimeOffset publishedAt)
    {
        DateOnly publishedDate = DateOnly.FromDateTime(publishedAt.UtcDateTime);
        return publishedDate >= StartDate && publishedDate <= EndDate;
    }

    public static bool TryCreate(DateOnly startDate, DateOnly endDate, out YouTubePublishedDateRange range)
    {
        if (endDate < startDate)
        {
            range = default;
            return false;
        }

        range = new YouTubePublishedDateRange(startDate, endDate);
        return true;
    }

    private static DateTimeOffset GetPublishedAfter(DateOnly startDate)
    {
        DateTimeOffset start = new(DateTime.SpecifyKind(startDate.ToDateTime(TimeOnly.MinValue), DateTimeKind.Utc));
        return start == DateTimeOffset.MinValue ? start : start.AddTicks(-1);
    }

    private static DateTimeOffset GetPublishedBefore(DateOnly endDate)
    {
        if (endDate == DateOnly.MaxValue)
        {
            return DateTimeOffset.MaxValue;
        }

        return new DateTimeOffset(DateTime.SpecifyKind(endDate.AddDays(1).ToDateTime(TimeOnly.MinValue), DateTimeKind.Utc));
    }
}
