using System.Collections.Generic;
using Edi.Contracts.Qualifiers;
using Edi.Contracts.Interfaces;
using indice.Edi.Serialization;

namespace Edi.Contracts.Segments;

/// <summary>
/// To specify the qualification of a person.
/// </summary>
[EdiSegment, EdiPath("QUA")]
public class QUA : ISegment
{
	/// <summary>
	/// To specify type of qualification.
	/// </summary>
	[EdiValue("X(3)", Path = "QUA/0", Mandatory = true)]
	public QualificationQualifier? QualificationQualifier { get; set; }

	/// <summary>
	/// Qualification classification description and/or code. This specifies the trade, skill, professional or similar qualification category.
	/// </summary>
	[EdiPath("QUA/1")]
	public QUA_QualificationClassification? QualificationClassification { get; set; }
}

/// <summary>
/// Qualification classification description and/or code. This specifies the trade, skill, professional or similar qualification category.
/// </summary>
[EdiElement]
public class QUA_QualificationClassification : IElement
{
	/// <summary>
	/// Identification of a qualification classification.
	/// </summary>
	[EdiValue("X(3)", Path = "QUA/*/0", Mandatory = false)]
	public string? QualificationClassificationCoded { get; set; }

	/// <summary>
	/// Identification of a code list.
	/// </summary>
	[EdiValue("X(3)", Path = "QUA/*/1", Mandatory = false)]
	public CodeListQualifier? CodeListQualifier { get; set; }

	/// <summary>
	/// Code identifying the agency responsible for a code list.
	/// </summary>
	[EdiValue("X(3)", Path = "QUA/*/2", Mandatory = false)]
	public CodeListResponsibleAgencyCoded? CodeListResponsibleAgencyCoded { get; set; }

	/// <summary>
	/// Description of a qualification classification.
	/// </summary>
	[EdiValue("X(35)", Path = "QUA/*/3", Mandatory = false)]
	public string? QualificationClassification1 { get; set; }

	/// <summary>
	/// Description of a qualification classification.
	/// </summary>
	[EdiValue("X(35)", Path = "QUA/*/4", Mandatory = false)]
	public string? QualificationClassification2 { get; set; }
}