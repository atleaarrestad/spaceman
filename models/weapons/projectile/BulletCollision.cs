using Godot;
using System;


[GlobalClass]
public partial class BulletCollision : Node
{
	[Export]
	public DestroyableArea2D Detectable;

	[Export]
	public Godot.AnimatedSprite2D Animation;

	public override void _Ready()
	{
		Detectable.AreaEntered += (node) =>
		{
			Animation.AnimationFinished += () =>
			{
				((DestroyableArea2D)node).Destroy();
			};
			Animation.Play("explode");
		};
	}
}
