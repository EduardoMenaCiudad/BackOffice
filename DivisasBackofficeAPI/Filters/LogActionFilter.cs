using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DivisasBackofficeAPI.Filters
{
    public class LogActionFilter : IActionFilter
    {

        public void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine($" ///// Request = {context.HttpContext.Request}");
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            Console.WriteLine($" ///// Response = {context.HttpContext.Response}");
        }
    }
}
