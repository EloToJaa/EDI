using System.Collections.Generic;
using Edi.Contracts.Segments;
using Edi.Contracts.Interfaces;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// BOPCUS
/// </summary>
[EdiMessage]
public class BOPCUS : IMessage
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
	/// SG1
	/// </summary>
	public List<BOPCUS_SG1>? SG1C { get; set; }

	/// <summary>
	/// SG2
	/// </summary>
	public List<BOPCUS_SG2>? SG2M { get; set; }

	/// <summary>
	/// SG3
	/// </summary>
	public List<BOPCUS_SG3>? SG3M { get; set; }

	/// <summary>
	/// SG9
	/// </summary>
	public BOPCUS_SG9? SG9C { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class BOPCUS_SG1 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("NAD", "CTA", "COM")]
public class BOPCUS_SG2 : NAD, ISegmentGroup
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

[EdiSegmentGroup("LIN", "FII", "DTM", "RFF", "NAD", "MOA", "DOC", "RCS")]
public class BOPCUS_SG3 : LIN, ISegmentGroup
{
	/// <summary>
	/// Financial institution information
	/// </summary>
	public FII? FinancialInstitutionInformationC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }

	/// <summary>
	/// SG4
	/// </summary>
	public List<BOPCUS_SG4>? SG4C { get; set; }

	/// <summary>
	/// SG5
	/// </summary>
	public List<BOPCUS_SG5>? SG5C { get; set; }

	/// <summary>
	/// SG6
	/// </summary>
	public BOPCUS_SG6? SG6C { get; set; }

	/// <summary>
	/// SG7
	/// </summary>
	public List<BOPCUS_SG7>? SG7C { get; set; }

	/// <summary>
	/// SG8
	/// </summary>
	public List<BOPCUS_SG8>? SG8M { get; set; }

}

[EdiSegmentGroup("RFF", "DTM")]
public class BOPCUS_SG4 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("NAD", "CTA", "COM")]
public class BOPCUS_SG5 : NAD, ISegmentGroup
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

[EdiSegmentGroup("MOA", "CUX")]
public class BOPCUS_SG6 : MOA, ISegmentGroup
{
	/// <summary>
	/// Currencies
	/// </summary>
	public CUX? CurrenciesC { get; set; }
}

[EdiSegmentGroup("DOC", "DTM")]
public class BOPCUS_SG7 : DOC, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("RCS", "FTX", "MOA", "LOC")]
public class BOPCUS_SG8 : RCS, ISegmentGroup
{
	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// Monetary amount
	/// </summary>
	public MOA? MonetaryAmountC { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }
}

[EdiSegmentGroup("AUT", "DTM")]
public class BOPCUS_SG9 : AUT, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}