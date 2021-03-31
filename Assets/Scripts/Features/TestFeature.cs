using LazyECS;
using SampleGame.Systems.Cleanup;
using SampleGame.Systems.Initialize;
using SampleGame.Systems.Teardown;
using SampleGame.Systems.Update;
using SampleGame.Worlds;

namespace SampleGame.Features
{
	public class TestFeature : Feature
	{
		public override void Setup()
		{
			MainWorld mainWorld = CoreController.Instance.Worlds[typeof(MainWorld)] as MainWorld;
			
			Systems = new LazyECS.Systems()
				.Add(new TestInitializeSystem(mainWorld))
				.Add(new TestUpdateSystem(mainWorld))
				.Add(new TestTeardownSystem())
				.Add(new TestCleanupSystem());
		}
	}
}