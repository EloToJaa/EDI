using System.Collections.Generic;
using Edi.Contracts.Segments;
using Edi.Contracts.Interfaces;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// IFTSTQ
/// </summary>
[EdiMessage]
public class IFTSTQ : IMessage
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
	/// SG1
	/// </summary>
	public List<IFTSTQ_SG1>? SG1C { get; set; }

	/// <summary>
	/// Details of transport
	/// </summary>
	public List<TDT>? DetailsOfTransportC { get; set; }

	/// <summary>
	/// Equipment details
	/// </summary>
	public List<EQD>? EquipmentDetailsC { get; set; }

	/// <summary>
	/// SG2
	/// </summary>
	public List<IFTSTQ_SG2>? SG2C { get; set; }

	/// <summary>
	/// SG4
	/// </summary>
	public List<IFTSTQ_SG4>? SG4C { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class IFTSTQ_SG1 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("NAD", "CTA")]
public class IFTSTQ_SG2 : NAD, ISegmentGroup
{
	/// <summary>
	/// SG3
	/// </summary>
	public List<IFTSTQ_SG3>? SG3C { get; set; }

}

[EdiSegmentGroup("CTA", "COM")]
public class IFTSTQ_SG3 : CTA, ISegmentGroup
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("CNI", "DTM", "LOC", "RFF", "TDT", "EQD", "NAD")]
public class IFTSTQ_SG4 : CNI, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }

	/// <summary>
	/// Details of transport
	/// </summary>
	public List<TDT>? DetailsOfTransportC { get; set; }

	/// <summary>
	/// SG5
	/// </summary>
	public List<IFTSTQ_SG5>? SG5C { get; set; }

	/// <summary>
	/// SG6
	/// </summary>
	public List<IFTSTQ_SG6>? SG6C { get; set; }

}

[EdiSegmentGroup("EQD", "TPL")]
public class IFTSTQ_SG5 : EQD, ISegmentGroup
{
	/// <summary>
	/// Transport placement
	/// </summary>
	public List<TPL>? TransportPlacementC { get; set; }
}

[EdiSegmentGroup("NAD", "GID", "CTA")]
public class IFTSTQ_SG6 : NAD, ISegmentGroup
{
	/// <summary>
	/// SG7
	/// </summary>
	public List<IFTSTQ_SG7>? SG7C { get; set; }

	/// <summary>
	/// SG8
	/// </summary>
	public List<IFTSTQ_SG8>? SG8C { get; set; }

}

[EdiSegmentGroup("GID", "FTX", "SGP")]
public class IFTSTQ_SG7 : GID, ISegmentGroup
{
	/// <summary>
	/// Free text
	/// </summary>
	public FTX? FreeTextC { get; set; }

	/// <summary>
	/// Split goods placement
	/// </summary>
	public List<SGP>? SplitGoodsPlacementC { get; set; }
}

[EdiSegmentGroup("CTA", "COM")]
public class IFTSTQ_SG8 : CTA, ISegmentGroup
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}