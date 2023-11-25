using Godot;
using System;


[GlobalClass]
public partial class DestroyableNode2D : Node2D
{
	[Signal]
	public delegate void DestroyNode2DEventHandler();

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	public event Action OnDestroy
	{
		add
		{
			Connect(SignalName.DestroyNode2D, Callable.From(value));
		}
		remove
		{
			Disconnect(SignalName.DestroyNode2D, Callable.From(value));
		}
	}


	public void Destroy()
	{
		EmitSignal(SignalName.DestroyNode2D);
	}

}
