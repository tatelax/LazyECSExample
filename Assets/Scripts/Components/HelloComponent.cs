using LazyECS.Component;
using UnityEngine;

namespace SampleGame.Components
{
	public class HelloComponent : IComponent
	{
		public HelloComponent()
		{
			Value = "";
		}

		public string Value { get; }
	}
}