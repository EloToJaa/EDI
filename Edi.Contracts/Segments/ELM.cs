using System.Collections.Generic;
using Edi.Contracts.Qualifiers;
using indice.Edi.Serialization;

namespace Edi.Contracts.Segments;

/// <summary>
/// To identify a simple data element and give related details.
/// </summary>
[EdiSegment, EdiPath("ELM")]
public class ELM
{
	/// <summary>
	/// Tag of a simple data element.
	/// </summary>
	[EdiValue("X(4)", Path = "ELM/0")]
	public string? SimpleDataElementTag { get; set; }

	/// <summary>
	/// To specify the character representation of a simple data element.
	/// </summary>
	[EdiValue("X(3)", Path = "ELM/1")]
	public SimpleDataElementCharacterRepresentationCoded? SimpleDataElementCharacterRepresentationCoded { get; set; }

	/// <summary>
	/// Code identifying the length type of a simple data element.
	/// </summary>
	[EdiValue("X(3)", Path = "ELM/2")]
	public SimpleDataElementLengthTypeCoded? SimpleDataElementLengthTypeCoded { get; set; }

	/// <summary>
	/// To indicate the maximum length of a simple data element.
	/// </summary>
	[EdiValue("9(3)", Path = "ELM/3")]
	public int? SimpleDataElementMaximumLength { get; set; }

	/// <summary>
	/// To indicate the minimum length of a simple data element.
	/// </summary>
	[EdiValue("9(3)", Path = "ELM/4")]
	public int? SimpleDataElementMinimumLength { get; set; }

	/// <summary>
	/// To indicate if a data element has an associated code set.
	/// </summary>
	[EdiValue("X(3)", Path = "ELM/5")]
	public CodeSetIndicatorCoded? CodeSetIndicatorCoded { get; set; }

	/// <summary>
	/// To identify a designated class.
	/// </summary>
	[EdiValue("X(3)", Path = "ELM/6")]
	public ClassDesignatorCoded? ClassDesignatorCoded { get; set; }

	/// <summary>
	/// To indicate the type of data maintenance operation for an object, such as add, delete, replace.
	/// </summary>
	[EdiValue("X(3)", Path = "ELM/7")]
	public MaintenanceOperationCoded? MaintenanceOperationCoded { get; set; }

}