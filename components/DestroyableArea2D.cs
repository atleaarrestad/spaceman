using Godot;
using System;


[GlobalClass]
public partial class DestroyableArea2D : Area2D
{
	[Signal]
	public delegate void DestroyArea2DEventHandler();

	public event Action OnDestroy
	{
		add
		{
			Connect(SignalName.DestroyArea2D, Callable.From(value));
		}
		remove
		{
			Disconnect(SignalName.DestroyArea2D, Callable.From(value));
		}
	}

	public void Destroy()
	{
		EmitSignal(SignalName.DestroyArea2D);
	}

}
