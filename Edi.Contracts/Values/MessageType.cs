using indice.Edi.Serialization;

namespace Edi.Contracts.Values;

[EdiElement]
public class MessageType
{
    [EdiValue("X(6)", Path = "*/*/0")]
    public string? MessageTypeIdentifier { get; set; }

    [EdiValue("X(3)", Path = "*/*/1")]
    public string? MessageTypeVersionNumber { get; set; }

    [EdiValue("X(3)", Path = "*/*/2")]
    public string? MessageTypeReleaseNumber { get; set; }

    [EdiValue("X(3)", Path = "*/*/3")]
    public string? ControllingAgency { get; set; }

    [EdiValue("X(6)", Path = "*/*/4")]
    public string? AssociationAssignedCode { get; set; }
}
