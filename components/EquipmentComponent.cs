using Godot;


[GlobalClass]
public partial class EquipmentComponent : Node2D
{
	[Export] public EquipmentStats Stats { get; set; }
	private Timer timer = new() { OneShot = true };
	private bool canShoot = true;

	public override void _Ready()
	{
		AddChild(timer);
		timer.Timeout += OnTimeout;
	}

	protected void OnTimeout()
	{
		canShoot = true;
	}

	public void Activate()
	{
		if (!canShoot)
			return;

		var node = Stats.Projectile.Instantiate<Node2D>();
		node.Position = new Vector2(GlobalPosition.X, GlobalPosition.Y);
		GetTree().Root.AddChild(node);

		canShoot = false;
		timer.Start(Stats.Cooldown);
	}
}
