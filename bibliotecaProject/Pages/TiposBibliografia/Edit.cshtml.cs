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

namespace bibliotecaProject.Pages.TiposBibliografia
{
    public class EditModel : PageModel
    {
        private readonly bibliotecaProject.Data.PagesTiposBibliografiaContext _context;

        public EditModel(bibliotecaProject.Data.PagesTiposBibliografiaContext context)
        {
            _context = context;
        }

        [BindProperty]
        public tiposBibliografia tiposBibliografia { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tiposbibliografia =  await _context.tiposBibliografia.FirstOrDefaultAsync(m => m.Id == id);
            if (tiposbibliografia == null)
            {
                return NotFound();
            }
            tiposBibliografia = tiposbibliografia;
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

            _context.Attach(tiposBibliografia).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tiposBibliografiaExists(tiposBibliografia.Id))
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

        private bool tiposBibliografiaExists(int id)
        {
            return _context.tiposBibliografia.Any(e => e.Id == id);
        }
    }
}
