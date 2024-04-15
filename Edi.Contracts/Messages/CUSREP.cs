using System.Collections.Generic;
using Edi.Contracts.Segments;
using Edi.Contracts.Interfaces;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// CUSREP
/// </summary>
[EdiMessage]
public class CUSREP : IMessage
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
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Quantity
	/// </summary>
	public List<QTY>? QuantityC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// Measurements
	/// </summary>
	public List<MEA>? MeasurementsC { get; set; }

	/// <summary>
	/// General indicator
	/// </summary>
	public List<GIS>? GeneralIndicatorC { get; set; }

	/// <summary>
	/// SG1
	/// </summary>
	public List<CUSREP_SG1>? SG1C { get; set; }

	/// <summary>
	/// SG2
	/// </summary>
	public List<CUSREP_SG2>? SG2C { get; set; }

	/// <summary>
	/// SG3
	/// </summary>
	public List<CUSREP_SG3>? SG3C { get; set; }

	/// <summary>
	/// SG4
	/// </summary>
	public List<CUSREP_SG4>? SG4C { get; set; }

	/// <summary>
	/// SG5
	/// </summary>
	public List<CUSREP_SG5>? SG5C { get; set; }

	/// <summary>
	/// SG8
	/// </summary>
	public List<CUSREP_SG8>? SG8C { get; set; }

	/// <summary>
	/// SG10
	/// </summary>
	public List<CUSREP_SG10>? SG10C { get; set; }

	/// <summary>
	/// SG11
	/// </summary>
	public CUSREP_SG11? SG11C { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class CUSREP_SG1 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("LOC", "DTM")]
public class CUSREP_SG2 : LOC, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("DOC", "RFF", "DTM", "LOC")]
public class CUSREP_SG3 : DOC, ISegmentGroup
{
	/// <summary>
	/// Reference
	/// </summary>
	public RFF? ReferenceC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public LOC? PlaceLocationIdentificationC { get; set; }
}

[EdiSegmentGroup("TAX", "MOA", "GIS")]
public class CUSREP_SG4 : TAX, ISegmentGroup
{
	/// <summary>
	/// Monetary amount
	/// </summary>
	public MOA? MonetaryAmountC { get; set; }

	/// <summary>
	/// General indicator
	/// </summary>
	public GIS? GeneralIndicatorC { get; set; }
}

[EdiSegmentGroup("NAD", "CTA", "RFF")]
public class CUSREP_SG5 : NAD, ISegmentGroup
{
	/// <summary>
	/// SG6
	/// </summary>
	public List<CUSREP_SG6>? SG6C { get; set; }

	/// <summary>
	/// SG7
	/// </summary>
	public List<CUSREP_SG7>? SG7C { get; set; }

}

[EdiSegmentGroup("CTA", "COM")]
public class CUSREP_SG6 : CTA, ISegmentGroup
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class CUSREP_SG7 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("TDT", "TPL", "DTM", "LOC")]
public class CUSREP_SG8 : TDT, ISegmentGroup
{
	/// <summary>
	/// Transport placement
	/// </summary>
	public TPL? TransportPlacementC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }

	/// <summary>
	/// SG9
	/// </summary>
	public List<CUSREP_SG9>? SG9C { get; set; }

}

[EdiSegmentGroup("LOC", "DTM", "QTY")]
public class CUSREP_SG9 : LOC, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Quantity
	/// </summary>
	public List<QTY>? QuantityC { get; set; }
}

[EdiSegmentGroup("EQD", "EQN")]
public class CUSREP_SG10 : EQD, ISegmentGroup
{
	/// <summary>
	/// Number of units
	/// </summary>
	public EQN? NumberOfUnitsC { get; set; }
}

[EdiSegmentGroup("AUT", "DTM")]
public class CUSREP_SG11 : AUT, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}