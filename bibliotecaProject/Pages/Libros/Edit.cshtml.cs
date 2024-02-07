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

namespace bibliotecaProject.Pages.Libros
{
    public class EditModel : PageModel
    {
        private readonly bibliotecaProject.Data.PagesLibrosContext _context;

        public EditModel(bibliotecaProject.Data.PagesLibrosContext context)
        {
            _context = context;
        }

        [BindProperty]
        public libros libros { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var libros =  await _context.libros.FirstOrDefaultAsync(m => m.Id == id);
            if (libros == null)
            {
                return NotFound();
            }
            libros = libros;
           ViewData["cienciaId"] = new SelectList(_context.Set<ciencias>(), "Id", "Id");
           ViewData["idiomaId"] = new SelectList(_context.Set<idiomas>(), "Id", "Id");
           ViewData["autoresId"] = new SelectList(_context.Set<autores>(), "Id", "Id");
           ViewData["editoraId"] = new SelectList(_context.Set<editoras>(), "Id", "Id");
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

            _context.Attach(libros).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!librosExists(libros.Id))
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

        private bool librosExists(int id)
        {
            return _context.libros.Any(e => e.Id == id);
        }
    }
}
