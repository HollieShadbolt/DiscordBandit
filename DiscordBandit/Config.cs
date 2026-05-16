using JsonPropertyNameAttribute = System.Text.Json.Serialization.JsonPropertyNameAttribute;

namespace DiscordBandit;

/// <summary>
/// A <see cref="DiscordBandit"/> config.
/// </summary>
public class Config : DiscordChannelNameUpdater.Interfaces.IConfig, DiscordStickyMessages.Interfaces.IConfig
{
    /// <summary>
    /// Get the credentials containing the authentication information of the user agent.
    /// </summary>
    /// <returns>The credentials containing the authentication information of the user agent.</returns>
    [JsonPropertyName("parameter")]
    public required string Parameter { get; init; }

    [JsonPropertyName("channel_ids_to_messages")]
    public required Dictionary<string, string> ChannelIdsToMessages { get; init; }

    [JsonPropertyName("guild_id")]
    public required string GuildId { get; init; }

    [JsonPropertyName("user_id")]
    public required string UserId { get; init; }

    [JsonPropertyName("channel_id")]
    public required string ChannelId { get; init; }

    [JsonPropertyName("channel_name_if_false")]
    public required string ChannelNameIfFalse { get; init; }

    [JsonPropertyName("channel_name_if_true")]
    public required string ChannelNameIfTrue { get; init; }
}