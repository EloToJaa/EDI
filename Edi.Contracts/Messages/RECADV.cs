using System.Collections.Generic;
using Edi.Contracts.Segments;
using Edi.Contracts.Interfaces;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// RECADV
/// </summary>
[EdiMessage]
public class RECADV : IMessage
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
	/// Additional information
	/// </summary>
	public List<ALI>? AdditionalInformationC { get; set; }

	/// <summary>
	/// SG1
	/// </summary>
	public List<RECADV_SG1>? SG1C { get; set; }

	/// <summary>
	/// SG2
	/// </summary>
	public List<RECADV_SG2>? SG2C { get; set; }

	/// <summary>
	/// SG4
	/// </summary>
	public List<RECADV_SG4>? SG4M { get; set; }

	/// <summary>
	/// SG7
	/// </summary>
	public List<RECADV_SG7>? SG7C { get; set; }

	/// <summary>
	/// SG10
	/// </summary>
	public List<RECADV_SG10>? SG10C { get; set; }

	/// <summary>
	/// SG11
	/// </summary>
	public List<RECADV_SG11>? SG11C { get; set; }

	/// <summary>
	/// SG16
	/// </summary>
	public List<RECADV_SG16>? SG16C { get; set; }

	/// <summary>
	/// Control total
	/// </summary>
	public CNT? ControlTotalC { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class RECADV_SG1 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("DOC", "CDI")]
public class RECADV_SG2 : DOC, ISegmentGroup
{
	/// <summary>
	/// SG3
	/// </summary>
	public List<RECADV_SG3>? SG3C { get; set; }

}

[EdiSegmentGroup("CDI", "INP")]
public class RECADV_SG3 : CDI, ISegmentGroup
{
	/// <summary>
	/// Parties to instruction
	/// </summary>
	public List<INP>? PartiesToInstructionC { get; set; }
}

[EdiSegmentGroup("NAD", "LOC", "RFF", "CTA")]
public class RECADV_SG4 : NAD, ISegmentGroup
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// SG5
	/// </summary>
	public List<RECADV_SG5>? SG5C { get; set; }

	/// <summary>
	/// SG6
	/// </summary>
	public List<RECADV_SG6>? SG6C { get; set; }

}

[EdiSegmentGroup("RFF", "DTM")]
public class RECADV_SG5 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("CTA", "COM")]
public class RECADV_SG6 : CTA, ISegmentGroup
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("TOD", "CDI", "LOC")]
public class RECADV_SG7 : TOD, ISegmentGroup
{
	/// <summary>
	/// SG8
	/// </summary>
	public List<RECADV_SG8>? SG8C { get; set; }

	/// <summary>
	/// SG9
	/// </summary>
	public List<RECADV_SG9>? SG9C { get; set; }

}

[EdiSegmentGroup("CDI", "INP")]
public class RECADV_SG8 : CDI, ISegmentGroup
{
	/// <summary>
	/// Parties to instruction
	/// </summary>
	public List<INP>? PartiesToInstructionC { get; set; }
}

[EdiSegmentGroup("LOC", "CDI")]
public class RECADV_SG9 : LOC, ISegmentGroup
{
	/// <summary>
	/// Physical or logical state
	/// </summary>
	public List<CDI>? PhysicalOrLogicalStateC { get; set; }
}

[EdiSegmentGroup("TDT", "DTM", "CDI")]
public class RECADV_SG10 : TDT, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Physical or logical state
	/// </summary>
	public List<CDI>? PhysicalOrLogicalStateC { get; set; }
}

[EdiSegmentGroup("EQD", "CDI", "SEL", "EQA")]
public class RECADV_SG11 : EQD, ISegmentGroup
{
	/// <summary>
	/// SG12
	/// </summary>
	public List<RECADV_SG12>? SG12C { get; set; }

	/// <summary>
	/// SG13
	/// </summary>
	public List<RECADV_SG13>? SG13C { get; set; }

	/// <summary>
	/// SG14
	/// </summary>
	public List<RECADV_SG14>? SG14C { get; set; }

}

[EdiSegmentGroup("CDI", "INP")]
public class RECADV_SG12 : CDI, ISegmentGroup
{
	/// <summary>
	/// Parties to instruction
	/// </summary>
	public List<INP>? PartiesToInstructionC { get; set; }
}

[EdiSegmentGroup("SEL", "CDI")]
public class RECADV_SG13 : SEL, ISegmentGroup
{
	/// <summary>
	/// Physical or logical state
	/// </summary>
	public List<CDI>? PhysicalOrLogicalStateM { get; set; }
}

[EdiSegmentGroup("EQA", "CDI")]
public class RECADV_SG14 : EQA, ISegmentGroup
{
	/// <summary>
	/// SG15
	/// </summary>
	public List<RECADV_SG15>? SG15C { get; set; }

}

[EdiSegmentGroup("CDI", "INP")]
public class RECADV_SG15 : CDI, ISegmentGroup
{
	/// <summary>
	/// Parties to instruction
	/// </summary>
	public List<INP>? PartiesToInstructionC { get; set; }
}

[EdiSegmentGroup("CPS", "PAC", "LIN")]
public class RECADV_SG16 : CPS, ISegmentGroup
{
	/// <summary>
	/// SG17
	/// </summary>
	public List<RECADV_SG17>? SG17C { get; set; }

	/// <summary>
	/// SG22
	/// </summary>
	public List<RECADV_SG22>? SG22C { get; set; }

}

[EdiSegmentGroup("PAC", "QVR", "PCI")]
public class RECADV_SG17 : PAC, ISegmentGroup
{
	/// <summary>
	/// Quantity variances
	/// </summary>
	public QVR? QuantityVariancesC { get; set; }

	/// <summary>
	/// SG18
	/// </summary>
	public List<RECADV_SG18>? SG18C { get; set; }

}

[EdiSegmentGroup("PCI", "RFF", "CDI", "GIN")]
public class RECADV_SG18 : PCI, ISegmentGroup
{
	/// <summary>
	/// Reference
	/// </summary>
	public RFF? ReferenceC { get; set; }

	/// <summary>
	/// SG19
	/// </summary>
	public List<RECADV_SG19>? SG19C { get; set; }

	/// <summary>
	/// SG20
	/// </summary>
	public List<RECADV_SG20>? SG20C { get; set; }

}

[EdiSegmentGroup("CDI", "INP")]
public class RECADV_SG19 : CDI, ISegmentGroup
{
	/// <summary>
	/// Parties to instruction
	/// </summary>
	public List<INP>? PartiesToInstructionC { get; set; }
}

[EdiSegmentGroup("GIN", "CDI")]
public class RECADV_SG20 : GIN, ISegmentGroup
{
	/// <summary>
	/// SG21
	/// </summary>
	public List<RECADV_SG21>? SG21C { get; set; }

}

[EdiSegmentGroup("CDI", "INP")]
public class RECADV_SG21 : CDI, ISegmentGroup
{
	/// <summary>
	/// Parties to instruction
	/// </summary>
	public List<INP>? PartiesToInstructionC { get; set; }
}

[EdiSegmentGroup("LIN", "PIA", "IMD", "QTY", "QVR", "DTM", "PRI", "CDI", "DOC", "GIN", "RFF", "PCI")]
public class RECADV_SG22 : LIN, ISegmentGroup
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
	/// Quantity
	/// </summary>
	public List<QTY>? QuantityC { get; set; }

	/// <summary>
	/// Quantity variances
	/// </summary>
	public List<QVR>? QuantityVariancesC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Price details
	/// </summary>
	public PRI? PriceDetailsC { get; set; }

	/// <summary>
	/// SG23
	/// </summary>
	public List<RECADV_SG23>? SG23C { get; set; }

	/// <summary>
	/// SG24
	/// </summary>
	public List<RECADV_SG24>? SG24C { get; set; }

	/// <summary>
	/// SG26
	/// </summary>
	public List<RECADV_SG26>? SG26C { get; set; }

	/// <summary>
	/// SG28
	/// </summary>
	public List<RECADV_SG28>? SG28C { get; set; }

	/// <summary>
	/// SG29
	/// </summary>
	public List<RECADV_SG29>? SG29C { get; set; }

}

[EdiSegmentGroup("CDI", "INP")]
public class RECADV_SG23 : CDI, ISegmentGroup
{
	/// <summary>
	/// Parties to instruction
	/// </summary>
	public List<INP>? PartiesToInstructionC { get; set; }
}

[EdiSegmentGroup("DOC", "CDI")]
public class RECADV_SG24 : DOC, ISegmentGroup
{
	/// <summary>
	/// SG25
	/// </summary>
	public List<RECADV_SG25>? SG25C { get; set; }

}

[EdiSegmentGroup("CDI", "INP")]
public class RECADV_SG25 : CDI, ISegmentGroup
{
	/// <summary>
	/// Parties to instruction
	/// </summary>
	public List<INP>? PartiesToInstructionC { get; set; }
}

[EdiSegmentGroup("GIN", "CDI")]
public class RECADV_SG26 : GIN, ISegmentGroup
{
	/// <summary>
	/// SG27
	/// </summary>
	public List<RECADV_SG27>? SG27C { get; set; }

}

[EdiSegmentGroup("CDI", "INP")]
public class RECADV_SG27 : CDI, ISegmentGroup
{
	/// <summary>
	/// Parties to instruction
	/// </summary>
	public List<INP>? PartiesToInstructionC { get; set; }
}

[EdiSegmentGroup("RFF", "DTM")]
public class RECADV_SG28 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("PCI", "QTY", "QVR", "CDI", "GIN")]
public class RECADV_SG29 : PCI, ISegmentGroup
{
	/// <summary>
	/// Quantity
	/// </summary>
	public QTY? QuantityC { get; set; }

	/// <summary>
	/// Quantity variances
	/// </summary>
	public QVR? QuantityVariancesC { get; set; }

	/// <summary>
	/// SG30
	/// </summary>
	public List<RECADV_SG30>? SG30C { get; set; }

	/// <summary>
	/// SG31
	/// </summary>
	public List<RECADV_SG31>? SG31C { get; set; }

}

[EdiSegmentGroup("CDI", "INP")]
public class RECADV_SG30 : CDI, ISegmentGroup
{
	/// <summary>
	/// Parties to instruction
	/// </summary>
	public List<INP>? PartiesToInstructionC { get; set; }
}

[EdiSegmentGroup("GIN", "CDI")]
public class RECADV_SG31 : GIN, ISegmentGroup
{
	/// <summary>
	/// SG32
	/// </summary>
	public List<RECADV_SG32>? SG32C { get; set; }

}

[EdiSegmentGroup("CDI", "INP")]
public class RECADV_SG32 : CDI, ISegmentGroup
{
	/// <summary>
	/// Parties to instruction
	/// </summary>
	public List<INP>? PartiesToInstructionC { get; set; }
}