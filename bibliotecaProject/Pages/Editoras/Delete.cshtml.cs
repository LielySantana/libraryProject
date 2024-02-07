using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using bibliotecaProject.Data;
using bibliotecaProject.Models;

namespace bibliotecaProject.Pages.Editoras
{
    public class DeleteModel : PageModel
    {
        private readonly bibliotecaProject.Data.PagesEditorasContext _context;

        public DeleteModel(bibliotecaProject.Data.PagesEditorasContext context)
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

            var editoras = await _context.editoras.FirstOrDefaultAsync(m => m.Id == id);

            if (editoras == null)
            {
                return NotFound();
            }
            else
            {
                editoras = editoras;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var editoras = await _context.editoras.FindAsync(id);
            if (editoras != null)
            {
                editoras = editoras;
                _context.editoras.Remove(editoras);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
