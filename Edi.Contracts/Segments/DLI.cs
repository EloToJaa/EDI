using System.Collections.Generic;
using Edi.Contracts.Qualifiers;
using Edi.Contracts.Interfaces;
using indice.Edi.Serialization;

namespace Edi.Contracts.Segments;

/// <summary>
/// To specify the processing mode of a specific line within a referenced document.
/// </summary>
[EdiSegment, EdiPath("DLI")]
public class DLI : ISegment
{
	/// <summary>
	/// Code indicating if a document line is included or excluded for processing purposes.
	/// </summary>
	[EdiValue("X(3)", Path = "DLI/0", Mandatory = true)]
	public DocumentLineIndicatorCoded? DocumentLineIndicatorCoded { get; set; }

	/// <summary>
	/// Serial number designating each separate item within a series of articles.
	/// </summary>
	[EdiValue("X(6)", Path = "DLI/1", Mandatory = true)]
	public string? LineItemNumber { get; set; }

}