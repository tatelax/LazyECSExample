using LazyECS;
using SampleGame.Components;
using SampleGame.Worlds;
using UnityEngine;

namespace SampleGame.Systems.Update
{
	public class TestUpdateSystem : IUpdateSystem
	{
		private MainWorld mainWorld;
		private Group testGroup;
		
		public TestUpdateSystem(MainWorld world)
		{
			mainWorld = world;
			testGroup = mainWorld.CreateGroup(GroupType.All, new []
			{
				typeof(PositionComponent),
				typeof(HelloComponent)
			});
		}
		
		public void Update()
		{
			for (int i = 0; i < testGroup.Entities.Count; i++)
			{
				Debug.Log($"Looping through {i} entity");
			}
			
			// GameEntity newEntity = mainWorld.CreateEntity<GameEntity>();
			// newEntity.Add<PositionComponent>();
		}
	}
}