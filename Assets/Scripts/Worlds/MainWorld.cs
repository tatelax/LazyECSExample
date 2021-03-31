using LazyECS;
using SampleGame.Features;

namespace SampleGame.Worlds
{
	public class MainWorld : World
	{
		public override void Init()
		{
			features = new Feature[]
			{
				new TestFeature()
			};
		}
	}
}