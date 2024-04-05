using System.Collections.Generic;
using Edi.Contracts.Qualifiers;
using indice.Edi.Serialization;

namespace Edi.Contracts.Segments;

/// <summary>
/// To head, identify and specify a message.
/// </summary>
[EdiSegment, EdiPath("UNH")]
public class UNH
{
	/// <summary>
	/// Unique message reference assigned by the sender.
	/// </summary>
	[EdiValue("X(14)", Path = "UNH/0")]
	public string? MessageReferenceNumber { get; set; }

	/// <summary>
	/// Identification of the type, version etc. of the message being interchanged.
	/// </summary>
	[EdiPath("UNH/1")]
	public UNH_MessageIdentifier? MessageIdentifier { get; set; }

	/// <summary>
	/// Reference serving as a key to relate all subsequent transfers of data to the same business case or file.
	/// </summary>
	[EdiValue("X(35)", Path = "UNH/2")]
	public string? CommonAccessReference { get; set; }

	/// <summary>
	/// Statement that the message is one in a sequence of transfers relating to the same topic.
	/// </summary>
	[EdiPath("UNH/3")]
	public UNH_StatusOfTheTransfer? StatusOfTheTransfer { get; set; }
}

/// <summary>
/// Identification of the type, version etc. of the message being interchanged.
/// </summary>
[EdiElement]
public class UNH_MessageIdentifier
{
	/// <summary>
	/// Code identifying a type of message and assigned by its controlling agency.
	/// </summary>
	[EdiValue("X(6)", Path = "UNH/*/0")]
	public MessageTypeIdentifier? MessageTypeIdentifier { get; set; }

	/// <summary>
	/// Version number of a message type.
	/// </summary>
	[EdiValue("X(3)", Path = "UNH/*/1")]
	public MessageVersionNumber? MessageTypeVersionNumber { get; set; }

	/// <summary>
	/// Release number within the current message type version number (0052).
	/// </summary>
	[EdiValue("X(3)", Path = "UNH/*/2")]
	public MessageReleaseNumber? MessageTypeReleaseNumber { get; set; }

	/// <summary>
	/// Code to identify the agency controlling the specification, maintenance and publication of the message type.
	/// </summary>
	[EdiValue("X(2)", Path = "UNH/*/3")]
	public ControllingAgency? ControllingAgency { get; set; }

	/// <summary>
	/// A code assigned by the association responsible for the design and maintenance of the message type concerned, which further identifies the message.
	/// </summary>
	[EdiValue("X(6)", Path = "UNH/*/4")]
	public string? AssociationAssignedCode { get; set; }
}

/// <summary>
/// Statement that the message is one in a sequence of transfers relating to the same topic.
/// </summary>
[EdiElement]
public class UNH_StatusOfTheTransfer
{
	/// <summary>
	/// Number assigned by the sender indicating the numerical sequence of one or more transfers.
	/// </summary>
	[EdiValue("9(2)", Path = "UNH/*/0")]
	public int? SequenceMessageTransferNumber { get; set; }

	/// <summary>
	/// Indication used for the first and last message in a sequence of the same type of message relating to the same topic.
	/// </summary>
	[EdiValue("X(1)", Path = "UNH/*/1")]
	public FirstLastSequenceMessageTransferIndication? FirstLastSequenceMessageTransferIndication { get; set; }
}