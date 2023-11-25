using System;
using System.Collections.Generic;
using Godot;


[GlobalClass]
public partial class SpawnerComponent : Node2D
{
	[Export]
	public Spawner spawner;

	[Export]
	public Timer spawnTimer;

	private readonly List<DestroyableNode2D> spawnPool = new();

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		GD.Randomize();

		spawnTimer.OneShot = true;
		spawnTimer.Start(GetSpawnTimer());
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	private void Spawn()
	{
		DestroyableNode2D node;

		if (spawnPool.Count > 0)
		{
			node = spawnPool[0];
			spawnPool.RemoveAt(0);
		}
		else
		{
			var scene = spawner.enemyTypes[GetEnemyIndex()];
			node = scene.Instantiate<DestroyableNode2D>();
			node.OnDestroy += () =>
			{
				RemoveChild(node);
				spawnPool.Add(node);
			};
		}

		node.Position = new Vector2(GetSpawnPosition(), Position.Y);

		AddChild(node);
	}

	public void _on_spawn_timer_timeout()
	{
		Spawn();
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
