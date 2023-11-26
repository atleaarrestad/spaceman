using System;


public interface IDestroyable
{
	event Action OnDestroy;
	void Destroy();
}
