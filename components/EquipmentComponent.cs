using Godot;
using System;

[GlobalClass]
public partial class EquipmentComponent : Node
{
	[Export]
	public EquipmentStats Stats { get; set; }
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{

	}

	public void Fire()
	{
		Console.WriteLine("Gun has fired");
		GD.Print("Gun has diddley doo scoobey doo fired");
	}
}
