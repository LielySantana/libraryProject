using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using bibliotecaProject.Data;
using bibliotecaProject.Models;

namespace bibliotecaProject.Pages.Prestamos
{
    public class CreateModel : PageModel
    {
        private readonly bibliotecaProject.Data.PagesPrestamosContext _context;

        public CreateModel(bibliotecaProject.Data.PagesPrestamosContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["empleadoId"] = new SelectList(_context.Set<empleados>(), "Id", "Cedula");
        ViewData["libroId"] = new SelectList(_context.Set<libros>(), "Id", "ISBN");
        ViewData["usuarioId"] = new SelectList(_context.Set<usuarios>(), "Id", "Cedula");
            return Page();
        }

        [BindProperty]
        public prestamo prestamo { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.prestamo.Add(prestamo);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
