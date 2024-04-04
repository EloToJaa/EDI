using Edi.Contracts.Segments;
using indice.Edi.Serialization;

namespace Edi.Contracts.SegmentGroups;

[EdiSegmentGroup("RFF", SequenceEnd = "NAD")]
public class Order
{
    [EdiValue("X(3)", Path = "RFF/0/0")]
    public string? ReferenceQualifier { get; set; }

    [EdiValue("X(35)", Path = "RFF/0/1")]
    public string? ReferenceNumber { get; set; }

    [EdiCondition("171", Path = "DTM/0/0")]
    public DTM? OrderDateTime { get; set; }
}
