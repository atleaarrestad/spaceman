using Godot;
using System;

public partial class ParallaxStars : ParallaxLayer
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

		var value = GenerateSinusoidalValue(currentFrame, 1200);
		MotionOffset += new Vector2((float)value, 2);
	}

	static double GenerateSinusoidalValue(int frameIndex, int numberOfPoints)
	{
		double frequency = 2 * Math.PI / numberOfPoints;
		double value = Math.Sin(frameIndex * frequency);
		return value;
	}
}