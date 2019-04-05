using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;

namespace WebStore.Infrastructure.Filters
{
	class ActionFilter : IActionFilter
	{
		public void OnActionExecuting(ActionExecutingContext context)
		{

		}

		public void OnActionExecuted(ActionExecutedContext context)
		{

		}
	}

	class ActionFilterAsync : Attribute, IAsyncActionFilter
	{
		public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
		{
			await next();
		}
	}
}
