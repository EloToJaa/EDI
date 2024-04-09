using System.Collections.Generic;
using Edi.Contracts.Segments;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// PAYDUC
/// </summary>
[EdiMessage]
public class PAYDUC
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
	/// Payment instructions
	/// </summary>
	public PAI? PaymentInstructionsM { get; set; }

	/// <summary>
	/// Financial institution information
	/// </summary>
	public List<FII>? FinancialInstitutionInformationM { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriod1M { get; set; }

	/// <summary>
	/// Currencies
	/// </summary>
	public CUX? Currencies1C { get; set; }

	/// <summary>
	/// Payment terms basis
	/// </summary>
	public PAT? PaymentTermsBasis1C { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeText1C { get; set; }

	/// <summary>
	/// SG1
	/// </summary>
	public List<PAYDUC_SG1>? SG1C { get; set; }

	/// <summary>
	/// SG2
	/// </summary>
	public List<PAYDUC_SG2>? SG2C { get; set; }

	/// <summary>
	/// SG4
	/// </summary>
	public List<PAYDUC_SG4>? SG4M { get; set; }

	/// <summary>
	/// Section control
	/// </summary>
	public UNS? SectionControlM { get; set; }

	/// <summary>
	/// Monetary amount
	/// </summary>
	public MOA? MonetaryAmount1M { get; set; }

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

[EdiSegmentGroup("RFF", "DTM")]
public class PAYDUC_SG1 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("NAD", "CTA")]
public class PAYDUC_SG2 : NAD
{
	/// <summary>
	/// SG3
	/// </summary>
	public List<PAYDUC_SG3>? SG3C { get; set; }

}

[EdiSegmentGroup("CTA", "COM")]
public class PAYDUC_SG3 : CTA
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public COM? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("GIS", "RFF", "MOA", "BUS", "CUX", "DTM")]
public class PAYDUC_SG4 : GIS
{
	/// <summary>
	/// Reference
	/// </summary>
	public RFF? ReferenceM { get; set; }

	/// <summary>
	/// Monetary amount
	/// </summary>
	public List<MOA>? MonetaryAmountM { get; set; }

	/// <summary>
	/// Business function
	/// </summary>
	public BUS? BusinessFunctionC { get; set; }

	/// <summary>
	/// Currencies
	/// </summary>
	public CUX? CurrenciesC { get; set; }

	/// <summary>
	/// SG5
	/// </summary>
	public List<PAYDUC_SG5>? SG5M { get; set; }

}

[EdiSegmentGroup("DTM", "NAD")]
public class PAYDUC_SG5 : DTM
{
	/// <summary>
	/// SG6
	/// </summary>
	public List<PAYDUC_SG6>? SG6C { get; set; }

}

[EdiSegmentGroup("NAD", "RFF", "MOA", "AJT", "PAT", "FTX")]
public class PAYDUC_SG6 : NAD
{
	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceM { get; set; }

	/// <summary>
	/// Monetary amount
	/// </summary>
	public List<MOA>? MonetaryAmountM { get; set; }

	/// <summary>
	/// Adjustment details
	/// </summary>
	public AJT? AdjustmentDetailsC { get; set; }

	/// <summary>
	/// Payment terms basis
	/// </summary>
	public PAT? PaymentTermsBasisC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }
}