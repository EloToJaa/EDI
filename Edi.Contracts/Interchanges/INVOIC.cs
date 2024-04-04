using Edi.Contracts.Messages;
using Edi.Contracts.Segments;

namespace Edi.Contracts.Interchanges;

public class INVOIC
{
    public UNB? InterchangeHeader { get; set; }
    public Invoice? Invoice { get; set; }
}
