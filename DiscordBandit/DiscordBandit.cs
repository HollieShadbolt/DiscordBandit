namespace DiscordBandit;

public sealed class DiscordBandit(
    DiscordStickyMessages.Interfaces.IDiscordStickyMessages discordStickyMessages,
    DiscordChannelNameUpdater.Interfaces.IDiscordChannelNameUpdater discordChannelNameUpdater)
{
    public async Task Run(CancellationToken cancellationToken)
    {
        Task[] tasks =
        [
            discordStickyMessages.RunAsync(cancellationToken),
            discordChannelNameUpdater.RunAsync(cancellationToken)
        ];

        await Task.WhenAll(tasks);
    }
}