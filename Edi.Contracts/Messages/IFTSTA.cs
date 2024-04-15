using System.Collections.Generic;
using Edi.Contracts.Segments;
using Edi.Contracts.Interfaces;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// IFTSTA
/// </summary>
[EdiMessage]
public class IFTSTA : IMessage
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
	/// Transport service requirements
	/// </summary>
	public TSR? TransportServiceRequirementsC { get; set; }

	/// <summary>
	/// SG1
	/// </summary>
	public List<IFTSTA_SG1>? SG1C { get; set; }

	/// <summary>
	/// SG3
	/// </summary>
	public List<IFTSTA_SG3>? SG3C { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// Control total
	/// </summary>
	public List<CNT>? ControlTotalC { get; set; }

	/// <summary>
	/// SG4
	/// </summary>
	public List<IFTSTA_SG4>? SG4C { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("NAD", "CTA")]
public class IFTSTA_SG1 : NAD, ISegmentGroup
{
	/// <summary>
	/// SG2
	/// </summary>
	public List<IFTSTA_SG2>? SG2C { get; set; }

}

[EdiSegmentGroup("CTA", "COM")]
public class IFTSTA_SG2 : CTA, ISegmentGroup
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class IFTSTA_SG3 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("CNI", "LOC", "CNT", "STS")]
public class IFTSTA_SG4 : CNI, ISegmentGroup
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// Control total
	/// </summary>
	public List<CNT>? ControlTotalC { get; set; }

	/// <summary>
	/// SG5
	/// </summary>
	public List<IFTSTA_SG5>? SG5M { get; set; }

}

[EdiSegmentGroup("STS", "RFF", "DTM", "DOC", "FTX", "NAD", "LOC", "PCI", "TDT", "EQD", "GID")]
public class IFTSTA_SG5 : STS, ISegmentGroup
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
	/// Document/message details
	/// </summary>
	public DOC? DocumentMessageDetailsC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// Name and address
	/// </summary>
	public List<NAD>? NameAndAddressC { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public LOC? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// Package identification
	/// </summary>
	public List<PCI>? PackageIdentificationC { get; set; }

	/// <summary>
	/// SG6
	/// </summary>
	public List<IFTSTA_SG6>? SG6C { get; set; }

	/// <summary>
	/// SG7
	/// </summary>
	public List<IFTSTA_SG7>? SG7C { get; set; }

	/// <summary>
	/// SG9
	/// </summary>
	public List<IFTSTA_SG9>? SG9C { get; set; }

}

[EdiSegmentGroup("TDT", "RFF", "LOC", "DTM")]
public class IFTSTA_SG6 : TDT, ISegmentGroup
{
	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("EQD", "MEA", "DIM", "SEL", "TPL", "EQA")]
public class IFTSTA_SG7 : EQD, ISegmentGroup
{
	/// <summary>
	/// Measurements
	/// </summary>
	public List<MEA>? MeasurementsC { get; set; }

	/// <summary>
	/// Dimensions
	/// </summary>
	public List<DIM>? DimensionsC { get; set; }

	/// <summary>
	/// Seal number
	/// </summary>
	public List<SEL>? SealNumberC { get; set; }

	/// <summary>
	/// Transport placement
	/// </summary>
	public List<TPL>? TransportPlacementC { get; set; }

	/// <summary>
	/// SG8
	/// </summary>
	public List<IFTSTA_SG8>? SG8C { get; set; }

}

[EdiSegmentGroup("EQA", "SEL")]
public class IFTSTA_SG8 : EQA, ISegmentGroup
{
	/// <summary>
	/// Seal number
	/// </summary>
	public List<SEL>? SealNumberC { get; set; }
}

[EdiSegmentGroup("GID", "HAN", "SGP", "DGS", "FTX", "MEA", "DIM", "PCI")]
public class IFTSTA_SG9 : GID, ISegmentGroup
{
	/// <summary>
	/// Handling instructions
	/// </summary>
	public List<HAN>? HandlingInstructionsC { get; set; }

	/// <summary>
	/// Split goods placement
	/// </summary>
	public List<SGP>? SplitGoodsPlacementC { get; set; }

	/// <summary>
	/// Dangerous goods
	/// </summary>
	public List<DGS>? DangerousGoodsC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// SG10
	/// </summary>
	public List<IFTSTA_SG10>? SG10C { get; set; }

	/// <summary>
	/// SG11
	/// </summary>
	public List<IFTSTA_SG11>? SG11C { get; set; }

	/// <summary>
	/// SG12
	/// </summary>
	public List<IFTSTA_SG12>? SG12C { get; set; }

}

[EdiSegmentGroup("MEA", "EQN")]
public class IFTSTA_SG10 : MEA, ISegmentGroup
{
	/// <summary>
	/// Number of units
	/// </summary>
	public EQN? NumberOfUnitsC { get; set; }
}

[EdiSegmentGroup("DIM", "EQN")]
public class IFTSTA_SG11 : DIM, ISegmentGroup
{
	/// <summary>
	/// Number of units
	/// </summary>
	public EQN? NumberOfUnitsC { get; set; }
}

[EdiSegmentGroup("PCI", "GIN")]
public class IFTSTA_SG12 : PCI, ISegmentGroup
{
	/// <summary>
	/// Goods identity number
	/// </summary>
	public List<GIN>? GoodsIdentityNumberC { get; set; }
}