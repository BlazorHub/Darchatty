using System;

namespace Darchatty.Orleans.GrainInterfaces.Model
{
    public class ChatMessage
    {
        public int ChatMessageNumber { get; set; }

        public Guid SenderUserId { get; set; }

        public DateTimeOffset SendTime { get; set; }

        public string MessageContentsRaw { get; set; } = null!;
    }
}
