using Godot;
using System;

public partial class Player : Node2D
{
    public int moveSpeed { get; set; } = 200;
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
        if (Input.IsKeyPressed(Key.W))
            Position += new Vector2(0, (float)-delta * moveSpeed);

        if (Input.IsKeyPressed(Key.S))
            Position += new Vector2(0, (float)delta * moveSpeed);

        if (Input.IsKeyPressed(Key.A))
            Position += new Vector2((float)-delta * moveSpeed, 0);

        if (Input.IsKeyPressed(Key.D))
            Position += new Vector2((float)delta * moveSpeed, 0);
    }
}
