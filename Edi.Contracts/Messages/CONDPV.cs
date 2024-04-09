using System.Collections.Generic;
using Edi.Contracts.Segments;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// CONDPV
/// </summary>
[EdiMessage]
public class CONDPV
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
	public List<CONDPV_SG1>? SG1C { get; set; }

	/// <summary>
	/// SG2
	/// </summary>
	public List<CONDPV_SG2>? SG2M { get; set; }

	/// <summary>
	/// SG6
	/// </summary>
	public List<CONDPV_SG6>? SG6C { get; set; }

	/// <summary>
	/// SG7
	/// </summary>
	public List<CONDPV_SG7>? SG7C { get; set; }

	/// <summary>
	/// SG8
	/// </summary>
	public List<CONDPV_SG8>? SG8C { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class CONDPV_SG1 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("NAD", "LOC", "FII", "RFF", "DOC", "CTA")]
public class CONDPV_SG2 : NAD
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
	public List<CONDPV_SG3>? SG3C { get; set; }

	/// <summary>
	/// SG4
	/// </summary>
	public List<CONDPV_SG4>? SG4C { get; set; }

	/// <summary>
	/// SG5
	/// </summary>
	public List<CONDPV_SG5>? SG5C { get; set; }

}

[EdiSegmentGroup("RFF", "DTM")]
public class CONDPV_SG3 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("DOC", "DTM")]
public class CONDPV_SG4 : DOC
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("CTA", "COM")]
public class CONDPV_SG5 : CTA
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("CUX", "DTM")]
public class CONDPV_SG6 : CUX
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("IND", "RFF", "DTM")]
public class CONDPV_SG7 : IND
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
public class CONDPV_SG8 : BII
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
	public List<CONDPV_SG9>? SG9C { get; set; }

	/// <summary>
	/// SG10
	/// </summary>
	public List<CONDPV_SG10>? SG10M { get; set; }

	/// <summary>
	/// SG12
	/// </summary>
	public List<CONDPV_SG12>? SG12C { get; set; }

}

[EdiSegmentGroup("APR", "DTM")]
public class CONDPV_SG9 : APR
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("ARD", "MOA", "FTX", "TAX")]
public class CONDPV_SG10 : ARD
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
	public List<CONDPV_SG11>? SG11C { get; set; }

}

[EdiSegmentGroup("TAX", "MOA", "LOC")]
public class CONDPV_SG11 : TAX
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

[EdiSegmentGroup("NAD", "LOC", "FII", "RFF", "DOC", "CTA")]
public class CONDPV_SG12 : NAD
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
	/// SG13
	/// </summary>
	public List<CONDPV_SG13>? SG13C { get; set; }

	/// <summary>
	/// SG14
	/// </summary>
	public List<CONDPV_SG14>? SG14C { get; set; }

	/// <summary>
	/// SG15
	/// </summary>
	public List<CONDPV_SG15>? SG15C { get; set; }

}

[EdiSegmentGroup("RFF", "DTM")]
public class CONDPV_SG13 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("DOC", "DTM")]
public class CONDPV_SG14 : DOC
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("CTA", "COM")]
public class CONDPV_SG15 : CTA
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}