using System.Collections.Generic;
using Edi.Contracts.Qualifiers;
using indice.Edi.Serialization;

namespace Edi.Contracts.Segments;

/// <summary>
/// To identify a data set.
/// </summary>
[EdiSegment, EdiPath("DSI")]
public class DSI
{
	/// <summary>
	/// The identification of a data set.
	/// </summary>
	[EdiPath("DSI/0")]
	public DSI_DataSetIdentification? DataSetIdentification { get; set; }

	/// <summary>
	/// Identification of a transaction party by code.
	/// </summary>
	[EdiPath("DSI/1")]
	public DSI_PartyIdentificationDetails? PartyIdentificationDetails { get; set; }

	/// <summary>
	/// Provides information regarding a status.
	/// </summary>
	[EdiValue("X(3)", Path = "DSI/2")]
	public StatusCoded? StatusCoded { get; set; }

	/// <summary>
	/// Identification of a sequence and source for sequencing.
	/// </summary>
	[EdiPath("DSI/3")]
	public DSI_SequenceInformation? SequenceInformation { get; set; }

	/// <summary>
	/// To specify a revision number.
	/// </summary>
	[EdiValue("X(6)", Path = "DSI/4")]
	public string? RevisionNumber { get; set; }

}

/// <summary>
/// The identification of a data set.
/// </summary>
[EdiElement]
public class DSI_DataSetIdentification
{
	/// <summary>
	/// The identifier of a data set.
	/// </summary>
	[EdiValue("X(35)", Path = "DSI/*/0")]
	public string? DataSetIdentifier { get; set; }

	/// <summary>
	/// Code specifying the type/source of identity number.
	/// </summary>
	[EdiValue("X(3)", Path = "DSI/*/1")]
	public IdentityNumberQualifier? IdentityNumberQualifier { get; set; }
}

/// <summary>
/// Identification of a transaction party by code.
/// </summary>
[EdiElement]
public class DSI_PartyIdentificationDetails
{
	/// <summary>
	/// Code identifying a party involved in a transaction.
	/// </summary>
	[EdiValue("X(35)", Path = "DSI/*/0")]
	public string? PartyIdIdentification { get; set; }

	/// <summary>
	/// Identification of a code list.
	/// </summary>
	[EdiValue("X(3)", Path = "DSI/*/1")]
	public CodeListQualifier? CodeListQualifier { get; set; }

	/// <summary>
	/// Code identifying the agency responsible for a code list.
	/// </summary>
	[EdiValue("X(3)", Path = "DSI/*/2")]
	public CodeListResponsibleAgencyCoded? CodeListResponsibleAgencyCoded { get; set; }
}

/// <summary>
/// Identification of a sequence and source for sequencing.
/// </summary>
[EdiElement]
public class DSI_SequenceInformation
{
	/// <summary>
	/// Number indicating the position in a sequence.
	/// </summary>
	[EdiValue("X(10)", Path = "DSI/*/0")]
	public string? SequenceNumber { get; set; }

	/// <summary>
	/// Specification of the source for a specified sequence number in a coded form.
	/// </summary>
	[EdiValue("X(3)", Path = "DSI/*/1")]
	public SequenceNumberSourceCoded? SequenceNumberSourceCoded { get; set; }

	/// <summary>
	/// Identification of a code list.
	/// </summary>
	[EdiValue("X(3)", Path = "DSI/*/2")]
	public CodeListQualifier? CodeListQualifier { get; set; }

	/// <summary>
	/// Code identifying the agency responsible for a code list.
	/// </summary>
	[EdiValue("X(3)", Path = "DSI/*/3")]
	public CodeListResponsibleAgencyCoded? CodeListResponsibleAgencyCoded { get; set; }
}