using System.Collections.Generic;
using Edi.Contracts.Segments;
using Edi.Contracts.Interfaces;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// MSCONS
/// </summary>
[EdiMessage]
public class MSCONS : IMessage
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
	public List<MSCONS_SG1>? SG1C { get; set; }

	/// <summary>
	/// SG2
	/// </summary>
	public List<MSCONS_SG2>? SG2C { get; set; }

	/// <summary>
	/// Section control
	/// </summary>
	public UNS? SectionControlM { get; set; }

	/// <summary>
	/// SG5
	/// </summary>
	public List<MSCONS_SG5>? SG5M { get; set; }

	/// <summary>
	/// Control total
	/// </summary>
	public List<CNT>? ControlTotalC { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class MSCONS_SG1 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("NAD", "RFF", "CTA")]
public class MSCONS_SG2 : NAD, ISegmentGroup
{
	/// <summary>
	/// SG3
	/// </summary>
	public List<MSCONS_SG3>? SG3C { get; set; }

	/// <summary>
	/// SG4
	/// </summary>
	public List<MSCONS_SG4>? SG4C { get; set; }

}

[EdiSegmentGroup("RFF", "DTM")]
public class MSCONS_SG3 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("CTA", "COM")]
public class MSCONS_SG4 : CTA, ISegmentGroup
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("NAD", "LOC")]
public class MSCONS_SG5 : NAD, ISegmentGroup
{
	/// <summary>
	/// SG6
	/// </summary>
	public List<MSCONS_SG6>? SG6M { get; set; }

}

[EdiSegmentGroup("LOC", "DTM", "RFF", "CCI", "LIN")]
public class MSCONS_SG6 : LOC, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// SG7
	/// </summary>
	public List<MSCONS_SG7>? SG7C { get; set; }

	/// <summary>
	/// SG8
	/// </summary>
	public List<MSCONS_SG8>? SG8C { get; set; }

	/// <summary>
	/// SG9
	/// </summary>
	public List<MSCONS_SG9>? SG9C { get; set; }

}

[EdiSegmentGroup("RFF", "DTM")]
public class MSCONS_SG7 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("CCI", "DTM")]
public class MSCONS_SG8 : CCI, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("LIN", "PIA", "IMD", "PRI", "NAD", "MOA", "QTY", "CCI")]
public class MSCONS_SG9 : LIN, ISegmentGroup
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
	/// Price details
	/// </summary>
	public List<PRI>? PriceDetailsC { get; set; }

	/// <summary>
	/// Name and address
	/// </summary>
	public List<NAD>? NameAndAddressC { get; set; }

	/// <summary>
	/// Monetary amount
	/// </summary>
	public List<MOA>? MonetaryAmountC { get; set; }

	/// <summary>
	/// SG10
	/// </summary>
	public List<MSCONS_SG10>? SG10M { get; set; }

	/// <summary>
	/// SG11
	/// </summary>
	public List<MSCONS_SG11>? SG11C { get; set; }

}

[EdiSegmentGroup("QTY", "DTM")]
public class MSCONS_SG10 : QTY, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("CCI", "MEA", "DTM")]
public class MSCONS_SG11 : CCI, ISegmentGroup
{
	/// <summary>
	/// Measurements
	/// </summary>
	public List<MEA>? MeasurementsC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}