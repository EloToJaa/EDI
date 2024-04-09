using System.Collections.Generic;
using Edi.Contracts.Segments;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// CONEST
/// </summary>
[EdiMessage]
public class CONEST
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
	/// Reference
	/// </summary>
	public RFF? Reference1M { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriod1M { get; set; }

	/// <summary>
	/// Authentication result
	/// </summary>
	public List<AUT>? AuthenticationResultC { get; set; }

	/// <summary>
	/// Agreement identification
	/// </summary>
	public List<AGR>? AgreementIdentificationC { get; set; }

	/// <summary>
	/// SG1
	/// </summary>
	public List<CONEST_SG1>? SG1C { get; set; }

	/// <summary>
	/// SG4
	/// </summary>
	public List<CONEST_SG4>? SG4C { get; set; }

	/// <summary>
	/// Section control
	/// </summary>
	public UNS? SectionControlM { get; set; }

	/// <summary>
	/// SG22
	/// </summary>
	public List<CONEST_SG22>? SG22M { get; set; }

	/// <summary>
	/// Control total
	/// </summary>
	public List<CNT>? ControlTotalC { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("IND", "RCS", "GIS")]
public class CONEST_SG1 : IND
{
	/// <summary>
	/// Requirements and conditions
	/// </summary>
	public RCS? RequirementsAndConditionsM { get; set; }

	/// <summary>
	/// SG2
	/// </summary>
	public CONEST_SG2? SG2M { get; set; }

}

[EdiSegmentGroup("GIS", "BII")]
public class CONEST_SG2 : GIS
{
	/// <summary>
	/// SG3
	/// </summary>
	public CONEST_SG3? SG3M { get; set; }

}

[EdiSegmentGroup("BII", "IMD")]
public class CONEST_SG3 : BII
{
	/// <summary>
	/// Item description
	/// </summary>
	public List<IMD>? ItemDescriptionM { get; set; }
}

[EdiSegmentGroup("BII", "RCS", "GIS", "NAD", "LOC", "APR", "ALI", "QTY", "DTM", "RTE", "RFF", "CUX", "ALC", "RCS", "ARD", "NAD")]
public class CONEST_SG4 : BII
{
	/// <summary>
	/// Requirements and conditions
	/// </summary>
	public RCS? RequirementsAndConditionsM { get; set; }

	/// <summary>
	/// General indicator
	/// </summary>
	public List<GIS>? GeneralIndicatorM { get; set; }

	/// <summary>
	/// Name and address
	/// </summary>
	public NAD? NameAndAddressC { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public LOC? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// Additional price information
	/// </summary>
	public APR? AdditionalPriceInformationC { get; set; }

	/// <summary>
	/// Additional information
	/// </summary>
	public List<ALI>? AdditionalInformationC { get; set; }

	/// <summary>
	/// Quantity
	/// </summary>
	public List<QTY>? QuantityC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Rate details
	/// </summary>
	public List<RTE>? RateDetailsC { get; set; }

	/// <summary>
	/// SG5
	/// </summary>
	public List<CONEST_SG5>? SG5C { get; set; }

	/// <summary>
	/// SG6
	/// </summary>
	public List<CONEST_SG6>? SG6C { get; set; }

	/// <summary>
	/// SG7
	/// </summary>
	public List<CONEST_SG7>? SG7C { get; set; }

	/// <summary>
	/// SG9
	/// </summary>
	public List<CONEST_SG9>? SG9C { get; set; }

	/// <summary>
	/// SG10
	/// </summary>
	public List<CONEST_SG10>? SG10M { get; set; }

	/// <summary>
	/// SG18
	/// </summary>
	public List<CONEST_SG18>? SG18C { get; set; }

}

[EdiSegmentGroup("RFF", "DTM", "GIS", "FTX")]
public class CONEST_SG5 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// General indicator
	/// </summary>
	public List<GIS>? GeneralIndicatorC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }
}

[EdiSegmentGroup("CUX", "DTM", "FTX")]
public class CONEST_SG6 : CUX
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public FTX? FreeTextC { get; set; }
}

[EdiSegmentGroup("ALC", "RFF", "DTM", "RNG", "FTX", "PCD")]
public class CONEST_SG7 : ALC
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
	/// Range details
	/// </summary>
	public RNG? RangeDetailsC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// SG8
	/// </summary>
	public List<CONEST_SG8>? SG8C { get; set; }

}

[EdiSegmentGroup("PCD", "RFF")]
public class CONEST_SG8 : PCD
{
	/// <summary>
	/// Reference
	/// </summary>
	public RFF? ReferenceC { get; set; }
}

[EdiSegmentGroup("RCS", "BII", "FTX")]
public class CONEST_SG9 : RCS
{
	/// <summary>
	/// Structure identification
	/// </summary>
	public BII? StructureIdentificationM { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }
}

[EdiSegmentGroup("ARD", "MOA", "FTX", "TAX", "ALC")]
public class CONEST_SG10 : ARD
{
	/// <summary>
	/// Monetary amount
	/// </summary>
	public List<MOA>? MonetaryAmountM { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// SG11
	/// </summary>
	public List<CONEST_SG11>? SG11C { get; set; }

	/// <summary>
	/// SG12
	/// </summary>
	public List<CONEST_SG12>? SG12C { get; set; }

}

[EdiSegmentGroup("TAX", "MOA", "LOC")]
public class CONEST_SG11 : TAX
{
	/// <summary>
	/// Monetary amount
	/// </summary>
	public MOA? MonetaryAmountC { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }
}

[EdiSegmentGroup("ALC", "ALI", "QTY", "PCD", "MOA", "RTE", "TAX")]
public class CONEST_SG12 : ALC
{
	/// <summary>
	/// Additional information
	/// </summary>
	public List<ALI>? AdditionalInformationC { get; set; }

	/// <summary>
	/// SG13
	/// </summary>
	public CONEST_SG13? SG13C { get; set; }

	/// <summary>
	/// SG14
	/// </summary>
	public CONEST_SG14? SG14C { get; set; }

	/// <summary>
	/// SG15
	/// </summary>
	public CONEST_SG15? SG15C { get; set; }

	/// <summary>
	/// SG16
	/// </summary>
	public CONEST_SG16? SG16C { get; set; }

	/// <summary>
	/// SG17
	/// </summary>
	public List<CONEST_SG17>? SG17C { get; set; }

}

[EdiSegmentGroup("QTY", "RNG")]
public class CONEST_SG13 : QTY
{
	/// <summary>
	/// Range details
	/// </summary>
	public RNG? RangeDetailsC { get; set; }
}

[EdiSegmentGroup("PCD", "RNG")]
public class CONEST_SG14 : PCD
{
	/// <summary>
	/// Range details
	/// </summary>
	public RNG? RangeDetailsC { get; set; }
}

[EdiSegmentGroup("MOA", "RNG")]
public class CONEST_SG15 : MOA
{
	/// <summary>
	/// Range details
	/// </summary>
	public RNG? RangeDetailsC { get; set; }
}

[EdiSegmentGroup("RTE", "RNG")]
public class CONEST_SG16 : RTE
{
	/// <summary>
	/// Range details
	/// </summary>
	public RNG? RangeDetailsC { get; set; }
}

[EdiSegmentGroup("TAX", "MOA")]
public class CONEST_SG17 : TAX
{
	/// <summary>
	/// Monetary amount
	/// </summary>
	public MOA? MonetaryAmountC { get; set; }
}

[EdiSegmentGroup("NAD", "LOC", "FII", "FTX", "RFF", "DOC", "CTA")]
public class CONEST_SG18 : NAD
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// Financial institution information
	/// </summary>
	public List<FII>? FinancialInstitutionInformationC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// SG19
	/// </summary>
	public List<CONEST_SG19>? SG19C { get; set; }

	/// <summary>
	/// SG20
	/// </summary>
	public List<CONEST_SG20>? SG20C { get; set; }

	/// <summary>
	/// SG21
	/// </summary>
	public List<CONEST_SG21>? SG21C { get; set; }

}

[EdiSegmentGroup("RFF", "DTM")]
public class CONEST_SG19 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("DOC", "DTM")]
public class CONEST_SG20 : DOC
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("CTA", "COM")]
public class CONEST_SG21 : CTA
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("BII", "RCS", "GIS", "RFF", "DIM", "LIN", "QTY", "TAX", "RCS", "ALC", "IMD")]
public class CONEST_SG22 : BII
{
	/// <summary>
	/// Requirements and conditions
	/// </summary>
	public RCS? RequirementsAndConditionsM { get; set; }

	/// <summary>
	/// General indicator
	/// </summary>
	public List<GIS>? GeneralIndicatorM { get; set; }

	/// <summary>
	/// SG23
	/// </summary>
	public List<CONEST_SG23>? SG23C { get; set; }

	/// <summary>
	/// SG24
	/// </summary>
	public List<CONEST_SG24>? SG24C { get; set; }

	/// <summary>
	/// SG25
	/// </summary>
	public List<CONEST_SG25>? SG25C { get; set; }

	/// <summary>
	/// SG27
	/// </summary>
	public List<CONEST_SG27>? SG27M { get; set; }

	/// <summary>
	/// SG30
	/// </summary>
	public List<CONEST_SG30>? SG30C { get; set; }

	/// <summary>
	/// SG31
	/// </summary>
	public List<CONEST_SG31>? SG31C { get; set; }

	/// <summary>
	/// SG32
	/// </summary>
	public List<CONEST_SG32>? SG32C { get; set; }

	/// <summary>
	/// SG34
	/// </summary>
	public List<CONEST_SG34>? SG34C { get; set; }

}

[EdiSegmentGroup("RFF", "DTM")]
public class CONEST_SG23 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("DIM", "APR", "FTX")]
public class CONEST_SG24 : DIM
{
	/// <summary>
	/// Additional price information
	/// </summary>
	public APR? AdditionalPriceInformationC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public FTX? FreeTextC { get; set; }
}

[EdiSegmentGroup("LIN", "IMD")]
public class CONEST_SG25 : LIN
{
	/// <summary>
	/// SG26
	/// </summary>
	public List<CONEST_SG26>? SG26C { get; set; }

}

[EdiSegmentGroup("IMD", "RFF", "GIS")]
public class CONEST_SG26 : IMD
{
	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }

	/// <summary>
	/// General indicator
	/// </summary>
	public List<GIS>? GeneralIndicatorC { get; set; }
}

[EdiSegmentGroup("QTY", "GIS", "APR", "PRI")]
public class CONEST_SG27 : QTY
{
	/// <summary>
	/// General indicator
	/// </summary>
	public List<GIS>? GeneralIndicatorC { get; set; }

	/// <summary>
	/// Additional price information
	/// </summary>
	public APR? AdditionalPriceInformationC { get; set; }

	/// <summary>
	/// SG28
	/// </summary>
	public List<CONEST_SG28>? SG28C { get; set; }

}

[EdiSegmentGroup("PRI", "GIS", "ARD")]
public class CONEST_SG28 : PRI
{
	/// <summary>
	/// General indicator
	/// </summary>
	public List<GIS>? GeneralIndicatorM { get; set; }

	/// <summary>
	/// SG29
	/// </summary>
	public List<CONEST_SG29>? SG29C { get; set; }

}

[EdiSegmentGroup("ARD", "MOA")]
public class CONEST_SG29 : ARD
{
	/// <summary>
	/// Monetary amount
	/// </summary>
	public MOA? MonetaryAmountC { get; set; }
}

[EdiSegmentGroup("TAX", "MOA", "LOC")]
public class CONEST_SG30 : TAX
{
	/// <summary>
	/// Monetary amount
	/// </summary>
	public MOA? MonetaryAmountC { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }
}

[EdiSegmentGroup("RCS", "BII", "GIS")]
public class CONEST_SG31 : RCS
{
	/// <summary>
	/// Structure identification
	/// </summary>
	public BII? StructureIdentificationM { get; set; }

	/// <summary>
	/// General indicator
	/// </summary>
	public GIS? GeneralIndicatorM { get; set; }
}

[EdiSegmentGroup("ALC", "RFF", "DTM", "RNG", "FTX", "PCD")]
public class CONEST_SG32 : ALC
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
	/// Range details
	/// </summary>
	public RNG? RangeDetailsC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// SG33
	/// </summary>
	public List<CONEST_SG33>? SG33C { get; set; }

}

[EdiSegmentGroup("PCD", "RFF")]
public class CONEST_SG33 : PCD
{
	/// <summary>
	/// Reference
	/// </summary>
	public RFF? ReferenceC { get; set; }
}

[EdiSegmentGroup("IMD", "QTY", "MOA", "PRI")]
public class CONEST_SG34 : IMD
{
	/// <summary>
	/// Quantity
	/// </summary>
	public QTY? QuantityC { get; set; }

	/// <summary>
	/// Monetary amount
	/// </summary>
	public MOA? MonetaryAmountC { get; set; }

	/// <summary>
	/// Price details
	/// </summary>
	public PRI? PriceDetailsC { get; set; }
}