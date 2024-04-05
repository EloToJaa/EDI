using System.Collections.Generic;
using Edi.Contracts.Qualifiers;
using indice.Edi.Serialization;

namespace Edi.Contracts.Segments;

/// <summary>
/// To identify the direct relationship between the data/information contained in one segment and the data/information contained in one or more other segments.
/// </summary>
[EdiSegment, EdiPath("REL")]
public class REL
{
	/// <summary>
	/// Specification of the meaning of a relationship.
	/// </summary>
	[EdiValue("X(3)", Path = "REL/0")]
	public RelationshipQualifier? RelationshipQualifier { get; set; }

	/// <summary>
	/// Identification and/or description of a relationship.
	/// </summary>
	[EdiPath("REL/1")]
	public REL_Relationship? Relationship { get; set; }
}

/// <summary>
/// Identification and/or description of a relationship.
/// </summary>
[EdiElement]
public class REL_Relationship
{
	/// <summary>
	/// Identification of a relationship.
	/// </summary>
	[EdiValue("X(3)", Path = "REL/*/0")]
	public string? RelationshipCoded { get; set; }

	/// <summary>
	/// Identification of a code list.
	/// </summary>
	[EdiValue("X(3)", Path = "REL/*/1")]
	public CodeListQualifier? CodeListQualifier { get; set; }

	/// <summary>
	/// Code identifying the agency responsible for a code list.
	/// </summary>
	[EdiValue("X(3)", Path = "REL/*/2")]
	public CodeListResponsibleAgencyCoded? CodeListResponsibleAgencyCoded { get; set; }

	/// <summary>
	/// Description of a relationship.
	/// </summary>
	[EdiValue("X(35)", Path = "REL/*/3")]
	public string? Relationship { get; set; }
}