using Godot;


public partial class Spawner : Node2D
{

	[Export] public PackedScene[] enemyTypes = default;
	[Export] public int spawnXmin = 0;
	[Export] public int spawnXmax = 0;
	[Export] public double spawnTimerMin = 5.0;
	[Export] public double spawnTimerMax = 10.0;

}
