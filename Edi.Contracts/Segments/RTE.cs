using System.Collections.Generic;
using Edi.Contracts.Qualifiers;
using Edi.Contracts.Interfaces;
using indice.Edi.Serialization;

namespace Edi.Contracts.Segments;

/// <summary>
/// To specify rate information.
/// </summary>
[EdiSegment, EdiPath("RTE")]
public class RTE : ISegment
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
public class RTE_RateDetails : IElement
{
	/// <summary>
	/// Identification of the type of rate.
	/// </summary>
	[EdiValue("X(3)", Path = "RTE/*/0", Mandatory = true)]
	public RateTypeQualifier? RateTypeQualifier { get; set; }

	/// <summary>
	/// Rate per unit specified in the unit price basis.
	/// </summary>
	[EdiValue("9(15)", Path = "RTE/*/1", Mandatory = true)]
	public decimal? RatePerUnit { get; set; }

	/// <summary>
	/// Basis on which the unit price/rate applies.
	/// </summary>
	[EdiValue("9(9)", Path = "RTE/*/2", Mandatory = false)]
	public decimal? UnitPriceBasis { get; set; }

	/// <summary>
	/// Indication of the unit of measurement in which weight (mass), capacity, length, area, volume or other quantity is expressed.
	/// </summary>
	[EdiValue("X(3)", Path = "RTE/*/3", Mandatory = false)]
	public string? MeasureUnitQualifier { get; set; }
}