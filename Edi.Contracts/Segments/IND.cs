using System.Collections.Generic;
using Edi.Contracts.Qualifiers;
using indice.Edi.Serialization;

namespace Edi.Contracts.Segments;

/// <summary>
/// To specify an index.
/// </summary>
[EdiSegment, EdiPath("IND")]
public class IND
{
	/// <summary>
	/// To identify an index.
	/// </summary>
	[EdiPath("IND/0")]
	public IND_IndexIdentification? IndexIdentification { get; set; }

	/// <summary>
	/// To identify the value of an index.
	/// </summary>
	[EdiPath("IND/1")]
	public IND_IndexValue? IndexValue { get; set; }
}

/// <summary>
/// To identify an index.
/// </summary>
[EdiElement]
public class IND_IndexIdentification
{
	/// <summary>
	/// To identify the type of index being referred to.
	/// </summary>
	[EdiValue("X(3)", Path = "IND/*/0")]
	public IndexQualifier? IndexQualifier { get; set; }

	/// <summary>
	/// To identify the type of index.
	/// </summary>
	[EdiValue("X(3)", Path = "IND/*/1")]
	public IndexTypeCoded? IndexTypeCoded { get; set; }

	/// <summary>
	/// Identification of a code list.
	/// </summary>
	[EdiValue("X(3)", Path = "IND/*/2")]
	public CodeListQualifier? CodeListQualifier { get; set; }

	/// <summary>
	/// Code identifying the agency responsible for a code list.
	/// </summary>
	[EdiValue("X(3)", Path = "IND/*/3")]
	public CodeListResponsibleAgencyCoded? CodeListResponsibleAgencyCoded { get; set; }
}

/// <summary>
/// To identify the value of an index.
/// </summary>
[EdiElement]
public class IND_IndexValue
{
	/// <summary>
	/// To specify the value of an index.
	/// </summary>
	[EdiValue("9(6)", Path = "IND/*/0")]
	public int? IndexValue { get; set; }

	/// <summary>
	/// To identify the representation of an index value.
	/// </summary>
	[EdiValue("X(3)", Path = "IND/*/1")]
	public IndexValueRepresentationCoded? IndexValueRepresentationCoded { get; set; }
}