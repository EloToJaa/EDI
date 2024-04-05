using System.Collections.Generic;
using Edi.Contracts.Qualifiers;
using indice.Edi.Serialization;

namespace Edi.Contracts.Segments;

/// <summary>
/// A segment specifying technical rules.
/// </summary>
[EdiSegment, EdiPath("TRU")]
public class TRU
{
	/// <summary>
	/// The number given to an object for its unique identification.
	/// </summary>
	[EdiValue("X(35)", Path = "TRU/0")]
	public string? IdentityNumber { get; set; }

	/// <summary>
	/// To specify the version number or name of an object.
	/// </summary>
	[EdiValue("X(9)", Path = "TRU/1")]
	public string? Version { get; set; }

	/// <summary>
	/// To specify the release number or release name of an object.
	/// </summary>
	[EdiValue("X(9)", Path = "TRU/2")]
	public string? Release { get; set; }

	/// <summary>
	/// Identification of a specific part of a rule.
	/// </summary>
	[EdiValue("X(7)", Path = "TRU/3")]
	public string? RulePartIdentification { get; set; }

	/// <summary>
	/// Code identifying the agency responsible for a code list.
	/// </summary>
	[EdiValue("X(3)", Path = "TRU/4")]
	public CodeListResponsibleAgencyCoded? CodeListResponsibleAgencyCoded { get; set; }

}