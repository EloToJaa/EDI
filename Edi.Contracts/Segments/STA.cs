using System.Collections.Generic;
using Edi.Contracts.Qualifiers;
using Edi.Contracts.Interfaces;
using indice.Edi.Serialization;

namespace Edi.Contracts.Segments;

/// <summary>
/// To transmit summary statistics related to a specified collection of test result values.
/// </summary>
[EdiSegment, EdiPath("STA")]
public class STA : ISegment
{
	/// <summary>
	/// Specification of the specific statistic being reported.
	/// </summary>
	[EdiValue("X(3)", Path = "STA/0", Mandatory = true)]
	public StatisticTypeCoded? StatisticTypeCoded { get; set; }

	/// <summary>
	/// Specifications related to statistical measurements.
	/// </summary>
	[EdiPath("STA/1")]
	public STA_StatisticalDetails? StatisticalDetails { get; set; }
}

/// <summary>
/// Specifications related to statistical measurements.
/// </summary>
[EdiElement]
public class STA_StatisticalDetails : IElement
{
	/// <summary>
	/// Value of the measured unit.
	/// </summary>
	[EdiValue("X(18)", Path = "STA/*/0", Mandatory = false)]
	public string? MeasurementValue { get; set; }

	/// <summary>
	/// Indication of the unit of measurement in which weight (mass), capacity, length, area, volume or other quantity is expressed.
	/// </summary>
	[EdiValue("X(3)", Path = "STA/*/1", Mandatory = false)]
	public string? MeasureUnitQualifier { get; set; }

	/// <summary>
	/// Specification of the property measured.
	/// </summary>
	[EdiValue("X(3)", Path = "STA/*/2", Mandatory = false)]
	public PropertyMeasuredCoded? PropertyMeasuredCoded { get; set; }

	/// <summary>
	/// Code specifying the significance of a measurement value.
	/// </summary>
	[EdiValue("X(3)", Path = "STA/*/3", Mandatory = false)]
	public MeasurementSignificanceCoded? MeasurementSignificanceCoded { get; set; }
}