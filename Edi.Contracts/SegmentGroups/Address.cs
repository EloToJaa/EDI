using Edi.Contracts.Segments;
using indice.Edi.Serialization;

namespace Edi.Contracts.SegmentGroups;

[EdiSegmentGroup("NAD", "NAD", "RFF")]
public class Address
{
    public NAD? NameAndAddress { get; set; }
    public RFF? VATRegistrationNumber { get; set; }
}
