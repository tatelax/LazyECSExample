using LazyECS.Component;
using UnityEngine;

namespace SampleGame.Components
{
	public class PositionComponent : IComponent
	{
		public Vector3 Value { get; private set; }

		public void Set(Vector3 pos)
		{
			// I can do whatever validation here that I want
			Value = pos;
		}
	}
}