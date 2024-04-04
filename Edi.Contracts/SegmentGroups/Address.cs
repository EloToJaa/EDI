using Edi.Contracts.Segments;
using indice.Edi.Serialization;

namespace Edi.Contracts.SegmentGroups;

[EdiSegmentGroup("NAD", SequenceEnd = "CUX")]
public class Address
{
    [EdiValue("X(3)", Path = "NAD/0")]
    public string? PartyQualifier { get; set; }

    [EdiValue("X(35)", Path = "NAD/1/0")]
    public string? PartyIdentification { get; set; }

    [EdiValue("X(3)", Path = "NAD/1/1")]
    public string? CodeListQualifier { get; set; }

    [EdiValue("X(3)", Path = "NAD/1/2")]
    public string? CodeListResponsibleAgency { get; set; }

    [EdiValue("X(35)", Path = "NAD/2")]
    public string? NameAndAddressLine { get; set; }

    [EdiValue("X(35)", Path = "NAD/3")]
    public string? PartyName { get; set; }

    [EdiValue("X(35)", Path = "NAD/4")]
    public string? StreetNumber { get; set; }

    [EdiValue("X(35)", Path = "NAD/5")]
    public string? CityName { get; set; }

    [EdiValue("X(9)", Path = "NAD/6")]
    public string? CountryIdentification { get; set; }

    [EdiValue("X(9)", Path = "NAD/7")]
    public string? PostcodeIdentification { get; set; }

    [EdiValue("X(9)", Path = "NAD/8")]
    public string? CountryCoded { get; set; }

    [EdiCondition("VA", Path = "RFF/0/0")]
    public RFF? VATRegistrationNumber { get; set; }
}
