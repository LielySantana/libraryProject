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

namespace bibliotecaProject.Pages.Ciencias
{
    public class EditModel : PageModel
    {
        private readonly bibliotecaProject.Data.PagesCienciasContext _context;

        public EditModel(bibliotecaProject.Data.PagesCienciasContext context)
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

            var ciencias =  await _context.ciencias.FirstOrDefaultAsync(m => m.Id == id);
            if (ciencias == null)
            {
                return NotFound();
            }
            ciencias = ciencias;
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

            _context.Attach(ciencias).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!cienciasExists(ciencias.Id))
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

        private bool cienciasExists(int id)
        {
            return _context.ciencias.Any(e => e.Id == id);
        }
    }
}
