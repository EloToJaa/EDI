using System.Collections.Generic;
using Edi.Contracts.Qualifiers;
using indice.Edi.Serialization;

namespace Edi.Contracts.Segments;

/// <summary>
/// To specify a related set of identification numbers.
/// </summary>
[EdiSegment, EdiPath("GIR")]
public class GIR
{
	/// <summary>
	/// Identification of the type of set.
	/// </summary>
	[EdiValue("X(3)", Path = "GIR/0")]
	public SetIdentificationQualifier? SetIdentificationQualifier { get; set; }

	/// <summary>
	/// The identification of an object.
	/// </summary>
	[EdiPath("GIR/1")]
	public GIR_IdentificationNumber? IdentificationNumber1 { get; set; }

	/// <summary>
	/// The identification of an object.
	/// </summary>
	[EdiPath("GIR/2")]
	public GIR_IdentificationNumber? IdentificationNumber2 { get; set; }

	/// <summary>
	/// The identification of an object.
	/// </summary>
	[EdiPath("GIR/3")]
	public GIR_IdentificationNumber? IdentificationNumber3 { get; set; }

	/// <summary>
	/// The identification of an object.
	/// </summary>
	[EdiPath("GIR/4")]
	public GIR_IdentificationNumber? IdentificationNumber4 { get; set; }

	/// <summary>
	/// The identification of an object.
	/// </summary>
	[EdiPath("GIR/5")]
	public GIR_IdentificationNumber? IdentificationNumber5 { get; set; }
}

/// <summary>
/// The identification of an object.
/// </summary>
[EdiElement]
public class GIR_IdentificationNumber
{
	/// <summary>
	/// The number given to an object for its unique identification.
	/// </summary>
	[EdiValue("X(35)", Path = "GIR/*/0")]
	public string? IdentityNumber { get; set; }

	/// <summary>
	/// Code specifying the type/source of identity number.
	/// </summary>
	[EdiValue("X(3)", Path = "GIR/*/1")]
	public IdentityNumberQualifier? IdentityNumberQualifier { get; set; }

	/// <summary>
	/// Provides information regarding a status.
	/// </summary>
	[EdiValue("X(3)", Path = "GIR/*/2")]
	public StatusCoded? StatusCoded { get; set; }
}