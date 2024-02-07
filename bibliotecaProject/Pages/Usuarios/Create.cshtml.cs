using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using bibliotecaProject.Data;
using bibliotecaProject.Models;

namespace bibliotecaProject.Pages.Usuarios
{
    public class CreateModel : PageModel
    {
        private readonly bibliotecaProject.Data.PagesUsuariosContext _context;

        public CreateModel(bibliotecaProject.Data.PagesUsuariosContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public usuarios usuarios { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.usuarios.Add(usuarios);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
