using System.Collections.Generic;
using Edi.Contracts.Segments;
using indice.Edi.Serialization;

namespace Edi.Contracts.Messages;

/// <summary>
/// CASINT
/// </summary>
[EdiMessage]
public class CASINT
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
	public List<DTM>? DateTimePeriod1C { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentification1C { get; set; }

	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? Reference1C { get; set; }

	/// <summary>
	/// Attribute
	/// </summary>
	public List<ATT>? Attribute1C { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeText1C { get; set; }

	/// <summary>
	/// SG1
	/// </summary>
	public CASINT_SG1? SG1C { get; set; }

	/// <summary>
	/// SG2
	/// </summary>
	public List<CASINT_SG2>? SG2C { get; set; }

	/// <summary>
	/// Section control
	/// </summary>
	public UNS? SectionControlM { get; set; }

	/// <summary>
	/// SG3
	/// </summary>
	public List<CASINT_SG3>? SG3M { get; set; }

	/// <summary>
	/// SG4
	/// </summary>
	public List<CASINT_SG4>? SG4C { get; set; }

	/// <summary>
	/// Message trailer
	/// </summary>
	public UNT? MessageTrailerM { get; set; }
}

[EdiSegmentGroup("NAD", "LOC")]
public class CASINT_SG1 : NAD
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }
}

[EdiSegmentGroup("MOA", "DTM", "FCA")]
public class CASINT_SG2 : MOA
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }

	/// <summary>
	/// Financial charges allocation
	/// </summary>
	public FCA? FinancialChargesAllocationC { get; set; }
}

[EdiSegmentGroup("NAD", "SEQ", "LOC", "CTA", "COM", "RFF", "ATT", "PRC", "MEA", "DTM", "EMP", "FTX")]
public class CASINT_SG3 : NAD
{
	/// <summary>
	/// Sequence details
	/// </summary>
	public SEQ? SequenceDetailsC { get; set; }

	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }

	/// <summary>
	/// Contact information
	/// </summary>
	public CTA? ContactInformationC { get; set; }

	/// <summary>
	/// Communication contact
	/// </summary>
	public List<COM>? CommunicationContactC { get; set; }

	/// <summary>
	/// Reference
	/// </summary>
	public List<RFF>? ReferenceC { get; set; }

	/// <summary>
	/// Attribute
	/// </summary>
	public List<ATT>? AttributeC { get; set; }

	/// <summary>
	/// Process identification
	/// </summary>
	public PRC? ProcessIdentificationC { get; set; }

	/// <summary>
	/// Measurements
	/// </summary>
	public List<MEA>? MeasurementsC { get; set; }

	/// <summary>
	/// Date/time/period
	/// </summary>
	public List<DTM>? DateTimePeriodC { get; set; }

	/// <summary>
	/// Employment details
	/// </summary>
	public List<EMP>? EmploymentDetailsC { get; set; }

	/// <summary>
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }
}

[EdiSegmentGroup("DOC", "GIR", "PAT", "DTM", "FTX", "NAD", "MOA")]
public class CASINT_SG4 : DOC
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
	/// Free text
	/// </summary>
	public List<FTX>? FreeTextC { get; set; }

	/// <summary>
	/// SG5
	/// </summary>
	public CASINT_SG5? SG5C { get; set; }

	/// <summary>
	/// SG6
	/// </summary>
	public List<CASINT_SG6>? SG6C { get; set; }

}

[EdiSegmentGroup("NAD", "LOC")]
public class CASINT_SG5 : NAD
{
	/// <summary>
	/// Place/location identification
	/// </summary>
	public List<LOC>? PlaceLocationIdentificationC { get; set; }
}

[EdiSegmentGroup("MOA", "DTM", "FCA")]
public class CASINT_SG6 : MOA
{
	/// <summary>
	/// Date/time/period
	/// </summary>
	public DTM? DateTimePeriodC { get; set; }

	/// <summary>
	/// Financial charges allocation
	/// </summary>
	public FCA? FinancialChargesAllocationC { get; set; }
}