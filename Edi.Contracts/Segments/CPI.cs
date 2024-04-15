using System.Collections.Generic;
using Edi.Contracts.Qualifiers;
using Edi.Contracts.Interfaces;
using indice.Edi.Serialization;

namespace Edi.Contracts.Segments;

/// <summary>
/// To identify a charge.
/// </summary>
[EdiSegment, EdiPath("CPI")]
public class CPI : ISegment
{
	/// <summary>
	/// Identification of a category or a zone of charges.
	/// </summary>
	[EdiPath("CPI/0")]
	public CPI_ChargeCategory? ChargeCategory { get; set; }

	/// <summary>
	/// Code identifying the method of payment.
	/// </summary>
	[EdiPath("CPI/1")]
	public CPI_MethodOfPayment? MethodOfPayment { get; set; }

	/// <summary>
	/// Code indicating whether freight item amount is prepaid or to be collected.
	/// </summary>
	[EdiValue("X(3)", Path = "CPI/2", Mandatory = false)]
	public PrepaidCollectIndicatorCoded? PrepaidCollectIndicatorCoded { get; set; }

}

/// <summary>
/// Identification of a category or a zone of charges.
/// </summary>
[EdiElement]
public class CPI_ChargeCategory : IElement
{
	/// <summary>
	/// To indicate the category or zone of charges.
	/// </summary>
	[EdiValue("X(3)", Path = "CPI/*/0", Mandatory = true)]
	public ChargeCategoryCoded? ChargeCategoryCoded { get; set; }

	/// <summary>
	/// Identification of a code list.
	/// </summary>
	[EdiValue("X(3)", Path = "CPI/*/1", Mandatory = false)]
	public CodeListQualifier? CodeListQualifier { get; set; }

	/// <summary>
	/// Code identifying the agency responsible for a code list.
	/// </summary>
	[EdiValue("X(3)", Path = "CPI/*/2", Mandatory = false)]
	public CodeListResponsibleAgencyCoded? CodeListResponsibleAgencyCoded { get; set; }
}

/// <summary>
/// Code identifying the method of payment.
/// </summary>
[EdiElement]
public class CPI_MethodOfPayment : IElement
{
	/// <summary>
	/// Identification of method of payment for transport charges.
	/// </summary>
	[EdiValue("X(3)", Path = "CPI/*/0", Mandatory = true)]
	public TransportChargesMethodOfPaymentCoded? TransportChargesMethodOfPaymentCoded { get; set; }

	/// <summary>
	/// Identification of a code list.
	/// </summary>
	[EdiValue("X(3)", Path = "CPI/*/1", Mandatory = false)]
	public CodeListQualifier? CodeListQualifier { get; set; }

	/// <summary>
	/// Code identifying the agency responsible for a code list.
	/// </summary>
	[EdiValue("X(3)", Path = "CPI/*/2", Mandatory = false)]
	public CodeListResponsibleAgencyCoded? CodeListResponsibleAgencyCoded { get; set; }
}