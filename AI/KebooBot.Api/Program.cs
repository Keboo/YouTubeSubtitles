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

app.MapGet("/ingest", async ([FromServices] IKernelMemory memory, [FromServices] ILogger<Program> logger) =>
{
    var files = Directory.EnumerateFiles(@"D:\Dev\YouTubeSubtitles\Subtitles")
        .Where(x => Path.GetExtension(x) == ".md")
        //.Where(x => Path.GetFileName(x) == "_dhQL.md")
        //.Take(3)
        .ToList();

    await Task.WhenAll(files.Select(ProcessFileAsync));

    async Task ProcessFileAsync(string file)
    {
        DateTime start = DateTime.Now;
        logger.LogInformation("{When}: Processing file {File}", start, file);
        await memory.ImportDocumentAsync(new DocumentUploadRequest()
        {
            Files = [new DocumentUploadRequest.UploadedFile(Path.GetFileName(file), File.OpenRead(file))],
            DocumentId = Path.GetFileName(file)
        });
        DateTime end = DateTime.Now;
        logger.LogInformation("{When}: Done processing file {File} in {Duration}", DateTime.Now, file, end - start);
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
