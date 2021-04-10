using LazyECS;
using UnityEngine;

namespace Systems.Initialize
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
			mainWorld.CreateEntity().Set<GameObjectComponent>(GameObject.CreatePrimitive(PrimitiveType.Cube));
		}
	}
}