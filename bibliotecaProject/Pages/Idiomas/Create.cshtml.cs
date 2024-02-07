using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using bibliotecaProject.Data;
using bibliotecaProject.Models;

namespace bibliotecaProject.Pages.Idiomas
{
    public class CreateModel : PageModel
    {
        private readonly bibliotecaProject.Data.PagesIdiomasContext _context;

        public CreateModel(bibliotecaProject.Data.PagesIdiomasContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public idiomas idiomas { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.idiomas.Add(idiomas);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
