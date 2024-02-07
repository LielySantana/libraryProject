using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using bibliotecaProject.Data;
using bibliotecaProject.Models;

namespace bibliotecaProject.Pages.Prestamos
{
    public class DeleteModel : PageModel
    {
        private readonly bibliotecaProject.Data.PagesPrestamosContext _context;

        public DeleteModel(bibliotecaProject.Data.PagesPrestamosContext context)
        {
            _context = context;
        }

        [BindProperty]
        public prestamo prestamo { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prestamo = await _context.prestamo.FirstOrDefaultAsync(m => m.Id == id);

            if (prestamo == null)
            {
                return NotFound();
            }
            else
            {
                prestamo = prestamo;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prestamo = await _context.prestamo.FindAsync(id);
            if (prestamo != null)
            {
                prestamo = prestamo;
                _context.prestamo.Remove(prestamo);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
