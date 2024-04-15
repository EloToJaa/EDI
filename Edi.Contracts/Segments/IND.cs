using System.Collections.Generic;
using Edi.Contracts.Qualifiers;
using Edi.Contracts.Interfaces;
using indice.Edi.Serialization;

namespace Edi.Contracts.Segments;

/// <summary>
/// To specify an index.
/// </summary>
[EdiSegment, EdiPath("IND")]
public class IND : ISegment
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
public class IND_IndexIdentification : IElement
{
	/// <summary>
	/// To identify the type of index being referred to.
	/// </summary>
	[EdiValue("X(3)", Path = "IND/*/0", Mandatory = true)]
	public IndexQualifier? IndexQualifier { get; set; }

	/// <summary>
	/// To identify the type of index.
	/// </summary>
	[EdiValue("X(3)", Path = "IND/*/1", Mandatory = false)]
	public IndexTypeCoded? IndexTypeCoded { get; set; }

	/// <summary>
	/// Identification of a code list.
	/// </summary>
	[EdiValue("X(3)", Path = "IND/*/2", Mandatory = false)]
	public CodeListQualifier? CodeListQualifier { get; set; }

	/// <summary>
	/// Code identifying the agency responsible for a code list.
	/// </summary>
	[EdiValue("X(3)", Path = "IND/*/3", Mandatory = false)]
	public CodeListResponsibleAgencyCoded? CodeListResponsibleAgencyCoded { get; set; }
}

/// <summary>
/// To identify the value of an index.
/// </summary>
[EdiElement]
public class IND_IndexValue : IElement
{
	/// <summary>
	/// To specify the value of an index.
	/// </summary>
	[EdiValue("9(6)", Path = "IND/*/0", Mandatory = true)]
	public decimal? IndexValue { get; set; }

	/// <summary>
	/// To identify the representation of an index value.
	/// </summary>
	[EdiValue("X(3)", Path = "IND/*/1", Mandatory = false)]
	public IndexValueRepresentationCoded? IndexValueRepresentationCoded { get; set; }
}