using System.Collections.Generic;
using Edi.Contracts.Segments;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// CONPVA
/// </summary>
[EdiMessage]
public class CONPVA
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
	public List<DTM>? DateTimePeriod1M { get; set; }

	/// <summary>
	/// Authentication result
	/// </summary>
	public List<AUT>? AuthenticationResultC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeText1C { get; set; }

	/// <summary>
	/// SG1
	/// </summary>
	public List<CONPVA_SG1>? SG1C { get; set; }

	/// <summary>
	/// SG2
	/// </summary>
	public List<CONPVA_SG2>? SG2M { get; set; }

	/// <summary>
	/// SG6
	/// </summary>
	public List<CONPVA_SG6>? SG6C { get; set; }

	/// <summary>
	/// SG7
	/// </summary>
	public List<CONPVA_SG7>? SG7C { get; set; }

	/// <summary>
	/// SG8
	/// </summary>
	public List<CONPVA_SG8>? SG8C { get; set; }

	/// <summary>
	/// Section control
	/// </summary>
	public UNS? SectionControl1M { get; set; }

	/// <summary>
	/// SG22
	/// </summary>
	public List<CONPVA_SG22>? SG22M { get; set; }

	/// <summary>
	/// Section control
	/// </summary>
	public UNS? SectionControl2M { get; set; }

	/// <summary>
	/// SG33
	/// </summary>
	public List<CONPVA_SG33>? SG33C { get; set; }

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
public class CONPVA_SG1 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("NAD", "LOC", "FII", "RFF", "DOC", "CTA")]
public class CONPVA_SG2 : NAD
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
	/// SG3
	/// </summary>
	public List<CONPVA_SG3>? SG3C { get; set; }

	/// <summary>
	/// SG4
	/// </summary>
	public List<CONPVA_SG4>? SG4C { get; set; }

	/// <summary>
	/// SG5
	/// </summary>
	public List<CONPVA_SG5>? SG5C { get; set; }

}

[EdiSegmentGroup("RFF", "DTM")]
public class CONPVA_SG3 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("DOC", "DTM")]
public class CONPVA_SG4 : DOC
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("CTA", "COM")]
public class CONPVA_SG5 : CTA
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("CUX", "DTM")]
public class CONPVA_SG6 : CUX
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("IND", "RFF", "DTM")]
public class CONPVA_SG7 : IND
{
	/// <summary>
	/// Reference
	/// </summary>
	public RFF? ReferenceM { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("BII", "RCS", "PAI", "PAT", "APR", "ARD", "NAD")]
public class CONPVA_SG8 : BII
{
	/// <summary>
	/// Requirements and conditions
	/// </summary>
	public RCS? RequirementsAndConditionsC { get; set; }

	/// <summary>
	/// Payment instructions
	/// </summary>
	public PAI? PaymentInstructionsC { get; set; }

	/// <summary>
	/// Payment terms basis
	/// </summary>
	public PAT? PaymentTermsBasisC { get; set; }

	/// <summary>
	/// SG9
	/// </summary>
	public List<CONPVA_SG9>? SG9C { get; set; }

	/// <summary>
	/// SG10
	/// </summary>
	public List<CONPVA_SG10>? SG10M { get; set; }

	/// <summary>
	/// SG18
	/// </summary>
	public List<CONPVA_SG18>? SG18C { get; set; }

}

[EdiSegmentGroup("APR", "DTM")]
public class CONPVA_SG9 : APR
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("ARD", "MOA", "FTX", "TAX", "ALC")]
public class CONPVA_SG10 : ARD
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
	public List<CONPVA_SG11>? SG11C { get; set; }

	/// <summary>
	/// SG12
	/// </summary>
	public List<CONPVA_SG12>? SG12C { get; set; }

}

[EdiSegmentGroup("TAX", "MOA", "LOC")]
public class CONPVA_SG11 : TAX
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
public class CONPVA_SG12 : ALC
{
	/// <summary>
	/// Additional information
	/// </summary>
	public List<ALI>? AdditionalInformationC { get; set; }

	/// <summary>
	/// SG13
	/// </summary>
	public CONPVA_SG13? SG13C { get; set; }

	/// <summary>
	/// SG14
	/// </summary>
	public CONPVA_SG14? SG14C { get; set; }

	/// <summary>
	/// SG15
	/// </summary>
	public CONPVA_SG15? SG15C { get; set; }

	/// <summary>
	/// SG16
	/// </summary>
	public CONPVA_SG16? SG16C { get; set; }

	/// <summary>
	/// SG17
	/// </summary>
	public CONPVA_SG17? SG17C { get; set; }

}

[EdiSegmentGroup("QTY", "RNG")]
public class CONPVA_SG13 : QTY
{
	/// <summary>
	/// Range details
	/// </summary>
	public RNG? RangeDetailsC { get; set; }
}

[EdiSegmentGroup("PCD", "RNG")]
public class CONPVA_SG14 : PCD
{
	/// <summary>
	/// Range details
	/// </summary>
	public RNG? RangeDetailsC { get; set; }
}

[EdiSegmentGroup("MOA", "RNG")]
public class CONPVA_SG15 : MOA
{
	/// <summary>
	/// Range details
	/// </summary>
	public RNG? RangeDetailsC { get; set; }
}

[EdiSegmentGroup("RTE", "RNG")]
public class CONPVA_SG16 : RTE
{
	/// <summary>
	/// Range details
	/// </summary>
	public RNG? RangeDetailsC { get; set; }
}

[EdiSegmentGroup("TAX", "MOA")]
public class CONPVA_SG17 : TAX
{
	/// <summary>
	/// Monetary amount
	/// </summary>
	public MOA? MonetaryAmountC { get; set; }
}

[EdiSegmentGroup("NAD", "LOC", "FII", "RFF", "DOC", "CTA")]
public class CONPVA_SG18 : NAD
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
	/// SG19
	/// </summary>
	public List<CONPVA_SG19>? SG19C { get; set; }

	/// <summary>
	/// SG20
	/// </summary>
	public List<CONPVA_SG20>? SG20C { get; set; }

	/// <summary>
	/// SG21
	/// </summary>
	public List<CONPVA_SG21>? SG21C { get; set; }

}

[EdiSegmentGroup("RFF", "DTM")]
public class CONPVA_SG19 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("DOC", "DTM")]
public class CONPVA_SG20 : DOC
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("CTA", "COM")]
public class CONPVA_SG21 : CTA
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("BII", "RCS", "QTY", "PRI", "MOA", "LIN", "APR", "TAX", "ALC")]
public class CONPVA_SG22 : BII
{
	/// <summary>
	/// Requirements and conditions
	/// </summary>
	public RCS? RequirementsAndConditionsC { get; set; }

	/// <summary>
	/// Quantity
	/// </summary>
	public List<QTY>? QuantityM { get; set; }

	/// <summary>
	/// Price details
	/// </summary>
	public PRI? PriceDetailsC { get; set; }

	/// <summary>
	/// Monetary amount
	/// </summary>
	public List<MOA>? MonetaryAmountM { get; set; }

	/// <summary>
	/// SG23
	/// </summary>
	public List<CONPVA_SG23>? SG23M { get; set; }

	/// <summary>
	/// SG25
	/// </summary>
	public List<CONPVA_SG25>? SG25C { get; set; }

	/// <summary>
	/// SG26
	/// </summary>
	public List<CONPVA_SG26>? SG26C { get; set; }

	/// <summary>
	/// SG27
	/// </summary>
	public List<CONPVA_SG27>? SG27C { get; set; }

}

[EdiSegmentGroup("LIN", "IMD")]
public class CONPVA_SG23 : LIN
{
	/// <summary>
	/// SG24
	/// </summary>
	public List<CONPVA_SG24>? SG24C { get; set; }

}

[EdiSegmentGroup("IMD", "RFF", "GIS")]
public class CONPVA_SG24 : IMD
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

[EdiSegmentGroup("APR", "DTM")]
public class CONPVA_SG25 : APR
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("TAX", "MOA", "LOC")]
public class CONPVA_SG26 : TAX
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
public class CONPVA_SG27 : ALC
{
	/// <summary>
	/// Additional information
	/// </summary>
	public ALI? AdditionalInformationC { get; set; }

	/// <summary>
	/// SG28
	/// </summary>
	public CONPVA_SG28? SG28C { get; set; }

	/// <summary>
	/// SG29
	/// </summary>
	public CONPVA_SG29? SG29C { get; set; }

	/// <summary>
	/// SG30
	/// </summary>
	public CONPVA_SG30? SG30C { get; set; }

	/// <summary>
	/// SG31
	/// </summary>
	public CONPVA_SG31? SG31C { get; set; }

	/// <summary>
	/// SG32
	/// </summary>
	public CONPVA_SG32? SG32C { get; set; }

}

[EdiSegmentGroup("QTY", "RNG")]
public class CONPVA_SG28 : QTY
{
	/// <summary>
	/// Range details
	/// </summary>
	public RNG? RangeDetailsC { get; set; }
}

[EdiSegmentGroup("PCD", "RNG")]
public class CONPVA_SG29 : PCD
{
	/// <summary>
	/// Range details
	/// </summary>
	public RNG? RangeDetailsC { get; set; }
}

[EdiSegmentGroup("MOA", "RNG")]
public class CONPVA_SG30 : MOA
{
	/// <summary>
	/// Range details
	/// </summary>
	public RNG? RangeDetailsC { get; set; }
}

[EdiSegmentGroup("RTE", "RNG")]
public class CONPVA_SG31 : RTE
{
	/// <summary>
	/// Range details
	/// </summary>
	public RNG? RangeDetailsC { get; set; }
}

[EdiSegmentGroup("TAX", "MOA")]
public class CONPVA_SG32 : TAX
{
	/// <summary>
	/// Monetary amount
	/// </summary>
	public MOA? MonetaryAmountC { get; set; }
}

[EdiSegmentGroup("TAX", "MOA")]
public class CONPVA_SG33 : TAX
{
	/// <summary>
	/// Monetary amount
	/// </summary>
	public List<MOA>? MonetaryAmountC { get; set; }
}