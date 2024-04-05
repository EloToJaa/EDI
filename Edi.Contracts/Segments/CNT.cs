using System.Collections.Generic;
using Edi.Contracts.Qualifiers;
using indice.Edi.Serialization;

namespace Edi.Contracts.Segments;

/// <summary>
/// To provide control total.
/// </summary>
[EdiSegment, EdiPath("CNT")]
public class CNT
{
	/// <summary>
	/// Control total for checking integrity of a message or part of a message.
	/// </summary>
	[EdiPath("CNT/0")]
	public CNT_Control? Control { get; set; }
}

/// <summary>
/// Control total for checking integrity of a message or part of a message.
/// </summary>
[EdiElement]
public class CNT_Control
{
	/// <summary>
	/// Determines the source data elements in the message which forms the basis for 6066 Control value.
	/// </summary>
	[EdiValue("X(3)", Path = "CNT/*/0")]
	public ControlQualifier? ControlQualifier { get; set; }

	/// <summary>
	/// Value obtained from summing the values specified by the Control Qualifier throughout the message (Hash total).
	/// </summary>
	[EdiValue("9(18)", Path = "CNT/*/1")]
	public int? ControlValue { get; set; }

	/// <summary>
	/// Indication of the unit of measurement in which weight (mass), capacity, length, area, volume or other quantity is expressed.
	/// </summary>
	[EdiValue("X(3)", Path = "CNT/*/2")]
	public string? MeasureUnitQualifier { get; set; }
}