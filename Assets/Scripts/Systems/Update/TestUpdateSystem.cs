﻿using Components;
using LazyECS;
using LazyECS.Entity;
using SampleGame.Worlds;
using UnityEngine;

namespace Systems.Update
{
	public class TestUpdateSystem : IUpdateSystem
	{
		private readonly MainWorld mainWorld;
		private Group testGroup;
		
		public TestUpdateSystem(MainWorld world)
		{
			mainWorld = world;
			testGroup = mainWorld.CreateGroup(GroupType.All, new []
			{
				typeof(GameObjectComponent)
			});
		}
		
		public void Update()
		{
			foreach (IEntity entity in testGroup.Entities)
			{
				if (!entity.Has<PositionComponent>())
				{
					entity.Add<PositionComponent>();
				}
				
				Vector3 currPos = entity.Get<PositionComponent>().Value;
				Vector3 newPos = new Vector3(currPos.x + 0.01f, currPos.y, currPos.z);
				
				Debug.Log($"Changed position to {newPos}");
				
				entity.Set<PositionComponent>(newPos);
			}
		}
	}
}