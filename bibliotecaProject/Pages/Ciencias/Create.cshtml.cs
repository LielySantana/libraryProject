using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using bibliotecaProject.Data;
using bibliotecaProject.Models;

namespace bibliotecaProject.Pages.Ciencias
{
    public class CreateModel : PageModel
    {
        private readonly bibliotecaProject.Data.PagesCienciasContext _context;

        public CreateModel(bibliotecaProject.Data.PagesCienciasContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public ciencias ciencias { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.ciencias.Add(ciencias);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
