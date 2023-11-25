using Godot;
using System;

[GlobalClass]
public partial class ActionInputComponent : Node
{
    [Signal]
    public delegate void ShootEventHandler();
    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta)
	{
		if (Input.IsKeyPressed(Key.Space))
            EmitSignal(SignalName.Shoot);

    }
}
