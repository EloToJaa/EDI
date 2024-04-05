using System.Collections.Generic;
using Edi.Contracts.Qualifiers;
using indice.Edi.Serialization;

namespace Edi.Contracts.Segments;

/// <summary>
/// To identify the sequence in which physical packing is presented in the consignment, and optionally to identify the hierarchical relationship between packing layers.
/// </summary>
[EdiSegment, EdiPath("CPS")]
public class CPS
{
	/// <summary>
	/// A unique number assigned by the sender to identify a level within a hierarchical structure.
	/// </summary>
	[EdiValue("X(12)", Path = "CPS/0")]
	public string? HierarchicalIdNumber { get; set; }

	/// <summary>
	/// Identification number of the next higher hierarchical data segment in a hierarchical structure.
	/// </summary>
	[EdiValue("X(12)", Path = "CPS/1")]
	public string? HierarchicalParentId { get; set; }

	/// <summary>
	/// Indication of level of packaging specified.
	/// </summary>
	[EdiValue("X(3)", Path = "CPS/2")]
	public PackagingLevelCoded? PackagingLevelCoded { get; set; }

}