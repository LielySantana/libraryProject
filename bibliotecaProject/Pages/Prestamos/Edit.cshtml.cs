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

namespace bibliotecaProject.Pages.Prestamos
{
    public class EditModel : PageModel
    {
        private readonly bibliotecaProject.Data.PagesPrestamosContext _context;

        public EditModel(bibliotecaProject.Data.PagesPrestamosContext context)
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

            var prestamo =  await _context.prestamo.FirstOrDefaultAsync(m => m.Id == id);
            if (prestamo == null)
            {
                return NotFound();
            }
            prestamo = prestamo;
           ViewData["empleadoId"] = new SelectList(_context.Set<empleados>(), "Id", "Cedula");
           ViewData["libroId"] = new SelectList(_context.Set<libros>(), "Id", "ISBN");
           ViewData["usuarioId"] = new SelectList(_context.Set<usuarios>(), "Id", "Cedula");
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

            _context.Attach(prestamo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!prestamoExists(prestamo.Id))
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

        private bool prestamoExists(int id)
        {
            return _context.prestamo.Any(e => e.Id == id);
        }
    }
}
