using System.Collections.Generic;
using Edi.Contracts.Segments;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// DEBMUL
/// </summary>
[EdiMessage]
public class DEBMUL
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
	public List<DEBMUL_SG1>? SG1C { get; set; }

	/// <summary>
	/// SG2
	/// </summary>
	public List<DEBMUL_SG2>? SG2C { get; set; }

	/// <summary>
	/// SG3
	/// </summary>
	public List<DEBMUL_SG3>? SG3C { get; set; }

	/// <summary>
	/// SG4
	/// </summary>
	public List<DEBMUL_SG4>? SG4M { get; set; }

	/// <summary>
	/// Control total
	/// </summary>
	public List<CNT>? ControlTotalC { get; set; }

	/// <summary>
	/// SG28
	/// </summary>
	public List<DEBMUL_SG28>? SG28C { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class DEBMUL_SG1 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("FII", "CTA", "COM")]
public class DEBMUL_SG2 : FII
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
public class DEBMUL_SG3 : NAD
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

[EdiSegmentGroup("LIN", "DTM", "BUS", "MOA", "RFF", "FII", "FCA", "SEQ")]
public class DEBMUL_SG4 : LIN
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Business function
	/// </summary>
	public BUS? BusinessFunctionC { get; set; }

	/// <summary>
	/// Monetary amount
	/// </summary>
	public List<MOA>? MonetaryAmountM { get; set; }

	/// <summary>
	/// SG5
	/// </summary>
	public List<DEBMUL_SG5>? SG5M { get; set; }

	/// <summary>
	/// SG6
	/// </summary>
	public DEBMUL_SG6? SG6M { get; set; }

	/// <summary>
	/// SG7
	/// </summary>
	public List<DEBMUL_SG7>? SG7C { get; set; }

	/// <summary>
	/// SG10
	/// </summary>
	public List<DEBMUL_SG10>? SG10C { get; set; }

}

[EdiSegmentGroup("RFF", "DTM")]
public class DEBMUL_SG5 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("FII", "CTA", "COM")]
public class DEBMUL_SG6 : FII
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

[EdiSegmentGroup("FCA", "MOA", "ALC")]
public class DEBMUL_SG7 : FCA
{
	/// <summary>
	/// Monetary amount
	/// </summary>
	public List<MOA>? MonetaryAmountC { get; set; }

	/// <summary>
	/// SG8
	/// </summary>
	public List<DEBMUL_SG8>? SG8C { get; set; }

}

[EdiSegmentGroup("ALC", "PCD", "MOA", "CUX", "DTM", "TAX")]
public class DEBMUL_SG8 : ALC
{
	/// <summary>
	/// Percentage details
	/// </summary>
	public PCD? PercentageDetailsC { get; set; }

	/// <summary>
	/// Monetary amount
	/// </summary>
	public List<MOA>? MonetaryAmountC { get; set; }

	/// <summary>
	/// Currencies
	/// </summary>
	public CUX? CurrenciesC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }

	/// <summary>
	/// SG9
	/// </summary>
	public List<DEBMUL_SG9>? SG9C { get; set; }

}

[EdiSegmentGroup("TAX", "MOA", "CUX", "DTM")]
public class DEBMUL_SG9 : TAX
{
	/// <summary>
	/// Monetary amount
	/// </summary>
	public List<MOA>? MonetaryAmountC { get; set; }

	/// <summary>
	/// Currencies
	/// </summary>
	public CUX? CurrenciesC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("SEQ", "DTM", "BUS", "FII", "RFF", "PAI", "MOA", "NAD", "INP", "GIS", "FCA", "PRC")]
public class DEBMUL_SG10 : SEQ
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Business function
	/// </summary>
	public BUS? BusinessFunctionC { get; set; }

	/// <summary>
	/// Financial institution information
	/// </summary>
	public List<FII>? FinancialInstitutionInformationM { get; set; }

	/// <summary>
	/// SG11
	/// </summary>
	public List<DEBMUL_SG11>? SG11C { get; set; }

	/// <summary>
	/// SG12
	/// </summary>
	public DEBMUL_SG12? SG12C { get; set; }

	/// <summary>
	/// SG13
	/// </summary>
	public List<DEBMUL_SG13>? SG13M { get; set; }

	/// <summary>
	/// SG14
	/// </summary>
	public List<DEBMUL_SG14>? SG14C { get; set; }

	/// <summary>
	/// SG15
	/// </summary>
	public List<DEBMUL_SG15>? SG15C { get; set; }

	/// <summary>
	/// SG16
	/// </summary>
	public List<DEBMUL_SG16>? SG16C { get; set; }

	/// <summary>
	/// SG17
	/// </summary>
	public List<DEBMUL_SG17>? SG17C { get; set; }

	/// <summary>
	/// SG20
	/// </summary>
	public DEBMUL_SG20? SG20C { get; set; }

}

[EdiSegmentGroup("RFF", "DTM")]
public class DEBMUL_SG11 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("PAI", "FTX")]
public class DEBMUL_SG12 : PAI
{
	/// <summary>
	/// Free text
	/// </summary>
	public FTX? FreeTextC { get; set; }
}

[EdiSegmentGroup("MOA", "CUX", "DTM", "RFF")]
public class DEBMUL_SG13 : MOA
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

[EdiSegmentGroup("NAD", "CTA", "COM")]
public class DEBMUL_SG14 : NAD
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
public class DEBMUL_SG15 : INP
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
public class DEBMUL_SG16 : GIS
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

[EdiSegmentGroup("FCA", "MOA", "ALC")]
public class DEBMUL_SG17 : FCA
{
	/// <summary>
	/// Monetary amount
	/// </summary>
	public List<MOA>? MonetaryAmountC { get; set; }

	/// <summary>
	/// SG18
	/// </summary>
	public List<DEBMUL_SG18>? SG18C { get; set; }

}

[EdiSegmentGroup("ALC", "PCD", "MOA", "CUX", "DTM", "TAX")]
public class DEBMUL_SG18 : ALC
{
	/// <summary>
	/// Percentage details
	/// </summary>
	public PCD? PercentageDetailsC { get; set; }

	/// <summary>
	/// Monetary amount
	/// </summary>
	public List<MOA>? MonetaryAmountC { get; set; }

	/// <summary>
	/// Currencies
	/// </summary>
	public CUX? CurrenciesC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }

	/// <summary>
	/// SG19
	/// </summary>
	public List<DEBMUL_SG19>? SG19C { get; set; }

}

[EdiSegmentGroup("TAX", "MOA", "CUX", "DTM")]
public class DEBMUL_SG19 : TAX
{
	/// <summary>
	/// Monetary amount
	/// </summary>
	public List<MOA>? MonetaryAmountC { get; set; }

	/// <summary>
	/// Currencies
	/// </summary>
	public CUX? CurrenciesC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("PRC", "FTX", "DOC", "GIS")]
public class DEBMUL_SG20 : PRC
{
	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// SG21
	/// </summary>
	public List<DEBMUL_SG21>? SG21C { get; set; }

	/// <summary>
	/// SG27
	/// </summary>
	public DEBMUL_SG27? SG27C { get; set; }

}

[EdiSegmentGroup("DOC", "MOA", "DTM", "RFF", "NAD", "CUX", "AJT", "DLI")]
public class DEBMUL_SG21 : DOC
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
	/// SG22
	/// </summary>
	public List<DEBMUL_SG22>? SG22C { get; set; }

	/// <summary>
	/// SG23
	/// </summary>
	public List<DEBMUL_SG23>? SG23C { get; set; }

	/// <summary>
	/// SG24
	/// </summary>
	public List<DEBMUL_SG24>? SG24C { get; set; }

}

[EdiSegmentGroup("CUX", "DTM")]
public class DEBMUL_SG22 : CUX
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("AJT", "MOA", "RFF", "FTX")]
public class DEBMUL_SG23 : AJT
{
	/// <summary>
	/// Monetary amount
	/// </summary>
	public MOA? MonetaryAmountC { get; set; }

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
public class DEBMUL_SG24 : DLI
{
	/// <summary>
	/// Monetary amount
	/// </summary>
	public List<MOA>? MonetaryAmountC { get; set; }

	/// <summary>
	/// Additional product id
	/// </summary>
	public List<PIA>? AdditionalProductIdC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// SG25
	/// </summary>
	public List<DEBMUL_SG25>? SG25C { get; set; }

	/// <summary>
	/// SG26
	/// </summary>
	public List<DEBMUL_SG26>? SG26C { get; set; }

}

[EdiSegmentGroup("CUX", "DTM")]
public class DEBMUL_SG25 : CUX
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("AJT", "MOA", "RFF", "FTX")]
public class DEBMUL_SG26 : AJT
{
	/// <summary>
	/// Monetary amount
	/// </summary>
	public MOA? MonetaryAmountC { get; set; }

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
public class DEBMUL_SG27 : GIS
{
	/// <summary>
	/// Monetary amount
	/// </summary>
	public List<MOA>? MonetaryAmountC { get; set; }
}

[EdiSegmentGroup("AUT", "DTM")]
public class DEBMUL_SG28 : AUT
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}