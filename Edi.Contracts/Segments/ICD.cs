using System.Collections.Generic;
using Edi.Contracts.Qualifiers;
using indice.Edi.Serialization;

namespace Edi.Contracts.Segments;

/// <summary>
/// To describe the insurance cover.
/// </summary>
[EdiSegment, EdiPath("ICD")]
public class ICD
{
	/// <summary>
	/// To provide the insurance cover type.
	/// </summary>
	[EdiPath("ICD/0")]
	public ICD_InsuranceCoverType? InsuranceCoverType { get; set; }

	/// <summary>
	/// To provide the insurance cover details.
	/// </summary>
	[EdiPath("ICD/1")]
	public ICD_InsuranceCoverDetails? InsuranceCoverDetails { get; set; }
}

/// <summary>
/// To provide the insurance cover type.
/// </summary>
[EdiElement]
public class ICD_InsuranceCoverType
{
	/// <summary>
	/// Specification of the meaning of the insurance cover.
	/// </summary>
	[EdiValue("X(3)", Path = "ICD/*/0")]
	public string? InsuranceCoverTypeCoded { get; set; }

	/// <summary>
	/// Identification of a code list.
	/// </summary>
	[EdiValue("X(3)", Path = "ICD/*/1")]
	public CodeListQualifier? CodeListQualifier { get; set; }

	/// <summary>
	/// Code identifying the agency responsible for a code list.
	/// </summary>
	[EdiValue("X(3)", Path = "ICD/*/2")]
	public CodeListResponsibleAgencyCoded? CodeListResponsibleAgencyCoded { get; set; }
}

/// <summary>
/// To provide the insurance cover details.
/// </summary>
[EdiElement]
public class ICD_InsuranceCoverDetails
{
	/// <summary>
	/// Coded identification of the insurance cover.
	/// </summary>
	[EdiValue("X(17)", Path = "ICD/*/0")]
	public string? InsuranceCoverIdentification { get; set; }

	/// <summary>
	/// Identification of a code list.
	/// </summary>
	[EdiValue("X(3)", Path = "ICD/*/1")]
	public CodeListQualifier? CodeListQualifier { get; set; }

	/// <summary>
	/// Code identifying the agency responsible for a code list.
	/// </summary>
	[EdiValue("X(3)", Path = "ICD/*/2")]
	public CodeListResponsibleAgencyCoded? CodeListResponsibleAgencyCoded { get; set; }

	/// <summary>
	/// Identification of the insurance cover.
	/// </summary>
	[EdiValue("X(35)", Path = "ICD/*/3")]
	public string? InsuranceCover1 { get; set; }

	/// <summary>
	/// Identification of the insurance cover.
	/// </summary>
	[EdiValue("X(35)", Path = "ICD/*/4")]
	public string? InsuranceCover2 { get; set; }
}