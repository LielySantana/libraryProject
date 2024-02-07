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
    public class DetailsModel : PageModel
    {
        private readonly bibliotecaProject.Data.PagesCienciasContext _context;

        public DetailsModel(bibliotecaProject.Data.PagesCienciasContext context)
        {
            _context = context;
        }

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
    }
}
