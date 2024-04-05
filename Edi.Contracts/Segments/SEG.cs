using System.Collections.Generic;
using Edi.Contracts.Qualifiers;
using indice.Edi.Serialization;

namespace Edi.Contracts.Segments;

/// <summary>
/// To identify a segment and give its class and maintenance operation.
/// </summary>
[EdiSegment, EdiPath("SEG")]
public class SEG
{
	/// <summary>
	/// Tag of a segment.
	/// </summary>
	[EdiValue("X(3)", Path = "SEG/0")]
	public string? SegmentTag { get; set; }

	/// <summary>
	/// To identify a designated class.
	/// </summary>
	[EdiValue("X(3)", Path = "SEG/1")]
	public ClassDesignatorCoded? ClassDesignatorCoded { get; set; }

	/// <summary>
	/// To indicate the type of data maintenance operation for an object, such as add, delete, replace.
	/// </summary>
	[EdiValue("X(3)", Path = "SEG/2")]
	public MaintenanceOperationCoded? MaintenanceOperationCoded { get; set; }

}