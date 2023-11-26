using Godot;
using System;

[GlobalClass]
public partial class EquipmentComponent : Node2D
{
	[Export]
	public EquipmentStats Stats { get; set; }
	private Timer timer;
	private bool canShoot = true;

	public override void _Ready()
	{
		timer = new Timer();
		timer.OneShot = true;
		AddChild(timer);

		timer.Timeout += () => canShoot = true;
	}

	public override void _Process(double delta)
	{

	}

	public void Activate()
	{
		if (canShoot)
		{
			var projectile = Stats.Projectile.Instantiate<Area2D>();
			GetTree().Root.AddChild(projectile);
			projectile.Position = new Vector2(GlobalPosition.X, GlobalPosition.Y);
			canShoot = false;
			 timer.Start(Stats.Cooldown);
		}
	} 
}
