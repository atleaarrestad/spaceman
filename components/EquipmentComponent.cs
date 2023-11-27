using Godot;
using System;

[GlobalClass]
public partial class EquipmentComponent : Node2D
{
	[Export]
	public EquipmentStats Stats { get; set; }

	private Timer timer = new() { OneShot = true };
	private Node2DPoolComponent nodePool = new();
	private bool canShoot = true;

	public override void _Ready()
	{
		nodePool.Spawnable = Stats.Projectile;
		nodePool.SpawnTarget = GetTree().Root;
		nodePool.signal = "DestroyArea2D";

		AddChild(timer);
		timer.Timeout += () => canShoot = true;
	}

	public void Activate()
	{
		if (!canShoot)
			return;

		nodePool.Spawn(new Vector2(GlobalPosition.X, GlobalPosition.Y));
		canShoot = false;
		timer.Start(Stats.Cooldown);
	}
}
