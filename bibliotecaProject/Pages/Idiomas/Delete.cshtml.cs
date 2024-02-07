using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using bibliotecaProject.Data;
using bibliotecaProject.Models;

namespace bibliotecaProject.Pages.Idiomas
{
    public class DeleteModel : PageModel
    {
        private readonly bibliotecaProject.Data.PagesIdiomasContext _context;

        public DeleteModel(bibliotecaProject.Data.PagesIdiomasContext context)
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

            var idiomas = await _context.idiomas.FirstOrDefaultAsync(m => m.Id == id);

            if (idiomas == null)
            {
                return NotFound();
            }
            else
            {
                idiomas = idiomas;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var idiomas = await _context.idiomas.FindAsync(id);
            if (idiomas != null)
            {
                idiomas = idiomas;
                _context.idiomas.Remove(idiomas);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
