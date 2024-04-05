using System.Collections.Generic;
using Edi.Contracts.Qualifiers;
using indice.Edi.Serialization;

namespace Edi.Contracts.Segments;

/// <summary>
/// To provide information concerning pricing related to class of trade, price multiplier, and reason for change.
/// </summary>
[EdiSegment, EdiPath("APR")]
public class APR
{
	/// <summary>
	/// Code identifying the class of trade.
	/// </summary>
	[EdiValue("X(3)", Path = "APR/0")]
	public ClassOfTradeCoded? ClassOfTradeCoded { get; set; }

	/// <summary>
	/// Price multiplier and its identification.
	/// </summary>
	[EdiPath("APR/1")]
	public APR_PriceMultiplierInformation? PriceMultiplierInformation { get; set; }

	/// <summary>
	/// Code and/or description of the reason for a change.
	/// </summary>
	[EdiPath("APR/2")]
	public APR_ReasonForChange? ReasonForChange { get; set; }
}

/// <summary>
/// Price multiplier and its identification.
/// </summary>
[EdiElement]
public class APR_PriceMultiplierInformation
{
	/// <summary>
	/// Rate to be used to multiply a price.
	/// </summary>
	[EdiValue("9(12)", Path = "APR/*/0")]
	public int? PriceMultiplier { get; set; }

	/// <summary>
	/// Type of price multiplier.
	/// </summary>
	[EdiValue("X(3)", Path = "APR/*/1")]
	public PriceMultiplierQualifier? PriceMultiplierQualifier { get; set; }
}

/// <summary>
/// Code and/or description of the reason for a change.
/// </summary>
[EdiElement]
public class APR_ReasonForChange
{
	/// <summary>
	/// Identification of the reason for a change.
	/// </summary>
	[EdiValue("X(3)", Path = "APR/*/0")]
	public ChangeReasonCoded? ChangeReasonCoded { get; set; }

	/// <summary>
	/// Identification of a code list.
	/// </summary>
	[EdiValue("X(3)", Path = "APR/*/1")]
	public CodeListQualifier? CodeListQualifier { get; set; }

	/// <summary>
	/// Code identifying the agency responsible for a code list.
	/// </summary>
	[EdiValue("X(3)", Path = "APR/*/2")]
	public CodeListResponsibleAgencyCoded? CodeListResponsibleAgencyCoded { get; set; }

	/// <summary>
	/// Description of the reason for a change.
	/// </summary>
	[EdiValue("X(35)", Path = "APR/*/3")]
	public string? ChangeReason { get; set; }
}