using System.Collections.Generic;
using Edi.Contracts.Qualifiers;
using Edi.Contracts.Interfaces;
using indice.Edi.Serialization;

namespace Edi.Contracts.Segments;

/// <summary>
/// To provide information related to a code value.
/// </summary>
[EdiSegment, EdiPath("CDV")]
public class CDV : ISegment
{
	/// <summary>
	/// Value of the code.
	/// </summary>
	[EdiValue("X(35)", Path = "CDV/0", Mandatory = true)]
	public string? CodeValue { get; set; }

	/// <summary>
	/// Name of a code.
	/// </summary>
	[EdiValue("X(70)", Path = "CDV/1", Mandatory = false)]
	public string? CodeName { get; set; }

	/// <summary>
	/// To indicate the type of data maintenance operation for an object, such as add, delete, replace.
	/// </summary>
	[EdiValue("X(3)", Path = "CDV/2", Mandatory = false)]
	public MaintenanceOperationCoded? MaintenanceOperationCoded { get; set; }

}