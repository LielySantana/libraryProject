using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using bibliotecaProject.Data;
using bibliotecaProject.Models;

namespace bibliotecaProject.Pages.Ciencias
{
    public class DeleteModel : PageModel
    {
        private readonly bibliotecaProject.Data.PagesCienciasContext _context;

        public DeleteModel(bibliotecaProject.Data.PagesCienciasContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ciencias ciencias { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ciencias = await _context.ciencias.FirstOrDefaultAsync(m => m.Id == id);

            if (ciencias == null)
            {
                return NotFound();
            }
            else
            {
                ciencias = ciencias;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ciencias = await _context.ciencias.FindAsync(id);
            if (ciencias != null)
            {
                ciencias = ciencias;
                _context.ciencias.Remove(ciencias);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
