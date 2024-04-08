using System.Collections.Generic;
using Edi.Contracts.Qualifiers;
using indice.Edi.Serialization;

namespace Edi.Contracts.Segments;

/// <summary>
/// To identify the reason for an adjustment.
/// </summary>
[EdiSegment, EdiPath("AJT")]
public class AJT
{
	/// <summary>
	/// Indication of reason for adjustment.
	/// </summary>
	[EdiValue("X(3)", Path = "AJT/0", Mandatory = true)]
	public AdjustmentReasonCoded? AdjustmentReasonCoded { get; set; }

	/// <summary>
	/// Serial number designating each separate item within a series of articles.
	/// </summary>
	[EdiValue("X(6)", Path = "AJT/1", Mandatory = false)]
	public string? LineItemNumber { get; set; }

}