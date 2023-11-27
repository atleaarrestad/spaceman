using Godot;
using System.Collections.Generic;


[GlobalClass]
public partial class Node2DPoolComponent : Node
{
	[Export]
	public PackedScene Spawnable;

	[Export]
	public Node SpawnTarget;

	[Export]
	public StringName signal;

	private readonly List<Node2D> spawnPool = new();

	public void Spawn(Vector2 position)
	{
		Node2D node;

		//if (spawnPool.Count > 0)
		//{
		//	node = spawnPool[0];
		//	spawnPool.RemoveAt(0);
		//}
		//else
		//{
		//	node = Spawnable.Instantiate<Node2D>();

		//	node.Connect(signal, Callable.From(() =>
		//	{
		//		SpawnTarget.RemoveChild(node);
		//		spawnPool.Add(node);
		//	}));
		//}

		node = Spawnable.Instantiate<Node2D>();
		node.Connect(signal, Callable.From(() =>
		{
			SpawnTarget.RemoveChild(node);
			node.Owner = null;
			node.Free();
		}));

		node.Position = position;

		SpawnTarget.AddChild(node);
	}

}
