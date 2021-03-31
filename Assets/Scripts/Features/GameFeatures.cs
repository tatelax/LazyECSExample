using Systems.Update;
using LazyECS;
using SampleGame.Systems.Cleanup;
using SampleGame.Systems.Initialize;
using SampleGame.Systems.Teardown;
using SampleGame.Worlds;

namespace SampleGame.Features
{
	public class GameFeatures : Feature
	{
		public override void Setup()
		{
			MainWorld mainWorld = CoreController.Instance.Worlds[typeof(MainWorld)] as MainWorld;
			
			Systems = new LazyECS.Systems()
				.Add(new CreateCubeEntitySystem(mainWorld))
				.Add(new UpdateCubePositionSystem(mainWorld))
				.Add(new MoveGameObjectSystem(mainWorld))
				.Add(new TestTeardownSystem())
				.Add(new TestCleanupSystem());
		}
	}
}