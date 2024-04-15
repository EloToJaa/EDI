using System.Collections.Generic;
using Edi.Contracts.Segments;
using Edi.Contracts.Interfaces;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// CASRES
/// </summary>
[EdiMessage]
public class CASRES : IMessage
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
	/// Application error information
	/// </summary>
	public List<ERC>? ApplicationErrorInformationC { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }

	/// <summary>
	/// Monetary amount
	/// </summary>
	public List<MOA>? MonetaryAmountC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// SG1
	/// </summary>
	public List<CASRES_SG1>? SG1C { get; set; }

	/// <summary>
	/// SG2
	/// </summary>
	public List<CASRES_SG2>? SG2C { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("NAD", "SEQ", "FTX")]
public class CASRES_SG1 : NAD, ISegmentGroup
{
	/// <summary>
	/// Sequence details
	/// </summary>
	public SEQ? SequenceDetailsC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }
}

[EdiSegmentGroup("DOC", "GIR", "PAT", "DTM", "MOA", "FTX")]
public class CASRES_SG2 : DOC, ISegmentGroup
{
	/// <summary>
	/// Related identification numbers
	/// </summary>
	public List<GIR>? RelatedIdentificationNumbersC { get; set; }

	/// <summary>
	/// Payment terms basis
	/// </summary>
	public PAT? PaymentTermsBasisC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Monetary amount
	/// </summary>
	public List<MOA>? MonetaryAmountC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }
}