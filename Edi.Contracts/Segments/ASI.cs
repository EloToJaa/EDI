using System.Collections.Generic;
using Edi.Contracts.Qualifiers;
using Edi.Contracts.Interfaces;
using indice.Edi.Serialization;

namespace Edi.Contracts.Segments;

/// <summary>
/// To identify the structure of an array.
/// </summary>
[EdiSegment, EdiPath("ASI")]
public class ASI : ISegment
{
	/// <summary>
	/// The identification of an array structure.
	/// </summary>
	[EdiPath("ASI/0")]
	public ASI_ArrayStructureIdentification? ArrayStructureIdentification { get; set; }

	/// <summary>
	/// Identification of a transaction party by code.
	/// </summary>
	[EdiPath("ASI/1")]
	public ASI_PartyIdentificationDetails? PartyIdentificationDetails { get; set; }

	/// <summary>
	/// Provides information regarding a status.
	/// </summary>
	[EdiValue("X(3)", Path = "ASI/2", Mandatory = false)]
	public StatusCoded? StatusCoded { get; set; }

	/// <summary>
	/// To indicate the type of data maintenance operation for an object, such as add, delete, replace.
	/// </summary>
	[EdiValue("X(3)", Path = "ASI/3", Mandatory = false)]
	public MaintenanceOperationCoded? MaintenanceOperationCoded { get; set; }

}

/// <summary>
/// The identification of an array structure.
/// </summary>
[EdiElement]
public class ASI_ArrayStructureIdentification : IElement
{
	/// <summary>
	/// The identifier of an array structure.
	/// </summary>
	[EdiValue("X(35)", Path = "ASI/*/0", Mandatory = true)]
	public string? ArrayStructureIdentifier { get; set; }

	/// <summary>
	/// Code specifying the type/source of identity number.
	/// </summary>
	[EdiValue("X(3)", Path = "ASI/*/1", Mandatory = false)]
	public IdentityNumberQualifier? IdentityNumberQualifier { get; set; }
}

/// <summary>
/// Identification of a transaction party by code.
/// </summary>
[EdiElement]
public class ASI_PartyIdentificationDetails : IElement
{
	/// <summary>
	/// Code identifying a party involved in a transaction.
	/// </summary>
	[EdiValue("X(35)", Path = "ASI/*/0", Mandatory = true)]
	public string? PartyIdIdentification { get; set; }

	/// <summary>
	/// Identification of a code list.
	/// </summary>
	[EdiValue("X(3)", Path = "ASI/*/1", Mandatory = false)]
	public CodeListQualifier? CodeListQualifier { get; set; }

	/// <summary>
	/// Code identifying the agency responsible for a code list.
	/// </summary>
	[EdiValue("X(3)", Path = "ASI/*/2", Mandatory = false)]
	public CodeListResponsibleAgencyCoded? CodeListResponsibleAgencyCoded { get; set; }
}