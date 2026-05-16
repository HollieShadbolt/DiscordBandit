[![Unit Test](https://github.com/HollieShadbolt/DiscordBandit/actions/workflows/dotnet.yml/badge.svg)](https://github.com/HollieShadbolt/DiscordBandit/actions/workflows/dotnet.yml)
[![Linux Release](https://github.com/HollieShadbolt/DiscordBandit/actions/workflows/linux-release.yml/badge.svg)](https://github.com/HollieShadbolt/DiscordBandit/actions/workflows/linux-release.yml)
[![Windows Release](https://github.com/HollieShadbolt/DiscordBandit/actions/workflows/windows-release.yml/badge.svg)](https://github.com/HollieShadbolt/DiscordBandit/actions/workflows/windows-release.yml)


A .NET console application for running [DiscordStickyMessages](https://github.com/HollieShadbolt/DiscordStickyMessages) and [HttpRequestMessageHandler](https://github.com/HollieShadbolt/HttpRequestMessageHandler).

# Usage
```
DiscordBandit path/to/file.config
```

This file should contain the following JSON properties:
- `parameter` (string) - The credentials containing the authentication information of the user agent.
- `channel_ids_to_messages` (dictionary<string, string>) - The IDs of the channels to send paired messages to.
- `guild_id` (string) - The ID of the guild.
- `user_id` (string) - The ID of the user.
- `channel_id` (string) - The ID of the channel.
- `channel_name_if_false` (string) - The channel names to update to when the user is not in the channel.
- `channel_name_if_true` (string) - The channel names to update to when the user is in the channel.

# Dependencies
- [DiscordStickyMessages](https://github.com/HollieShadbolt/DiscordStickyMessages)
- [DiscordChannelNameUpdater](https://github.com/HollieShadbolt/DiscordChannelNameUpdater)
