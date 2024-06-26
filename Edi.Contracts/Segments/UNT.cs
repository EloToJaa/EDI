using System.Collections.Generic;
using Edi.Contracts.Qualifiers;
using Edi.Contracts.Interfaces;
using indice.Edi.Serialization;

namespace Edi.Contracts.Segments;

/// <summary>
/// To end and check the completeness of a message.
/// </summary>
[EdiSegment, EdiPath("UNT")]
public class UNT : ISegment
{
	/// <summary>
	/// Control count of number of segments in a message.
	/// </summary>
	[EdiValue("9(6)", Path = "UNT/0", Mandatory = true)]
	public decimal? NumberOfSegmentsInAMessage { get; set; }

	/// <summary>
	/// Unique message reference assigned by the sender.
	/// </summary>
	[EdiValue("X(14)", Path = "UNT/1", Mandatory = true)]
	public string? MessageReferenceNumber { get; set; }

}