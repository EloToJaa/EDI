using System.Collections.Generic;
using Edi.Contracts.Qualifiers;
using indice.Edi.Serialization;

namespace Edi.Contracts.Segments;

/// <summary>
/// To identify the relevance of a characteristic information for subsequent business processes.
/// </summary>
[EdiSegment, EdiPath("CCI")]
public class CCI
{
	/// <summary>
	/// Specification of the type of class.
	/// </summary>
	[EdiValue("X(3)", Path = "CCI/0")]
	public PropertyClassCoded? PropertyClassCoded { get; set; }

	/// <summary>
	/// Identification of measurement type.
	/// </summary>
	[EdiPath("CCI/1")]
	public CCI_MeasurementDetails? MeasurementDetails { get; set; }

	/// <summary>
	/// Specific product characteristic data.
	/// </summary>
	[EdiPath("CCI/2")]
	public CCI_ProductCharacteristic? ProductCharacteristic { get; set; }

	/// <summary>
	/// To specify the relevance of a characteristic.
	/// </summary>
	[EdiValue("X(3)", Path = "CCI/3")]
	public CharacteristicRelevanceCoded? CharacteristicRelevanceCoded { get; set; }

}

/// <summary>
/// Identification of measurement type.
/// </summary>
[EdiElement]
public class CCI_MeasurementDetails
{
	/// <summary>
	/// Specification of the property measured.
	/// </summary>
	[EdiValue("X(3)", Path = "CCI/*/0")]
	public PropertyMeasuredCoded? PropertyMeasuredCoded { get; set; }

	/// <summary>
	/// Code specifying the significance of a measurement value.
	/// </summary>
	[EdiValue("X(3)", Path = "CCI/*/1")]
	public MeasurementSignificanceCoded? MeasurementSignificanceCoded { get; set; }

	/// <summary>
	/// Code used to specify non-discrete measurement values.
	/// </summary>
	[EdiValue("X(17)", Path = "CCI/*/2")]
	public MeasurementAttributeIdentification? MeasurementAttributeIdentification { get; set; }

	/// <summary>
	/// To specify non-discrete measurement values.
	/// </summary>
	[EdiValue("X(70)", Path = "CCI/*/3")]
	public string? MeasurementAttribute { get; set; }
}

/// <summary>
/// Specific product characteristic data.
/// </summary>
[EdiElement]
public class CCI_ProductCharacteristic
{
	/// <summary>
	/// A code from an industry code list which provides specific data about a product characteristic.
	/// </summary>
	[EdiValue("X(17)", Path = "CCI/*/0")]
	public string? CharacteristicIdentification { get; set; }

	/// <summary>
	/// Identification of a code list.
	/// </summary>
	[EdiValue("X(3)", Path = "CCI/*/1")]
	public CodeListQualifier? CodeListQualifier { get; set; }

	/// <summary>
	/// Code identifying the agency responsible for a code list.
	/// </summary>
	[EdiValue("X(3)", Path = "CCI/*/2")]
	public CodeListResponsibleAgencyCoded? CodeListResponsibleAgencyCoded { get; set; }

	/// <summary>
	/// Free form description of the product characteristic.
	/// </summary>
	[EdiValue("X(35)", Path = "CCI/*/3")]
	public string? Characteristic1 { get; set; }

	/// <summary>
	/// Free form description of the product characteristic.
	/// </summary>
	[EdiValue("X(35)", Path = "CCI/*/4")]
	public string? Characteristic2 { get; set; }
}