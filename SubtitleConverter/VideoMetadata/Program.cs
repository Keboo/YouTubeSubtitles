using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;
using Microsoft.Azure.Cosmos.Table;
using Microsoft.Extensions.Configuration;
using StreamingTools.Azure;
using StreamingTools.YouTube;

DateTime OLDEST_DATE = new(2023, 1, 1);

var configBuilder = new ConfigurationBuilder();
configBuilder.AddEnvironmentVariables();
configBuilder.AddUserSecrets(typeof(Program).Assembly);
var config = configBuilder.Build();

var azureSection = config.GetSection("Azure");
string azureStorageAccountKey = azureSection["StorageAccountKey"] ?? throw new Exception(); //TODO
var youtubeSection = config.GetSection("YouTube");
string youTubeClientId = youtubeSection["ClientId"] ?? throw new Exception();
string youTubeClientSecret = youtubeSection["ClientSecret"] ?? throw new Exception();

CloudStorageAccount storageAccount = StorageAccount.Get(azureStorageAccountKey, config);
var tableClient = storageAccount.CreateCloudTableClient();
var youtubeSettingsTable = tableClient.GetTableReference("youtubesettings");

YouTubeService youtubeService = await YouTubeFactory.GetServiceAsync(
                new CloudTableDataStore(youtubeSettingsTable),
                config,
                youTubeClientId,
                youTubeClientSecret,
                YouTubeService.Scope.YoutubeForceSsl);

var listVideosRequest = youtubeService.Search.List("snippet");
listVideosRequest.Order = SearchResource.ListRequest.OrderEnum.Date;
listVideosRequest.ForMine = true;
listVideosRequest.MaxResults = 25;
//listVideosRequest.PublishedAfter = DateTime.Now.AddYears(-1);
listVideosRequest.Type = "video";

using var writer = new StreamWriter("Videos.txt");
do
{
    SearchListResponse? response;
    response = await listVideosRequest.ExecuteAsync();
    foreach (SearchResult item in response.Items)
    {
        if (item.Snippet.PublishedAtDateTimeOffset <= OLDEST_DATE)
        {
            Console.WriteLine($"Found item {item.Snippet.Title} published on {item.Snippet.PublishedAtDateTimeOffset:d}, ending");
            return;
        }
        var videoDetails = youtubeService.Videos.List(new[] { "statistics", "snippet" });
        videoDetails.Id = item.Id.VideoId;
        var videoDetailsResponse = await videoDetails.ExecuteAsync();

        Console.WriteLine($"Saving {item.Snippet.Title} ({item.Snippet.PublishedAtDateTimeOffset:d})");
        await writer.WriteLineAsync($"Activity: Video/Webcast/Podcast");
        await writer.WriteLineAsync($"Primary Area: ");
        await writer.WriteLineAsync($"Secondary Area: ");
        await writer.WriteLineAsync($"Title: {item.Snippet.Title}");
        await writer.WriteLineAsync($"Date: {item.Snippet.PublishedAtDateTimeOffset:d}");
        await writer.WriteLineAsync($"Url: https://youtu.be/{item.Id.VideoId}");
        await writer.WriteLineAsync($"Description: {item.Snippet.Description}");
        await writer.WriteLineAsync($"Views: {videoDetailsResponse.Items[0].Statistics.ViewCount ?? 0}");
        //await writer.WriteLineAsync($"Tags: {string.Join(",", videoDetailsResponse.Items[0].Snippet.Tags ?? Array.Empty<string>())}");
        await writer.WriteLineAsync("----");
    }
    await writer.FlushAsync();
    listVideosRequest.PageToken = response.NextPageToken;
}
while (!string.IsNullOrWhiteSpace(listVideosRequest.PageToken));