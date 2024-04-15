using System.Collections.Generic;
using Edi.Contracts.Segments;
using Edi.Contracts.Interfaces;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// SLSFCT
/// </summary>
[EdiMessage]
public class SLSFCT : IMessage
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
	public List<SLSFCT_SG1>? SG1M { get; set; }

	/// <summary>
	/// SG3
	/// </summary>
	public List<SLSFCT_SG3>? SG3C { get; set; }

	/// <summary>
	/// SG4
	/// </summary>
	public List<SLSFCT_SG4>? SG4C { get; set; }

	/// <summary>
	/// SG5
	/// </summary>
	public List<SLSFCT_SG5>? SG5M { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("NAD", "CTA")]
public class SLSFCT_SG1 : NAD, ISegmentGroup
{
	/// <summary>
	/// SG2
	/// </summary>
	public List<SLSFCT_SG2>? SG2C { get; set; }

}

[EdiSegmentGroup("CTA", "COM")]
public class SLSFCT_SG2 : CTA, ISegmentGroup
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class SLSFCT_SG3 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("CUX", "DTM")]
public class SLSFCT_SG4 : CUX, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("LOC", "DTM", "LIN")]
public class SLSFCT_SG5 : LOC, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// SG6
	/// </summary>
	public List<SLSFCT_SG6>? SG6C { get; set; }

}

[EdiSegmentGroup("LIN", "PIA", "IMD", "PAC", "RFF", "DOC", "ALI", "MOA", "PRI", "QTY")]
public class SLSFCT_SG6 : LIN, ISegmentGroup
{
	/// <summary>
	/// Additional product id
	/// </summary>
	public List<PIA>? AdditionalProductIdC { get; set; }

	/// <summary>
	/// Item description
	/// </summary>
	public List<IMD>? ItemDescriptionC { get; set; }

	/// <summary>
	/// Package
	/// </summary>
	public List<PAC>? PackageC { get; set; }

	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }

	/// <summary>
	/// Document/message details
	/// </summary>
	public List<DOC>? DocumentMessageDetailsC { get; set; }

	/// <summary>
	/// Additional information
	/// </summary>
	public List<ALI>? AdditionalInformationC { get; set; }

	/// <summary>
	/// Monetary amount
	/// </summary>
	public List<MOA>? MonetaryAmountC { get; set; }

	/// <summary>
	/// Price details
	/// </summary>
	public List<PRI>? PriceDetailsC { get; set; }

	/// <summary>
	/// SG7
	/// </summary>
	public List<SLSFCT_SG7>? SG7C { get; set; }

}

[EdiSegmentGroup("QTY", "MKS", "NAD")]
public class SLSFCT_SG7 : QTY, ISegmentGroup
{
	/// <summary>
	/// Market/sales channel information
	/// </summary>
	public MKS? MarketSalesChannelInformationC { get; set; }

	/// <summary>
	/// Name and address
	/// </summary>
	public NAD? NameAndAddressC { get; set; }
}