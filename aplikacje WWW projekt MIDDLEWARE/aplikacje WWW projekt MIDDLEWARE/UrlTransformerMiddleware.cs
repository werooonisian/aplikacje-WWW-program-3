using Microsoft.AspNetCore.Http;
using Shyjus.BrowserDetection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aplikacje_WWW_projekt_MIDDLEWARE
{
    public class UrlTransformerMiddleware
    {
        private RequestDelegate _next;
        public UrlTransformerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context, IBrowserDetector detector)
        {
            var browser = detector.Browser;
            if (browser.Name == BrowserNames.Edge || browser.Name == BrowserNames.InternetExplorer || browser.Name == BrowserNames.EdgeChromium)
            {
                await context.Response.WriteAsync("Przeglądarka nie jest obsługiwana");
            }
            else
            {
                await _next(context);
            }
        }
    }
}
