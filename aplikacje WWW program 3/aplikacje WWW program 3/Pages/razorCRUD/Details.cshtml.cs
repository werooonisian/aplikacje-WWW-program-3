using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using aplikacje_WWW_program_3.Data;
using aplikacje_WWW_program_3.Models;

namespace aplikacje_WWW_program_3.Pages.razorCRUD
{
    public class DetailsModel : PageModel
    {
        private readonly aplikacje_WWW_program_3.Data.ContextClass _context;

        public DetailsModel(aplikacje_WWW_program_3.Data.ContextClass context)
        {
            _context = context;
        }

        public FizzBuzz FizzBuzz { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            FizzBuzz = await _context.FizzBuzz.FirstOrDefaultAsync(m => m.Id == id);

            if (FizzBuzz == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
