using Godot;
using System;
using System.Collections.Generic;
using System.Linq;

[GlobalClass]
public partial class EquipmentContainer : Node2D
{
	[Export]
	public PackedScene WeaponScene { get; set; }
	[Export]
	public Vector2 Offset { get; set; } = Vector2.Zero;
	[Export]
	public Node2D ParentNode { get; set; }

	private Node2D WeaponNode;
	private EquipmentComponent equipmentComponent;
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		WeaponNode = WeaponScene.Instantiate<Node2D>();
		AddChild(WeaponNode);
		WeaponNode.Position += Offset;
		equipmentComponent = WeaponNode.GetNode<EquipmentComponent>("EquipmentComponent");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		
	}
}
