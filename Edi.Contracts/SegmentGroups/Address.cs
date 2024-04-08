using Edi.Contracts.Segments;
using indice.Edi.Serialization;

namespace Edi.Contracts.SegmentGroups;

[EdiSegmentGroup("NAD", SequenceEnd = "CUX")]
public class Address : NAD
{
    [EdiCondition("VA", Path = "RFF/0/0")]
    public RFF? VATRegistrationNumber { get; set; }
}
