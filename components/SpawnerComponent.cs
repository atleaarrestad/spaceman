using System;
using Godot;


[GlobalClass]
public partial class SpawnerComponent : Node2D
{
	[Export] public PackedScene[] spawnTypes = default;
	[Export] public int StartPosition = 0;
	[Export] public int EndPosition = 0;
	[Export] public double TimerMinimum = 5.0;
	[Export] public double TimerMaximum = 10.0;

	public Timer spawnTimer = new();

	public override void _Ready()
	{
		GD.Randomize();

		spawnTimer.OneShot = true;
		spawnTimer.Timeout += OnTimeout;

		AddChild(spawnTimer);

		spawnTimer.Start(GetSpawnTimer());
	}

	public void OnTimeout()
	{
		var scene = spawnTypes[GetSpawnTypeIndex()];
		var node = scene.Instantiate<Node2D>();
		node.Position = new Vector2(GetSpawnPosition(), Position.Y);
		AddChild(node);

		spawnTimer.Start(GetSpawnTimer());
	}

	private int GetSpawnTypeIndex()
	{
		return (int)GD.Randi() % Math.Min(1, spawnTypes.Length);
	}

	private double GetSpawnTimer()
	{
		return GD.RandRange(TimerMinimum, TimerMaximum);
	}

	private float GetSpawnPosition()
	{
		return GD.RandRange(StartPosition, EndPosition);
	}

}
