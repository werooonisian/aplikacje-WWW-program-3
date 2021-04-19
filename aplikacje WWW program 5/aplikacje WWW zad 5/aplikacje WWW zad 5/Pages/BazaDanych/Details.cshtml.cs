using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using aplikacje_WWW_zad_5.Data;
using aplikacje_WWW_zad_5.Models;

namespace aplikacje_WWW_zad_5.Pages.BazaDanych
{
    public class DetailsModel : PageModel
    {
        private readonly aplikacje_WWW_zad_5.Data.ContextClass _context;

        public DetailsModel(aplikacje_WWW_zad_5.Data.ContextClass context)
        {
            _context = context;
        }

        public Product Product { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Product = await _context.Product.FirstOrDefaultAsync(m => m.Id == id);

            if (Product == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
