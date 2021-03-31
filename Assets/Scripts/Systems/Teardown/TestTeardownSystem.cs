using LazyECS;

namespace SampleGame.Systems.Teardown
{
	public class TestTeardownSystem : ITeardownSystem
	{
		public void Teardown()
		{
			UnityEngine.Debug.Log("I'm tearing down.");
		}
	}
}