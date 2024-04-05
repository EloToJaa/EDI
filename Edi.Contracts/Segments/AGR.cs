using System.Collections.Generic;
using Edi.Contracts.Qualifiers;
using indice.Edi.Serialization;

namespace Edi.Contracts.Segments;

/// <summary>
/// To specify the agreement details.
/// </summary>
[EdiSegment, EdiPath("AGR")]
public class AGR
{
	/// <summary>
	/// Identification of specific agreement type by code or name.
	/// </summary>
	[EdiPath("AGR/0")]
	public AGR_AgreementTypeIdentification? AgreementTypeIdentification { get; set; }

	/// <summary>
	/// Subdivision of a service by code.
	/// </summary>
	[EdiValue("X(3)", Path = "AGR/1")]
	public string? ServiceLayerCoded { get; set; }

}

/// <summary>
/// Identification of specific agreement type by code or name.
/// </summary>
[EdiElement]
public class AGR_AgreementTypeIdentification
{
	/// <summary>
	/// Indication of the type of agreement.
	/// </summary>
	[EdiValue("X(3)", Path = "AGR/*/0")]
	public AgreementTypeQualifier? AgreementTypeQualifier { get; set; }

	/// <summary>
	/// Specification of the type of agreement.
	/// </summary>
	[EdiValue("X(3)", Path = "AGR/*/1")]
	public AgreementTypeCoded? AgreementTypeCoded { get; set; }

	/// <summary>
	/// Identification of a code list.
	/// </summary>
	[EdiValue("X(3)", Path = "AGR/*/2")]
	public CodeListQualifier? CodeListQualifier { get; set; }

	/// <summary>
	/// Code identifying the agency responsible for a code list.
	/// </summary>
	[EdiValue("X(3)", Path = "AGR/*/3")]
	public CodeListResponsibleAgencyCoded? CodeListResponsibleAgencyCoded { get; set; }

	/// <summary>
	/// Description of the type of agreement.
	/// </summary>
	[EdiValue("X(70)", Path = "AGR/*/4")]
	public string? AgreementTypeDescription { get; set; }
}