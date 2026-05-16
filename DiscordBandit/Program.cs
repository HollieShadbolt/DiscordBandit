namespace DiscordBandit;

public static class Program
{
    public static async Task Main(string[] args)
    {
        var path = args.Single();

        var text = await File.ReadAllTextAsync(path);

        var config = System.Text.Json.JsonSerializer.Deserialize<Config>(text) ?? throw new InvalidOperationException();

        var httpRequestMessageHandler = new HttpRequestMessageHandler.HttpRequestMessageHandler();

        var delayHandler = new HttpRequestMessageHandler.DelayHandler();

        var httpRequestMessageFactoryHandler =
            new HttpRequestMessageHandler.HttpRequestMessageFactoryHandler(httpRequestMessageHandler, delayHandler);

        var discord = new Discord.Discord(httpRequestMessageFactoryHandler, config.Parameter);

        var discordStickyMessages = new DiscordStickyMessages.DiscordStickyMessages(discord, config);

        var discordChannelNameUpdater =
            new DiscordChannelNameUpdater.DiscordChannelNameNameUpdater(discord, config, delayHandler);

        var discordBandit = new DiscordBandit(discordStickyMessages, discordChannelNameUpdater);

        await discordBandit.Run(CancellationToken.None);
    }
}