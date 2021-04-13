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
    public class IndexModel : PageModel
    {
        private readonly aplikacje_WWW_program_3.Data.ContextClass _context;

        public IndexModel(aplikacje_WWW_program_3.Data.ContextClass context)
        {
            _context = context;
        }

        public List<FizzBuzz> FizzBuzzList { get;set; }

        public async Task OnGetAsync()
        {
            FizzBuzzList = await _context.FizzBuzz.ToListAsync();
            FizzBuzzList = FizzBuzz.ogarnijListe(FizzBuzzList);
            await _context.SaveChangesAsync();
        }
    }
}
