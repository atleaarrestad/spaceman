using Godot;


[GlobalClass]
public partial class OutOfBoundsDetectorComponent : Node
{
	[Export] public Area2D Actor;

	[Export] public int YLower = 0;
	[Export] public int YUpper = 0;
	[Export] public bool CheckYLowerBounds = false;
	[Export] public bool CheckYUpperBounds = false;

	[Export] public int XLower = 0;
	[Export] public int XUpper = 0;
	[Export] public bool CheckXLowerBounds = false;
	[Export] public bool CheckXUpperBounds = false;

	public override void _Process(double delta)
	{
		if (CheckYLowerBounds && Actor.Position.Y < YLower)
			Actor.QueueFree();
		if (CheckYUpperBounds && Actor.Position.Y > YUpper)
			Actor.QueueFree();
		if (CheckXLowerBounds && Actor.Position.X < XLower)
			Actor.QueueFree();
		if (CheckXUpperBounds && Actor.Position.X > XUpper)
			Actor.QueueFree();
	}
}
