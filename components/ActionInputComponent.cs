using Godot;
using System;

[GlobalClass]
public partial class ActionInputComponent : Node
{
	[Signal]
	public delegate void ShootEventHandler();

	public override void _Process(double delta)
	{
		if (Input.IsKeyPressed(Key.Space))
			EmitSignal(SignalName.Shoot);

	}
}
