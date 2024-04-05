using System.Collections.Generic;
using Edi.Contracts.Qualifiers;
using indice.Edi.Serialization;

namespace Edi.Contracts.Segments;

/// <summary>
/// To provide the different information related to the inventory management functions and needed to process properly the inventory movements and the inventory balances.
/// </summary>
[EdiSegment, EdiPath("INV")]
public class INV
{
	/// <summary>
	/// To specify the direction of inventory movement.
	/// </summary>
	[EdiValue("X(3)", Path = "INV/0")]
	public InventoryMovementDirectionCoded? InventoryMovementDirectionCoded { get; set; }

	/// <summary>
	/// To specify the type of inventory which is affected by an inventory movement or expressed in an inventory balance.
	/// </summary>
	[EdiValue("X(3)", Path = "INV/1")]
	public TypeOfInventoryAffectedCoded? TypeOfInventoryAffectedCoded { get; set; }

	/// <summary>
	/// To explain the reason for the inventory movement.
	/// </summary>
	[EdiValue("X(3)", Path = "INV/2")]
	public ReasonForInventoryMovementCoded? ReasonForInventoryMovementCoded { get; set; }

	/// <summary>
	/// To specify the method used to establish an inventory balance.
	/// </summary>
	[EdiValue("X(3)", Path = "INV/3")]
	public InventoryBalanceMethodCoded? InventoryBalanceMethodCoded { get; set; }

	/// <summary>
	/// To specify an instruction.
	/// </summary>
	[EdiPath("INV/4")]
	public INV_Instruction? Instruction { get; set; }
}

/// <summary>
/// To specify an instruction.
/// </summary>
[EdiElement]
public class INV_Instruction
{
	/// <summary>
	/// Code giving specific meaning to the type of instructions.
	/// </summary>
	[EdiValue("X(3)", Path = "INV/*/0")]
	public InstructionQualifier? InstructionQualifier { get; set; }

	/// <summary>
	/// Specification of an action to be taken by the receiver of the message.
	/// </summary>
	[EdiValue("X(3)", Path = "INV/*/1")]
	public InstructionCoded? InstructionCoded { get; set; }

	/// <summary>
	/// Identification of a code list.
	/// </summary>
	[EdiValue("X(3)", Path = "INV/*/2")]
	public CodeListQualifier? CodeListQualifier { get; set; }

	/// <summary>
	/// Code identifying the agency responsible for a code list.
	/// </summary>
	[EdiValue("X(3)", Path = "INV/*/3")]
	public CodeListResponsibleAgencyCoded? CodeListResponsibleAgencyCoded { get; set; }

	/// <summary>
	/// Description of an instruction.
	/// </summary>
	[EdiValue("X(35)", Path = "INV/*/4")]
	public string? Instruction { get; set; }
}