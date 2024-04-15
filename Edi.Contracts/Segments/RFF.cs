using System.Collections.Generic;
using Edi.Contracts.Qualifiers;
using Edi.Contracts.Interfaces;
using indice.Edi.Serialization;

namespace Edi.Contracts.Segments;

/// <summary>
/// To specify a reference.
/// </summary>
[EdiSegment, EdiPath("RFF")]
public class RFF : ISegment
{
	/// <summary>
	/// Identification of a reference.
	/// </summary>
	[EdiPath("RFF/0")]
	public RFF_Reference? Reference { get; set; }
}

/// <summary>
/// Identification of a reference.
/// </summary>
[EdiElement]
public class RFF_Reference : IElement
{
	/// <summary>
	/// Code giving specific meaning to a reference segment or a reference number.
	/// </summary>
	[EdiValue("X(3)", Path = "RFF/*/0", Mandatory = true)]
	public ReferenceQualifier? ReferenceQualifier { get; set; }

	/// <summary>
	/// Identification number the nature and function of which can be qualified by an entry in data element 1153 Reference qualifier.
	/// </summary>
	[EdiValue("X(35)", Path = "RFF/*/1", Mandatory = false)]
	public string? ReferenceNumber { get; set; }

	/// <summary>
	/// Number of the line in the document/message referenced in 1154 Reference number.
	/// </summary>
	[EdiValue("X(6)", Path = "RFF/*/2", Mandatory = false)]
	public string? LineNumber { get; set; }

	/// <summary>
	/// To uniquely identify a reference by its revision number.
	/// </summary>
	[EdiValue("X(35)", Path = "RFF/*/3", Mandatory = false)]
	public string? ReferenceVersionNumber { get; set; }
}