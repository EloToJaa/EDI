using System.Collections.Generic;
using Edi.Contracts.Qualifiers;
using Edi.Contracts.Interfaces;
using indice.Edi.Serialization;

namespace Edi.Contracts.Segments;

/// <summary>
/// To specify attendance information relating to an individual.
/// </summary>
[EdiSegment, EdiPath("PAS")]
public class PAS : ISegment
{
	/// <summary>
	/// To specify type of attendance.
	/// </summary>
	[EdiValue("X(3)", Path = "PAS/0", Mandatory = true)]
	public AttendanceQualifier? AttendanceQualifier { get; set; }

	/// <summary>
	/// To specify the category of the attendee.
	/// </summary>
	[EdiPath("PAS/1")]
	public PAS_AttendeeCategory? AttendeeCategory { get; set; }

	/// <summary>
	/// To specify type of admission.
	/// </summary>
	[EdiPath("PAS/2")]
	public PAS_AttendanceAdmissionDetails? AttendanceAdmissionDetails { get; set; }

	/// <summary>
	/// To specify type of discharge.
	/// </summary>
	[EdiPath("PAS/3")]
	public PAS_AttendanceDischargeDetails? AttendanceDischargeDetails { get; set; }
}

/// <summary>
/// To specify the category of the attendee.
/// </summary>
[EdiElement]
public class PAS_AttendeeCategory : IElement
{
	/// <summary>
	/// Code to specify the category of the attendee.
	/// </summary>
	[EdiValue("X(3)", Path = "PAS/*/0", Mandatory = false)]
	public string? AttendeeCategoryCoded { get; set; }

	/// <summary>
	/// Identification of a code list.
	/// </summary>
	[EdiValue("X(3)", Path = "PAS/*/1", Mandatory = false)]
	public CodeListQualifier? CodeListQualifier { get; set; }

	/// <summary>
	/// Code identifying the agency responsible for a code list.
	/// </summary>
	[EdiValue("X(3)", Path = "PAS/*/2", Mandatory = false)]
	public CodeListResponsibleAgencyCoded? CodeListResponsibleAgencyCoded { get; set; }

	/// <summary>
	/// To specify the category of the attendee.
	/// </summary>
	[EdiValue("X(35)", Path = "PAS/*/3", Mandatory = false)]
	public string? AttendeeCategory { get; set; }
}

/// <summary>
/// To specify type of admission.
/// </summary>
[EdiElement]
public class PAS_AttendanceAdmissionDetails : IElement
{
	/// <summary>
	/// To specify type of admission using code.
	/// </summary>
	[EdiValue("X(3)", Path = "PAS/*/0", Mandatory = false)]
	public string? AdmissionTypeCoded { get; set; }

	/// <summary>
	/// Identification of a code list.
	/// </summary>
	[EdiValue("X(3)", Path = "PAS/*/1", Mandatory = false)]
	public CodeListQualifier? CodeListQualifier { get; set; }

	/// <summary>
	/// Code identifying the agency responsible for a code list.
	/// </summary>
	[EdiValue("X(3)", Path = "PAS/*/2", Mandatory = false)]
	public CodeListResponsibleAgencyCoded? CodeListResponsibleAgencyCoded { get; set; }

	/// <summary>
	/// To specify type of admission as free text.
	/// </summary>
	[EdiValue("X(35)", Path = "PAS/*/3", Mandatory = false)]
	public string? AdmissionType { get; set; }
}

/// <summary>
/// To specify type of discharge.
/// </summary>
[EdiElement]
public class PAS_AttendanceDischargeDetails : IElement
{
	/// <summary>
	/// To specify type of discharge using code.
	/// </summary>
	[EdiValue("X(3)", Path = "PAS/*/0", Mandatory = false)]
	public string? DischargeTypeCoded { get; set; }

	/// <summary>
	/// Identification of a code list.
	/// </summary>
	[EdiValue("X(3)", Path = "PAS/*/1", Mandatory = false)]
	public CodeListQualifier? CodeListQualifier { get; set; }

	/// <summary>
	/// Code identifying the agency responsible for a code list.
	/// </summary>
	[EdiValue("X(3)", Path = "PAS/*/2", Mandatory = false)]
	public CodeListResponsibleAgencyCoded? CodeListResponsibleAgencyCoded { get; set; }

	/// <summary>
	/// To specify type of discharge as free text.
	/// </summary>
	[EdiValue("X(35)", Path = "PAS/*/3", Mandatory = false)]
	public string? DischargeType { get; set; }
}