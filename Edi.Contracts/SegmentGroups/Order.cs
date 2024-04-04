using Edi.Contracts.Segments;
using indice.Edi.Serialization;

namespace Edi.Contracts.SegmentGroups;

[EdiSegmentGroup("RFF", SequenceEnd = "DTM")]
public class Order
{
    public RFF? OrderNumber { get; set; }

    public DTM? OrderDateTime { get; set; }
}
