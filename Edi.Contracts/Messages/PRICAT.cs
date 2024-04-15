using System.Collections.Generic;
using Edi.Contracts.Segments;
using Edi.Contracts.Interfaces;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// PRICAT
/// </summary>
[EdiMessage]
public class PRICAT : IMessage
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
	/// Additional information
	/// </summary>
	public List<ALI>? AdditionalInformationC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// SG1
	/// </summary>
	public List<PRICAT_SG1>? SG1C { get; set; }

	/// <summary>
	/// SG2
	/// </summary>
	public List<PRICAT_SG2>? SG2C { get; set; }

	/// <summary>
	/// SG5
	/// </summary>
	public List<PRICAT_SG5>? SG5C { get; set; }

	/// <summary>
	/// SG6
	/// </summary>
	public List<PRICAT_SG6>? SG6C { get; set; }

	/// <summary>
	/// SG7
	/// </summary>
	public List<PRICAT_SG7>? SG7C { get; set; }

	/// <summary>
	/// SG8
	/// </summary>
	public List<PRICAT_SG8>? SG8C { get; set; }

	/// <summary>
	/// SG9
	/// </summary>
	public List<PRICAT_SG9>? SG9C { get; set; }

	/// <summary>
	/// SG10
	/// </summary>
	public List<PRICAT_SG10>? SG10C { get; set; }

	/// <summary>
	/// SG16
	/// </summary>
	public List<PRICAT_SG16>? SG16C { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class PRICAT_SG1 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("NAD", "LOC", "RFF", "CTA")]
public class PRICAT_SG2 : NAD, ISegmentGroup
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// SG3
	/// </summary>
	public List<PRICAT_SG3>? SG3C { get; set; }

	/// <summary>
	/// SG4
	/// </summary>
	public List<PRICAT_SG4>? SG4C { get; set; }

}

[EdiSegmentGroup("RFF", "DTM")]
public class PRICAT_SG3 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("CTA", "COM")]
public class PRICAT_SG4 : CTA, ISegmentGroup
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("TAX", "MOA", "DTM")]
public class PRICAT_SG5 : TAX, ISegmentGroup
{
	/// <summary>
	/// Monetary amount
	/// </summary>
	public MOA? MonetaryAmountC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("CUX", "DTM")]
public class PRICAT_SG6 : CUX, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("PAT", "DTM", "PCD", "MOA")]
public class PRICAT_SG7 : PAT, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Percentage details
	/// </summary>
	public PCD? PercentageDetailsC { get; set; }

	/// <summary>
	/// Monetary amount
	/// </summary>
	public MOA? MonetaryAmountC { get; set; }
}

[EdiSegmentGroup("TDT", "LOC")]
public class PRICAT_SG8 : TDT, ISegmentGroup
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }
}

[EdiSegmentGroup("TOD", "LOC")]
public class PRICAT_SG9 : TOD, ISegmentGroup
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }
}

[EdiSegmentGroup("ALC", "ALI", "DTM", "QTY", "PCD", "MOA", "RTE", "TAX")]
public class PRICAT_SG10 : ALC, ISegmentGroup
{
	/// <summary>
	/// Additional information
	/// </summary>
	public List<ALI>? AdditionalInformationC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// SG11
	/// </summary>
	public List<PRICAT_SG11>? SG11C { get; set; }

	/// <summary>
	/// SG12
	/// </summary>
	public List<PRICAT_SG12>? SG12C { get; set; }

	/// <summary>
	/// SG13
	/// </summary>
	public List<PRICAT_SG13>? SG13C { get; set; }

	/// <summary>
	/// SG14
	/// </summary>
	public List<PRICAT_SG14>? SG14C { get; set; }

	/// <summary>
	/// SG15
	/// </summary>
	public List<PRICAT_SG15>? SG15C { get; set; }

}

[EdiSegmentGroup("QTY", "RNG")]
public class PRICAT_SG11 : QTY, ISegmentGroup
{
	/// <summary>
	/// Range details
	/// </summary>
	public RNG? RangeDetailsC { get; set; }
}

[EdiSegmentGroup("PCD", "RNG")]
public class PRICAT_SG12 : PCD, ISegmentGroup
{
	/// <summary>
	/// Range details
	/// </summary>
	public RNG? RangeDetailsC { get; set; }
}

[EdiSegmentGroup("MOA", "RNG")]
public class PRICAT_SG13 : MOA, ISegmentGroup
{
	/// <summary>
	/// Range details
	/// </summary>
	public RNG? RangeDetailsC { get; set; }
}

[EdiSegmentGroup("RTE", "RNG")]
public class PRICAT_SG14 : RTE, ISegmentGroup
{
	/// <summary>
	/// Range details
	/// </summary>
	public RNG? RangeDetailsC { get; set; }
}

[EdiSegmentGroup("TAX", "MOA", "DTM")]
public class PRICAT_SG15 : TAX, ISegmentGroup
{
	/// <summary>
	/// Monetary amount
	/// </summary>
	public MOA? MonetaryAmountC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("PGI", "DTM", "QTY", "ALI", "FTX", "CUX", "PRI", "TAX", "ALC", "NAD", "PAT", "TDT", "TOD", "PAC", "LIN")]
public class PRICAT_SG16 : PGI, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Quantity
	/// </summary>
	public List<QTY>? QuantityC { get; set; }

	/// <summary>
	/// Additional information
	/// </summary>
	public List<ALI>? AdditionalInformationC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// SG17
	/// </summary>
	public List<PRICAT_SG17>? SG17C { get; set; }

	/// <summary>
	/// SG18
	/// </summary>
	public List<PRICAT_SG18>? SG18C { get; set; }

	/// <summary>
	/// SG19
	/// </summary>
	public List<PRICAT_SG19>? SG19C { get; set; }

	/// <summary>
	/// SG20
	/// </summary>
	public List<PRICAT_SG20>? SG20C { get; set; }

	/// <summary>
	/// SG26
	/// </summary>
	public List<PRICAT_SG26>? SG26C { get; set; }

	/// <summary>
	/// SG29
	/// </summary>
	public List<PRICAT_SG29>? SG29C { get; set; }

	/// <summary>
	/// SG30
	/// </summary>
	public List<PRICAT_SG30>? SG30C { get; set; }

	/// <summary>
	/// SG31
	/// </summary>
	public List<PRICAT_SG31>? SG31C { get; set; }

	/// <summary>
	/// SG32
	/// </summary>
	public List<PRICAT_SG32>? SG32C { get; set; }

	/// <summary>
	/// SG33
	/// </summary>
	public List<PRICAT_SG33>? SG33C { get; set; }

}

[EdiSegmentGroup("CUX", "DTM")]
public class PRICAT_SG17 : CUX, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("PRI", "CUX", "APR", "RNG", "DTM")]
public class PRICAT_SG18 : PRI, ISegmentGroup
{
	/// <summary>
	/// Currencies
	/// </summary>
	public CUX? CurrenciesC { get; set; }

	/// <summary>
	/// Additional price information
	/// </summary>
	public APR? AdditionalPriceInformationC { get; set; }

	/// <summary>
	/// Range details
	/// </summary>
	public RNG? RangeDetailsC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("TAX", "MOA", "DTM")]
public class PRICAT_SG19 : TAX, ISegmentGroup
{
	/// <summary>
	/// Monetary amount
	/// </summary>
	public MOA? MonetaryAmountC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("ALC", "ALI", "QTY", "PCD", "MOA", "RTE", "TAX")]
public class PRICAT_SG20 : ALC, ISegmentGroup
{
	/// <summary>
	/// Additional information
	/// </summary>
	public List<ALI>? AdditionalInformationC { get; set; }

	/// <summary>
	/// SG21
	/// </summary>
	public PRICAT_SG21? SG21C { get; set; }

	/// <summary>
	/// SG22
	/// </summary>
	public PRICAT_SG22? SG22C { get; set; }

	/// <summary>
	/// SG23
	/// </summary>
	public List<PRICAT_SG23>? SG23C { get; set; }

	/// <summary>
	/// SG24
	/// </summary>
	public PRICAT_SG24? SG24C { get; set; }

	/// <summary>
	/// SG25
	/// </summary>
	public List<PRICAT_SG25>? SG25C { get; set; }

}

[EdiSegmentGroup("QTY", "RNG")]
public class PRICAT_SG21 : QTY, ISegmentGroup
{
	/// <summary>
	/// Range details
	/// </summary>
	public RNG? RangeDetailsC { get; set; }
}

[EdiSegmentGroup("PCD", "RNG")]
public class PRICAT_SG22 : PCD, ISegmentGroup
{
	/// <summary>
	/// Range details
	/// </summary>
	public RNG? RangeDetailsC { get; set; }
}

[EdiSegmentGroup("MOA", "RNG")]
public class PRICAT_SG23 : MOA, ISegmentGroup
{
	/// <summary>
	/// Range details
	/// </summary>
	public RNG? RangeDetailsC { get; set; }
}

[EdiSegmentGroup("RTE", "RNG")]
public class PRICAT_SG24 : RTE, ISegmentGroup
{
	/// <summary>
	/// Range details
	/// </summary>
	public RNG? RangeDetailsC { get; set; }
}

[EdiSegmentGroup("TAX", "MOA", "DTM")]
public class PRICAT_SG25 : TAX, ISegmentGroup
{
	/// <summary>
	/// Monetary amount
	/// </summary>
	public MOA? MonetaryAmountC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("NAD", "LOC", "RFF", "CTA")]
public class PRICAT_SG26 : NAD, ISegmentGroup
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// SG27
	/// </summary>
	public List<PRICAT_SG27>? SG27C { get; set; }

	/// <summary>
	/// SG28
	/// </summary>
	public List<PRICAT_SG28>? SG28C { get; set; }

}

[EdiSegmentGroup("RFF", "DTM")]
public class PRICAT_SG27 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("CTA", "COM")]
public class PRICAT_SG28 : CTA, ISegmentGroup
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("PAT", "DTM", "PCD", "MOA")]
public class PRICAT_SG29 : PAT, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Percentage details
	/// </summary>
	public PCD? PercentageDetailsC { get; set; }

	/// <summary>
	/// Monetary amount
	/// </summary>
	public MOA? MonetaryAmountC { get; set; }
}

[EdiSegmentGroup("TDT", "LOC")]
public class PRICAT_SG30 : TDT, ISegmentGroup
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }
}

[EdiSegmentGroup("TOD", "LOC")]
public class PRICAT_SG31 : TOD, ISegmentGroup
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }
}

[EdiSegmentGroup("PAC", "MEA", "HAN")]
public class PRICAT_SG32 : PAC, ISegmentGroup
{
	/// <summary>
	/// Measurements
	/// </summary>
	public List<MEA>? MeasurementsC { get; set; }

	/// <summary>
	/// Handling instructions
	/// </summary>
	public List<HAN>? HandlingInstructionsC { get; set; }
}

[EdiSegmentGroup("LIN", "PIA", "IMD", "MEA", "QTY", "HAN", "ALI", "DTM", "NAD", "RFF", "LOC", "DOC", "FTX", "CCI", "TAX", "CUX", "PRI", "ALC", "PAC", "PAT", "TDT", "TOD")]
public class PRICAT_SG33 : LIN, ISegmentGroup
{
	/// <summary>
	/// Additional product id
	/// </summary>
	public List<PIA>? AdditionalProductIdC { get; set; }

	/// <summary>
	/// Item description
	/// </summary>
	public List<IMD>? ItemDescriptionC { get; set; }

	/// <summary>
	/// Measurements
	/// </summary>
	public List<MEA>? MeasurementsC { get; set; }

	/// <summary>
	/// Quantity
	/// </summary>
	public List<QTY>? QuantityC { get; set; }

	/// <summary>
	/// Handling instructions
	/// </summary>
	public List<HAN>? HandlingInstructionsC { get; set; }

	/// <summary>
	/// Additional information
	/// </summary>
	public List<ALI>? AdditionalInformationC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Name and address
	/// </summary>
	public List<NAD>? NameAndAddressC { get; set; }

	/// <summary>
	/// Reference
	/// </summary>
	public RFF? ReferenceC { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public LOC? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// Document/message details
	/// </summary>
	public DOC? DocumentMessageDetailsC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// SG34
	/// </summary>
	public List<PRICAT_SG34>? SG34C { get; set; }

	/// <summary>
	/// SG35
	/// </summary>
	public List<PRICAT_SG35>? SG35C { get; set; }

	/// <summary>
	/// SG36
	/// </summary>
	public List<PRICAT_SG36>? SG36C { get; set; }

	/// <summary>
	/// SG37
	/// </summary>
	public List<PRICAT_SG37>? SG37C { get; set; }

	/// <summary>
	/// SG38
	/// </summary>
	public List<PRICAT_SG38>? SG38C { get; set; }

	/// <summary>
	/// SG44
	/// </summary>
	public List<PRICAT_SG44>? SG44C { get; set; }

	/// <summary>
	/// SG45
	/// </summary>
	public List<PRICAT_SG45>? SG45C { get; set; }

	/// <summary>
	/// SG46
	/// </summary>
	public List<PRICAT_SG46>? SG46C { get; set; }

	/// <summary>
	/// SG47
	/// </summary>
	public List<PRICAT_SG47>? SG47C { get; set; }

}

[EdiSegmentGroup("CCI", "CAV", "MEA")]
public class PRICAT_SG34 : CCI, ISegmentGroup
{
	/// <summary>
	/// Characteristic value
	/// </summary>
	public List<CAV>? CharacteristicValueC { get; set; }

	/// <summary>
	/// Measurements
	/// </summary>
	public List<MEA>? MeasurementsC { get; set; }
}

[EdiSegmentGroup("TAX", "MOA", "DTM")]
public class PRICAT_SG35 : TAX, ISegmentGroup
{
	/// <summary>
	/// Monetary amount
	/// </summary>
	public MOA? MonetaryAmountC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("CUX", "DTM")]
public class PRICAT_SG36 : CUX, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("PRI", "CUX", "APR", "RNG", "DTM", "PCD")]
public class PRICAT_SG37 : PRI, ISegmentGroup
{
	/// <summary>
	/// Currencies
	/// </summary>
	public CUX? CurrenciesC { get; set; }

	/// <summary>
	/// Additional price information
	/// </summary>
	public APR? AdditionalPriceInformationC { get; set; }

	/// <summary>
	/// Range details
	/// </summary>
	public RNG? RangeDetailsC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Percentage details
	/// </summary>
	public List<PCD>? PercentageDetailsC { get; set; }
}

[EdiSegmentGroup("ALC", "ALI", "DTM", "QTY", "PCD", "MOA", "RTE", "TAX")]
public class PRICAT_SG38 : ALC, ISegmentGroup
{
	/// <summary>
	/// Additional information
	/// </summary>
	public List<ALI>? AdditionalInformationC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// SG39
	/// </summary>
	public List<PRICAT_SG39>? SG39C { get; set; }

	/// <summary>
	/// SG40
	/// </summary>
	public List<PRICAT_SG40>? SG40C { get; set; }

	/// <summary>
	/// SG41
	/// </summary>
	public List<PRICAT_SG41>? SG41C { get; set; }

	/// <summary>
	/// SG42
	/// </summary>
	public List<PRICAT_SG42>? SG42C { get; set; }

	/// <summary>
	/// SG43
	/// </summary>
	public List<PRICAT_SG43>? SG43C { get; set; }

}

[EdiSegmentGroup("QTY", "RNG")]
public class PRICAT_SG39 : QTY, ISegmentGroup
{
	/// <summary>
	/// Range details
	/// </summary>
	public RNG? RangeDetailsC { get; set; }
}

[EdiSegmentGroup("PCD", "RNG")]
public class PRICAT_SG40 : PCD, ISegmentGroup
{
	/// <summary>
	/// Range details
	/// </summary>
	public RNG? RangeDetailsC { get; set; }
}

[EdiSegmentGroup("MOA", "RNG")]
public class PRICAT_SG41 : MOA, ISegmentGroup
{
	/// <summary>
	/// Range details
	/// </summary>
	public RNG? RangeDetailsC { get; set; }
}

[EdiSegmentGroup("RTE", "RNG")]
public class PRICAT_SG42 : RTE, ISegmentGroup
{
	/// <summary>
	/// Range details
	/// </summary>
	public RNG? RangeDetailsC { get; set; }
}

[EdiSegmentGroup("TAX", "MOA", "DTM")]
public class PRICAT_SG43 : TAX, ISegmentGroup
{
	/// <summary>
	/// Monetary amount
	/// </summary>
	public MOA? MonetaryAmountC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("PAC", "MEA", "HAN")]
public class PRICAT_SG44 : PAC, ISegmentGroup
{
	/// <summary>
	/// Measurements
	/// </summary>
	public List<MEA>? MeasurementsC { get; set; }

	/// <summary>
	/// Handling instructions
	/// </summary>
	public List<HAN>? HandlingInstructionsC { get; set; }
}

[EdiSegmentGroup("PAT", "DTM", "PCD", "MOA")]
public class PRICAT_SG45 : PAT, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Percentage details
	/// </summary>
	public PCD? PercentageDetailsC { get; set; }

	/// <summary>
	/// Monetary amount
	/// </summary>
	public MOA? MonetaryAmountC { get; set; }
}

[EdiSegmentGroup("TDT", "LOC")]
public class PRICAT_SG46 : TDT, ISegmentGroup
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }
}

[EdiSegmentGroup("TOD", "LOC")]
public class PRICAT_SG47 : TOD, ISegmentGroup
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }
}