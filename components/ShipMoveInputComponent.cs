using Godot;
using System;


[GlobalClass]
public partial class ShipMoveInputComponent : Node
{
	[Export]
	public ShipMoveComponent MoveComponent;

	[Export]
	public MoveStats MoveStats;

	private float baseMoveValue = 1;


	public override void _Input(InputEvent @event)
	{
		base._Input(@event);

		float x = 0;
		float y = 0;

		if (Input.IsKeyPressed(Key.W))
			y -= baseMoveValue * MoveStats.Speed;

		if (Input.IsKeyPressed(Key.S))
			y += baseMoveValue * MoveStats.Speed;

		if (Input.IsKeyPressed(Key.A))
			x -= baseMoveValue * MoveStats.Speed;

		if (Input.IsKeyPressed(Key.D))
			x += baseMoveValue * MoveStats.Speed;

		if (Input.IsKeyPressed(Key.W) && (Input.IsKeyPressed(Key.A) || Input.IsKeyPressed(Key.D)))
		{
			y *= (float)0.5;
			x *= (float)0.5;
		}
		if (Input.IsKeyPressed(Key.S) && (Input.IsKeyPressed(Key.A) || Input.IsKeyPressed(Key.D)))
		{
			y *= (float)0.5;
			x *= (float)0.5;
		}

		MoveComponent.Velocity = new Vector2(x, y);
	}
}

