using System.Collections.Generic;
using Edi.Contracts.Qualifiers;
using Edi.Contracts.Interfaces;
using indice.Edi.Serialization;

namespace Edi.Contracts.Segments;

/// <summary>
/// To specify a nationality.
/// </summary>
[EdiSegment, EdiPath("NAT")]
public class NAT : ISegment
{
	/// <summary>
	/// To qualify a nationality.
	/// </summary>
	[EdiValue("X(3)", Path = "NAT/0", Mandatory = true)]
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
public class NAT_NationalityDetails : IElement
{
	/// <summary>
	/// Code for country of which an entity is the subject.
	/// </summary>
	[EdiValue("X(3)", Path = "NAT/*/0", Mandatory = false)]
	public string? NationalityCoded { get; set; }

	/// <summary>
	/// Identification of a code list.
	/// </summary>
	[EdiValue("X(3)", Path = "NAT/*/1", Mandatory = false)]
	public CodeListQualifier? CodeListQualifier { get; set; }

	/// <summary>
	/// Code identifying the agency responsible for a code list.
	/// </summary>
	[EdiValue("X(3)", Path = "NAT/*/2", Mandatory = false)]
	public CodeListResponsibleAgencyCoded? CodeListResponsibleAgencyCoded { get; set; }

	/// <summary>
	/// Name of country of which an entity is the subject.
	/// </summary>
	[EdiValue("X(35)", Path = "NAT/*/3", Mandatory = false)]
	public string? Nationality { get; set; }
}