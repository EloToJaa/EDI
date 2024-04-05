using System.Collections.Generic;
using Edi.Contracts.Qualifiers;
using indice.Edi.Serialization;

namespace Edi.Contracts.Segments;

/// <summary>
/// To communicate how dose(s) are administered.
/// </summary>
[EdiSegment, EdiPath("DSG")]
public class DSG
{
	/// <summary>
	/// To provide a part of dosage specification.
	/// </summary>
	[EdiValue("X(3)", Path = "DSG/0")]
	public DosageAdministrationQualifier? DosageAdministrationQualifier { get; set; }

	/// <summary>
	/// To specify a dosage.
	/// </summary>
	[EdiPath("DSG/1")]
	public DSG_DosageDetails? DosageDetails { get; set; }
}

/// <summary>
/// To specify a dosage.
/// </summary>
[EdiElement]
public class DSG_DosageDetails
{
	/// <summary>
	/// To specify a dosage using code.
	/// </summary>
	[EdiValue("X(8)", Path = "DSG/*/0")]
	public string? DosageIdentification { get; set; }

	/// <summary>
	/// Identification of a code list.
	/// </summary>
	[EdiValue("X(3)", Path = "DSG/*/1")]
	public CodeListQualifier? CodeListQualifier { get; set; }

	/// <summary>
	/// Code identifying the agency responsible for a code list.
	/// </summary>
	[EdiValue("X(3)", Path = "DSG/*/2")]
	public CodeListResponsibleAgencyCoded? CodeListResponsibleAgencyCoded { get; set; }

	/// <summary>
	/// To specify a dosage as free text.
	/// </summary>
	[EdiValue("X(70)", Path = "DSG/*/3")]
	public string? Dosage { get; set; }
}