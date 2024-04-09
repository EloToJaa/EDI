namespace Edi.Download;

public class MessageSegment
{
    public int Depth { get; set; }
    public string SegmentName { get; set; } = string.Empty;
    public bool Mandatory { get; set; } = false;
    public int MaxCount { get; set; } = 1;
}
