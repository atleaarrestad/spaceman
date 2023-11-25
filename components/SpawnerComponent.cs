using Godot;


[GlobalClass]
public partial class SpawnerComponent : Node2D
{
	[Export]
	public Spawner spawner;

	[Export]
	public Timer SpawnTimer;

	public double NextSpawnTime = 3.0;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		GD.Randomize();
		SpawnTimer.Start(NextSpawnTime);
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	public void _on_spawn_timer_timeout()
	{
		var scene = GD.Load<PackedScene>("res://models/enemies/klaed_fighter/KlaedFighter.tscn");
		var enemy = scene.Instantiate<Node2D>();
		enemy.Position = new Vector2(Position.X, Position.Y);
		AddChild(enemy);

		SpawnTimer.Start(NextSpawnTime);
	}

}
