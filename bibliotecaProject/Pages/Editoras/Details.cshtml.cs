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
    public class DetailsModel : PageModel
    {
        private readonly bibliotecaProject.Data.PagesEditorasContext _context;

        public DetailsModel(bibliotecaProject.Data.PagesEditorasContext context)
        {
            _context = context;
        }

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
    }
}
