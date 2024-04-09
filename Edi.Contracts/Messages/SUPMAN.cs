using System.Collections.Generic;
using Edi.Contracts.Segments;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// SUPMAN
/// </summary>
[EdiMessage]
public class SUPMAN
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
	public List<RFF>? Reference1M { get; set; }

	/// <summary>
	/// Currencies
	/// </summary>
	public CUX? Currencies1C { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriod1C { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeText1C { get; set; }

	/// <summary>
	/// SG1
	/// </summary>
	public List<SUPMAN_SG1>? SG1C { get; set; }

	/// <summary>
	/// Section control
	/// </summary>
	public UNS? SectionControlM { get; set; }

	/// <summary>
	/// SG3
	/// </summary>
	public List<SUPMAN_SG3>? SG3M { get; set; }

	/// <summary>
	/// Control total
	/// </summary>
	public List<CNT>? ControlTotalC { get; set; }

	/// <summary>
	/// Authentication result
	/// </summary>
	public AUT? AuthenticationResultC { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("NAD", "CTA")]
public class SUPMAN_SG1 : NAD
{
	/// <summary>
	/// SG2
	/// </summary>
	public List<SUPMAN_SG2>? SG2C { get; set; }

}

[EdiSegmentGroup("CTA", "COM")]
public class SUPMAN_SG2 : CTA
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public COM? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("NAD", "DTM", "ATT", "RFF", "REL", "EMP", "GIS", "MEM")]
public class SUPMAN_SG3 : NAD
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodM { get; set; }

	/// <summary>
	/// Attribute
	/// </summary>
	public List<ATT>? AttributeC { get; set; }

	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }

	/// <summary>
	/// SG4
	/// </summary>
	public List<SUPMAN_SG4>? SG4C { get; set; }

	/// <summary>
	/// SG5
	/// </summary>
	public List<SUPMAN_SG5>? SG5C { get; set; }

	/// <summary>
	/// SG7
	/// </summary>
	public List<SUPMAN_SG7>? SG7M { get; set; }

	/// <summary>
	/// SG8
	/// </summary>
	public List<SUPMAN_SG8>? SG8C { get; set; }

}

[EdiSegmentGroup("REL", "NAD", "PCD")]
public class SUPMAN_SG4 : REL
{
	/// <summary>
	/// Name and address
	/// </summary>
	public NAD? NameAndAddressM { get; set; }

	/// <summary>
	/// Percentage details
	/// </summary>
	public PCD? PercentageDetailsC { get; set; }
}

[EdiSegmentGroup("EMP", "PCD", "CUX", "NAD", "MOA")]
public class SUPMAN_SG5 : EMP
{
	/// <summary>
	/// Percentage details
	/// </summary>
	public PCD? PercentageDetailsC { get; set; }

	/// <summary>
	/// Currencies
	/// </summary>
	public CUX? CurrenciesC { get; set; }

	/// <summary>
	/// Name and address
	/// </summary>
	public List<NAD>? NameAndAddressC { get; set; }

	/// <summary>
	/// SG6
	/// </summary>
	public List<SUPMAN_SG6>? SG6C { get; set; }

}

[EdiSegmentGroup("MOA", "PAT", "DTM")]
public class SUPMAN_SG6 : MOA
{
	/// <summary>
	/// Payment terms basis
	/// </summary>
	public PAT? PaymentTermsBasisC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("GIS", "DTM")]
public class SUPMAN_SG7 : GIS
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("MEM", "ATT", "COT")]
public class SUPMAN_SG8 : MEM
{
	/// <summary>
	/// SG9
	/// </summary>
	public List<SUPMAN_SG9>? SG9C { get; set; }

	/// <summary>
	/// SG10
	/// </summary>
	public List<SUPMAN_SG10>? SG10C { get; set; }

}

[EdiSegmentGroup("ATT", "PCD")]
public class SUPMAN_SG9 : ATT
{
	/// <summary>
	/// Percentage details
	/// </summary>
	public PCD? PercentageDetailsC { get; set; }
}

[EdiSegmentGroup("COT", "MOA", "PCD", "DTM", "PAT", "FTX")]
public class SUPMAN_SG10 : COT
{
	/// <summary>
	/// Monetary amount
	/// </summary>
	public MOA? MonetaryAmountC { get; set; }

	/// <summary>
	/// Percentage details
	/// </summary>
	public PCD? PercentageDetailsC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Payment terms basis
	/// </summary>
	public PAT? PaymentTermsBasisC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }
}