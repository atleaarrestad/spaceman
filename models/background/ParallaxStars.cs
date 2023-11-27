using Godot;


public partial class ParallaxStars : Godot.ParallaxLayer
{
	public override void _Process(double delta)
	{
		MotionOffset += new Vector2(0, (float)0.3);
	}
}
