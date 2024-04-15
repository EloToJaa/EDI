using System.Collections.Generic;
using Edi.Contracts.Segments;
using Edi.Contracts.Interfaces;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// BAPLIE
/// </summary>
[EdiMessage]
public class BAPLIE : IMessage
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
	public DTM? DateTimePeriodM { get; set; }

	/// <summary>
	/// SG1
	/// </summary>
	public List<BAPLIE_SG1>? SG1C { get; set; }

	/// <summary>
	/// SG2
	/// </summary>
	public List<BAPLIE_SG2>? SG2C { get; set; }

	/// <summary>
	/// SG4
	/// </summary>
	public List<BAPLIE_SG4>? SG4M { get; set; }

	/// <summary>
	/// SG5
	/// </summary>
	public List<BAPLIE_SG5>? SG5C { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class BAPLIE_SG1 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("NAD", "CTA")]
public class BAPLIE_SG2 : NAD, ISegmentGroup
{
	/// <summary>
	/// SG3
	/// </summary>
	public List<BAPLIE_SG3>? SG3C { get; set; }

}

[EdiSegmentGroup("CTA", "COM")]
public class BAPLIE_SG3 : CTA, ISegmentGroup
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("TDT", "LOC", "DTM", "RFF", "FTX")]
public class BAPLIE_SG4 : TDT, ISegmentGroup
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationM { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodM { get; set; }

	/// <summary>
	/// Reference
	/// </summary>
	public RFF? ReferenceC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public FTX? FreeTextC { get; set; }
}

[EdiSegmentGroup("LOC", "GID", "GDS", "FTX", "MEA", "DIM", "TMP", "RNG", "LOC", "RFF", "EQD", "DGS")]
public class BAPLIE_SG5 : LOC, ISegmentGroup
{
	/// <summary>
	/// Goods item details
	/// </summary>
	public GID? GoodsItemDetailsC { get; set; }

	/// <summary>
	/// Nature of cargo
	/// </summary>
	public GDS? NatureOfCargoC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// Measurements
	/// </summary>
	public List<MEA>? MeasurementsM { get; set; }

	/// <summary>
	/// Dimensions
	/// </summary>
	public List<DIM>? DimensionsC { get; set; }

	/// <summary>
	/// Temperature
	/// </summary>
	public TMP? TemperatureC { get; set; }

	/// <summary>
	/// Range details
	/// </summary>
	public RNG? RangeDetailsC { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentification1C { get; set; }

	/// <summary>
	/// Reference
	/// </summary>
	public RFF? ReferenceM { get; set; }

	/// <summary>
	/// SG6
	/// </summary>
	public List<BAPLIE_SG6>? SG6C { get; set; }

	/// <summary>
	/// SG7
	/// </summary>
	public List<BAPLIE_SG7>? SG7C { get; set; }

}

[EdiSegmentGroup("EQD", "EQA", "NAD")]
public class BAPLIE_SG6 : EQD, ISegmentGroup
{
	/// <summary>
	/// Attached equipment
	/// </summary>
	public List<EQA>? AttachedEquipmentC { get; set; }

	/// <summary>
	/// Name and address
	/// </summary>
	public NAD? NameAndAddressC { get; set; }
}

[EdiSegmentGroup("DGS", "FTX")]
public class BAPLIE_SG7 : DGS, ISegmentGroup
{
	/// <summary>
	/// Free text
	/// </summary>
	public FTX? FreeTextC { get; set; }
}