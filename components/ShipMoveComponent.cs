using Godot;


[GlobalClass]
public partial class ShipMoveComponent : Node
{
	[Export]
	public Node2D Actor;

	[Export]
	public Vector2 Velocity;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		var offset = new Vector2(Velocity.X * (float)delta, Velocity.Y * (float)delta);

		Actor.Translate(offset);
	}
}
