using Godot;
using System;


[GlobalClass]
public partial class CollisionDetection : Node
{
	[Export]
	public Area2D Detectable;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		Detectable.AreaEntered += (node) =>
		{
			GD.Print("NODE ENTERED SOMETHING");
		};
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
