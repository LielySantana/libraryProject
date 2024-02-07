using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using bibliotecaProject.Data;
using bibliotecaProject.Models;

namespace bibliotecaProject.Pages.Autores
{
    public class DeleteModel : PageModel
    {
        private readonly bibliotecaProject.Data.PagesAutoresContext _context;

        public DeleteModel(bibliotecaProject.Data.PagesAutoresContext context)
        {
            _context = context;
        }

        [BindProperty]
        public autores autores { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var autores = await _context.autores.FirstOrDefaultAsync(m => m.Id == id);

            if (autores == null)
            {
                return NotFound();
            }
            else
            {
                autores = autores;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var autores = await _context.autores.FindAsync(id);
            if (autores != null)
            {
                autores = autores;
                _context.autores.Remove(autores);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
