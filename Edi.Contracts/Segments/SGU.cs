using System.Collections.Generic;
using Edi.Contracts.Qualifiers;
using indice.Edi.Serialization;

namespace Edi.Contracts.Segments;

/// <summary>
/// To specify the details of the usage of a segment within a message type structure.
/// </summary>
[EdiSegment, EdiPath("SGU")]
public class SGU
{
	/// <summary>
	/// Tag of a segment.
	/// </summary>
	[EdiValue("X(3)", Path = "SGU/0")]
	public string? SegmentTag { get; set; }

	/// <summary>
	/// To specify the designated requirement.
	/// </summary>
	[EdiValue("X(3)", Path = "SGU/1")]
	public RequirementDesignatorCoded? RequirementDesignatorCoded { get; set; }

	/// <summary>
	/// To specify the maximum number of occurrences.
	/// </summary>
	[EdiValue("9(7)", Path = "SGU/2")]
	public int? MaximumNumberOfOccurrences { get; set; }

	/// <summary>
	/// Relative hierarchical position of a data segment within a message as expressed in a branching diagram.
	/// </summary>
	[EdiValue("9(1)", Path = "SGU/3")]
	public int? LevelNumber { get; set; }

	/// <summary>
	/// Number indicating the position in a sequence.
	/// </summary>
	[EdiValue("X(10)", Path = "SGU/4")]
	public string? SequenceNumber { get; set; }

	/// <summary>
	/// Recognition of a particular part of a message.
	/// </summary>
	[EdiValue("X(3)", Path = "SGU/5")]
	public MessageSectionCoded? MessageSectionCoded { get; set; }

	/// <summary>
	/// To indicate the type of data maintenance operation for an object, such as add, delete, replace.
	/// </summary>
	[EdiValue("X(3)", Path = "SGU/6")]
	public MaintenanceOperationCoded? MaintenanceOperationCoded { get; set; }

}