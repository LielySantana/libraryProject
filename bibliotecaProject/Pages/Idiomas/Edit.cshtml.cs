using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using bibliotecaProject.Data;
using bibliotecaProject.Models;

namespace bibliotecaProject.Pages.Idiomas
{
    public class EditModel : PageModel
    {
        private readonly bibliotecaProject.Data.PagesIdiomasContext _context;

        public EditModel(bibliotecaProject.Data.PagesIdiomasContext context)
        {
            _context = context;
        }

        [BindProperty]
        public idiomas idiomas { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var idiomas =  await _context.idiomas.FirstOrDefaultAsync(m => m.Id == id);
            if (idiomas == null)
            {
                return NotFound();
            }
            idiomas = idiomas;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(idiomas).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!idiomasExists(idiomas.Id))
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

        private bool idiomasExists(int id)
        {
            return _context.idiomas.Any(e => e.Id == id);
        }
    }
}
