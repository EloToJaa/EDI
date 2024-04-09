using System.Collections.Generic;
using Edi.Contracts.Segments;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// DEBADV
/// </summary>
[EdiMessage]
public class DEBADV
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
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriod1M { get; set; }

	/// <summary>
	/// SG1
	/// </summary>
	public List<DEBADV_SG1>? SG1C { get; set; }

	/// <summary>
	/// SG2
	/// </summary>
	public DEBADV_SG2? SG2C { get; set; }

	/// <summary>
	/// SG3
	/// </summary>
	public List<DEBADV_SG3>? SG3M { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeText1C { get; set; }

	/// <summary>
	/// SG4
	/// </summary>
	public List<DEBADV_SG4>? SG4M { get; set; }

	/// <summary>
	/// SG5
	/// </summary>
	public List<DEBADV_SG5>? SG5C { get; set; }

	/// <summary>
	/// SG6
	/// </summary>
	public List<DEBADV_SG6>? SG6C { get; set; }

	/// <summary>
	/// SG7
	/// </summary>
	public List<DEBADV_SG7>? SG7C { get; set; }

	/// <summary>
	/// SG8
	/// </summary>
	public List<DEBADV_SG8>? SG8C { get; set; }

	/// <summary>
	/// SG11
	/// </summary>
	public List<DEBADV_SG11>? SG11C { get; set; }

	/// <summary>
	/// SG12
	/// </summary>
	public List<DEBADV_SG12>? SG12C { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class DEBADV_SG1 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("PAI", "FTX")]
public class DEBADV_SG2 : PAI
{
	/// <summary>
	/// Free text
	/// </summary>
	public FTX? FreeTextC { get; set; }
}

[EdiSegmentGroup("MOA", "CUX", "DTM", "RFF")]
public class DEBADV_SG3 : MOA
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
public class DEBADV_SG4 : FII
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
public class DEBADV_SG5 : NAD
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
public class DEBADV_SG6 : INP
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
public class DEBADV_SG7 : GIS
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
public class DEBADV_SG8 : FCA
{
	/// <summary>
	/// Monetary amount
	/// </summary>
	public List<MOA>? MonetaryAmountC { get; set; }

	/// <summary>
	/// SG9
	/// </summary>
	public List<DEBADV_SG9>? SG9C { get; set; }

}

[EdiSegmentGroup("ALC", "PCD", "MOA", "CUX", "DTM", "TAX")]
public class DEBADV_SG9 : ALC
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
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// SG10
	/// </summary>
	public List<DEBADV_SG10>? SG10C { get; set; }

}

[EdiSegmentGroup("TAX", "MOA", "CUX", "DTM")]
public class DEBADV_SG10 : TAX
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

[EdiSegmentGroup("DOC", "DTM")]
public class DEBADV_SG11 : DOC
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("AUT", "DTM")]
public class DEBADV_SG12 : AUT
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}