using System.Collections.Generic;
using Edi.Contracts.Qualifiers;
using Edi.Contracts.Interfaces;
using indice.Edi.Serialization;

namespace Edi.Contracts.Segments;

/// <summary>
/// To provide information related to the kind of stage in a process, the number of stages and the actual stage.
/// </summary>
[EdiSegment, EdiPath("STG")]
public class STG : ISegment
{
	/// <summary>
	/// Code identifying the kind of stage in a process.
	/// </summary>
	[EdiValue("X(3)", Path = "STG/0", Mandatory = true)]
	public StagesQualifier? StagesQualifier { get; set; }

	/// <summary>
	/// Count of the number of stages that will be used in the process.
	/// </summary>
	[EdiValue("9(2)", Path = "STG/1", Mandatory = false)]
	public decimal? NumberOfStages { get; set; }

	/// <summary>
	/// Count of the actual number of stages agreed in a process.
	/// </summary>
	[EdiValue("9(2)", Path = "STG/2", Mandatory = false)]
	public decimal? ActualStageCount { get; set; }

}