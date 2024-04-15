using System.Collections.Generic;
using Edi.Contracts.Segments;
using Edi.Contracts.Interfaces;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// DELJIT
/// </summary>
[EdiMessage]
public class DELJIT : IMessage
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
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// SG1
	/// </summary>
	public List<DELJIT_SG1>? SG1C { get; set; }

	/// <summary>
	/// SG2
	/// </summary>
	public List<DELJIT_SG2>? SG2C { get; set; }

	/// <summary>
	/// SG4
	/// </summary>
	public List<DELJIT_SG4>? SG4M { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class DELJIT_SG1 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("NAD", "LOC", "FTX", "CTA")]
public class DELJIT_SG2 : NAD, ISegmentGroup
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// SG3
	/// </summary>
	public List<DELJIT_SG3>? SG3C { get; set; }

}

[EdiSegmentGroup("CTA", "COM")]
public class DELJIT_SG3 : CTA, ISegmentGroup
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("SEQ", "DTM", "GIR", "LOC", "PAC", "LIN")]
public class DELJIT_SG4 : SEQ, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Related identification numbers
	/// </summary>
	public List<GIR>? RelatedIdentificationNumbersC { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// SG5
	/// </summary>
	public List<DELJIT_SG5>? SG5C { get; set; }

	/// <summary>
	/// SG7
	/// </summary>
	public List<DELJIT_SG7>? SG7C { get; set; }

}

[EdiSegmentGroup("PAC", "PCI")]
public class DELJIT_SG5 : PAC, ISegmentGroup
{
	/// <summary>
	/// SG6
	/// </summary>
	public List<DELJIT_SG6>? SG6C { get; set; }

}

[EdiSegmentGroup("PCI", "GIN")]
public class DELJIT_SG6 : PCI, ISegmentGroup
{
	/// <summary>
	/// Goods identity number
	/// </summary>
	public List<GIN>? GoodsIdentityNumberC { get; set; }
}

[EdiSegmentGroup("LIN", "PIA", "IMD", "ALI", "GIR", "TDT", "FTX", "PAC", "DTM", "RFF", "LOC", "QTY")]
public class DELJIT_SG7 : LIN, ISegmentGroup
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
	/// Additional information
	/// </summary>
	public List<ALI>? AdditionalInformationC { get; set; }

	/// <summary>
	/// Related identification numbers
	/// </summary>
	public List<GIR>? RelatedIdentificationNumbersC { get; set; }

	/// <summary>
	/// Details of transport
	/// </summary>
	public List<TDT>? DetailsOfTransportC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// Package
	/// </summary>
	public List<PAC>? PackageC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// SG8
	/// </summary>
	public List<DELJIT_SG8>? SG8C { get; set; }

	/// <summary>
	/// SG9
	/// </summary>
	public List<DELJIT_SG9>? SG9C { get; set; }

	/// <summary>
	/// SG11
	/// </summary>
	public List<DELJIT_SG11>? SG11C { get; set; }

}

[EdiSegmentGroup("RFF", "DTM")]
public class DELJIT_SG8 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("LOC", "CTA")]
public class DELJIT_SG9 : LOC, ISegmentGroup
{
	/// <summary>
	/// SG10
	/// </summary>
	public List<DELJIT_SG10>? SG10C { get; set; }

}

[EdiSegmentGroup("CTA", "COM")]
public class DELJIT_SG10 : CTA, ISegmentGroup
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("QTY", "SCC", "DTM", "RFF")]
public class DELJIT_SG11 : QTY, ISegmentGroup
{
	/// <summary>
	/// Scheduling conditions
	/// </summary>
	public SCC? SchedulingConditionsC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// SG12
	/// </summary>
	public List<DELJIT_SG12>? SG12C { get; set; }

}

[EdiSegmentGroup("RFF", "DTM")]
public class DELJIT_SG12 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}