using System.Collections.Generic;
using Edi.Contracts.Qualifiers;
using indice.Edi.Serialization;

namespace Edi.Contracts.Segments;

/// <summary>
/// To identify a code set and to give its class and maintenance operation.
/// </summary>
[EdiSegment, EdiPath("CDS")]
public class CDS
{
	/// <summary>
	/// To identify a code set.
	/// </summary>
	[EdiPath("CDS/0")]
	public CDS_CodeSetIdentification? CodeSetIdentification { get; set; }

	/// <summary>
	/// To identify a designated class.
	/// </summary>
	[EdiValue("X(3)", Path = "CDS/1")]
	public ClassDesignatorCoded? ClassDesignatorCoded { get; set; }

	/// <summary>
	/// To indicate the type of data maintenance operation for an object, such as add, delete, replace.
	/// </summary>
	[EdiValue("X(3)", Path = "CDS/2")]
	public MaintenanceOperationCoded? MaintenanceOperationCoded { get; set; }

}

/// <summary>
/// To identify a code set.
/// </summary>
[EdiElement]
public class CDS_CodeSetIdentification
{
	/// <summary>
	/// Tag of a simple data element.
	/// </summary>
	[EdiValue("X(4)", Path = "CDS/*/0")]
	public string? SimpleDataElementTag { get; set; }

	/// <summary>
	/// Identification of a code list.
	/// </summary>
	[EdiValue("X(3)", Path = "CDS/*/1")]
	public CodeListQualifier? CodeListQualifier { get; set; }

	/// <summary>
	/// Code identifying the agency responsible for a code list.
	/// </summary>
	[EdiValue("X(3)", Path = "CDS/*/2")]
	public CodeListResponsibleAgencyCoded? CodeListResponsibleAgencyCoded { get; set; }
}