using System.Collections.Generic;
using Edi.Contracts.Qualifiers;
using Edi.Contracts.Interfaces;
using indice.Edi.Serialization;

namespace Edi.Contracts.Segments;

/// <summary>
/// To request a credit cover, reply to that request and disclose the reason for the reply.
/// </summary>
[EdiSegment, EdiPath("CCD")]
public class CCD : ISegment
{
	/// <summary>
	/// Request for a credit cover.
	/// </summary>
	[EdiValue("X(3)", Path = "CCD/0", Mandatory = false)]
	public CreditCoverRequestCoded? CreditCoverRequestCoded { get; set; }

	/// <summary>
	/// Reply to a request for credit cover.
	/// </summary>
	[EdiValue("X(3)", Path = "CCD/1", Mandatory = false)]
	public CreditCoverResponseCoded? CreditCoverResponseCoded { get; set; }

	/// <summary>
	/// Reason of reply to a request for credit cover.
	/// </summary>
	[EdiValue("X(3)", Path = "CCD/2", Mandatory = false)]
	public CreditCoverReasonCoded? CreditCoverReasonCoded { get; set; }

}