﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using aplikacje_WWW_program_3.Data;
using aplikacje_WWW_program_3.Models;

namespace aplikacje_WWW_program_3.Pages.razorCRUD
{
    public class EditModel : PageModel
    {
        private readonly aplikacje_WWW_program_3.Data.ContextClass _context;

        public EditModel(aplikacje_WWW_program_3.Data.ContextClass context)
        {
            _context = context;
        }

        [BindProperty]
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(FizzBuzz).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FizzBuzzExists(FizzBuzz.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool FizzBuzzExists(int id)
        {
            return _context.FizzBuzz.Any(e => e.Id == id);
        }
    }
}
