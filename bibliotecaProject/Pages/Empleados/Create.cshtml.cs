using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using bibliotecaProject.Data;
using bibliotecaProject.Models;

namespace bibliotecaProject.Pages.Empleados
{
    public class CreateModel : PageModel
    {
        private readonly bibliotecaProject.Data.PagesEmpleadosContext _context;

        public CreateModel(bibliotecaProject.Data.PagesEmpleadosContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public empleados empleados { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.empleados.Add(empleados);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
