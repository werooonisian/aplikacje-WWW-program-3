using aplikacje_WWW_program_3.Models;
using aplikacje_WWW_program_3.Pages;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aplikacje_WWW_program_3.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;
        [BindProperty]
        public FizzBuzz FizzBuzz { get; set; }

        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            var SessionFizzBuzz = HttpContext.Session.GetString("SessionFizzBuzz");
            if (SessionFizzBuzz != null)
              FizzBuzz = JsonConvert.DeserializeObject<FizzBuzz>(SessionFizzBuzz);

        }

    }
}
