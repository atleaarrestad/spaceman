using System;
using System.Collections.Generic;
using Godot;


[GlobalClass]
public partial class SpawnerComponent : Node2D
{
	[Export]
	public Spawner spawner;

	[Export]
	public Node2DPoolComponent nodePool;

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
		nodePool.Spawn(new Vector2(GetSpawnPosition(), Position.Y));
		spawnTimer.Start(GetSpawnTimer());
	}

	private int GetEnemyIndex()
	{
		return (int)GD.Randi() % Math.Min(1, spawner.enemyTypes.Length);
	}

	private double GetSpawnTimer()
	{
		return GD.RandRange(spawner.spawnTimerMin, spawner.spawnTimerMax);
	}

	private float GetSpawnPosition()
	{
		return GD.RandRange(spawner.spawnXmin, spawner.spawnXmax);
	}

}
