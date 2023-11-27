using Godot;
using System;

public partial class KlaedFighter : EnemyShip
{
	[Export] public Godot.AnimatedSprite2D ShipSprite;

	private bool destroyed = false;

	public override void _Ready()
	{
	}

	public override void _Process(double delta)
	{
	}

	public override void Collide(Area2D node)
	{
		if (!destroyed)
		{
			ShipSprite.AnimationFinished += OnAnimationFinished;
			ShipSprite.Play("explode");
			destroyed = true;
		}
	}

	public void OnAnimationFinished()
	{
		QueueFree();
	}
}
