using Systems.Initialize;
using Systems.Update;
using LazyECS;
using SampleGame.Systems.Cleanup;
using SampleGame.Systems.Teardown;

namespace Features
{
	public class MainFeature : Feature
	{
		public MainFeature(MainWorld world)
		{
			Systems = new LazyECS.Systems()
				.Add(new CreateCubeEntitySystem(world))
				.Add(new UpdateCubePositionSystem(world))
				.Add(new MoveGameObjectSystem(world))
				.Add(new TestTeardownSystem())
				.Add(new TestCleanupSystem());
		}
	}
}