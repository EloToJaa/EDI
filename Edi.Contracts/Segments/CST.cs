using System.Collections.Generic;
using Edi.Contracts.Qualifiers;
using indice.Edi.Serialization;

namespace Edi.Contracts.Segments;

/// <summary>
/// To specify goods in terms of customs identities, status and intended use.
/// </summary>
[EdiSegment, EdiPath("CST")]
public class CST
{
	/// <summary>
	/// Serial number differentiating each separate goods item entry of a consignment as contained in one document/declaration.
	/// </summary>
	[EdiValue("9(5)", Path = "CST/0")]
	public int? GoodsItemNumber { get; set; }

	/// <summary>
	/// Specification of goods in terms of customs identity.
	/// </summary>
	[EdiPath("CST/1")]
	public CST_CustomsIdentityCodes? CustomsIdentityCodes1 { get; set; }

	/// <summary>
	/// Specification of goods in terms of customs identity.
	/// </summary>
	[EdiPath("CST/2")]
	public CST_CustomsIdentityCodes? CustomsIdentityCodes2 { get; set; }

	/// <summary>
	/// Specification of goods in terms of customs identity.
	/// </summary>
	[EdiPath("CST/3")]
	public CST_CustomsIdentityCodes? CustomsIdentityCodes3 { get; set; }

	/// <summary>
	/// Specification of goods in terms of customs identity.
	/// </summary>
	[EdiPath("CST/4")]
	public CST_CustomsIdentityCodes? CustomsIdentityCodes4 { get; set; }

	/// <summary>
	/// Specification of goods in terms of customs identity.
	/// </summary>
	[EdiPath("CST/5")]
	public CST_CustomsIdentityCodes? CustomsIdentityCodes5 { get; set; }
}

/// <summary>
/// Specification of goods in terms of customs identity.
/// </summary>
[EdiElement]
public class CST_CustomsIdentityCodes
{
	/// <summary>
	/// To specify goods in terms of customs identity.
	/// </summary>
	[EdiValue("X(18)", Path = "CST/*/0")]
	public string? CustomsCodeIdentification { get; set; }

	/// <summary>
	/// Identification of a code list.
	/// </summary>
	[EdiValue("X(3)", Path = "CST/*/1")]
	public CodeListQualifier? CodeListQualifier { get; set; }

	/// <summary>
	/// Code identifying the agency responsible for a code list.
	/// </summary>
	[EdiValue("X(3)", Path = "CST/*/2")]
	public CodeListResponsibleAgencyCoded? CodeListResponsibleAgencyCoded { get; set; }
}