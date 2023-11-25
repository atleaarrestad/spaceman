using Godot;
using System;

public partial class ParallaxStars : Godot.ParallaxLayer
{
	int currentFrame = 0;


	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		currentFrame++;

		MotionOffset += new Vector2(0, (float)0.3);
	}

	static double GenerateSinusoidalValue(int frameIndex, int numberOfPoints)
	{
		double frequency = 2 * Math.PI / numberOfPoints;
		double value = Math.Sin(frameIndex * frequency);
		return value;
	}
}
