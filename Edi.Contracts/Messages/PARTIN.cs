using System.Collections.Generic;
using Edi.Contracts.Segments;
using Edi.Contracts.Interfaces;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// PARTIN
/// </summary>
[EdiMessage]
public class PARTIN : IMessage
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
	public List<DTM>? DateTimePeriodM { get; set; }

	/// <summary>
	/// Financial institution information
	/// </summary>
	public List<FII>? FinancialInstitutionInformationC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// SG1
	/// </summary>
	public List<PARTIN_SG1>? SG1C { get; set; }

	/// <summary>
	/// SG2
	/// </summary>
	public List<PARTIN_SG2>? SG2C { get; set; }

	/// <summary>
	/// Section control
	/// </summary>
	public UNS? SectionControlM { get; set; }

	/// <summary>
	/// SG4
	/// </summary>
	public List<PARTIN_SG4>? SG4C { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class PARTIN_SG1 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("NAD", "CTA")]
public class PARTIN_SG2 : NAD, ISegmentGroup
{
	/// <summary>
	/// SG3
	/// </summary>
	public List<PARTIN_SG3>? SG3C { get; set; }

}

[EdiSegmentGroup("CTA", "COM")]
public class PARTIN_SG3 : CTA, ISegmentGroup
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("NAD", "DTM", "FII", "LOC", "RFF", "CTA", "SCC", "TOD", "PAI")]
public class PARTIN_SG4 : NAD, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Financial institution information
	/// </summary>
	public List<FII>? FinancialInstitutionInformationC { get; set; }

	/// <summary>
	/// SG5
	/// </summary>
	public List<PARTIN_SG5>? SG5C { get; set; }

	/// <summary>
	/// SG6
	/// </summary>
	public List<PARTIN_SG6>? SG6C { get; set; }

	/// <summary>
	/// SG7
	/// </summary>
	public List<PARTIN_SG7>? SG7C { get; set; }

	/// <summary>
	/// SG8
	/// </summary>
	public List<PARTIN_SG8>? SG8C { get; set; }

	/// <summary>
	/// SG9
	/// </summary>
	public PARTIN_SG9? SG9C { get; set; }

	/// <summary>
	/// SG10
	/// </summary>
	public PARTIN_SG10? SG10C { get; set; }

}

[EdiSegmentGroup("LOC", "DTM")]
public class PARTIN_SG5 : LOC, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class PARTIN_SG6 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("CTA", "COM")]
public class PARTIN_SG7 : CTA, ISegmentGroup
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("SCC", "DTM")]
public class PARTIN_SG8 : SCC, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("TOD", "LOC")]
public class PARTIN_SG9 : TOD, ISegmentGroup
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public LOC? PlaceLocationIdentificationC { get; set; }
}

[EdiSegmentGroup("PAI", "PAT", "CUX")]
public class PARTIN_SG10 : PAI, ISegmentGroup
{
	/// <summary>
	/// Payment terms basis
	/// </summary>
	public PAT? PaymentTermsBasisC { get; set; }

	/// <summary>
	/// Currencies
	/// </summary>
	public List<CUX>? CurrenciesC { get; set; }
}