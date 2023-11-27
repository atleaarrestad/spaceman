using Godot;


[GlobalClass]
public partial class BulletCollision : Node
{
	[Export] public Area2D Detectable;
	[Export] public Godot.AnimatedSprite2D Animation;

	private bool destroyed = false;

	public override void _Ready()
	{
		Detectable.AreaEntered += OnAreaEntered;
	}

	public void OnAreaEntered(Area2D node)
	{
		if (node is not EnemyShip)
			return;

		if (!destroyed)
		{
			Animation.AnimationFinished += OnAnimationFinished;
			Animation.Play("explode");
			destroyed = true;
		}
	}

	public void OnAnimationFinished()
	{
		Detectable.QueueFree();
	}
}
