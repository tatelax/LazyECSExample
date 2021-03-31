using LazyECS;
using SampleGame.Entities;
using SampleGame.Worlds;
using UnityEngine;

namespace SampleGame.Systems.Initialize
{
	public class CreateCubeEntitySystem : IInitializeSystem
	{
		private World mainWorld;
		
		public CreateCubeEntitySystem(MainWorld world)
		{
			mainWorld = world;
		}
		
		public void Initialize()
		{
			mainWorld.CreateEntity<GameEntity>().Set<GameObjectComponent>(GameObject.CreatePrimitive(PrimitiveType.Cube));
		}
	}
}