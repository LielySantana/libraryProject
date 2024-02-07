using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using bibliotecaProject.Data;
using bibliotecaProject.Models;

namespace bibliotecaProject.Pages.TiposBibliografia
{
    public class DetailsModel : PageModel
    {
        private readonly bibliotecaProject.Data.PagesTiposBibliografiaContext _context;

        public DetailsModel(bibliotecaProject.Data.PagesTiposBibliografiaContext context)
        {
            _context = context;
        }

        public tiposBibliografia tiposBibliografia { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tiposbibliografia = await _context.tiposBibliografia.FirstOrDefaultAsync(m => m.Id == id);
            if (tiposbibliografia == null)
            {
                return NotFound();
            }
            else
            {
                tiposBibliografia = tiposbibliografia;
            }
            return Page();
        }
    }
}
