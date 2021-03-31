using LazyECS.Component;
using UnityEngine;

namespace Components
{
	public class PositionComponent : IComponent
	{
		public Vector3 Value { get; private set; }

		public void Set(object pos)
		{
			// I can do whatever validation here that I want
			Value = (Vector3)pos;
		}
	}
}