using LazyECS.Component;

namespace Components
{
	public class HelloComponent : IComponent
	{
		public HelloComponent()
		{
			Value = "";
		}

		private string Value { get; set; }
		
		public void Set(object value)
		{
			Value = (string)value;
		}

		public object Get()
		{
			return Value;
		}
	}
}