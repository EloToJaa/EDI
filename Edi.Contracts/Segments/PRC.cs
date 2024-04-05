using System.Collections.Generic;
using Edi.Contracts.Qualifiers;
using indice.Edi.Serialization;

namespace Edi.Contracts.Segments;

/// <summary>
/// To identify a process.
/// </summary>
[EdiSegment, EdiPath("PRC")]
public class PRC
{
	/// <summary>
	/// Identification of process type and description.
	/// </summary>
	[EdiPath("PRC/0")]
	public PRC_ProcessTypeAndDescription? ProcessTypeAndDescription { get; set; }

	/// <summary>
	/// To identify the details of a specific process.
	/// </summary>
	[EdiPath("PRC/1")]
	public PRC_ProcessIdentificationDetails? ProcessIdentificationDetails { get; set; }
}

/// <summary>
/// Identification of process type and description.
/// </summary>
[EdiElement]
public class PRC_ProcessTypeAndDescription
{
	/// <summary>
	/// Specification of a process or subprocess.
	/// </summary>
	[EdiValue("X(17)", Path = "PRC/*/0")]
	public ProcessTypeIdentification? ProcessTypeIdentification { get; set; }

	/// <summary>
	/// Identification of a code list.
	/// </summary>
	[EdiValue("X(3)", Path = "PRC/*/1")]
	public CodeListQualifier? CodeListQualifier { get; set; }

	/// <summary>
	/// Code identifying the agency responsible for a code list.
	/// </summary>
	[EdiValue("X(3)", Path = "PRC/*/2")]
	public CodeListResponsibleAgencyCoded? CodeListResponsibleAgencyCoded { get; set; }

	/// <summary>
	/// Free form description of a process.
	/// </summary>
	[EdiValue("X(35)", Path = "PRC/*/3")]
	public string? ProcessType1 { get; set; }

	/// <summary>
	/// Free form description of a process.
	/// </summary>
	[EdiValue("X(35)", Path = "PRC/*/4")]
	public string? ProcessType2 { get; set; }
}

/// <summary>
/// To identify the details of a specific process.
/// </summary>
[EdiElement]
public class PRC_ProcessIdentificationDetails
{
	/// <summary>
	/// Code to identify a specific process.
	/// </summary>
	[EdiValue("X(17)", Path = "PRC/*/0")]
	public string? ProcessIdentification { get; set; }

	/// <summary>
	/// Identification of a code list.
	/// </summary>
	[EdiValue("X(3)", Path = "PRC/*/1")]
	public CodeListQualifier? CodeListQualifier { get; set; }

	/// <summary>
	/// Code identifying the agency responsible for a code list.
	/// </summary>
	[EdiValue("X(3)", Path = "PRC/*/2")]
	public CodeListResponsibleAgencyCoded? CodeListResponsibleAgencyCoded { get; set; }

	/// <summary>
	/// To specify a specific process as free text.
	/// </summary>
	[EdiValue("X(70)", Path = "PRC/*/3")]
	public string? Process { get; set; }
}