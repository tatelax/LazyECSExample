using LazyECS;
using SampleGame.Entities;
using SampleGame.Worlds;
using UnityEngine;

namespace SampleGame.Systems.Initialize
{
	public class TestInitializeSystem : IInitializeSystem
	{
		private World mainWorld;
		
		public TestInitializeSystem(MainWorld world)
		{
			mainWorld = world;
		}
		
		public void Initialize()
		{
			mainWorld.CreateEntity<GameEntity>().Set<GameObjectComponent>(new GameObject("My Object"));
		}
	}
}