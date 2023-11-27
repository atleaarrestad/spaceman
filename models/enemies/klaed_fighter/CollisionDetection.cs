using Godot;
using System;


[GlobalClass]
public partial class CollisionDetection : Node
{
	[Export]
	public Area2D Detectable;

	public override void _Ready()
	{
		Detectable.AreaEntered += (node) =>
		{
			GD.Print("NODE ENTERED SOMETHING");
		};
	}
}
