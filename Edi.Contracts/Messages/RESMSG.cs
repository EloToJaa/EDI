using System.Collections.Generic;
using Edi.Contracts.Segments;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// RESMSG
/// </summary>
[EdiMessage]
public class RESMSG
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
	/// Payment instructions
	/// </summary>
	public PAI? PaymentInstructions1C { get; set; }

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
	/// Payment terms basis
	/// </summary>
	public List<PAT>? PaymentTermsBasis1C { get; set; }

	/// <summary>
	/// Financial institution information
	/// </summary>
	public List<FII>? FinancialInstitutionInformation1C { get; set; }

	/// <summary>
	/// SG1
	/// </summary>
	public List<RESMSG_SG1>? SG1C { get; set; }

	/// <summary>
	/// SG2
	/// </summary>
	public List<RESMSG_SG2>? SG2C { get; set; }

	/// <summary>
	/// SG4
	/// </summary>
	public List<RESMSG_SG4>? SG4C { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class RESMSG_SG1 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("NAD", "RFF", "COM", "LAN", "CTA")]
public class RESMSG_SG2 : NAD
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
	public List<RESMSG_SG3>? SG3C { get; set; }

}

[EdiSegmentGroup("CTA", "COM", "LAN")]
public class RESMSG_SG3 : CTA
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }

	/// <summary>
	/// Language
	/// </summary>
	public LAN? LanguageC { get; set; }
}

[EdiSegmentGroup("SEQ", "IMD", "MEM")]
public class RESMSG_SG4 : SEQ
{
	/// <summary>
	/// SG5
	/// </summary>
	public List<RESMSG_SG5>? SG5C { get; set; }

	/// <summary>
	/// SG9
	/// </summary>
	public List<RESMSG_SG9>? SG9C { get; set; }

}

[EdiSegmentGroup("IMD", "QTY", "LAN", "DTM", "NAD", "RFF", "PCD", "PAI", "PAT", "FII", "DIM", "FTX", "LOC", "MOA", "RCS")]
public class RESMSG_SG5 : IMD
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
	/// Name and address
	/// </summary>
	public NAD? NameAndAddressC { get; set; }

	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }

	/// <summary>
	/// Percentage details
	/// </summary>
	public PCD? PercentageDetailsC { get; set; }

	/// <summary>
	/// Payment instructions
	/// </summary>
	public PAI? PaymentInstructionsC { get; set; }

	/// <summary>
	/// Payment terms basis
	/// </summary>
	public List<PAT>? PaymentTermsBasisC { get; set; }

	/// <summary>
	/// Financial institution information
	/// </summary>
	public List<FII>? FinancialInstitutionInformationC { get; set; }

	/// <summary>
	/// Dimensions
	/// </summary>
	public List<DIM>? DimensionsC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// SG6
	/// </summary>
	public List<RESMSG_SG6>? SG6C { get; set; }

	/// <summary>
	/// SG7
	/// </summary>
	public List<RESMSG_SG7>? SG7C { get; set; }

	/// <summary>
	/// SG8
	/// </summary>
	public List<RESMSG_SG8>? SG8C { get; set; }

}

[EdiSegmentGroup("LOC", "NAD", "DTM")]
public class RESMSG_SG6 : LOC
{
	/// <summary>
	/// Name and address
	/// </summary>
	public NAD? NameAndAddressC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("MOA", "QTY")]
public class RESMSG_SG7 : MOA
{
	/// <summary>
	/// Quantity
	/// </summary>
	public QTY? QuantityC { get; set; }
}

[EdiSegmentGroup("RCS", "FII", "MOA", "RFF", "FTX")]
public class RESMSG_SG8 : RCS
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
}

[EdiSegmentGroup("MEM", "NAD")]
public class RESMSG_SG9 : MEM
{
	/// <summary>
	/// SG10
	/// </summary>
	public List<RESMSG_SG10>? SG10C { get; set; }

}

[EdiSegmentGroup("NAD", "ATT", "RFF", "LAN", "FTX", "COM", "CTA", "DOC", "PAI", "RCS")]
public class RESMSG_SG10 : NAD
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
	/// SG11
	/// </summary>
	public RESMSG_SG11? SG11C { get; set; }

	/// <summary>
	/// SG12
	/// </summary>
	public List<RESMSG_SG12>? SG12C { get; set; }

	/// <summary>
	/// SG13
	/// </summary>
	public List<RESMSG_SG13>? SG13C { get; set; }

	/// <summary>
	/// SG14
	/// </summary>
	public List<RESMSG_SG14>? SG14C { get; set; }

}

[EdiSegmentGroup("CTA", "COM")]
public class RESMSG_SG11 : CTA
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("DOC", "LOC", "DTM")]
public class RESMSG_SG12 : DOC
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
public class RESMSG_SG13 : PAI
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
public class RESMSG_SG14 : RCS
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