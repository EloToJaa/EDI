using System.Collections.Generic;
using Edi.Contracts.Qualifiers;
using indice.Edi.Serialization;

namespace Edi.Contracts.Segments;

/// <summary>
/// A segment to identify hierarchical connections from a given item to higher or lower levelled item.
/// </summary>
[EdiSegment, EdiPath("HYN")]
public class HYN
{
	/// <summary>
	/// To qualify the object of the given hierarchy (e.g. product hierarchy, company hierarchy..).
	/// </summary>
	[EdiValue("X(3)", Path = "HYN/0")]
	public HierarchyObjectQualifier? HierarchyObjectQualifier { get; set; }

	/// <summary>
	/// To identify the relationship between the hierarchical object and the identified product within the PRODAT message.
	/// </summary>
	[EdiValue("X(3)", Path = "HYN/1")]
	public HierarchicalLevelCoded? HierarchicalLevelCoded { get; set; }

	/// <summary>
	/// Code specifying the action to be taken or already taken.
	/// </summary>
	[EdiValue("X(3)", Path = "HYN/2")]
	public ActionRequestNotificationCoded? ActionRequestNotificationCoded { get; set; }

	/// <summary>
	/// Goods identification for a specified source.
	/// </summary>
	[EdiPath("HYN/3")]
	public HYN_ItemNumberIdentification? ItemNumberIdentification { get; set; }
}

/// <summary>
/// Goods identification for a specified source.
/// </summary>
[EdiElement]
public class HYN_ItemNumberIdentification
{
	/// <summary>
	/// A number allocated to a group or item.
	/// </summary>
	[EdiValue("X(35)", Path = "HYN/*/0")]
	public string? ItemNumber { get; set; }

	/// <summary>
	/// Identification of the type of item number.
	/// </summary>
	[EdiValue("X(3)", Path = "HYN/*/1")]
	public ItemNumberTypeCoded? ItemNumberTypeCoded { get; set; }

	/// <summary>
	/// Identification of a code list.
	/// </summary>
	[EdiValue("X(3)", Path = "HYN/*/2")]
	public CodeListQualifier? CodeListQualifier { get; set; }

	/// <summary>
	/// Code identifying the agency responsible for a code list.
	/// </summary>
	[EdiValue("X(3)", Path = "HYN/*/3")]
	public CodeListResponsibleAgencyCoded? CodeListResponsibleAgencyCoded { get; set; }
}