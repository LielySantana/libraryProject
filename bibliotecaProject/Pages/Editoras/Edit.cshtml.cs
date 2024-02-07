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

namespace bibliotecaProject.Pages.Editoras
{
    public class EditModel : PageModel
    {
        private readonly bibliotecaProject.Data.PagesEditorasContext _context;

        public EditModel(bibliotecaProject.Data.PagesEditorasContext context)
        {
            _context = context;
        }

        [BindProperty]
        public editoras editoras { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var editoras =  await _context.editoras.FirstOrDefaultAsync(m => m.Id == id);
            if (editoras == null)
            {
                return NotFound();
            }
            editoras = editoras;
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

            _context.Attach(editoras).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!editorasExists(editoras.Id))
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

        private bool editorasExists(int id)
        {
            return _context.editoras.Any(e => e.Id == id);
        }
    }
}
