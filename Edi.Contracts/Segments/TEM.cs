using System.Collections.Generic;
using Edi.Contracts.Qualifiers;
using indice.Edi.Serialization;

namespace Edi.Contracts.Segments;

/// <summary>
/// To describe the nature of the test performed.
/// </summary>
[EdiSegment, EdiPath("TEM")]
public class TEM
{
	/// <summary>
	/// Specification of the test method employed.
	/// </summary>
	[EdiPath("TEM/0")]
	public TEM_TestMethod? TestMethod { get; set; }

	/// <summary>
	/// Code specifying the method of administering the test, e.g. oral, inhalation.
	/// </summary>
	[EdiValue("X(3)", Path = "TEM/1")]
	public TestRouteOfAdministeringCoded? TestRouteOfAdministeringCoded { get; set; }

	/// <summary>
	/// Code specifying the medium on which the test was applied, e.g. animal, human.
	/// </summary>
	[EdiValue("X(3)", Path = "TEM/2")]
	public TestMediaCoded? TestMediaCoded { get; set; }

	/// <summary>
	/// Specification of the purpose of the measurement.
	/// </summary>
	[EdiValue("X(3)", Path = "TEM/3")]
	public MeasurementPurposeQualifier? MeasurementPurposeQualifier { get; set; }

	/// <summary>
	/// Definition of the revision or of the change level of the specified test method employed.
	/// </summary>
	[EdiValue("X(30)", Path = "TEM/4")]
	public string? TestRevisionNumber { get; set; }

	/// <summary>
	/// To identify the reason for the test as specified.
	/// </summary>
	[EdiPath("TEM/5")]
	public TEM_TestReason? TestReason { get; set; }
}

/// <summary>
/// Specification of the test method employed.
/// </summary>
[EdiElement]
public class TEM_TestMethod
{
	/// <summary>
	/// Code to specify the test method employed.
	/// </summary>
	[EdiValue("X(17)", Path = "TEM/*/0")]
	public string? TestMethodIdentification { get; set; }

	/// <summary>
	/// Identification of a code list.
	/// </summary>
	[EdiValue("X(3)", Path = "TEM/*/1")]
	public CodeListQualifier? CodeListQualifier { get; set; }

	/// <summary>
	/// Code identifying the agency responsible for a code list.
	/// </summary>
	[EdiValue("X(3)", Path = "TEM/*/2")]
	public CodeListResponsibleAgencyCoded? CodeListResponsibleAgencyCoded { get; set; }

	/// <summary>
	/// Free form description of the test method and procedure.
	/// </summary>
	[EdiValue("X(70)", Path = "TEM/*/3")]
	public string? TestDescription { get; set; }
}

/// <summary>
/// To identify the reason for the test as specified.
/// </summary>
[EdiElement]
public class TEM_TestReason
{
	/// <summary>
	/// Reason for performing a test by code.
	/// </summary>
	[EdiValue("X(17)", Path = "TEM/*/0")]
	public string? TestReasonIdentification { get; set; }

	/// <summary>
	/// Identification of a code list.
	/// </summary>
	[EdiValue("X(3)", Path = "TEM/*/1")]
	public CodeListQualifier? CodeListQualifier { get; set; }

	/// <summary>
	/// Code identifying the agency responsible for a code list.
	/// </summary>
	[EdiValue("X(3)", Path = "TEM/*/2")]
	public CodeListResponsibleAgencyCoded? CodeListResponsibleAgencyCoded { get; set; }

	/// <summary>
	/// Reason for performing a test by name.
	/// </summary>
	[EdiValue("X(35)", Path = "TEM/*/3")]
	public string? TestReason { get; set; }
}