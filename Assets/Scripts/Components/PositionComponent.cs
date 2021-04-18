using LazyECS.Component;
using UnityEngine;

namespace Components
{
	public class PositionComponent : IComponent
	{
		public Vector3 Value { get; private set; }

		public bool Set(object pos)
		{
			// I can do whatever validation here that I want
			Value = (Vector3)pos;
			return true;
		}

		public object Get()
		{
			return Value;
		}
	}
}