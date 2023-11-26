using Godot;
using System;


[GlobalClass]
public partial class DestroyableNode2D : Node2D
{
	[Signal]
	public delegate void DestroyNode2DEventHandler();

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
