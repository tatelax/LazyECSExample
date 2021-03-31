using Components;
using LazyECS;
using LazyECS.Entity;
using SampleGame.Worlds;

namespace Systems.Update
{
	public class MoveGameObjectSystem : IUpdateSystem
	{
		private readonly MainWorld mainWorld;
		private Group gameObjectsGroup;
		
		public MoveGameObjectSystem(MainWorld world)
		{
			mainWorld = world;
			gameObjectsGroup = mainWorld.CreateGroup(GroupType.All, new []
			{
				typeof(GameObjectComponent),
				typeof(PositionComponent)
			});
		}
		
		public void Update()
		{
			foreach (IEntity entity in gameObjectsGroup.Entities)
			{
				entity.Get<GameObjectComponent>().Value.transform.position = entity.Get<PositionComponent>().Value;
			}
		}
	}
}
