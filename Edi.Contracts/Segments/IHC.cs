using System.Collections.Generic;
using Edi.Contracts.Qualifiers;
using indice.Edi.Serialization;

namespace Edi.Contracts.Segments;

/// <summary>
/// To specify characteristics of a person such as ethnic origin.
/// </summary>
[EdiSegment, EdiPath("IHC")]
public class IHC
{
	/// <summary>
	/// To specify the type of specific person characteristic.
	/// </summary>
	[EdiValue("X(3)", Path = "IHC/0")]
	public PersonCharacteristicQualifier? PersonCharacteristicQualifier { get; set; }

	/// <summary>
	/// To specify an inherited characteristic of a person.
	/// </summary>
	[EdiPath("IHC/1")]
	public IHC_PersonInheritedCharacteristicDetails? PersonInheritedCharacteristicDetails { get; set; }
}

/// <summary>
/// To specify an inherited characteristic of a person.
/// </summary>
[EdiElement]
public class IHC_PersonInheritedCharacteristicDetails
{
	/// <summary>
	/// To specify a person inherited characteristic using a code value.
	/// </summary>
	[EdiValue("X(8)", Path = "IHC/*/0")]
	public string? PersonInheritedCharacteristicIdentification { get; set; }

	/// <summary>
	/// Identification of a code list.
	/// </summary>
	[EdiValue("X(3)", Path = "IHC/*/1")]
	public CodeListQualifier? CodeListQualifier { get; set; }

	/// <summary>
	/// Code identifying the agency responsible for a code list.
	/// </summary>
	[EdiValue("X(3)", Path = "IHC/*/2")]
	public CodeListResponsibleAgencyCoded? CodeListResponsibleAgencyCoded { get; set; }

	/// <summary>
	/// To specify a person inherited characteristic as free text.
	/// </summary>
	[EdiValue("X(70)", Path = "IHC/*/3")]
	public string? PersonInheritedCharacteristic { get; set; }
}