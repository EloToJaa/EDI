using System.Collections.Generic;
using Edi.Contracts.Segments;
using Edi.Contracts.Interfaces;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// DESTIM
/// </summary>
[EdiMessage]
public class DESTIM : IMessage
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
	/// General indicator
	/// </summary>
	public GIS? GeneralIndicatorC { get; set; }

	/// <summary>
	/// Currencies
	/// </summary>
	public List<CUX>? CurrenciesC { get; set; }

	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// SG1
	/// </summary>
	public DESTIM_SG1? SG1M { get; set; }

	/// <summary>
	/// SG2
	/// </summary>
	public List<DESTIM_SG2>? SG2C { get; set; }

	/// <summary>
	/// SG4
	/// </summary>
	public DESTIM_SG4? SG4C { get; set; }

	/// <summary>
	/// Section control
	/// </summary>
	public UNS? SectionControlM { get; set; }

	/// <summary>
	/// SG5
	/// </summary>
	public List<DESTIM_SG5>? SG5C { get; set; }

	/// <summary>
	/// SG6
	/// </summary>
	public List<DESTIM_SG6>? SG6C { get; set; }

	/// <summary>
	/// SG7
	/// </summary>
	public List<DESTIM_SG7>? SG7C { get; set; }

	/// <summary>
	/// Control total
	/// </summary>
	public List<CNT>? ControlTotalC { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("EQD", "DIM", "IMD")]
public class DESTIM_SG1 : EQD, ISegmentGroup
{
	/// <summary>
	/// Dimensions
	/// </summary>
	public DIM? DimensionsC { get; set; }

	/// <summary>
	/// Item description
	/// </summary>
	public List<IMD>? ItemDescriptionC { get; set; }
}

[EdiSegmentGroup("NAD", "MOA", "CTA")]
public class DESTIM_SG2 : NAD, ISegmentGroup
{
	/// <summary>
	/// Monetary amount
	/// </summary>
	public List<MOA>? MonetaryAmountC { get; set; }

	/// <summary>
	/// SG3
	/// </summary>
	public List<DESTIM_SG3>? SG3C { get; set; }

}

[EdiSegmentGroup("CTA", "COM")]
public class DESTIM_SG3 : CTA, ISegmentGroup
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("TDT", "LOC", "DTM")]
public class DESTIM_SG4 : TDT, ISegmentGroup
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("DTM", "LOC", "NAD")]
public class DESTIM_SG5 : DTM, ISegmentGroup
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public LOC? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// Name and address
	/// </summary>
	public List<NAD>? NameAndAddressC { get; set; }
}

[EdiSegmentGroup("RFF", "DTM", "NAD", "MOA")]
public class DESTIM_SG6 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }

	/// <summary>
	/// Name and address
	/// </summary>
	public List<NAD>? NameAndAddressC { get; set; }

	/// <summary>
	/// Monetary amount
	/// </summary>
	public MOA? MonetaryAmountC { get; set; }
}

[EdiSegmentGroup("LIN", "DIM", "QTY", "FTX", "DAM", "RTE", "NAD")]
public class DESTIM_SG7 : LIN, ISegmentGroup
{
	/// <summary>
	/// Dimensions
	/// </summary>
	public DIM? DimensionsC { get; set; }

	/// <summary>
	/// Quantity
	/// </summary>
	public QTY? QuantityC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// SG8
	/// </summary>
	public DESTIM_SG8? SG8C { get; set; }

	/// <summary>
	/// SG9
	/// </summary>
	public List<DESTIM_SG9>? SG9C { get; set; }

	/// <summary>
	/// SG10
	/// </summary>
	public List<DESTIM_SG10>? SG10C { get; set; }

}

[EdiSegmentGroup("DAM", "COD")]
public class DESTIM_SG8 : DAM, ISegmentGroup
{
	/// <summary>
	/// Component details
	/// </summary>
	public COD? ComponentDetailsC { get; set; }
}

[EdiSegmentGroup("RTE", "QTY")]
public class DESTIM_SG9 : RTE, ISegmentGroup
{
	/// <summary>
	/// Quantity
	/// </summary>
	public QTY? QuantityM { get; set; }
}

[EdiSegmentGroup("NAD", "MOA")]
public class DESTIM_SG10 : NAD, ISegmentGroup
{
	/// <summary>
	/// SG11
	/// </summary>
	public List<DESTIM_SG11>? SG11M { get; set; }

}

[EdiSegmentGroup("MOA", "TAX", "MEA")]
public class DESTIM_SG11 : MOA, ISegmentGroup
{
	/// <summary>
	/// Duty/tax/fee details
	/// </summary>
	public TAX? DutyTaxFeeDetailsC { get; set; }

	/// <summary>
	/// Measurements
	/// </summary>
	public MEA? MeasurementsC { get; set; }
}