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
    public class IndexModel : PageModel
    {
        private readonly aplikacje_WWW_zad_5.Data.ContextClass _context;

        public IndexModel(aplikacje_WWW_zad_5.Data.ContextClass context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; }

        public async Task OnGetAsync()
        {
            Product = await _context.Product.ToListAsync();
        }
    }
}
