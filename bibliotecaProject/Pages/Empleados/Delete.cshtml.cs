using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using bibliotecaProject.Data;
using bibliotecaProject.Models;

namespace bibliotecaProject.Pages.Empleados
{
    public class DeleteModel : PageModel
    {
        private readonly bibliotecaProject.Data.PagesEmpleadosContext _context;

        public DeleteModel(bibliotecaProject.Data.PagesEmpleadosContext context)
        {
            _context = context;
        }

        [BindProperty]
        public empleados empleados { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var empleados = await _context.empleados.FirstOrDefaultAsync(m => m.Id == id);

            if (empleados == null)
            {
                return NotFound();
            }
            else
            {
                empleados = empleados;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var empleados = await _context.empleados.FindAsync(id);
            if (empleados != null)
            {
                empleados = empleados;
                _context.empleados.Remove(empleados);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
