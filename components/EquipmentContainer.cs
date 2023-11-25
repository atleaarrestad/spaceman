using Godot;
using System;
using System.Collections.Generic;
using System.Linq;

[GlobalClass]
public partial class EquipmentContainer : Node
{
	[Export]
	public PackedScene WeaponScene { get; set; }
	private Node WeaponNode;
	private EquipmentComponent equipmentComponent;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		WeaponNode = WeaponScene.Instantiate();
		AddChild(WeaponNode);
		equipmentComponent = WeaponNode.GetNode<EquipmentComponent>("EquipmentComponent");
		equipmentComponent.Fire();

		
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		
	}
}
