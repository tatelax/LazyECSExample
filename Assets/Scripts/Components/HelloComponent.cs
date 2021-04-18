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
		
		public bool Set(object value)
		{
			Value = (string)value;
			return true;
		}

		public object Get()
		{
			return Value;
		}
	}
}