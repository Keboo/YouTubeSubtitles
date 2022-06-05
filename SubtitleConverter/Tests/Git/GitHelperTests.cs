using StreamingTools.Git;

namespace Tests.Git;


public class GitHelperTests
{
    [Fact]
    public async Task GetRemoteUrl_ReturnsUrl()
    {
        Uri? url = await GitHelper.GetRemoteUrl(CancellationToken.None);
        Assert.Equal("https://github.com/Keboo/YouTubeSubtitles/", url?.AbsoluteUri);
    }

    [Fact]
    public async Task GetCurrentBranch_ReturnsBranchName()
    {
        string? branchName = await GitHelper.GetCurrentBranchName(CancellationToken.None);
        Assert.Equal("main", branchName);
    }
}
