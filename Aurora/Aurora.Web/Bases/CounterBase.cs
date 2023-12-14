using Microsoft.AspNetCore.Components;

namespace Aurora.Web.Bases
{
	public class CounterBase : ComponentBase
	{
		protected int currentCount = 0;

		protected void IncrementCount()
		{
			currentCount++;
		}
	}
}
