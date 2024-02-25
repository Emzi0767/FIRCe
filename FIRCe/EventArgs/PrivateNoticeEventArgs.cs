﻿using System;
using FIRCe.Core;
using FIRCe.Extensions;
using FIRCe.ServerEntities;

namespace FIRCe.EventArgs
{
    public class PrivateNoticeEventArgs : System.EventArgs
    {
        public readonly IrcUser Author;
        public readonly string Content;

        public PrivateNoticeEventArgs(IrcController source, IrcMessage message)
        {
            if (message.Command.ToIrcLower() != "notice" || source.IsValidChannelName(message.Parameters[0]) || (source.Nick.ToIrcLower() != message.Parameters[0].ToIrcLower() && message.Parameters[0].ToIrcLower() != "*")) throw new ArgumentException("Not a private NOTICE", nameof(message));

            Author = source.Users.TryGetValue(message.SourceNick.ToIrcLower(), out IrcUser user) ? user : null;
            Content = message.Parameters[1];
        }
    }
}