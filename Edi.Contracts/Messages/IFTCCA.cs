using System.Collections.Generic;
using Edi.Contracts.Segments;
using Edi.Contracts.Interfaces;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// IFTCCA
/// </summary>
[EdiMessage]
public class IFTCCA : IMessage
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
	/// Contact information
	/// </summary>
	public List<CTA>? ContactInformationC { get; set; }

	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Transport service requirements
	/// </summary>
	public List<TSR>? TransportServiceRequirementsC { get; set; }

	/// <summary>
	/// Currencies
	/// </summary>
	public List<CUX>? CurrenciesC { get; set; }

	/// <summary>
	/// Monetary amount
	/// </summary>
	public List<MOA>? MonetaryAmountC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// SG1
	/// </summary>
	public List<IFTCCA_SG1>? SG1C { get; set; }

	/// <summary>
	/// Control total
	/// </summary>
	public List<CNT>? ControlTotalC { get; set; }

	/// <summary>
	/// SG2
	/// </summary>
	public List<IFTCCA_SG2>? SG2C { get; set; }

	/// <summary>
	/// SG3
	/// </summary>
	public List<IFTCCA_SG3>? SG3C { get; set; }

	/// <summary>
	/// SG4
	/// </summary>
	public List<IFTCCA_SG4>? SG4C { get; set; }

	/// <summary>
	/// SG6
	/// </summary>
	public List<IFTCCA_SG6>? SG6C { get; set; }

	/// <summary>
	/// SG9
	/// </summary>
	public List<IFTCCA_SG9>? SG9C { get; set; }

	/// <summary>
	/// SG23
	/// </summary>
	public List<IFTCCA_SG23>? SG23C { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class IFTCCA_SG1 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("LOC", "DTM")]
public class IFTCCA_SG2 : LOC, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("CPI", "CUX", "LOC", "MOA")]
public class IFTCCA_SG3 : CPI, ISegmentGroup
{
	/// <summary>
	/// Currencies
	/// </summary>
	public List<CUX>? CurrenciesC { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// Monetary amount
	/// </summary>
	public List<MOA>? MonetaryAmountC { get; set; }
}

[EdiSegmentGroup("TDT", "DTM", "TSR", "LOC", "FTX", "RFF")]
public class IFTCCA_SG4 : TDT, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Transport service requirements
	/// </summary>
	public List<TSR>? TransportServiceRequirementsC { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// SG5
	/// </summary>
	public List<IFTCCA_SG5>? SG5C { get; set; }

}

[EdiSegmentGroup("RFF", "DTM")]
public class IFTCCA_SG5 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("NAD", "LOC", "CTA", "RFF")]
public class IFTCCA_SG6 : NAD, ISegmentGroup
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// SG7
	/// </summary>
	public List<IFTCCA_SG7>? SG7C { get; set; }

	/// <summary>
	/// SG8
	/// </summary>
	public List<IFTCCA_SG8>? SG8C { get; set; }

}

[EdiSegmentGroup("CTA", "COM")]
public class IFTCCA_SG7 : CTA, ISegmentGroup
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class IFTCCA_SG8 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("GID", "HAN", "TMP", "RNG", "LOC", "FTX", "GDS", "MEA", "DIM", "RFF", "TPL", "SGP", "TCC", "DGS")]
public class IFTCCA_SG9 : GID, ISegmentGroup
{
	/// <summary>
	/// Handling instructions
	/// </summary>
	public List<HAN>? HandlingInstructionsC { get; set; }

	/// <summary>
	/// Temperature
	/// </summary>
	public List<TMP>? TemperatureC { get; set; }

	/// <summary>
	/// Range details
	/// </summary>
	public List<RNG>? RangeDetailsC { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// SG10
	/// </summary>
	public List<IFTCCA_SG10>? SG10C { get; set; }

	/// <summary>
	/// SG11
	/// </summary>
	public List<IFTCCA_SG11>? SG11C { get; set; }

	/// <summary>
	/// SG12
	/// </summary>
	public List<IFTCCA_SG12>? SG12C { get; set; }

	/// <summary>
	/// SG13
	/// </summary>
	public List<IFTCCA_SG13>? SG13C { get; set; }

	/// <summary>
	/// SG14
	/// </summary>
	public List<IFTCCA_SG14>? SG14C { get; set; }

	/// <summary>
	/// SG16
	/// </summary>
	public List<IFTCCA_SG16>? SG16C { get; set; }

	/// <summary>
	/// SG18
	/// </summary>
	public List<IFTCCA_SG18>? SG18C { get; set; }

	/// <summary>
	/// SG19
	/// </summary>
	public List<IFTCCA_SG19>? SG19C { get; set; }

}

[EdiSegmentGroup("GDS", "FTX")]
public class IFTCCA_SG10 : GDS, ISegmentGroup
{
	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }
}

[EdiSegmentGroup("MEA", "EQN")]
public class IFTCCA_SG11 : MEA, ISegmentGroup
{
	/// <summary>
	/// Number of units
	/// </summary>
	public List<EQN>? NumberOfUnitsC { get; set; }
}

[EdiSegmentGroup("DIM", "EQN")]
public class IFTCCA_SG12 : DIM, ISegmentGroup
{
	/// <summary>
	/// Number of units
	/// </summary>
	public List<EQN>? NumberOfUnitsC { get; set; }
}

[EdiSegmentGroup("RFF", "EQN")]
public class IFTCCA_SG13 : RFF, ISegmentGroup
{
	/// <summary>
	/// Number of units
	/// </summary>
	public List<EQN>? NumberOfUnitsC { get; set; }
}

[EdiSegmentGroup("TPL", "MEA")]
public class IFTCCA_SG14 : TPL, ISegmentGroup
{
	/// <summary>
	/// SG15
	/// </summary>
	public List<IFTCCA_SG15>? SG15C { get; set; }

}

[EdiSegmentGroup("MEA", "EQN")]
public class IFTCCA_SG15 : MEA, ISegmentGroup
{
	/// <summary>
	/// Number of units
	/// </summary>
	public List<EQN>? NumberOfUnitsC { get; set; }
}

[EdiSegmentGroup("SGP", "MEA")]
public class IFTCCA_SG16 : SGP, ISegmentGroup
{
	/// <summary>
	/// SG17
	/// </summary>
	public List<IFTCCA_SG17>? SG17C { get; set; }

}

[EdiSegmentGroup("MEA", "EQN")]
public class IFTCCA_SG17 : MEA, ISegmentGroup
{
	/// <summary>
	/// Number of units
	/// </summary>
	public List<EQN>? NumberOfUnitsC { get; set; }
}

[EdiSegmentGroup("TCC", "PRI", "EQN", "PCD", "MOA", "QTY", "LOC", "RFF", "MEA", "CUX", "DTM", "FTX")]
public class IFTCCA_SG18 : TCC, ISegmentGroup
{
	/// <summary>
	/// Price details
	/// </summary>
	public List<PRI>? PriceDetailsC { get; set; }

	/// <summary>
	/// Number of units
	/// </summary>
	public List<EQN>? NumberOfUnitsC { get; set; }

	/// <summary>
	/// Percentage details
	/// </summary>
	public List<PCD>? PercentageDetailsC { get; set; }

	/// <summary>
	/// Monetary amount
	/// </summary>
	public List<MOA>? MonetaryAmountC { get; set; }

	/// <summary>
	/// Quantity
	/// </summary>
	public List<QTY>? QuantityC { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }

	/// <summary>
	/// Measurements
	/// </summary>
	public List<MEA>? MeasurementsC { get; set; }

	/// <summary>
	/// Currencies
	/// </summary>
	public List<CUX>? CurrenciesC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }
}

[EdiSegmentGroup("DGS", "FTX", "MEA", "SGP")]
public class IFTCCA_SG19 : DGS, ISegmentGroup
{
	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// SG20
	/// </summary>
	public List<IFTCCA_SG20>? SG20C { get; set; }

	/// <summary>
	/// SG21
	/// </summary>
	public List<IFTCCA_SG21>? SG21C { get; set; }

}

[EdiSegmentGroup("MEA", "EQN")]
public class IFTCCA_SG20 : MEA, ISegmentGroup
{
	/// <summary>
	/// Number of units
	/// </summary>
	public EQN? NumberOfUnitsC { get; set; }
}

[EdiSegmentGroup("SGP", "MEA")]
public class IFTCCA_SG21 : SGP, ISegmentGroup
{
	/// <summary>
	/// SG22
	/// </summary>
	public List<IFTCCA_SG22>? SG22C { get; set; }

}

[EdiSegmentGroup("MEA", "EQN")]
public class IFTCCA_SG22 : MEA, ISegmentGroup
{
	/// <summary>
	/// Number of units
	/// </summary>
	public EQN? NumberOfUnitsC { get; set; }
}

[EdiSegmentGroup("EQD", "EQN", "FTX")]
public class IFTCCA_SG23 : EQD, ISegmentGroup
{
	/// <summary>
	/// Number of units
	/// </summary>
	public List<EQN>? NumberOfUnitsC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }
}