using LazyECS.Component;
using UnityEngine;

public class GameObjectComponent : IComponent
{
	public GameObject Value { get; private set; }

	public void Set(object value)
	{
		Value = (GameObject) value;
	}
}
