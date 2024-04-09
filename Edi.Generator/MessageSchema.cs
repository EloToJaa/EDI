namespace Edi.Generator;

public class MessageSchema
{
    public Dictionary<string, List<MessageSegment>> Messages { get; set; } = new Dictionary<string, List<MessageSegment>>();
}

public class MessageSegment
{
    public int Depth { get; set; }
    public string SegmentName { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public bool Mandatory { get; set; } = false;
    public int MaxCount { get; set; } = 1;

    public override string ToString()
    {
        return $"{Depth}:{SegmentName}";
    }
}
