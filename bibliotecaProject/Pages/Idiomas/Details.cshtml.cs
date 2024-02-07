using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using bibliotecaProject.Data;
using bibliotecaProject.Models;

namespace bibliotecaProject.Pages.Idiomas
{
    public class DetailsModel : PageModel
    {
        private readonly bibliotecaProject.Data.PagesIdiomasContext _context;

        public DetailsModel(bibliotecaProject.Data.PagesIdiomasContext context)
        {
            _context = context;
        }

        public idiomas idiomas { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var idiomas = await _context.idiomas.FirstOrDefaultAsync(m => m.Id == id);
            if (idiomas == null)
            {
                return NotFound();
            }
            else
            {
                idiomas = idiomas;
            }
            return Page();
        }
    }
}
