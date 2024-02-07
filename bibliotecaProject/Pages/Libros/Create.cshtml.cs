using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using bibliotecaProject.Data;
using bibliotecaProject.Models;

namespace bibliotecaProject.Pages.Libros
{
    public class CreateModel : PageModel
    {
        private readonly bibliotecaProject.Data.PagesLibrosContext _context;

        public CreateModel(bibliotecaProject.Data.PagesLibrosContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["cienciaId"] = new SelectList(_context.Set<ciencias>(), "Id", "Id");
        ViewData["idiomaId"] = new SelectList(_context.Set<idiomas>(), "Id", "Id");
        ViewData["autoresId"] = new SelectList(_context.Set<autores>(), "Id", "Id");
        ViewData["editoraId"] = new SelectList(_context.Set<editoras>(), "Id", "Id");
            return Page();
        }

        [BindProperty]
        public libros libros { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.libros.Add(libros);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
