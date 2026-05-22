namespace DiscordBandit;

public sealed class DiscordBandit(
    DiscordStickyMessages.Interfaces.IDiscordStickyMessages discordStickyMessages,
    DiscordChannelNameUpdater.Interfaces.IDiscordChannelNameUpdater discordChannelNameUpdater)
{
    /// <summary>
    /// Run.
    /// </summary>
    /// <param name="cancellationToken"> The cancellation token to cancel operation.</param>
    /// <returns>The task object representing the asynchronous operation.</returns>
    /// <exception cref="TaskCanceledException">The cancellation token was cancelled.</exception>
    public async Task RunAsync(CancellationToken cancellationToken)
    {
        Task[] tasks =
        [
            discordStickyMessages.RunAsync(cancellationToken),
            discordChannelNameUpdater.RunAsync(cancellationToken)
        ];

        await Task.WhenAll(tasks);
    }
}