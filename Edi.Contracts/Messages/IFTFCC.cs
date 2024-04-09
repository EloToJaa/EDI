using System.Collections.Generic;
using Edi.Contracts.Segments;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// IFTFCC
/// </summary>
[EdiMessage]
public class IFTFCC
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
	public CTA? ContactInformation1C { get; set; }

	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContact1C { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeText1C { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriod1C { get; set; }

	/// <summary>
	/// Transport service requirements
	/// </summary>
	public List<TSR>? TransportServiceRequirements1C { get; set; }

	/// <summary>
	/// Document/message details
	/// </summary>
	public List<DOC>? DocumentMessageDetailsC { get; set; }

	/// <summary>
	/// SG1
	/// </summary>
	public List<IFTFCC_SG1>? SG1C { get; set; }

	/// <summary>
	/// SG2
	/// </summary>
	public List<IFTFCC_SG2>? SG2C { get; set; }

	/// <summary>
	/// SG3
	/// </summary>
	public List<IFTFCC_SG3>? SG3C { get; set; }

	/// <summary>
	/// SG4
	/// </summary>
	public List<IFTFCC_SG4>? SG4C { get; set; }

	/// <summary>
	/// SG5
	/// </summary>
	public List<IFTFCC_SG5>? SG5C { get; set; }

	/// <summary>
	/// SG6
	/// </summary>
	public List<IFTFCC_SG6>? SG6C { get; set; }

	/// <summary>
	/// SG11
	/// </summary>
	public List<IFTFCC_SG11>? SG11C { get; set; }

	/// <summary>
	/// SG14
	/// </summary>
	public List<IFTFCC_SG14>? SG14C { get; set; }

	/// <summary>
	/// SG15
	/// </summary>
	public List<IFTFCC_SG15>? SG15C { get; set; }

	/// <summary>
	/// SG16
	/// </summary>
	public List<IFTFCC_SG16>? SG16C { get; set; }

	/// <summary>
	/// SG17
	/// </summary>
	public List<IFTFCC_SG17>? SG17C { get; set; }

	/// <summary>
	/// SG19
	/// </summary>
	public List<IFTFCC_SG19>? SG19C { get; set; }

	/// <summary>
	/// SG24
	/// </summary>
	public List<IFTFCC_SG24>? SG24C { get; set; }

	/// <summary>
	/// SG28
	/// </summary>
	public List<IFTFCC_SG28>? SG28C { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("LOC", "DTM")]
public class IFTFCC_SG1 : LOC
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class IFTFCC_SG2 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("MOA", "PCD")]
public class IFTFCC_SG3 : MOA
{
	/// <summary>
	/// Percentage details
	/// </summary>
	public PCD? PercentageDetailsC { get; set; }
}

[EdiSegmentGroup("TAX", "PCD", "MOA")]
public class IFTFCC_SG4 : TAX
{
	/// <summary>
	/// Percentage details
	/// </summary>
	public PCD? PercentageDetailsC { get; set; }

	/// <summary>
	/// Monetary amount
	/// </summary>
	public List<MOA>? MonetaryAmountC { get; set; }
}

[EdiSegmentGroup("CUX", "DTM")]
public class IFTFCC_SG5 : CUX
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("TCC", "LOC", "DTM", "RFF", "FTX", "PCD", "QTY", "PRI", "MOA")]
public class IFTFCC_SG6 : TCC
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// Percentage details
	/// </summary>
	public List<PCD>? PercentageDetailsC { get; set; }

	/// <summary>
	/// Quantity
	/// </summary>
	public List<QTY>? QuantityC { get; set; }

	/// <summary>
	/// SG7
	/// </summary>
	public List<IFTFCC_SG7>? SG7C { get; set; }

	/// <summary>
	/// SG8
	/// </summary>
	public List<IFTFCC_SG8>? SG8C { get; set; }

}

[EdiSegmentGroup("PRI", "CUX")]
public class IFTFCC_SG7 : PRI
{
	/// <summary>
	/// Currencies
	/// </summary>
	public List<CUX>? CurrenciesC { get; set; }
}

[EdiSegmentGroup("MOA", "CUX", "PCD", "TAX")]
public class IFTFCC_SG8 : MOA
{
	/// <summary>
	/// SG9
	/// </summary>
	public IFTFCC_SG9? SG9C { get; set; }

	/// <summary>
	/// Percentage details
	/// </summary>
	public PCD? PercentageDetailsC { get; set; }

	/// <summary>
	/// SG10
	/// </summary>
	public IFTFCC_SG10? SG10C { get; set; }

}

[EdiSegmentGroup("CUX", "DTM")]
public class IFTFCC_SG9 : CUX
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("TAX", "PCD")]
public class IFTFCC_SG10 : TAX
{
	/// <summary>
	/// Percentage details
	/// </summary>
	public PCD? PercentageDetailsC { get; set; }
}

[EdiSegmentGroup("NAD", "FII", "LOC", "CTA", "RFF")]
public class IFTFCC_SG11 : NAD
{
	/// <summary>
	/// Financial institution information
	/// </summary>
	public List<FII>? FinancialInstitutionInformationC { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// SG12
	/// </summary>
	public List<IFTFCC_SG12>? SG12C { get; set; }

	/// <summary>
	/// SG13
	/// </summary>
	public List<IFTFCC_SG13>? SG13C { get; set; }

}

[EdiSegmentGroup("CTA", "COM")]
public class IFTFCC_SG12 : CTA
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class IFTFCC_SG13 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("TOD", "LOC")]
public class IFTFCC_SG14 : TOD
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }
}

[EdiSegmentGroup("CPI", "CUX", "LOC", "MOA")]
public class IFTFCC_SG15 : CPI
{
	/// <summary>
	/// Currencies
	/// </summary>
	public CUX? CurrenciesC { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// Monetary amount
	/// </summary>
	public List<MOA>? MonetaryAmountC { get; set; }
}

[EdiSegmentGroup("PAT", "DTM", "PCD", "MOA")]
public class IFTFCC_SG16 : PAT
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

[EdiSegmentGroup("TDT", "TCC", "DTM", "LOC", "RFF")]
public class IFTFCC_SG17 : TDT
{
	/// <summary>
	/// Transport charge/rate calculations
	/// </summary>
	public List<TCC>? TransportChargeRateCalculationsC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// SG18
	/// </summary>
	public List<IFTFCC_SG18>? SG18C { get; set; }

}

[EdiSegmentGroup("RFF", "DTM")]
public class IFTFCC_SG18 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("GID", "TCC", "HAN", "TMP", "TMD", "LOC", "PCI", "PIA", "FTX", "MEA", "DIM", "RFF", "DGS")]
public class IFTFCC_SG19 : GID
{
	/// <summary>
	/// Transport charge/rate calculations
	/// </summary>
	public List<TCC>? TransportChargeRateCalculationsC { get; set; }

	/// <summary>
	/// Handling instructions
	/// </summary>
	public HAN? HandlingInstructionsC { get; set; }

	/// <summary>
	/// Temperature
	/// </summary>
	public TMP? TemperatureC { get; set; }

	/// <summary>
	/// Transport movement details
	/// </summary>
	public TMD? TransportMovementDetailsC { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// Package identification
	/// </summary>
	public List<PCI>? PackageIdentificationC { get; set; }

	/// <summary>
	/// Additional product id
	/// </summary>
	public List<PIA>? AdditionalProductIdC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// SG20
	/// </summary>
	public List<IFTFCC_SG20>? SG20C { get; set; }

	/// <summary>
	/// SG21
	/// </summary>
	public List<IFTFCC_SG21>? SG21C { get; set; }

	/// <summary>
	/// SG22
	/// </summary>
	public List<IFTFCC_SG22>? SG22C { get; set; }

	/// <summary>
	/// SG23
	/// </summary>
	public List<IFTFCC_SG23>? SG23C { get; set; }

}

[EdiSegmentGroup("MEA", "EQN")]
public class IFTFCC_SG20 : MEA
{
	/// <summary>
	/// Number of units
	/// </summary>
	public EQN? NumberOfUnitsC { get; set; }
}

[EdiSegmentGroup("DIM", "EQN")]
public class IFTFCC_SG21 : DIM
{
	/// <summary>
	/// Number of units
	/// </summary>
	public EQN? NumberOfUnitsC { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class IFTFCC_SG22 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("DGS", "FTX")]
public class IFTFCC_SG23 : DGS
{
	/// <summary>
	/// Free text
	/// </summary>
	public FTX? FreeTextC { get; set; }
}

[EdiSegmentGroup("EQD", "TCC", "EQN", "TMD", "MEA", "DIM", "SEL", "TPL", "FTX", "RFF", "NAD", "EQA")]
public class IFTFCC_SG24 : EQD
{
	/// <summary>
	/// Transport charge/rate calculations
	/// </summary>
	public List<TCC>? TransportChargeRateCalculationsC { get; set; }

	/// <summary>
	/// Number of units
	/// </summary>
	public EQN? NumberOfUnitsC { get; set; }

	/// <summary>
	/// Transport movement details
	/// </summary>
	public TMD? TransportMovementDetailsC { get; set; }

	/// <summary>
	/// Measurements
	/// </summary>
	public List<MEA>? MeasurementsC { get; set; }

	/// <summary>
	/// Dimensions
	/// </summary>
	public List<DIM>? DimensionsC { get; set; }

	/// <summary>
	/// Seal number
	/// </summary>
	public List<SEL>? SealNumberC { get; set; }

	/// <summary>
	/// Transport placement
	/// </summary>
	public List<TPL>? TransportPlacementC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// SG25
	/// </summary>
	public List<IFTFCC_SG25>? SG25C { get; set; }

	/// <summary>
	/// SG26
	/// </summary>
	public List<IFTFCC_SG26>? SG26C { get; set; }

	/// <summary>
	/// SG27
	/// </summary>
	public List<IFTFCC_SG27>? SG27C { get; set; }

}

[EdiSegmentGroup("RFF", "DTM")]
public class IFTFCC_SG25 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("NAD", "DTM")]
public class IFTFCC_SG26 : NAD
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("EQA", "EQN")]
public class IFTFCC_SG27 : EQA
{
	/// <summary>
	/// Number of units
	/// </summary>
	public EQN? NumberOfUnitsC { get; set; }
}

[EdiSegmentGroup("CNI", "TCC", "DTM", "TSR", "FTX", "MOA", "CUX", "LOC", "RFF", "TOD", "CPI", "TDT", "NAD", "GID", "EQD")]
public class IFTFCC_SG28 : CNI
{
	/// <summary>
	/// Transport charge/rate calculations
	/// </summary>
	public List<TCC>? TransportChargeRateCalculationsC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Transport service requirements
	/// </summary>
	public List<TSR>? TransportServiceRequirementsC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// Monetary amount
	/// </summary>
	public List<MOA>? MonetaryAmountC { get; set; }

	/// <summary>
	/// SG29
	/// </summary>
	public List<IFTFCC_SG29>? SG29C { get; set; }

	/// <summary>
	/// SG30
	/// </summary>
	public List<IFTFCC_SG30>? SG30C { get; set; }

	/// <summary>
	/// SG31
	/// </summary>
	public List<IFTFCC_SG31>? SG31C { get; set; }

	/// <summary>
	/// SG32
	/// </summary>
	public List<IFTFCC_SG32>? SG32C { get; set; }

	/// <summary>
	/// SG33
	/// </summary>
	public List<IFTFCC_SG33>? SG33C { get; set; }

	/// <summary>
	/// SG34
	/// </summary>
	public List<IFTFCC_SG34>? SG34C { get; set; }

	/// <summary>
	/// SG35
	/// </summary>
	public List<IFTFCC_SG35>? SG35C { get; set; }

	/// <summary>
	/// SG37
	/// </summary>
	public List<IFTFCC_SG37>? SG37C { get; set; }

	/// <summary>
	/// SG42
	/// </summary>
	public List<IFTFCC_SG42>? SG42C { get; set; }

}

[EdiSegmentGroup("CUX", "DTM")]
public class IFTFCC_SG29 : CUX
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("LOC", "DTM")]
public class IFTFCC_SG30 : LOC
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class IFTFCC_SG31 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("TOD", "LOC")]
public class IFTFCC_SG32 : TOD
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }
}

[EdiSegmentGroup("CPI", "CUX", "LOC", "MOA")]
public class IFTFCC_SG33 : CPI
{
	/// <summary>
	/// Currencies
	/// </summary>
	public CUX? CurrenciesC { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// Monetary amount
	/// </summary>
	public List<MOA>? MonetaryAmountC { get; set; }
}

[EdiSegmentGroup("TDT", "DTM", "LOC", "RFF")]
public class IFTFCC_SG34 : TDT
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }
}

[EdiSegmentGroup("NAD", "CTA", "RFF")]
public class IFTFCC_SG35 : NAD
{
	/// <summary>
	/// SG36
	/// </summary>
	public List<IFTFCC_SG36>? SG36C { get; set; }

	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }
}

[EdiSegmentGroup("CTA", "COM")]
public class IFTFCC_SG36 : CTA
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("GID", "TCC", "HAN", "TMP", "TMD", "LOC", "PCI", "PIA", "FTX", "MEA", "DIM", "RFF", "DGS")]
public class IFTFCC_SG37 : GID
{
	/// <summary>
	/// Transport charge/rate calculations
	/// </summary>
	public List<TCC>? TransportChargeRateCalculationsC { get; set; }

	/// <summary>
	/// Handling instructions
	/// </summary>
	public HAN? HandlingInstructionsC { get; set; }

	/// <summary>
	/// Temperature
	/// </summary>
	public TMP? TemperatureC { get; set; }

	/// <summary>
	/// Transport movement details
	/// </summary>
	public TMD? TransportMovementDetailsC { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// Package identification
	/// </summary>
	public List<PCI>? PackageIdentificationC { get; set; }

	/// <summary>
	/// Additional product id
	/// </summary>
	public List<PIA>? AdditionalProductIdC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// SG38
	/// </summary>
	public List<IFTFCC_SG38>? SG38C { get; set; }

	/// <summary>
	/// SG39
	/// </summary>
	public List<IFTFCC_SG39>? SG39C { get; set; }

	/// <summary>
	/// SG40
	/// </summary>
	public List<IFTFCC_SG40>? SG40C { get; set; }

	/// <summary>
	/// SG41
	/// </summary>
	public List<IFTFCC_SG41>? SG41C { get; set; }

}

[EdiSegmentGroup("MEA", "EQN")]
public class IFTFCC_SG38 : MEA
{
	/// <summary>
	/// Number of units
	/// </summary>
	public EQN? NumberOfUnitsC { get; set; }
}

[EdiSegmentGroup("DIM", "EQN")]
public class IFTFCC_SG39 : DIM
{
	/// <summary>
	/// Number of units
	/// </summary>
	public EQN? NumberOfUnitsC { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class IFTFCC_SG40 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("DGS", "FTX")]
public class IFTFCC_SG41 : DGS
{
	/// <summary>
	/// Free text
	/// </summary>
	public FTX? FreeTextC { get; set; }
}

[EdiSegmentGroup("EQD", "TCC", "EQN", "TMD", "MEA", "DIM", "SEL", "TPL", "FTX", "RFF", "NAD", "EQA")]
public class IFTFCC_SG42 : EQD
{
	/// <summary>
	/// Transport charge/rate calculations
	/// </summary>
	public List<TCC>? TransportChargeRateCalculationsC { get; set; }

	/// <summary>
	/// Number of units
	/// </summary>
	public EQN? NumberOfUnitsC { get; set; }

	/// <summary>
	/// Transport movement details
	/// </summary>
	public TMD? TransportMovementDetailsC { get; set; }

	/// <summary>
	/// Measurements
	/// </summary>
	public List<MEA>? MeasurementsC { get; set; }

	/// <summary>
	/// Dimensions
	/// </summary>
	public List<DIM>? DimensionsC { get; set; }

	/// <summary>
	/// Seal number
	/// </summary>
	public List<SEL>? SealNumberC { get; set; }

	/// <summary>
	/// Transport placement
	/// </summary>
	public List<TPL>? TransportPlacementC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// SG43
	/// </summary>
	public List<IFTFCC_SG43>? SG43C { get; set; }

	/// <summary>
	/// SG44
	/// </summary>
	public List<IFTFCC_SG44>? SG44C { get; set; }

	/// <summary>
	/// SG45
	/// </summary>
	public List<IFTFCC_SG45>? SG45C { get; set; }

}

[EdiSegmentGroup("RFF", "DTM")]
public class IFTFCC_SG43 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("NAD", "DTM")]
public class IFTFCC_SG44 : NAD
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("EQA", "EQN")]
public class IFTFCC_SG45 : EQA
{
	/// <summary>
	/// Number of units
	/// </summary>
	public EQN? NumberOfUnitsC { get; set; }
}