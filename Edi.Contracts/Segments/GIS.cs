using System.Collections.Generic;
using Edi.Contracts.Qualifiers;
using Edi.Contracts.Interfaces;
using indice.Edi.Serialization;

namespace Edi.Contracts.Segments;

/// <summary>
/// To transmit a processing indicator.
/// </summary>
[EdiSegment, EdiPath("GIS")]
public class GIS : ISegment
{
	/// <summary>
	/// Type of process indication.
	/// </summary>
	[EdiPath("GIS/0")]
	public GIS_ProcessingIndicator? ProcessingIndicator { get; set; }
}

/// <summary>
/// Type of process indication.
/// </summary>
[EdiElement]
public class GIS_ProcessingIndicator : IElement
{
	/// <summary>
	/// Identifies the value to be attributed to indicators required by the processing system.
	/// </summary>
	[EdiValue("X(3)", Path = "GIS/*/0", Mandatory = true)]
	public ProcessingIndicatorCoded? ProcessingIndicatorCoded { get; set; }

	/// <summary>
	/// Identification of a code list.
	/// </summary>
	[EdiValue("X(3)", Path = "GIS/*/1", Mandatory = false)]
	public CodeListQualifier? CodeListQualifier { get; set; }

	/// <summary>
	/// Code identifying the agency responsible for a code list.
	/// </summary>
	[EdiValue("X(3)", Path = "GIS/*/2", Mandatory = false)]
	public CodeListResponsibleAgencyCoded? CodeListResponsibleAgencyCoded { get; set; }

	/// <summary>
	/// Specification of a process or subprocess.
	/// </summary>
	[EdiValue("X(17)", Path = "GIS/*/3", Mandatory = false)]
	public ProcessTypeIdentification? ProcessTypeIdentification { get; set; }
}