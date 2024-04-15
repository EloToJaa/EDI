using System.Collections.Generic;
using Edi.Contracts.Segments;
using Edi.Contracts.Interfaces;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// BOPBNK
/// </summary>
[EdiMessage]
public class BOPBNK : IMessage
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
	public List<BOPBNK_SG1>? SG1C { get; set; }

	/// <summary>
	/// SG2
	/// </summary>
	public List<BOPBNK_SG2>? SG2M { get; set; }

	/// <summary>
	/// SG3
	/// </summary>
	public List<BOPBNK_SG3>? SG3M { get; set; }

	/// <summary>
	/// SG8
	/// </summary>
	public BOPBNK_SG8? SG8C { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class BOPBNK_SG1 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("NAD", "CTA", "COM")]
public class BOPBNK_SG2 : NAD, ISegmentGroup
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

[EdiSegmentGroup("LIN", "MOA", "RCS")]
public class BOPBNK_SG3 : LIN, ISegmentGroup
{
	/// <summary>
	/// Monetary amount
	/// </summary>
	public List<MOA>? MonetaryAmountC { get; set; }

	/// <summary>
	/// SG4
	/// </summary>
	public List<BOPBNK_SG4>? SG4M { get; set; }

}

[EdiSegmentGroup("RCS", "FTX", "MOA")]
public class BOPBNK_SG4 : RCS, ISegmentGroup
{
	/// <summary>
	/// Free text
	/// </summary>
	public FTX? FreeTextC { get; set; }

	/// <summary>
	/// SG5
	/// </summary>
	public List<BOPBNK_SG5>? SG5M { get; set; }

}

[EdiSegmentGroup("MOA", "GIR", "RFF", "NAD", "LOC")]
public class BOPBNK_SG5 : MOA, ISegmentGroup
{
	/// <summary>
	/// SG6
	/// </summary>
	public BOPBNK_SG6? SG6C { get; set; }

	/// <summary>
	/// SG7
	/// </summary>
	public BOPBNK_SG7? SG7C { get; set; }

	/// <summary>
	/// Name and address
	/// </summary>
	public NAD? NameAndAddressC { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }
}

[EdiSegmentGroup("GIR", "QTY", "PRI")]
public class BOPBNK_SG6 : GIR, ISegmentGroup
{
	/// <summary>
	/// Quantity
	/// </summary>
	public QTY? QuantityC { get; set; }

	/// <summary>
	/// Price details
	/// </summary>
	public PRI? PriceDetailsC { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class BOPBNK_SG7 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("AUT", "DTM")]
public class BOPBNK_SG8 : AUT, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}