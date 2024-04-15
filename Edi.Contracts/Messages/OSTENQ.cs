using System.Collections.Generic;
using Edi.Contracts.Segments;
using Edi.Contracts.Interfaces;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// OSTENQ
/// </summary>
[EdiMessage]
public class OSTENQ : IMessage
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
	public List<OSTENQ_SG1>? SG1M { get; set; }

	/// <summary>
	/// SG3
	/// </summary>
	public List<OSTENQ_SG3>? SG3C { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("NAD", "CTA")]
public class OSTENQ_SG1 : NAD, ISegmentGroup
{
	/// <summary>
	/// SG2
	/// </summary>
	public List<OSTENQ_SG2>? SG2C { get; set; }

}

[EdiSegmentGroup("CTA", "COM")]
public class OSTENQ_SG2 : CTA, ISegmentGroup
{
	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }
}

[EdiSegmentGroup("DOC", "DTM", "LIN")]
public class OSTENQ_SG3 : DOC, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// SG4
	/// </summary>
	public List<OSTENQ_SG4>? SG4C { get; set; }

}

[EdiSegmentGroup("LIN", "PIA", "IMD", "MEA", "RFF", "LOC")]
public class OSTENQ_SG4 : LIN, ISegmentGroup
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
	/// SG5
	/// </summary>
	public List<OSTENQ_SG5>? SG5C { get; set; }

	/// <summary>
	/// SG6
	/// </summary>
	public List<OSTENQ_SG6>? SG6C { get; set; }

}

[EdiSegmentGroup("RFF", "DTM")]
public class OSTENQ_SG5 : RFF, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }
}

[EdiSegmentGroup("LOC", "DTM", "QTY")]
public class OSTENQ_SG6 : LOC, ISegmentGroup
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Quantity
	/// </summary>
	public QTY? QuantityC { get; set; }
}