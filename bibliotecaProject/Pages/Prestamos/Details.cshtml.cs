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
    public class DetailsModel : PageModel
    {
        private readonly bibliotecaProject.Data.PagesPrestamosContext _context;

        public DetailsModel(bibliotecaProject.Data.PagesPrestamosContext context)
        {
            _context = context;
        }

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
    }
}
