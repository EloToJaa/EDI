using System.Collections.Generic;
using Edi.Contracts.Qualifiers;
using Edi.Contracts.Interfaces;
using indice.Edi.Serialization;

namespace Edi.Contracts.Segments;

/// <summary>
/// To identify a communication number of a department or a person to whom communication should be directed.
/// </summary>
[EdiSegment, EdiPath("COM")]
public class COM : ISegment
{
	/// <summary>
	/// Communication number of a department or employee in a specified channel.
	/// </summary>
	[EdiPath("COM/0")]
	public COM_CommunicationContact? CommunicationContact { get; set; }
}

/// <summary>
/// Communication number of a department or employee in a specified channel.
/// </summary>
[EdiElement]
public class COM_CommunicationContact : IElement
{
	/// <summary>
	/// The communication number.
	/// </summary>
	[EdiValue("X(512)", Path = "COM/*/0", Mandatory = true)]
	public string? CommunicationNumber { get; set; }

	/// <summary>
	/// Code identifying the type of communication channel being used.
	/// </summary>
	[EdiValue("X(3)", Path = "COM/*/1", Mandatory = true)]
	public CommunicationChannelQualifier? CommunicationChannelQualifier { get; set; }
}