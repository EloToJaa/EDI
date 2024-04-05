using System.Collections.Generic;
using Edi.Contracts.Qualifiers;
using indice.Edi.Serialization;

namespace Edi.Contracts.Segments;

/// <summary>
/// To specify terms of delivery or transport.
/// </summary>
[EdiSegment, EdiPath("TOD")]
public class TOD
{
	/// <summary>
	/// Indication whether the terms relate to e.g. price conditions, delivery conditions, transport conditions, or a combination of these.
	/// </summary>
	[EdiValue("X(3)", Path = "TOD/0")]
	public TermsOfDeliveryOrTransportFunctionCoded? TermsOfDeliveryOrTransportFunctionCoded { get; set; }

	/// <summary>
	/// Identification of method of payment for transport charges.
	/// </summary>
	[EdiValue("X(3)", Path = "TOD/1")]
	public TransportChargesMethodOfPaymentCoded? TransportChargesMethodOfPaymentCoded { get; set; }

	/// <summary>
	/// Terms of delivery or transport code from a specified source.
	/// </summary>
	[EdiPath("TOD/2")]
	public TOD_TermsOfDeliveryOrTransport? TermsOfDeliveryOrTransport { get; set; }
}

/// <summary>
/// Terms of delivery or transport code from a specified source.
/// </summary>
[EdiElement]
public class TOD_TermsOfDeliveryOrTransport
{
	/// <summary>
	/// Identification of the terms agreed between two parties (e.g. seller/buyer, shipper/carrier) under which a product or service is provided.
	/// </summary>
	[EdiValue("X(3)", Path = "TOD/*/0")]
	public string? TermsOfDeliveryOrTransportCoded { get; set; }

	/// <summary>
	/// Identification of a code list.
	/// </summary>
	[EdiValue("X(3)", Path = "TOD/*/1")]
	public CodeListQualifier? CodeListQualifier { get; set; }

	/// <summary>
	/// Code identifying the agency responsible for a code list.
	/// </summary>
	[EdiValue("X(3)", Path = "TOD/*/2")]
	public CodeListResponsibleAgencyCoded? CodeListResponsibleAgencyCoded { get; set; }

	/// <summary>
	/// Terms agreed between two parties (e.g. seller/buyer, shipper/carrier) under which a product or service is provided.
	/// </summary>
	[EdiValue("X(70)", Path = "TOD/*/3")]
	public string? TermsOfDeliveryOrTransport1 { get; set; }

	/// <summary>
	/// Terms agreed between two parties (e.g. seller/buyer, shipper/carrier) under which a product or service is provided.
	/// </summary>
	[EdiValue("X(70)", Path = "TOD/*/4")]
	public string? TermsOfDeliveryOrTransport2 { get; set; }
}