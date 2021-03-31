using LazyECS;

namespace SampleGame.Systems.Cleanup
{
	public class TestCleanupSystem : ICleanupSystem
	{
		public void Cleanup()
		{
			UnityEngine.Debug.Log("I'm cleaning up!");
		}
	}
}