using System.Collections.Generic;
using Edi.Contracts.Segments;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// SLSRPT
/// </summary>
[EdiMessage]
public class SLSRPT
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
	/// SG1
	/// </summary>
	public List<SLSRPT_SG1>? SG1M { get; set; }

	/// <summary>
	/// SG3
	/// </summary>
	public List<SLSRPT_SG3>? SG3C { get; set; }

	/// <summary>
	/// SG4
	/// </summary>
	public List<SLSRPT_SG4>? SG4C { get; set; }

	/// <summary>
	/// SG5
	/// </summary>
	public List<SLSRPT_SG5>? SG5C { get; set; }

	/// <summary>
	/// SG9
	/// </summary>
	public SLSRPT_SG9? SG9C { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("NAD", "CTA")]
public class SLSRPT_SG1 : NAD
{
	/// <summary>
	/// SG2
	/// </summary>
	public List<SLSRPT_SG2>? SG2C { get; set; }

}

[EdiSegmentGroup("CTA", "COM")]
public class SLSRPT_SG2 : CTA
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class SLSRPT_SG3 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("CUX", "DTM")]
public class SLSRPT_SG4 : CUX
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("LOC", "DTM", "RFF", "LIN")]
public class SLSRPT_SG5 : LOC
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// SG6
	/// </summary>
	public List<SLSRPT_SG6>? SG6C { get; set; }

	/// <summary>
	/// SG7
	/// </summary>
	public List<SLSRPT_SG7>? SG7C { get; set; }

}

[EdiSegmentGroup("RFF", "DTM")]
public class SLSRPT_SG6 : RFF
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("LIN", "PIA", "IMD", "PAC", "RFF", "DOC", "ALI", "MOA", "PRI", "GIN", "QTY")]
public class SLSRPT_SG7 : LIN
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
	/// Goods identity number
	/// </summary>
	public List<GIN>? GoodsIdentityNumberC { get; set; }

	/// <summary>
	/// SG8
	/// </summary>
	public List<SLSRPT_SG8>? SG8C { get; set; }

}

[EdiSegmentGroup("QTY", "MKS", "NAD", "PRI", "DTM", "RFF")]
public class SLSRPT_SG8 : QTY
{
	/// <summary>
	/// Market/sales channel information
	/// </summary>
	public MKS? MarketSalesChannelInformationC { get; set; }

	/// <summary>
	/// Name and address
	/// </summary>
	public NAD? NameAndAddressC { get; set; }

	/// <summary>
	/// Price details
	/// </summary>
	public List<PRI>? PriceDetailsC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }
}

[EdiSegmentGroup("GIS", "LIN")]
public class SLSRPT_SG9 : GIS
{
	/// <summary>
	/// SG10
	/// </summary>
	public List<SLSRPT_SG10>? SG10C { get; set; }

}

[EdiSegmentGroup("LIN", "PIA", "IMD", "PAC", "MOA", "LOC")]
public class SLSRPT_SG10 : LIN
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
	/// Monetary amount
	/// </summary>
	public List<MOA>? MonetaryAmountC { get; set; }

	/// <summary>
	/// SG11
	/// </summary>
	public List<SLSRPT_SG11>? SG11C { get; set; }

}

[EdiSegmentGroup("LOC", "RFF", "DTM", "MOA", "QTY")]
public class SLSRPT_SG11 : LOC
{
	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Monetary amount
	/// </summary>
	public List<MOA>? MonetaryAmountC { get; set; }

	/// <summary>
	/// SG12
	/// </summary>
	public List<SLSRPT_SG12>? SG12C { get; set; }

}

[EdiSegmentGroup("QTY", "PRI", "DTM", "RFF")]
public class SLSRPT_SG12 : QTY
{
	/// <summary>
	/// Price details
	/// </summary>
	public List<PRI>? PriceDetailsC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }
}