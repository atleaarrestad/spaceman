using Godot;
using System;


[GlobalClass]
public partial class EnemyShipCollider : Node
{
	[Export] public EnemyShip Detectable;

	public override void _Ready()
	{
		Detectable.AreaEntered += (node) =>
		{
			Detectable.Collide(node);
		};
	}
}
