using System.Collections.Generic;
using Edi.Contracts.Segments;
using Edi.Contracts.Interfaces;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// SUPCOT
/// </summary>
[EdiMessage]
public class SUPCOT : IMessage
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
	public List<RFF>? ReferenceM { get; set; }

	/// <summary>
	/// Payment instructions
	/// </summary>
	public PAI? PaymentInstructionsC { get; set; }

	/// <summary>
	/// Currencies
	/// </summary>
	public CUX? CurrenciesC { get; set; }

	/// <summary>
	/// Financial institution information
	/// </summary>
	public List<FII>? FinancialInstitutionInformationC { get; set; }

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

	/// <summary>
	/// SG1
	/// </summary>
	public List<SUPCOT_SG1>? SG1C { get; set; }

	/// <summary>
	/// Section control
	/// </summary>
	public UNS? SectionControl1M { get; set; }

	/// <summary>
	/// SG3
	/// </summary>
	public List<SUPCOT_SG3>? SG3M { get; set; }

	/// <summary>
	/// Section control
	/// </summary>
	public UNS? SectionControl2M { get; set; }

	/// <summary>
	/// Monetary amount
	/// </summary>
	public MOA? MonetaryAmountM { get; set; }

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
public class SUPCOT_SG1 : NAD, ISegmentGroup
{
	/// <summary>
	/// SG2
	/// </summary>
	public List<SUPCOT_SG2>? SG2C { get; set; }

}

[EdiSegmentGroup("CTA", "COM")]
public class SUPCOT_SG2 : CTA, ISegmentGroup
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public COM? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("NAD", "ATT", "RFF", "DTM", "EMP", "LOC", "FTX", "PAT")]
public class SUPCOT_SG3 : NAD, ISegmentGroup
{
	/// <summary>
	/// Attribute
	/// </summary>
	public ATT? AttributeC { get; set; }

	/// <summary>
	/// Reference
	/// </summary>
	public RFF? ReferenceC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }

	/// <summary>
	/// Employment details
	/// </summary>
	public EMP? EmploymentDetailsC { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public LOC? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// SG4
	/// </summary>
	public List<SUPCOT_SG4>? SG4M { get; set; }

}

[EdiSegmentGroup("PAT", "MOA", "CUX", "DTM", "FTX", "COT")]
public class SUPCOT_SG4 : PAT, ISegmentGroup
{
	/// <summary>
	/// Monetary amount
	/// </summary>
	public MOA? MonetaryAmountC { get; set; }

	/// <summary>
	/// Currencies
	/// </summary>
	public CUX? CurrenciesC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// SG5
	/// </summary>
	public List<SUPCOT_SG5>? SG5M { get; set; }

}

[EdiSegmentGroup("COT", "MOA", "DTM", "FTX")]
public class SUPCOT_SG5 : COT, ISegmentGroup
{
	/// <summary>
	/// Monetary amount
	/// </summary>
	public MOA? MonetaryAmountM { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }
}