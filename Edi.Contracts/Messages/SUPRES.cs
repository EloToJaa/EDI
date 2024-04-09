using System.Collections.Generic;
using Edi.Contracts.Segments;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// SUPRES
/// </summary>
[EdiMessage]
public class SUPRES
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
	/// Language
	/// </summary>
	public LAN? Language1C { get; set; }

	/// <summary>
	/// Percentage details
	/// </summary>
	public PCD? PercentageDetails1C { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriod1C { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeText1C { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentification1C { get; set; }

	/// <summary>
	/// Monetary amount
	/// </summary>
	public List<MOA>? MonetaryAmount1C { get; set; }

	/// <summary>
	/// Financial institution information
	/// </summary>
	public List<FII>? FinancialInstitutionInformation1C { get; set; }

	/// <summary>
	/// SG1
	/// </summary>
	public List<SUPRES_SG1>? SG1C { get; set; }

	/// <summary>
	/// SG2
	/// </summary>
	public List<SUPRES_SG2>? SG2C { get; set; }

	/// <summary>
	/// SG4
	/// </summary>
	public SUPRES_SG4? SG4C { get; set; }

	/// <summary>
	/// SG5
	/// </summary>
	public SUPRES_SG5? SG5C { get; set; }

	/// <summary>
	/// SG6
	/// </summary>
	public List<SUPRES_SG6>? SG6C { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class SUPRES_SG1 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("NAD", "RFF", "COM", "LAN", "CTA")]
public class SUPRES_SG2 : NAD
{
	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }

	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }

	/// <summary>
	/// Language
	/// </summary>
	public LAN? LanguageC { get; set; }

	/// <summary>
	/// SG3
	/// </summary>
	public List<SUPRES_SG3>? SG3C { get; set; }

}

[EdiSegmentGroup("CTA", "COM")]
public class SUPRES_SG3 : CTA
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("PAI", "RFF")]
public class SUPRES_SG4 : PAI
{
	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }
}

[EdiSegmentGroup("PAT", "DTM")]
public class SUPRES_SG5 : PAT
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("SEQ", "IMD", "MEM")]
public class SUPRES_SG6 : SEQ
{
	/// <summary>
	/// SG7
	/// </summary>
	public List<SUPRES_SG7>? SG7C { get; set; }

	/// <summary>
	/// SG17
	/// </summary>
	public List<SUPRES_SG17>? SG17C { get; set; }

}

[EdiSegmentGroup("IMD", "QTY", "LAN", "DTM", "RFF", "PCD", "DIM", "FTX", "NAD", "LOC", "MOA", "PAI", "PAT", "RCS")]
public class SUPRES_SG7 : IMD
{
	/// <summary>
	/// Quantity
	/// </summary>
	public QTY? QuantityC { get; set; }

	/// <summary>
	/// Language
	/// </summary>
	public LAN? LanguageC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }

	/// <summary>
	/// Percentage details
	/// </summary>
	public PCD? PercentageDetailsC { get; set; }

	/// <summary>
	/// Dimensions
	/// </summary>
	public List<DIM>? DimensionsC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// SG8
	/// </summary>
	public SUPRES_SG8? SG8C { get; set; }

	/// <summary>
	/// SG10
	/// </summary>
	public List<SUPRES_SG10>? SG10C { get; set; }

	/// <summary>
	/// SG13
	/// </summary>
	public List<SUPRES_SG13>? SG13C { get; set; }

	/// <summary>
	/// SG14
	/// </summary>
	public SUPRES_SG14? SG14C { get; set; }

	/// <summary>
	/// SG15
	/// </summary>
	public SUPRES_SG15? SG15C { get; set; }

	/// <summary>
	/// SG16
	/// </summary>
	public List<SUPRES_SG16>? SG16C { get; set; }

}

[EdiSegmentGroup("NAD", "COM", "LAN", "CTA")]
public class SUPRES_SG8 : NAD
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }

	/// <summary>
	/// Language
	/// </summary>
	public LAN? LanguageC { get; set; }

	/// <summary>
	/// SG9
	/// </summary>
	public SUPRES_SG9? SG9C { get; set; }

}

[EdiSegmentGroup("CTA", "COM")]
public class SUPRES_SG9 : CTA
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("LOC", "DTM", "NAD")]
public class SUPRES_SG10 : LOC
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// SG11
	/// </summary>
	public SUPRES_SG11? SG11C { get; set; }

}

[EdiSegmentGroup("NAD", "DTM", "CTA")]
public class SUPRES_SG11 : NAD
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// SG12
	/// </summary>
	public List<SUPRES_SG12>? SG12C { get; set; }

}

[EdiSegmentGroup("CTA", "COM")]
public class SUPRES_SG12 : CTA
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("MOA", "QTY")]
public class SUPRES_SG13 : MOA
{
	/// <summary>
	/// Quantity
	/// </summary>
	public QTY? QuantityC { get; set; }
}

[EdiSegmentGroup("PAI", "RFF")]
public class SUPRES_SG14 : PAI
{
	/// <summary>
	/// Reference
	/// </summary>
	public RFF? ReferenceC { get; set; }
}

[EdiSegmentGroup("PAT", "DTM")]
public class SUPRES_SG15 : PAT
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("RCS", "FII", "MOA", "RFF", "FTX", "DOC")]
public class SUPRES_SG16 : RCS
{
	/// <summary>
	/// Financial institution information
	/// </summary>
	public List<FII>? FinancialInstitutionInformationC { get; set; }

	/// <summary>
	/// Monetary amount
	/// </summary>
	public List<MOA>? MonetaryAmountC { get; set; }

	/// <summary>
	/// Reference
	/// </summary>
	public RFF? ReferenceC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public FTX? FreeTextC { get; set; }

	/// <summary>
	/// Document/message details
	/// </summary>
	public DOC? DocumentMessageDetailsC { get; set; }
}

[EdiSegmentGroup("MEM", "NAD")]
public class SUPRES_SG17 : MEM
{
	/// <summary>
	/// SG18
	/// </summary>
	public List<SUPRES_SG18>? SG18C { get; set; }

}

[EdiSegmentGroup("NAD", "ATT", "RFF", "LAN", "FTX", "COM", "CTA", "DOC", "PAI", "RCS")]
public class SUPRES_SG18 : NAD
{
	/// <summary>
	/// Attribute
	/// </summary>
	public List<ATT>? AttributeC { get; set; }

	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }

	/// <summary>
	/// Language
	/// </summary>
	public LAN? LanguageC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }

	/// <summary>
	/// SG19
	/// </summary>
	public SUPRES_SG19? SG19C { get; set; }

	/// <summary>
	/// SG20
	/// </summary>
	public List<SUPRES_SG20>? SG20C { get; set; }

	/// <summary>
	/// SG21
	/// </summary>
	public List<SUPRES_SG21>? SG21C { get; set; }

	/// <summary>
	/// SG22
	/// </summary>
	public List<SUPRES_SG22>? SG22C { get; set; }

}

[EdiSegmentGroup("CTA", "COM")]
public class SUPRES_SG19 : CTA
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("DOC", "LOC", "DTM")]
public class SUPRES_SG20 : DOC
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public LOC? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("PAI", "PAT", "FII", "MOA", "RFF")]
public class SUPRES_SG21 : PAI
{
	/// <summary>
	/// Payment terms basis
	/// </summary>
	public PAT? PaymentTermsBasisC { get; set; }

	/// <summary>
	/// Financial institution information
	/// </summary>
	public FII? FinancialInstitutionInformationC { get; set; }

	/// <summary>
	/// Monetary amount
	/// </summary>
	public MOA? MonetaryAmountC { get; set; }

	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }
}

[EdiSegmentGroup("RCS", "MOA", "RFF", "FTX")]
public class SUPRES_SG22 : RCS
{
	/// <summary>
	/// Monetary amount
	/// </summary>
	public List<MOA>? MonetaryAmountC { get; set; }

	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public FTX? FreeTextC { get; set; }
}