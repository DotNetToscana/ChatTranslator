namespace DotNetToscana.ChatSockets
{
    public enum MessageType
    {
        Text,
        ClientMethodInvocation,
        ConnectionEvent
    }

    public class Message
    {
        public string Sender { get; set; }
        public MessageType MessageType { get; set; }
        public string Data { get; set; }
    }
}