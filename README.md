[![Unit Test](https://github.com/HollieShadbolt/DiscordBandit/actions/workflows/dotnet.yml/badge.svg)](https://github.com/HollieShadbolt/DiscordBandit/actions/workflows/dotnet.yml)
[![Linux Release](https://github.com/HollieShadbolt/DiscordBandit/actions/workflows/linux-release.yml/badge.svg)](https://github.com/HollieShadbolt/DiscordBandit/actions/workflows/linux-release.yml)
[![Windows Release](https://github.com/HollieShadbolt/DiscordBandit/actions/workflows/windows-release.yml/badge.svg)](https://github.com/HollieShadbolt/DiscordBandit/actions/workflows/windows-release.yml)

# DiscordBandit

A .NET console application for running [DiscordStickyMessages](https://github.com/HollieShadbolt/DiscordStickyMessages) and [HttpRequestMessageHandler](https://github.com/HollieShadbolt/HttpRequestMessageHandler).

The application will loop indefinitely until cancelled.

For each channel ID to message pair, the latest message from the bot in that channel is retrieved. If this message from the bot is not the latest message in the channel, this message from the bot will be deleted and a new message will be posted in the channel.

If the defined user enters or leaves the defined channel, the channel name is updated to the defined name. This has a cooldown of 5 minutes due to Discord's Rate Limiting.

# Usage
```
DiscordBandit path/to/file.config
```

This file should contain the following JSON properties:
- `parameter` (string) - The Bot token (see [API Reference](https://docs.discord.com/developers/reference)).
- `channel_ids_to_messages` (dictionary<string, string>) - The IDs of the channels to monitor paired with the messages to send.
- `guild_id` (string) - The ID of the guild.
- `user_id` (string) - The ID of the user to monitor for updating the channel name.
- `channel_id` (string) - The ID of the channel.
- `channel_name_if_false` (string) - The channel name to update to when the user is not in the channel.
- `channel_name_if_true` (string) - The channel name to update to when the user is in the channel.

# Dependencies
- [DiscordStickyMessages](https://github.com/HollieShadbolt/DiscordStickyMessages)
- [DiscordChannelNameUpdater](https://github.com/HollieShadbolt/DiscordChannelNameUpdater)
