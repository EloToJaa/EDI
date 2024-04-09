using System.Collections.Generic;
using Edi.Contracts.Segments;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// CUSCAR
/// </summary>
[EdiMessage]
public class CUSCAR
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
	public List<DTM>? DateTimePeriod1C { get; set; }

	/// <summary>
	/// SG1
	/// </summary>
	public List<CUSCAR_SG1>? SG1C { get; set; }

	/// <summary>
	/// SG2
	/// </summary>
	public List<CUSCAR_SG2>? SG2C { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeText1C { get; set; }

	/// <summary>
	/// SG4
	/// </summary>
	public List<CUSCAR_SG4>? SG4C { get; set; }

	/// <summary>
	/// General indicator
	/// </summary>
	public List<GIS>? GeneralIndicator1C { get; set; }

	/// <summary>
	/// SG5
	/// </summary>
	public List<CUSCAR_SG5>? SG5C { get; set; }

	/// <summary>
	/// Control total
	/// </summary>
	public List<CNT>? ControlTotal1C { get; set; }

	/// <summary>
	/// SG7
	/// </summary>
	public List<CUSCAR_SG7>? SG7C { get; set; }

	/// <summary>
	/// SG17
	/// </summary>
	public CUSCAR_SG17? SG17C { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class CUSCAR_SG1 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("NAD", "CTA")]
public class CUSCAR_SG2 : NAD
{
	/// <summary>
	/// SG3
	/// </summary>
	public List<CUSCAR_SG3>? SG3C { get; set; }

}

[EdiSegmentGroup("CTA", "COM")]
public class CUSCAR_SG3 : CTA
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("TDT", "LOC", "DTM")]
public class CUSCAR_SG4 : TDT
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("EQD", "TSR", "MEA", "DIM", "SEL", "NAD", "GIS", "TMP")]
public class CUSCAR_SG5 : EQD
{
	/// <summary>
	/// Transport service requirements
	/// </summary>
	public List<TSR>? TransportServiceRequirementsC { get; set; }

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
	/// Name and address
	/// </summary>
	public List<NAD>? NameAndAddressC { get; set; }

	/// <summary>
	/// General indicator
	/// </summary>
	public List<GIS>? GeneralIndicatorC { get; set; }

	/// <summary>
	/// SG6
	/// </summary>
	public List<CUSCAR_SG6>? SG6C { get; set; }

}

[EdiSegmentGroup("TMP", "RNG")]
public class CUSCAR_SG6 : TMP
{
	/// <summary>
	/// Range details
	/// </summary>
	public RNG? RangeDetailsC { get; set; }
}

[EdiSegmentGroup("CNI", "CNT", "RFF")]
public class CUSCAR_SG7 : CNI
{
	/// <summary>
	/// Control total
	/// </summary>
	public List<CNT>? ControlTotalC { get; set; }

	/// <summary>
	/// SG8
	/// </summary>
	public List<CUSCAR_SG8>? SG8C { get; set; }

}

[EdiSegmentGroup("RFF", "CNT", "MOA", "LOC", "GIS", "CUX", "CPI", "TDT", "NAD", "QTY", "GID")]
public class CUSCAR_SG8 : RFF
{
	/// <summary>
	/// Control total
	/// </summary>
	public List<CNT>? ControlTotalC { get; set; }

	/// <summary>
	/// Monetary amount
	/// </summary>
	public List<MOA>? MonetaryAmountC { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// General indicator
	/// </summary>
	public List<GIS>? GeneralIndicatorC { get; set; }

	/// <summary>
	/// Currencies
	/// </summary>
	public List<CUX>? CurrenciesC { get; set; }

	/// <summary>
	/// Charge payment instructions
	/// </summary>
	public List<CPI>? ChargePaymentInstructionsC { get; set; }

	/// <summary>
	/// SG9
	/// </summary>
	public List<CUSCAR_SG9>? SG9C { get; set; }

	/// <summary>
	/// SG11
	/// </summary>
	public List<CUSCAR_SG11>? SG11C { get; set; }

	/// <summary>
	/// SG13
	/// </summary>
	public List<CUSCAR_SG13>? SG13C { get; set; }

	/// <summary>
	/// SG14
	/// </summary>
	public List<CUSCAR_SG14>? SG14M { get; set; }

}

[EdiSegmentGroup("TDT", "LOC", "DTM", "MEA", "RFF")]
public class CUSCAR_SG9 : TDT
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
	/// Measurements
	/// </summary>
	public List<MEA>? MeasurementsC { get; set; }

	/// <summary>
	/// SG10
	/// </summary>
	public List<CUSCAR_SG10>? SG10C { get; set; }

}

[EdiSegmentGroup("RFF", "TSR")]
public class CUSCAR_SG10 : RFF
{
	/// <summary>
	/// Transport service requirements
	/// </summary>
	public List<TSR>? TransportServiceRequirementsC { get; set; }
}

[EdiSegmentGroup("NAD", "DTM", "RFF", "CTA")]
public class CUSCAR_SG11 : NAD
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }

	/// <summary>
	/// SG12
	/// </summary>
	public List<CUSCAR_SG12>? SG12C { get; set; }

}

[EdiSegmentGroup("CTA", "COM")]
public class CUSCAR_SG12 : CTA
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("QTY", "FTX")]
public class CUSCAR_SG13 : QTY
{
	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }
}

[EdiSegmentGroup("GID", "PAC", "HAN", "FTX", "MEA", "MOA", "SGP", "DGS", "PCI", "CST", "TMD", "GIS", "QTY")]
public class CUSCAR_SG14 : GID
{
	/// <summary>
	/// Package
	/// </summary>
	public List<PAC>? PackageC { get; set; }

	/// <summary>
	/// Handling instructions
	/// </summary>
	public List<HAN>? HandlingInstructionsC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// Measurements
	/// </summary>
	public List<MEA>? MeasurementsC { get; set; }

	/// <summary>
	/// Monetary amount
	/// </summary>
	public List<MOA>? MonetaryAmountC { get; set; }

	/// <summary>
	/// Split goods placement
	/// </summary>
	public List<SGP>? SplitGoodsPlacementC { get; set; }

	/// <summary>
	/// Dangerous goods
	/// </summary>
	public List<DGS>? DangerousGoodsC { get; set; }

	/// <summary>
	/// Package identification
	/// </summary>
	public List<PCI>? PackageIdentificationC { get; set; }

	/// <summary>
	/// Customs status of goods
	/// </summary>
	public CST? CustomsStatusOfGoodsC { get; set; }

	/// <summary>
	/// Transport movement details
	/// </summary>
	public List<TMD>? TransportMovementDetailsC { get; set; }

	/// <summary>
	/// SG15
	/// </summary>
	public List<CUSCAR_SG15>? SG15C { get; set; }

	/// <summary>
	/// SG16
	/// </summary>
	public List<CUSCAR_SG16>? SG16C { get; set; }

}

[EdiSegmentGroup("GIS", "DTM", "DOC")]
public class CUSCAR_SG15 : GIS
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Document/message details
	/// </summary>
	public List<DOC>? DocumentMessageDetailsC { get; set; }
}

[EdiSegmentGroup("QTY", "FTX")]
public class CUSCAR_SG16 : QTY
{
	/// <summary>
	/// Free text
	/// </summary>
	public FTX? FreeTextC { get; set; }
}

[EdiSegmentGroup("AUT", "DTM", "RFF")]
public class CUSCAR_SG17 : AUT
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }
}