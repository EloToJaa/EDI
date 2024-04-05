using System.Collections.Generic;
using Edi.Contracts.Qualifiers;
using indice.Edi.Serialization;

namespace Edi.Contracts.Segments;

/// <summary>
/// To specify a nationality.
/// </summary>
[EdiSegment, EdiPath("NAT")]
public class NAT
{
	/// <summary>
	/// To qualify a nationality.
	/// </summary>
	[EdiValue("X(3)", Path = "NAT/0")]
	public NationalityQualifier? NationalityQualifier { get; set; }

	/// <summary>
	/// To specify a nationality.
	/// </summary>
	[EdiPath("NAT/1")]
	public NAT_NationalityDetails? NationalityDetails { get; set; }
}

/// <summary>
/// To specify a nationality.
/// </summary>
[EdiElement]
public class NAT_NationalityDetails
{
	/// <summary>
	/// Code for country of which an entity is the subject.
	/// </summary>
	[EdiValue("X(3)", Path = "NAT/*/0")]
	public string? NationalityCoded { get; set; }

	/// <summary>
	/// Identification of a code list.
	/// </summary>
	[EdiValue("X(3)", Path = "NAT/*/1")]
	public CodeListQualifier? CodeListQualifier { get; set; }

	/// <summary>
	/// Code identifying the agency responsible for a code list.
	/// </summary>
	[EdiValue("X(3)", Path = "NAT/*/2")]
	public CodeListResponsibleAgencyCoded? CodeListResponsibleAgencyCoded { get; set; }

	/// <summary>
	/// Name of country of which an entity is the subject.
	/// </summary>
	[EdiValue("X(35)", Path = "NAT/*/3")]
	public string? Nationality { get; set; }
}