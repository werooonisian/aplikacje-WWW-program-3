using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aplikacje_WWW_filtrowanie.Utils
{
    public class AsyncFilter : ResultFilterAttribute
    {
        public override async Task OnResultExecutionAsync(ResultExecutingContext context, ResultExecutionDelegate next)
        {
            var result = context.Result;
            if (result is PageResult)
            {
                var page = ((PageResult)result);
                page.ViewData["filterMessage"] = context.HttpContext.Connection.RemoteIpAddress.MapToIPv4(); 
            }
            await next.Invoke();
        }
    }
}