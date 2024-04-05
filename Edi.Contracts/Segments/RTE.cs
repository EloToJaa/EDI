using System.Collections.Generic;
using Edi.Contracts.Qualifiers;
using indice.Edi.Serialization;

namespace Edi.Contracts.Segments;

/// <summary>
/// To specify rate information.
/// </summary>
[EdiSegment, EdiPath("RTE")]
public class RTE
{
	/// <summary>
	/// Rate per unit and rate basis.
	/// </summary>
	[EdiPath("RTE/0")]
	public RTE_RateDetails? RateDetails { get; set; }
}

/// <summary>
/// Rate per unit and rate basis.
/// </summary>
[EdiElement]
public class RTE_RateDetails
{
	/// <summary>
	/// Identification of the type of rate.
	/// </summary>
	[EdiValue("X(3)", Path = "RTE/*/0")]
	public RateTypeQualifier? RateTypeQualifier { get; set; }

	/// <summary>
	/// Rate per unit specified in the unit price basis.
	/// </summary>
	[EdiValue("9(15)", Path = "RTE/*/1")]
	public int? RatePerUnit { get; set; }

	/// <summary>
	/// Basis on which the unit price/rate applies.
	/// </summary>
	[EdiValue("9(9)", Path = "RTE/*/2")]
	public int? UnitPriceBasis { get; set; }

	/// <summary>
	/// Indication of the unit of measurement in which weight (mass), capacity, length, area, volume or other quantity is expressed.
	/// </summary>
	[EdiValue("X(3)", Path = "RTE/*/3")]
	public string? MeasureUnitQualifier { get; set; }
}