using System.Collections.Generic;
using Edi.Contracts.Segments;
using Edi.Contracts.Interfaces;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// PRODEX
/// </summary>
[EdiMessage]
public class PRODEX : IMessage
{
	/// <summary>
	/// Message header
	/// </summary>
	public UNH? MessageHeaderM { get; set; }

	/// <summary>
	/// Beginning of message
	/// </summary>
	public BGM? BeginningOfMessageM { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodM { get; set; }

	/// <summary>
	/// Measurements
	/// </summary>
	public MEA? MeasurementsM { get; set; }

	/// <summary>
	/// Name and address
	/// </summary>
	public List<NAD>? NameAndAddressM { get; set; }

	/// <summary>
	/// SG1
	/// </summary>
	public List<PRODEX_SG1>? SG1M { get; set; }

	/// <summary>
	/// SG2
	/// </summary>
	public List<PRODEX_SG2>? SG2M { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class PRODEX_SG1 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("IMD", "QTY", "LIN")]
public class PRODEX_SG2 : IMD, ISegmentGroup
{
	/// <summary>
	/// Quantity
	/// </summary>
	public List<QTY>? QuantityC { get; set; }

	/// <summary>
	/// SG3
	/// </summary>
	public List<PRODEX_SG3>? SG3C { get; set; }

}

[EdiSegmentGroup("LIN", "GIS", "LOC", "DTM", "MEA", "QTY", "TDT", "RFF")]
public class PRODEX_SG3 : LIN, ISegmentGroup
{
	/// <summary>
	/// General indicator
	/// </summary>
	public List<GIS>? GeneralIndicatorC { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }

	/// <summary>
	/// Measurements
	/// </summary>
	public List<MEA>? MeasurementsC { get; set; }

	/// <summary>
	/// Quantity
	/// </summary>
	public List<QTY>? QuantityC { get; set; }

	/// <summary>
	/// Details of transport
	/// </summary>
	public List<TDT>? DetailsOfTransportC { get; set; }

	/// <summary>
	/// SG4
	/// </summary>
	public List<PRODEX_SG4>? SG4C { get; set; }

}

[EdiSegmentGroup("RFF", "DTM")]
public class PRODEX_SG4 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}