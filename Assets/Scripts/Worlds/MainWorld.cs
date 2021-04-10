using Features;
using LazyECS;

public class MainWorld : World
{
	public MainWorld()
	{
		Features = new Feature[]
		{
			new MainFeature(this)
		};
	}
}