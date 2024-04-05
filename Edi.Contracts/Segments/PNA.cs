using System.Collections.Generic;
using Edi.Contracts.Qualifiers;
using indice.Edi.Serialization;

namespace Edi.Contracts.Segments;

/// <summary>
/// To specify information necessary to establish the identity of a party.
/// </summary>
[EdiSegment, EdiPath("PNA")]
public class PNA
{
	/// <summary>
	/// Code giving specific meaning to a party.
	/// </summary>
	[EdiValue("X(3)", Path = "PNA/0")]
	public PartyQualifier? PartyQualifier { get; set; }

	/// <summary>
	/// The identification of an object.
	/// </summary>
	[EdiPath("PNA/1")]
	public PNA_IdentificationNumber? IdentificationNumber { get; set; }

	/// <summary>
	/// Identification of a transaction party by code.
	/// </summary>
	[EdiPath("PNA/2")]
	public PNA_PartyIdentificationDetails? PartyIdentificationDetails { get; set; }

	/// <summary>
	/// Code for type of name such as official name, alias.
	/// </summary>
	[EdiValue("X(3)", Path = "PNA/3")]
	public NameTypeCoded? NameTypeCoded { get; set; }

	/// <summary>
	/// To specify the status of a name (such as current name).
	/// </summary>
	[EdiValue("X(3)", Path = "PNA/4")]
	public NameStatusCoded? NameStatusCoded { get; set; }

	/// <summary>
	/// To specify a name component.
	/// </summary>
	[EdiPath("PNA/5")]
	public PNA_NameComponentDetails? NameComponentDetails1 { get; set; }

	/// <summary>
	/// To specify a name component.
	/// </summary>
	[EdiPath("PNA/6")]
	public PNA_NameComponentDetails? NameComponentDetails2 { get; set; }

	/// <summary>
	/// To specify a name component.
	/// </summary>
	[EdiPath("PNA/7")]
	public PNA_NameComponentDetails? NameComponentDetails3 { get; set; }

	/// <summary>
	/// To specify a name component.
	/// </summary>
	[EdiPath("PNA/8")]
	public PNA_NameComponentDetails? NameComponentDetails4 { get; set; }

	/// <summary>
	/// To specify a name component.
	/// </summary>
	[EdiPath("PNA/9")]
	public PNA_NameComponentDetails? NameComponentDetails5 { get; set; }
}

/// <summary>
/// The identification of an object.
/// </summary>
[EdiElement]
public class PNA_IdentificationNumber
{
	/// <summary>
	/// The number given to an object for its unique identification.
	/// </summary>
	[EdiValue("X(35)", Path = "PNA/*/0")]
	public string? IdentityNumber { get; set; }

	/// <summary>
	/// Code specifying the type/source of identity number.
	/// </summary>
	[EdiValue("X(3)", Path = "PNA/*/1")]
	public IdentityNumberQualifier? IdentityNumberQualifier { get; set; }

	/// <summary>
	/// Provides information regarding a status.
	/// </summary>
	[EdiValue("X(3)", Path = "PNA/*/2")]
	public StatusCoded? StatusCoded { get; set; }
}

/// <summary>
/// Identification of a transaction party by code.
/// </summary>
[EdiElement]
public class PNA_PartyIdentificationDetails
{
	/// <summary>
	/// Code identifying a party involved in a transaction.
	/// </summary>
	[EdiValue("X(35)", Path = "PNA/*/0")]
	public string? PartyIdIdentification { get; set; }

	/// <summary>
	/// Identification of a code list.
	/// </summary>
	[EdiValue("X(3)", Path = "PNA/*/1")]
	public CodeListQualifier? CodeListQualifier { get; set; }

	/// <summary>
	/// Code identifying the agency responsible for a code list.
	/// </summary>
	[EdiValue("X(3)", Path = "PNA/*/2")]
	public CodeListResponsibleAgencyCoded? CodeListResponsibleAgencyCoded { get; set; }
}

/// <summary>
/// To specify a name component.
/// </summary>
[EdiElement]
public class PNA_NameComponentDetails
{
	/// <summary>
	/// To indicate a part of the name such as family name or given name.
	/// </summary>
	[EdiValue("X(3)", Path = "PNA/*/0")]
	public NameComponentQualifier? NameComponentQualifier { get; set; }

	/// <summary>
	/// Part of party name such as family name or given name.
	/// </summary>
	[EdiValue("X(70)", Path = "PNA/*/1")]
	public string? NameComponent { get; set; }

	/// <summary>
	/// To specify the status of a name component.
	/// </summary>
	[EdiValue("X(3)", Path = "PNA/*/2")]
	public NameComponentStatusCoded? NameComponentStatusCoded { get; set; }

	/// <summary>
	/// To specify the alphabet originally used to represent the name.
	/// </summary>
	[EdiValue("X(3)", Path = "PNA/*/3")]
	public NameComponentOriginalRepresentationCoded? NameComponentOriginalRepresentationCoded { get; set; }
}