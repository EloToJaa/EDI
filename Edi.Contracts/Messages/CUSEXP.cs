using System.Collections.Generic;
using Edi.Contracts.Segments;
using Edi.Contracts.Interfaces;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// CUSEXP
/// </summary>
[EdiMessage]
public class CUSEXP : IMessage
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
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// Control total
	/// </summary>
	public List<CNT>? ControlTotalC { get; set; }

	/// <summary>
	/// SG1
	/// </summary>
	public CUSEXP_SG1? SG1M { get; set; }

	/// <summary>
	/// SG3
	/// </summary>
	public CUSEXP_SG3? SG3M { get; set; }

	/// <summary>
	/// SG5
	/// </summary>
	public List<CUSEXP_SG5>? SG5C { get; set; }

	/// <summary>
	/// SG6
	/// </summary>
	public List<CUSEXP_SG6>? SG6C { get; set; }

	/// <summary>
	/// SG17
	/// </summary>
	public CUSEXP_SG17? SG17C { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("NAD", "CTA")]
public class CUSEXP_SG1 : NAD, ISegmentGroup
{
	/// <summary>
	/// SG2
	/// </summary>
	public List<CUSEXP_SG2>? SG2C { get; set; }

}

[EdiSegmentGroup("CTA", "COM")]
public class CUSEXP_SG2 : CTA, ISegmentGroup
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("TDT", "DTM", "LOC")]
public class CUSEXP_SG3 : TDT, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }

	/// <summary>
	/// SG4
	/// </summary>
	public List<CUSEXP_SG4>? SG4C { get; set; }

}

[EdiSegmentGroup("LOC", "DTM")]
public class CUSEXP_SG4 : LOC, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("EQD", "SEL")]
public class CUSEXP_SG5 : EQD, ISegmentGroup
{
	/// <summary>
	/// Seal number
	/// </summary>
	public List<SEL>? SealNumberC { get; set; }
}

[EdiSegmentGroup("RFF", "NAD", "CNT", "CNI")]
public class CUSEXP_SG6 : RFF, ISegmentGroup
{
	/// <summary>
	/// Name and address
	/// </summary>
	public List<NAD>? NameAndAddressC { get; set; }

	/// <summary>
	/// Control total
	/// </summary>
	public CNT? ControlTotalC { get; set; }

	/// <summary>
	/// SG7
	/// </summary>
	public List<CUSEXP_SG7>? SG7M { get; set; }

}

[EdiSegmentGroup("CNI", "SGP", "CNT", "MEA", "LOC", "NAD", "GDS", "PAC", "TOD", "MOA", "TAX", "DOC", "CST")]
public class CUSEXP_SG7 : CNI, ISegmentGroup
{
	/// <summary>
	/// Split goods placement
	/// </summary>
	public List<SGP>? SplitGoodsPlacementC { get; set; }

	/// <summary>
	/// Control total
	/// </summary>
	public List<CNT>? ControlTotalC { get; set; }

	/// <summary>
	/// Measurements
	/// </summary>
	public MEA? MeasurementsC { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// Name and address
	/// </summary>
	public List<NAD>? NameAndAddressC { get; set; }

	/// <summary>
	/// SG8
	/// </summary>
	public CUSEXP_SG8? SG8C { get; set; }

	/// <summary>
	/// SG9
	/// </summary>
	public List<CUSEXP_SG9>? SG9C { get; set; }

	/// <summary>
	/// SG10
	/// </summary>
	public CUSEXP_SG10? SG10C { get; set; }

	/// <summary>
	/// SG11
	/// </summary>
	public List<CUSEXP_SG11>? SG11C { get; set; }

	/// <summary>
	/// SG13
	/// </summary>
	public List<CUSEXP_SG13>? SG13C { get; set; }

	/// <summary>
	/// SG14
	/// </summary>
	public List<CUSEXP_SG14>? SG14C { get; set; }

	/// <summary>
	/// SG15
	/// </summary>
	public List<CUSEXP_SG15>? SG15C { get; set; }

}

[EdiSegmentGroup("GDS", "FTX")]
public class CUSEXP_SG8 : GDS, ISegmentGroup
{
	/// <summary>
	/// Free text
	/// </summary>
	public FTX? FreeTextC { get; set; }
}

[EdiSegmentGroup("PAC", "PCI")]
public class CUSEXP_SG9 : PAC, ISegmentGroup
{
	/// <summary>
	/// Package identification
	/// </summary>
	public PCI? PackageIdentificationC { get; set; }
}

[EdiSegmentGroup("TOD", "LOC", "FTX")]
public class CUSEXP_SG10 : TOD, ISegmentGroup
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public LOC? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public FTX? FreeTextC { get; set; }
}

[EdiSegmentGroup("MOA", "CUX")]
public class CUSEXP_SG11 : MOA, ISegmentGroup
{
	/// <summary>
	/// SG12
	/// </summary>
	public CUSEXP_SG12? SG12C { get; set; }

}

[EdiSegmentGroup("CUX", "DTM")]
public class CUSEXP_SG12 : CUX, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("TAX", "MOA", "GIS")]
public class CUSEXP_SG13 : TAX, ISegmentGroup
{
	/// <summary>
	/// Monetary amount
	/// </summary>
	public MOA? MonetaryAmountC { get; set; }

	/// <summary>
	/// General indicator
	/// </summary>
	public GIS? GeneralIndicatorC { get; set; }
}

[EdiSegmentGroup("DOC", "DTM", "LOC")]
public class CUSEXP_SG14 : DOC, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public LOC? PlaceLocationIdentificationC { get; set; }
}

[EdiSegmentGroup("CST", "FTX", "LOC", "MEA", "TAX")]
public class CUSEXP_SG15 : CST, ISegmentGroup
{
	/// <summary>
	/// Free text
	/// </summary>
	public FTX? FreeTextC { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public LOC? PlaceLocationIdentificationM { get; set; }

	/// <summary>
	/// Measurements
	/// </summary>
	public List<MEA>? MeasurementsC { get; set; }

	/// <summary>
	/// SG16
	/// </summary>
	public List<CUSEXP_SG16>? SG16C { get; set; }

}

[EdiSegmentGroup("TAX", "MOA", "GIS")]
public class CUSEXP_SG16 : TAX, ISegmentGroup
{
	/// <summary>
	/// Monetary amount
	/// </summary>
	public MOA? MonetaryAmountC { get; set; }

	/// <summary>
	/// General indicator
	/// </summary>
	public GIS? GeneralIndicatorC { get; set; }
}

[EdiSegmentGroup("AUT", "DTM")]
public class CUSEXP_SG17 : AUT, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}