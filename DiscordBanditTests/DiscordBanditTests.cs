using Moq;

namespace DiscordBanditTests;

[TestFixture]
public static class DiscordBanditTests
{
    [Test]
    public static async Task RunAsync_TestAsync()
    {
        // Arrange
        var mockDiscordStickyMessages = new Mock<DiscordStickyMessages.Interfaces.IDiscordStickyMessages>();

        var mockDiscordChannelNameUpdater = new Mock<DiscordChannelNameUpdater.Interfaces.IDiscordChannelNameUpdater>();

        var discordBandit =
            new DiscordBandit.DiscordBandit(mockDiscordStickyMessages.Object, mockDiscordChannelNameUpdater.Object);

        var cancellationTokenSource = new CancellationTokenSource();

        // Act
        await discordBandit.RunAsync(cancellationTokenSource.Token);

        // Assert
        mockDiscordStickyMessages.Verify(
            discordStickyMessages => discordStickyMessages.RunAsync(cancellationTokenSource.Token), Times.Exactly(1));

        mockDiscordStickyMessages.VerifyNoOtherCalls();

        mockDiscordChannelNameUpdater.Verify(
            discordChannelNameUpdater => discordChannelNameUpdater.RunAsync(cancellationTokenSource.Token),
            Times.Exactly(1));

        mockDiscordChannelNameUpdater.VerifyNoOtherCalls();
    }
}