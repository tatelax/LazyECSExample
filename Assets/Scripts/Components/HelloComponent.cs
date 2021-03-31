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

		private string Value { get; }
		
		public void Set(dynamic value)
		{
			throw new System.NotImplementedException();
		}
	}
}