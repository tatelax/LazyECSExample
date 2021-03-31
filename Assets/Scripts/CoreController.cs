using System;
using System.Collections.Generic;
using LazyECS;
using SampleGame.Worlds;

namespace SampleGame
{
	public class CoreController : MonoBehaviourSingleton<CoreController>
	{
		public Dictionary<Type, World> Worlds { get; private set; }

		protected override void Awake()
		{
			base.Awake();
			
			Worlds = new Dictionary<Type, World>
			{
				{typeof(MainWorld), new MainWorld()}
			};
			
			// TODO: make this happen automatically as part of the ecs framework
			foreach (KeyValuePair<Type,World> world in Worlds)
			{
				world.Value.Init();
			}
		}

		public void Start()
		{
			foreach (KeyValuePair<Type,World> world in Worlds)
			{
				world.Value.Start();
			}
		}

		public void Update()
		{
			foreach (KeyValuePair<Type,World> world in Worlds)
			{
				world.Value.Update();
				world.Value.Cleanup();
			}
		}

		public void OnDisable()
		{
			foreach (KeyValuePair<Type,World> world in Worlds)
			{
				world.Value.Teardown();
			}
		}
	}
}
