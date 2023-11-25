using Godot;
using System;


[GlobalClass]
public partial class ShipMoveInputComponent : Node
{
	[Export]
	public ShipMoveComponent MoveComponent;

	[Export]
	public MoveStats MoveStats;

	private int baseMoveValue = 1;


	public override void _Input(InputEvent @event)
	{
		base._Input(@event);

		var x = 0;
		var y = 0;

		if (Input.IsKeyPressed(Key.W))
			y -= baseMoveValue * MoveStats.Speed;

		if (Input.IsKeyPressed(Key.S))
			y += baseMoveValue * MoveStats.Speed;

		if (Input.IsKeyPressed(Key.A))
			x -= baseMoveValue * MoveStats.Speed;

		if (Input.IsKeyPressed(Key.D))
			x += baseMoveValue * MoveStats.Speed;

		MoveComponent.Velocity = new Vector2(x, y);
	}
}

