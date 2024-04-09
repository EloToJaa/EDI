using System.Collections.Generic;
using Edi.Contracts.Segments;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// DESADV
/// </summary>
[EdiMessage]
public class DESADV
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
	/// Additional information
	/// </summary>
	public List<ALI>? AdditionalInformation1C { get; set; }

	/// <summary>
	/// Measurements
	/// </summary>
	public List<MEA>? Measurements1C { get; set; }

	/// <summary>
	/// Monetary amount
	/// </summary>
	public List<MOA>? MonetaryAmount1C { get; set; }

	/// <summary>
	/// SG1
	/// </summary>
	public List<DESADV_SG1>? SG1C { get; set; }

	/// <summary>
	/// SG2
	/// </summary>
	public List<DESADV_SG2>? SG2C { get; set; }

	/// <summary>
	/// SG5
	/// </summary>
	public List<DESADV_SG5>? SG5C { get; set; }

	/// <summary>
	/// SG6
	/// </summary>
	public List<DESADV_SG6>? SG6C { get; set; }

	/// <summary>
	/// SG8
	/// </summary>
	public List<DESADV_SG8>? SG8C { get; set; }

	/// <summary>
	/// SG10
	/// </summary>
	public List<DESADV_SG10>? SG10C { get; set; }

	/// <summary>
	/// Control total
	/// </summary>
	public List<CNT>? ControlTotalC { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class DESADV_SG1 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("NAD", "LOC", "RFF", "CTA")]
public class DESADV_SG2 : NAD
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// SG3
	/// </summary>
	public List<DESADV_SG3>? SG3C { get; set; }

	/// <summary>
	/// SG4
	/// </summary>
	public List<DESADV_SG4>? SG4C { get; set; }

}

[EdiSegmentGroup("RFF", "DTM")]
public class DESADV_SG3 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("CTA", "COM")]
public class DESADV_SG4 : CTA
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("TOD", "LOC", "FTX")]
public class DESADV_SG5 : TOD
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }
}

[EdiSegmentGroup("TDT", "PCD", "LOC")]
public class DESADV_SG6 : TDT
{
	/// <summary>
	/// Percentage details
	/// </summary>
	public List<PCD>? PercentageDetailsC { get; set; }

	/// <summary>
	/// SG7
	/// </summary>
	public List<DESADV_SG7>? SG7C { get; set; }

}

[EdiSegmentGroup("LOC", "DTM")]
public class DESADV_SG7 : LOC
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("EQD", "MEA", "SEL", "EQA", "HAN")]
public class DESADV_SG8 : EQD
{
	/// <summary>
	/// Measurements
	/// </summary>
	public List<MEA>? MeasurementsC { get; set; }

	/// <summary>
	/// Seal number
	/// </summary>
	public List<SEL>? SealNumberC { get; set; }

	/// <summary>
	/// Attached equipment
	/// </summary>
	public List<EQA>? AttachedEquipmentC { get; set; }

	/// <summary>
	/// SG9
	/// </summary>
	public List<DESADV_SG9>? SG9C { get; set; }

}

[EdiSegmentGroup("HAN", "FTX")]
public class DESADV_SG9 : HAN
{
	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }
}

[EdiSegmentGroup("CPS", "FTX", "PAC", "LIN")]
public class DESADV_SG10 : CPS
{
	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// SG11
	/// </summary>
	public List<DESADV_SG11>? SG11C { get; set; }

	/// <summary>
	/// SG15
	/// </summary>
	public List<DESADV_SG15>? SG15C { get; set; }

}

[EdiSegmentGroup("PAC", "MEA", "QTY", "HAN", "PCI")]
public class DESADV_SG11 : PAC
{
	/// <summary>
	/// Measurements
	/// </summary>
	public List<MEA>? MeasurementsC { get; set; }

	/// <summary>
	/// Quantity
	/// </summary>
	public List<QTY>? QuantityC { get; set; }

	/// <summary>
	/// SG12
	/// </summary>
	public List<DESADV_SG12>? SG12C { get; set; }

	/// <summary>
	/// SG13
	/// </summary>
	public List<DESADV_SG13>? SG13C { get; set; }

}

[EdiSegmentGroup("HAN", "FTX")]
public class DESADV_SG12 : HAN
{
	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }
}

[EdiSegmentGroup("PCI", "RFF", "DTM", "GIR", "GIN")]
public class DESADV_SG13 : PCI
{
	/// <summary>
	/// Reference
	/// </summary>
	public RFF? ReferenceC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Related identification numbers
	/// </summary>
	public List<GIR>? RelatedIdentificationNumbersC { get; set; }

	/// <summary>
	/// SG14
	/// </summary>
	public List<DESADV_SG14>? SG14C { get; set; }

}

[EdiSegmentGroup("GIN", "DLM")]
public class DESADV_SG14 : GIN
{
	/// <summary>
	/// Delivery limitations
	/// </summary>
	public List<DLM>? DeliveryLimitationsC { get; set; }
}

[EdiSegmentGroup("LIN", "PIA", "IMD", "MEA", "QTY", "ALI", "GIN", "GIR", "DLM", "DTM", "NAD", "TDT", "HAN", "FTX", "MOA", "RFF", "DGS", "LOC", "SGP", "PCI", "QVR")]
public class DESADV_SG15 : LIN
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
	/// Additional information
	/// </summary>
	public List<ALI>? AdditionalInformationC { get; set; }

	/// <summary>
	/// Goods identity number
	/// </summary>
	public List<GIN>? GoodsIdentityNumberC { get; set; }

	/// <summary>
	/// Related identification numbers
	/// </summary>
	public List<GIR>? RelatedIdentificationNumbersC { get; set; }

	/// <summary>
	/// Delivery limitations
	/// </summary>
	public List<DLM>? DeliveryLimitationsC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Name and address
	/// </summary>
	public List<NAD>? NameAndAddressC { get; set; }

	/// <summary>
	/// Details of transport
	/// </summary>
	public TDT? DetailsOfTransportC { get; set; }

	/// <summary>
	/// Handling instructions
	/// </summary>
	public List<HAN>? HandlingInstructionsC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// Monetary amount
	/// </summary>
	public List<MOA>? MonetaryAmountC { get; set; }

	/// <summary>
	/// SG16
	/// </summary>
	public List<DESADV_SG16>? SG16C { get; set; }

	/// <summary>
	/// SG17
	/// </summary>
	public List<DESADV_SG17>? SG17C { get; set; }

	/// <summary>
	/// SG18
	/// </summary>
	public List<DESADV_SG18>? SG18C { get; set; }

	/// <summary>
	/// SG19
	/// </summary>
	public List<DESADV_SG19>? SG19C { get; set; }

	/// <summary>
	/// SG20
	/// </summary>
	public List<DESADV_SG20>? SG20C { get; set; }

	/// <summary>
	/// SG23
	/// </summary>
	public List<DESADV_SG23>? SG23C { get; set; }

}

[EdiSegmentGroup("RFF", "NAD", "CTA", "DTM")]
public class DESADV_SG16 : RFF
{
	/// <summary>
	/// Name and address
	/// </summary>
	public NAD? NameAndAddressC { get; set; }

	/// <summary>
	/// Contact information
	/// </summary>
	public CTA? ContactInformationC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("DGS", "QTY", "FTX")]
public class DESADV_SG17 : DGS
{
	/// <summary>
	/// Quantity
	/// </summary>
	public QTY? QuantityC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }
}

[EdiSegmentGroup("LOC", "NAD", "DTM", "QTY")]
public class DESADV_SG18 : LOC
{
	/// <summary>
	/// Name and address
	/// </summary>
	public NAD? NameAndAddressC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }

	/// <summary>
	/// Quantity
	/// </summary>
	public List<QTY>? QuantityC { get; set; }
}

[EdiSegmentGroup("SGP", "QTY")]
public class DESADV_SG19 : SGP
{
	/// <summary>
	/// Quantity
	/// </summary>
	public List<QTY>? QuantityC { get; set; }
}

[EdiSegmentGroup("PCI", "DTM", "MEA", "QTY", "GIN", "HAN")]
public class DESADV_SG20 : PCI
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Measurements
	/// </summary>
	public List<MEA>? MeasurementsC { get; set; }

	/// <summary>
	/// Quantity
	/// </summary>
	public QTY? QuantityC { get; set; }

	/// <summary>
	/// SG21
	/// </summary>
	public List<DESADV_SG21>? SG21C { get; set; }

	/// <summary>
	/// SG22
	/// </summary>
	public List<DESADV_SG22>? SG22C { get; set; }

}

[EdiSegmentGroup("GIN", "DLM")]
public class DESADV_SG21 : GIN
{
	/// <summary>
	/// Delivery limitations
	/// </summary>
	public List<DLM>? DeliveryLimitationsC { get; set; }
}

[EdiSegmentGroup("HAN", "FTX", "GIN")]
public class DESADV_SG22 : HAN
{
	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// Goods identity number
	/// </summary>
	public List<GIN>? GoodsIdentityNumberC { get; set; }
}

[EdiSegmentGroup("QVR", "DTM")]
public class DESADV_SG23 : QVR
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}