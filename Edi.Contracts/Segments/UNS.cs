using System.Collections.Generic;
using Edi.Contracts.Qualifiers;
using indice.Edi.Serialization;

namespace Edi.Contracts.Segments;

/// <summary>
/// To separate header, detail and summary sections of a message.
/// </summary>
[EdiSegment, EdiPath("UNS")]
public class UNS
{
	/// <summary>
	/// Separates sections in a message.
	/// </summary>
	[EdiValue("X(1)", Path = "UNS/0")]
	public SectionIdentification? SectionIdentification { get; set; }

}