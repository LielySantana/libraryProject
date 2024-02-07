using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using bibliotecaProject.Data;
using bibliotecaProject.Models;

namespace bibliotecaProject.Pages.Editoras
{
    public class CreateModel : PageModel
    {
        private readonly bibliotecaProject.Data.PagesEditorasContext _context;

        public CreateModel(bibliotecaProject.Data.PagesEditorasContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public editoras editoras { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.editoras.Add(editoras);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
