using Edi.Contracts.Values;
using indice.Edi.Serialization;

namespace Edi.Contracts.Segments;

//[EdiSegment, EdiPath("UNH")]
//public class UNH
//{
//    [EdiValue("X(14)", Path = "UNH/0")]
//    public string? MessageReferenceNumber { get; set; }

//    [EdiPath("UNH/1")]
//    public MessageType? MessageType { get; set; }
//}

/// <summary>
/// To head, identify and specify a message.
/// </summary>
[EdiSegment, EdiPath("UNH")]
public class UNH
{
    /// <summary>
    /// Unique message reference assigned by the sender.
    /// </summary>
    [EdiValue("X(14)", Path = "UNH/0/0")]
    public string? MessageReferenceNumber { get; set; }

    /// <summary>
    /// Code identifying a type of message and assigned by its controlling agency.
    /// </summary>
    //[EdiValue("X(6)", Path = "UNH/1/0")]
    //public string? MessageTypeIdentifier { get; set; }
    [EdiValue("X(6)", Path = "UNH/1/0")]
    public MessageTypeIdentifier MessageTypeIdentifier { get; set; } = new MessageTypeIdentifier();

    /// <summary>
    /// Version number of a message type.
    /// </summary>
    //[EdiValue("X(3)", Path = "UNH/1/1")]
    //public string? MessageTypeVersionNumber { get; set; }
    [EdiValue("X(3)", Path = "UNH/1/1")]
    public MessageVersionNumber MessageVersionNumber { get; set; } = new MessageVersionNumber();

    /// <summary>
    /// Release number within the current message type version number (0052).
    /// </summary>
    [EdiValue("X(3)", Path = "UNH/1/2")]
    public string? MessageTypeReleaseNumber { get; set; }

    /// <summary>
    /// Code to identify the agency controlling the specification, maintenance and publication of the message type.
    /// </summary>
    [EdiValue("X(2)", Path = "UNH/1/3")]
    public string? ControllingAgency { get; set; }

    /// <summary>
    /// A code assigned by the association responsible for the design and maintenance of the message type concerned, which further identifies the message.
    /// </summary>
    [EdiValue("X(6)", Path = "UNH/1/4")]
    public string? AssociationAssignedCode { get; set; }

    /// <summary>
    /// Reference serving as a key to relate all subsequent transfers of data to the same business case or file.
    /// </summary>
    [EdiValue("X(35)", Path = "UNH/2/0")]
    public string? CommonAccessReference { get; set; }

    /// <summary>
    /// Number assigned by the sender indicating the numerical sequence of one or more transfers.
    /// </summary>
    [EdiValue("9(2)", Path = "UNH/3/0")]
    public int? SequenceMessageTransferNumber { get; set; }

    /// <summary>
    /// Indication used for the first and last message in a sequence of the same type of message relating to the same topic.
    /// </summary>
    [EdiValue("X(1)", Path = "UNH/3/1")]
    public string? FirstLastSequenceMessageTransferIndication { get; set; }

}