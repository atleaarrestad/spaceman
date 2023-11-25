using Godot;
using System;

public partial class ParallaxWave : ParallaxStars
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		MotionOffset += new Vector2(0, (float)0.5);
	}
}
