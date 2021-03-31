using aplikacje_WWW_program_3.Models;
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
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public string SessionInfo_Number { get; private set; }

        [BindProperty]
        public FizzBuzz FizzBuzz { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                FizzBuzz.Wyswietl();
                FizzBuzz.pobierzDate(DateTime.Now);
                HttpContext.Session.SetString("Number", JsonConvert.SerializeObject(FizzBuzz));
            }
            return Page();
        }

    }
}
