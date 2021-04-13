using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aplikacje_WWW_program_3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;

namespace aplikacje_WWW_program_3.Pages
{
    public class NumberModel : PageModel
    {
        public FizzBuzz FizzBuzz { get; set; }

        public void OnGet()
        {
            var SessionFizzBuzz = HttpContext.Session.GetString("Number");
            if (SessionFizzBuzz != null)
                FizzBuzz = JsonConvert.DeserializeObject<FizzBuzz>(SessionFizzBuzz);

        }
    }
}
