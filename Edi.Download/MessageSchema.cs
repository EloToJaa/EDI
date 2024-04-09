namespace Edi.Download;

public class MessageSchema
{
    public Dictionary<string, List<MessageSegment>> Messages { get; set; } = new Dictionary<string, List<MessageSegment>>();
}
