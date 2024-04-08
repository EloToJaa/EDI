using Edi.Contracts.Segments;
using indice.Edi.Serialization;

namespace Edi.Contracts.SegmentGroups;

[EdiSegmentGroup("MOA", SequenceEnd = "UNT")]
public class MonetaryAmount : MOA
{
    [EdiCondition("7", Path = "TAX/0/0")]
    public TAX? Tax { get; set; }
}