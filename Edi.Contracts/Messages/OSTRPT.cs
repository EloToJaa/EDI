using System.Collections.Generic;
using Edi.Contracts.Segments;
using Edi.Contracts.Interfaces;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// OSTRPT
/// </summary>
[EdiMessage]
public class OSTRPT : IMessage
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
	/// Reference
	/// </summary>
	public RFF? ReferenceC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// SG1
	/// </summary>
	public List<OSTRPT_SG1>? SG1M { get; set; }

	/// <summary>
	/// SG3
	/// </summary>
	public List<OSTRPT_SG3>? SG3M { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("NAD", "CTA")]
public class OSTRPT_SG1 : NAD, ISegmentGroup
{
	/// <summary>
	/// SG2
	/// </summary>
	public List<OSTRPT_SG2>? SG2C { get; set; }

}

[EdiSegmentGroup("CTA", "COM")]
public class OSTRPT_SG2 : CTA, ISegmentGroup
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("DOC", "DTM", "STS", "LIN")]
public class OSTRPT_SG3 : DOC, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// SG4
	/// </summary>
	public List<OSTRPT_SG4>? SG4C { get; set; }

	/// <summary>
	/// SG5
	/// </summary>
	public List<OSTRPT_SG5>? SG5C { get; set; }

}

[EdiSegmentGroup("STS", "DTM", "PCD", "QTY", "NAD")]
public class OSTRPT_SG4 : STS, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Percentage details
	/// </summary>
	public PCD? PercentageDetailsC { get; set; }

	/// <summary>
	/// Quantity
	/// </summary>
	public QTY? QuantityC { get; set; }

	/// <summary>
	/// Name and address
	/// </summary>
	public NAD? NameAndAddressC { get; set; }
}

[EdiSegmentGroup("LIN", "PIA", "IMD", "MEA", "GIN", "RCS", "FTX", "RFF", "STS", "SCC")]
public class OSTRPT_SG5 : LIN, ISegmentGroup
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
	/// Measurements
	/// </summary>
	public List<MEA>? MeasurementsC { get; set; }

	/// <summary>
	/// Goods identity number
	/// </summary>
	public List<GIN>? GoodsIdentityNumberC { get; set; }

	/// <summary>
	/// Requirements and conditions
	/// </summary>
	public List<RCS>? RequirementsAndConditionsC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// SG6
	/// </summary>
	public List<OSTRPT_SG6>? SG6C { get; set; }

	/// <summary>
	/// SG7
	/// </summary>
	public List<OSTRPT_SG7>? SG7C { get; set; }

	/// <summary>
	/// SG15
	/// </summary>
	public List<OSTRPT_SG15>? SG15C { get; set; }

}

[EdiSegmentGroup("RFF", "DTM")]
public class OSTRPT_SG6 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("STS", "DTM", "PCD", "QTY", "NAD", "TDT", "TOD", "EQD", "PAC")]
public class OSTRPT_SG7 : STS, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Percentage details
	/// </summary>
	public PCD? PercentageDetailsC { get; set; }

	/// <summary>
	/// Quantity
	/// </summary>
	public QTY? QuantityC { get; set; }

	/// <summary>
	/// SG8
	/// </summary>
	public List<OSTRPT_SG8>? SG8C { get; set; }

	/// <summary>
	/// SG10
	/// </summary>
	public List<OSTRPT_SG10>? SG10C { get; set; }

	/// <summary>
	/// SG11
	/// </summary>
	public List<OSTRPT_SG11>? SG11C { get; set; }

	/// <summary>
	/// SG12
	/// </summary>
	public List<OSTRPT_SG12>? SG12C { get; set; }

	/// <summary>
	/// SG13
	/// </summary>
	public OSTRPT_SG13? SG13C { get; set; }

}

[EdiSegmentGroup("NAD", "RFF", "CTA")]
public class OSTRPT_SG8 : NAD, ISegmentGroup
{
	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }

	/// <summary>
	/// SG9
	/// </summary>
	public List<OSTRPT_SG9>? SG9C { get; set; }

}

[EdiSegmentGroup("CTA", "COM")]
public class OSTRPT_SG9 : CTA, ISegmentGroup
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("TDT", "LOC")]
public class OSTRPT_SG10 : TDT, ISegmentGroup
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public LOC? PlaceLocationIdentificationC { get; set; }
}

[EdiSegmentGroup("TOD", "LOC")]
public class OSTRPT_SG11 : TOD, ISegmentGroup
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public LOC? PlaceLocationIdentificationC { get; set; }
}

[EdiSegmentGroup("EQD", "HAN")]
public class OSTRPT_SG12 : EQD, ISegmentGroup
{
	/// <summary>
	/// Handling instructions
	/// </summary>
	public List<HAN>? HandlingInstructionsC { get; set; }
}

[EdiSegmentGroup("PAC", "QTY", "PCI")]
public class OSTRPT_SG13 : PAC, ISegmentGroup
{
	/// <summary>
	/// Quantity
	/// </summary>
	public QTY? QuantityC { get; set; }

	/// <summary>
	/// SG14
	/// </summary>
	public List<OSTRPT_SG14>? SG14C { get; set; }

}

[EdiSegmentGroup("PCI", "RFF")]
public class OSTRPT_SG14 : PCI, ISegmentGroup
{
	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }
}

[EdiSegmentGroup("SCC", "LOC")]
public class OSTRPT_SG15 : SCC, ISegmentGroup
{
	/// <summary>
	/// SG16
	/// </summary>
	public List<OSTRPT_SG16>? SG16C { get; set; }

}

[EdiSegmentGroup("LOC", "DTM", "QTY", "STS")]
public class OSTRPT_SG16 : LOC, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Quantity
	/// </summary>
	public QTY? QuantityC { get; set; }

	/// <summary>
	/// SG17
	/// </summary>
	public List<OSTRPT_SG17>? SG17C { get; set; }

}

[EdiSegmentGroup("STS", "DTM", "PCD", "QTY", "NAD")]
public class OSTRPT_SG17 : STS, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Percentage details
	/// </summary>
	public PCD? PercentageDetailsC { get; set; }

	/// <summary>
	/// Quantity
	/// </summary>
	public QTY? QuantityC { get; set; }

	/// <summary>
	/// Name and address
	/// </summary>
	public NAD? NameAndAddressC { get; set; }
}