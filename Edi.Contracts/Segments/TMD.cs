using System.Collections.Generic;
using Edi.Contracts.Qualifiers;
using indice.Edi.Serialization;

namespace Edi.Contracts.Segments;

/// <summary>
/// To specify operational transport movement details for a goods item or equipment (which may differ from the contractual conditions).
/// </summary>
[EdiSegment, EdiPath("TMD")]
public class TMD
{
	/// <summary>
	/// Description of type of service for movement of cargo.
	/// </summary>
	[EdiPath("TMD/0")]
	public TMD_MovementType? MovementType { get; set; }

	/// <summary>
	/// Description indicating equipment plan, e.g. FCL or LCL.
	/// </summary>
	[EdiValue("X(26)", Path = "TMD/1")]
	public string? EquipmentPlan { get; set; }

	/// <summary>
	/// Specification of the type of equipment haulage arrangements.
	/// </summary>
	[EdiValue("X(3)", Path = "TMD/2")]
	public HaulageArrangementsCoded? HaulageArrangementsCoded { get; set; }

}

/// <summary>
/// Description of type of service for movement of cargo.
/// </summary>
[EdiElement]
public class TMD_MovementType
{
	/// <summary>
	/// Code indicating the type of movement.
	/// </summary>
	[EdiValue("X(3)", Path = "TMD/*/0")]
	public MovementTypeCoded? MovementTypeCoded { get; set; }

	/// <summary>
	/// Description of the type of movement.
	/// </summary>
	[EdiValue("X(35)", Path = "TMD/*/1")]
	public string? MovementType { get; set; }
}