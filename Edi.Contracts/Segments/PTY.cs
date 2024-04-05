using System.Collections.Generic;
using Edi.Contracts.Qualifiers;
using indice.Edi.Serialization;

namespace Edi.Contracts.Segments;

/// <summary>
/// The segment is used to communicate priority information.
/// </summary>
[EdiSegment, EdiPath("PTY")]
public class PTY
{
	/// <summary>
	/// To indicate the type of a priority.
	/// </summary>
	[EdiValue("X(3)", Path = "PTY/0")]
	public PriorityQualifier? PriorityQualifier { get; set; }

	/// <summary>
	/// To indicate a priority.
	/// </summary>
	[EdiPath("PTY/1")]
	public PTY_PriorityDetails? PriorityDetails { get; set; }
}

/// <summary>
/// To indicate a priority.
/// </summary>
[EdiElement]
public class PTY_PriorityDetails
{
	/// <summary>
	/// To indicate a priority in coded form.
	/// </summary>
	[EdiValue("X(3)", Path = "PTY/*/0")]
	public string? PriorityCoded { get; set; }

	/// <summary>
	/// Identification of a code list.
	/// </summary>
	[EdiValue("X(3)", Path = "PTY/*/1")]
	public CodeListQualifier? CodeListQualifier { get; set; }

	/// <summary>
	/// Code identifying the agency responsible for a code list.
	/// </summary>
	[EdiValue("X(3)", Path = "PTY/*/2")]
	public CodeListResponsibleAgencyCoded? CodeListResponsibleAgencyCoded { get; set; }

	/// <summary>
	/// To indicate a priority.
	/// </summary>
	[EdiValue("X(35)", Path = "PTY/*/3")]
	public string? Priority { get; set; }
}