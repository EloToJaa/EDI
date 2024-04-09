using System.Collections.Generic;
using Edi.Contracts.Segments;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// PAYEXT
/// </summary>
[EdiMessage]
public class PAYEXT
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
	/// Business function
	/// </summary>
	public BUS? BusinessFunctionC { get; set; }

	/// <summary>
	/// Payment instructions
	/// </summary>
	public PAI? PaymentInstructionsC { get; set; }

	/// <summary>
	/// Financial charges allocation
	/// </summary>
	public FCA? FinancialChargesAllocationC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriod1M { get; set; }

	/// <summary>
	/// SG1
	/// </summary>
	public List<PAYEXT_SG1>? SG1C { get; set; }

	/// <summary>
	/// SG2
	/// </summary>
	public PAYEXT_SG2? SG2M { get; set; }

	/// <summary>
	/// SG3
	/// </summary>
	public List<PAYEXT_SG3>? SG3C { get; set; }

	/// <summary>
	/// SG4
	/// </summary>
	public List<PAYEXT_SG4>? SG4C { get; set; }

	/// <summary>
	/// SG5
	/// </summary>
	public List<PAYEXT_SG5>? SG5C { get; set; }

	/// <summary>
	/// SG6
	/// </summary>
	public List<PAYEXT_SG6>? SG6C { get; set; }

	/// <summary>
	/// SG7
	/// </summary>
	public PAYEXT_SG7? SG7C { get; set; }

	/// <summary>
	/// SG15
	/// </summary>
	public List<PAYEXT_SG15>? SG15C { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class PAYEXT_SG1 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("MOA", "CUX", "DTM", "RFF")]
public class PAYEXT_SG2 : MOA
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
public class PAYEXT_SG3 : FII
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
public class PAYEXT_SG4 : NAD
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
public class PAYEXT_SG5 : INP
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
public class PAYEXT_SG6 : GIS
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
public class PAYEXT_SG7 : PRC
{
	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// SG8
	/// </summary>
	public List<PAYEXT_SG8>? SG8C { get; set; }

	/// <summary>
	/// SG14
	/// </summary>
	public PAYEXT_SG14? SG14C { get; set; }

}

[EdiSegmentGroup("DOC", "MOA", "DTM", "RFF", "NAD", "CUX", "AJT", "DLI")]
public class PAYEXT_SG8 : DOC
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
	/// SG9
	/// </summary>
	public List<PAYEXT_SG9>? SG9C { get; set; }

	/// <summary>
	/// SG10
	/// </summary>
	public List<PAYEXT_SG10>? SG10C { get; set; }

	/// <summary>
	/// SG11
	/// </summary>
	public List<PAYEXT_SG11>? SG11C { get; set; }

}

[EdiSegmentGroup("CUX", "DTM")]
public class PAYEXT_SG9 : CUX
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("AJT", "MOA", "RFF", "FTX")]
public class PAYEXT_SG10 : AJT
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
public class PAYEXT_SG11 : DLI
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
	/// SG12
	/// </summary>
	public List<PAYEXT_SG12>? SG12C { get; set; }

	/// <summary>
	/// SG13
	/// </summary>
	public List<PAYEXT_SG13>? SG13C { get; set; }

}

[EdiSegmentGroup("CUX", "DTM")]
public class PAYEXT_SG12 : CUX
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("AJT", "MOA", "RFF", "FTX")]
public class PAYEXT_SG13 : AJT
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
public class PAYEXT_SG14 : GIS
{
	/// <summary>
	/// Monetary amount
	/// </summary>
	public List<MOA>? MonetaryAmountC { get; set; }
}

[EdiSegmentGroup("AUT", "DTM")]
public class PAYEXT_SG15 : AUT
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}