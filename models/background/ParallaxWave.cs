using Godot;


public partial class ParallaxWave : ParallaxStars
{
	public override void _Process(double delta)
	{
		MotionOffset += new Vector2(0, (float)0.5);
	}
}
