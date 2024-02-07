using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using bibliotecaProject.Data;
using bibliotecaProject.Models;

namespace bibliotecaProject.Pages.Libros
{
    public class DeleteModel : PageModel
    {
        private readonly bibliotecaProject.Data.PagesLibrosContext _context;

        public DeleteModel(bibliotecaProject.Data.PagesLibrosContext context)
        {
            _context = context;
        }

        [BindProperty]
        public libros libros { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var libros = await _context.libros.FirstOrDefaultAsync(m => m.Id == id);

            if (libros == null)
            {
                return NotFound();
            }
            else
            {
                libros = libros;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var libros = await _context.libros.FindAsync(id);
            if (libros != null)
            {
                libros = libros;
                _context.libros.Remove(libros);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
