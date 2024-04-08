using Edi.Contracts.Segments;
using indice.Edi.Serialization;

namespace Edi.Contracts.SegmentGroups;

[EdiSegmentGroup("RFF", SequenceEnd = "NAD")]
public class Order : RFF
{
    [EdiCondition("171", Path = "DTM/0/0")]
    public DTM? OrderDateTime { get; set; }
}
