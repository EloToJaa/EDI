using System.Collections.Generic;
using Edi.Contracts.Segments;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// PAYMUL
/// </summary>
[EdiMessage]
public class PAYMUL
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
	public DTM? DateTimePeriod1M { get; set; }

	/// <summary>
	/// Business function
	/// </summary>
	public BUS? BusinessFunction1C { get; set; }

	/// <summary>
	/// SG1
	/// </summary>
	public List<PAYMUL_SG1>? SG1C { get; set; }

	/// <summary>
	/// SG2
	/// </summary>
	public List<PAYMUL_SG2>? SG2C { get; set; }

	/// <summary>
	/// SG3
	/// </summary>
	public List<PAYMUL_SG3>? SG3C { get; set; }

	/// <summary>
	/// SG4
	/// </summary>
	public List<PAYMUL_SG4>? SG4M { get; set; }

	/// <summary>
	/// Control total
	/// </summary>
	public List<CNT>? ControlTotalC { get; set; }

	/// <summary>
	/// SG24
	/// </summary>
	public List<PAYMUL_SG24>? SG24C { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class PAYMUL_SG1 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("FII", "CTA", "COM")]
public class PAYMUL_SG2 : FII
{
	/// <summary>
	/// Contact information
	/// </summary>
	public CTA? ContactInformationC { get; set; }

	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("NAD", "CTA", "COM")]
public class PAYMUL_SG3 : NAD
{
	/// <summary>
	/// Contact information
	/// </summary>
	public CTA? ContactInformationC { get; set; }

	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("LIN", "DTM", "RFF", "BUS", "FCA", "MOA", "FII", "NAD", "INP", "GIS", "PRC", "SEQ")]
public class PAYMUL_SG4 : LIN
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }

	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }

	/// <summary>
	/// Business function
	/// </summary>
	public BUS? BusinessFunctionC { get; set; }

	/// <summary>
	/// Financial charges allocation
	/// </summary>
	public FCA? FinancialChargesAllocationC { get; set; }

	/// <summary>
	/// SG5
	/// </summary>
	public PAYMUL_SG5? SG5C { get; set; }

	/// <summary>
	/// SG6
	/// </summary>
	public PAYMUL_SG6? SG6M { get; set; }

	/// <summary>
	/// SG7
	/// </summary>
	public List<PAYMUL_SG7>? SG7C { get; set; }

	/// <summary>
	/// SG8
	/// </summary>
	public PAYMUL_SG8? SG8C { get; set; }

	/// <summary>
	/// SG9
	/// </summary>
	public List<PAYMUL_SG9>? SG9C { get; set; }

	/// <summary>
	/// SG10
	/// </summary>
	public PAYMUL_SG10? SG10C { get; set; }

	/// <summary>
	/// SG11
	/// </summary>
	public List<PAYMUL_SG11>? SG11M { get; set; }

}

[EdiSegmentGroup("MOA", "CUX", "DTM", "RFF")]
public class PAYMUL_SG5 : MOA
{
	/// <summary>
	/// Currencies
	/// </summary>
	public CUX? CurrenciesC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Reference
	/// </summary>
	public RFF? ReferenceC { get; set; }
}

[EdiSegmentGroup("FII", "CTA", "COM")]
public class PAYMUL_SG6 : FII
{
	/// <summary>
	/// Contact information
	/// </summary>
	public CTA? ContactInformationC { get; set; }

	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("NAD", "CTA", "COM")]
public class PAYMUL_SG7 : NAD
{
	/// <summary>
	/// Contact information
	/// </summary>
	public CTA? ContactInformationC { get; set; }

	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("INP", "FTX", "DTM")]
public class PAYMUL_SG8 : INP
{
	/// <summary>
	/// Free text
	/// </summary>
	public FTX? FreeTextC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("GIS", "MOA", "LOC", "NAD", "RCS", "FTX")]
public class PAYMUL_SG9 : GIS
{
	/// <summary>
	/// Monetary amount
	/// </summary>
	public MOA? MonetaryAmountC { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// Name and address
	/// </summary>
	public NAD? NameAndAddressC { get; set; }

	/// <summary>
	/// Requirements and conditions
	/// </summary>
	public RCS? RequirementsAndConditionsC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }
}

[EdiSegmentGroup("PRC", "FTX")]
public class PAYMUL_SG10 : PRC
{
	/// <summary>
	/// Free text
	/// </summary>
	public FTX? FreeTextM { get; set; }
}

[EdiSegmentGroup("SEQ", "MOA", "DTM", "RFF", "PAI", "FCA", "FII", "NAD", "INP", "GIS", "PRC")]
public class PAYMUL_SG11 : SEQ
{
	/// <summary>
	/// Monetary amount
	/// </summary>
	public MOA? MonetaryAmountM { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }

	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }

	/// <summary>
	/// Payment instructions
	/// </summary>
	public PAI? PaymentInstructionsC { get; set; }

	/// <summary>
	/// Financial charges allocation
	/// </summary>
	public FCA? FinancialChargesAllocationC { get; set; }

	/// <summary>
	/// SG12
	/// </summary>
	public List<PAYMUL_SG12>? SG12C { get; set; }

	/// <summary>
	/// SG13
	/// </summary>
	public List<PAYMUL_SG13>? SG13C { get; set; }

	/// <summary>
	/// SG14
	/// </summary>
	public List<PAYMUL_SG14>? SG14C { get; set; }

	/// <summary>
	/// SG15
	/// </summary>
	public List<PAYMUL_SG15>? SG15C { get; set; }

	/// <summary>
	/// SG16
	/// </summary>
	public PAYMUL_SG16? SG16C { get; set; }

}

[EdiSegmentGroup("FII", "CTA", "COM")]
public class PAYMUL_SG12 : FII
{
	/// <summary>
	/// Contact information
	/// </summary>
	public CTA? ContactInformationC { get; set; }

	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("NAD", "CTA", "COM")]
public class PAYMUL_SG13 : NAD
{
	/// <summary>
	/// Contact information
	/// </summary>
	public CTA? ContactInformationC { get; set; }

	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("INP", "FTX", "DTM")]
public class PAYMUL_SG14 : INP
{
	/// <summary>
	/// Free text
	/// </summary>
	public FTX? FreeTextC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("GIS", "MOA", "LOC", "NAD", "RCS", "FTX")]
public class PAYMUL_SG15 : GIS
{
	/// <summary>
	/// Monetary amount
	/// </summary>
	public MOA? MonetaryAmountC { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// Name and address
	/// </summary>
	public NAD? NameAndAddressC { get; set; }

	/// <summary>
	/// Requirements and conditions
	/// </summary>
	public RCS? RequirementsAndConditionsC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }
}

[EdiSegmentGroup("PRC", "FTX", "DOC", "GIS")]
public class PAYMUL_SG16 : PRC
{
	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// SG17
	/// </summary>
	public List<PAYMUL_SG17>? SG17C { get; set; }

	/// <summary>
	/// SG23
	/// </summary>
	public PAYMUL_SG23? SG23C { get; set; }

}

[EdiSegmentGroup("DOC", "MOA", "DTM", "RFF", "NAD", "CUX", "AJT", "DLI")]
public class PAYMUL_SG17 : DOC
{
	/// <summary>
	/// Monetary amount
	/// </summary>
	public List<MOA>? MonetaryAmountC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }

	/// <summary>
	/// Name and address
	/// </summary>
	public List<NAD>? NameAndAddressC { get; set; }

	/// <summary>
	/// SG18
	/// </summary>
	public List<PAYMUL_SG18>? SG18C { get; set; }

	/// <summary>
	/// SG19
	/// </summary>
	public List<PAYMUL_SG19>? SG19C { get; set; }

	/// <summary>
	/// SG20
	/// </summary>
	public List<PAYMUL_SG20>? SG20C { get; set; }

}

[EdiSegmentGroup("CUX", "DTM")]
public class PAYMUL_SG18 : CUX
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("AJT", "MOA", "RFF", "FTX")]
public class PAYMUL_SG19 : AJT
{
	/// <summary>
	/// Monetary amount
	/// </summary>
	public MOA? MonetaryAmountM { get; set; }

	/// <summary>
	/// Reference
	/// </summary>
	public RFF? ReferenceC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }
}

[EdiSegmentGroup("DLI", "MOA", "PIA", "DTM", "CUX", "AJT")]
public class PAYMUL_SG20 : DLI
{
	/// <summary>
	/// Monetary amount
	/// </summary>
	public List<MOA>? MonetaryAmountM { get; set; }

	/// <summary>
	/// Additional product id
	/// </summary>
	public List<PIA>? AdditionalProductIdC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// SG21
	/// </summary>
	public List<PAYMUL_SG21>? SG21C { get; set; }

	/// <summary>
	/// SG22
	/// </summary>
	public List<PAYMUL_SG22>? SG22C { get; set; }

}

[EdiSegmentGroup("CUX", "DTM")]
public class PAYMUL_SG21 : CUX
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("AJT", "MOA", "RFF", "FTX")]
public class PAYMUL_SG22 : AJT
{
	/// <summary>
	/// Monetary amount
	/// </summary>
	public MOA? MonetaryAmountM { get; set; }

	/// <summary>
	/// Reference
	/// </summary>
	public RFF? ReferenceC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }
}

[EdiSegmentGroup("GIS", "MOA")]
public class PAYMUL_SG23 : GIS
{
	/// <summary>
	/// Monetary amount
	/// </summary>
	public List<MOA>? MonetaryAmountC { get; set; }
}

[EdiSegmentGroup("AUT", "DTM")]
public class PAYMUL_SG24 : AUT
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}