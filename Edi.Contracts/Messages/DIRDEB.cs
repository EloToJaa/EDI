using System.Collections.Generic;
using Edi.Contracts.Segments;
using Edi.Contracts.Interfaces;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// DIRDEB
/// </summary>
[EdiMessage]
public class DIRDEB : IMessage
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
	public DTM? DateTimePeriodM { get; set; }

	/// <summary>
	/// Business function
	/// </summary>
	public BUS? BusinessFunctionC { get; set; }

	/// <summary>
	/// SG1
	/// </summary>
	public List<DIRDEB_SG1>? SG1C { get; set; }

	/// <summary>
	/// SG2
	/// </summary>
	public List<DIRDEB_SG2>? SG2C { get; set; }

	/// <summary>
	/// SG3
	/// </summary>
	public List<DIRDEB_SG3>? SG3C { get; set; }

	/// <summary>
	/// SG4
	/// </summary>
	public List<DIRDEB_SG4>? SG4M { get; set; }

	/// <summary>
	/// Control total
	/// </summary>
	public List<CNT>? ControlTotalC { get; set; }

	/// <summary>
	/// SG24
	/// </summary>
	public List<DIRDEB_SG24>? SG24C { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class DIRDEB_SG1 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("FII", "CTA", "COM")]
public class DIRDEB_SG2 : FII, ISegmentGroup
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
public class DIRDEB_SG3 : NAD, ISegmentGroup
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
public class DIRDEB_SG4 : LIN, ISegmentGroup
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
	public DIRDEB_SG5? SG5C { get; set; }

	/// <summary>
	/// SG6
	/// </summary>
	public DIRDEB_SG6? SG6M { get; set; }

	/// <summary>
	/// SG7
	/// </summary>
	public List<DIRDEB_SG7>? SG7C { get; set; }

	/// <summary>
	/// SG8
	/// </summary>
	public DIRDEB_SG8? SG8C { get; set; }

	/// <summary>
	/// SG9
	/// </summary>
	public List<DIRDEB_SG9>? SG9C { get; set; }

	/// <summary>
	/// SG10
	/// </summary>
	public DIRDEB_SG10? SG10C { get; set; }

	/// <summary>
	/// SG11
	/// </summary>
	public List<DIRDEB_SG11>? SG11M { get; set; }

}

[EdiSegmentGroup("MOA", "CUX", "DTM", "RFF")]
public class DIRDEB_SG5 : MOA, ISegmentGroup
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
public class DIRDEB_SG6 : FII, ISegmentGroup
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
public class DIRDEB_SG7 : NAD, ISegmentGroup
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
public class DIRDEB_SG8 : INP, ISegmentGroup
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
public class DIRDEB_SG9 : GIS, ISegmentGroup
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
public class DIRDEB_SG10 : PRC, ISegmentGroup
{
	/// <summary>
	/// Free text
	/// </summary>
	public FTX? FreeTextM { get; set; }
}

[EdiSegmentGroup("SEQ", "MOA", "DTM", "RFF", "PAI", "FCA", "FII", "NAD", "INP", "GIS", "PRC")]
public class DIRDEB_SG11 : SEQ, ISegmentGroup
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
	public List<DIRDEB_SG12>? SG12C { get; set; }

	/// <summary>
	/// SG13
	/// </summary>
	public List<DIRDEB_SG13>? SG13C { get; set; }

	/// <summary>
	/// SG14
	/// </summary>
	public List<DIRDEB_SG14>? SG14C { get; set; }

	/// <summary>
	/// SG15
	/// </summary>
	public List<DIRDEB_SG15>? SG15C { get; set; }

	/// <summary>
	/// SG16
	/// </summary>
	public DIRDEB_SG16? SG16C { get; set; }

}

[EdiSegmentGroup("FII", "CTA", "COM")]
public class DIRDEB_SG12 : FII, ISegmentGroup
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
public class DIRDEB_SG13 : NAD, ISegmentGroup
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
public class DIRDEB_SG14 : INP, ISegmentGroup
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
public class DIRDEB_SG15 : GIS, ISegmentGroup
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
public class DIRDEB_SG16 : PRC, ISegmentGroup
{
	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// SG17
	/// </summary>
	public List<DIRDEB_SG17>? SG17C { get; set; }

	/// <summary>
	/// SG23
	/// </summary>
	public DIRDEB_SG23? SG23C { get; set; }

}

[EdiSegmentGroup("DOC", "MOA", "DTM", "RFF", "NAD", "CUX", "AJT", "DLI")]
public class DIRDEB_SG17 : DOC, ISegmentGroup
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
	public List<DIRDEB_SG18>? SG18C { get; set; }

	/// <summary>
	/// SG19
	/// </summary>
	public List<DIRDEB_SG19>? SG19C { get; set; }

	/// <summary>
	/// SG20
	/// </summary>
	public List<DIRDEB_SG20>? SG20C { get; set; }

}

[EdiSegmentGroup("CUX", "DTM")]
public class DIRDEB_SG18 : CUX, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("AJT", "MOA", "RFF", "FTX")]
public class DIRDEB_SG19 : AJT, ISegmentGroup
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
public class DIRDEB_SG20 : DLI, ISegmentGroup
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
	public List<DIRDEB_SG21>? SG21C { get; set; }

	/// <summary>
	/// SG22
	/// </summary>
	public List<DIRDEB_SG22>? SG22C { get; set; }

}

[EdiSegmentGroup("CUX", "DTM")]
public class DIRDEB_SG21 : CUX, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("AJT", "MOA", "RFF", "FTX")]
public class DIRDEB_SG22 : AJT, ISegmentGroup
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
public class DIRDEB_SG23 : GIS, ISegmentGroup
{
	/// <summary>
	/// Monetary amount
	/// </summary>
	public List<MOA>? MonetaryAmountC { get; set; }
}

[EdiSegmentGroup("AUT", "DTM")]
public class DIRDEB_SG24 : AUT, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}