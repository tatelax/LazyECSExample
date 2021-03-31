using LazyECS;
using SampleGame.Components;
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
			Debug.Log("Initialized!");

			GameEntity newEntity = mainWorld.CreateEntity<GameEntity>();
			
			PositionComponent posComp = new PositionComponent();
			
			PositionComponent pos = new PositionComponent();
			pos.Set(new Vector3());
			
			newEntity.Add<PositionComponent>().Set(new Vector3());
			PositionComponent myValue = newEntity.Get<PositionComponent>();
			myValue.Set(new Vector3());

			// PositionComponent pos = newEntity.Get<PositionComponent>() as PositionComponent;
			Debug.Log(pos.Value);
			newEntity.Replace<PositionComponent>();
			
			Debug.Log(newEntity.Has<PositionComponent>());
			
			//newEntity.Remove<PositionComponent>();
			
			newEntity.Add<HelloComponent>();
			
			Debug.Log(newEntity.Has<PositionComponent>());
		}
	}
}