using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using bibliotecaProject.Data;
using bibliotecaProject.Models;

namespace bibliotecaProject.Pages.Libros
{
    public class DetailsModel : PageModel
    {
        private readonly bibliotecaProject.Data.PagesLibrosContext _context;

        public DetailsModel(bibliotecaProject.Data.PagesLibrosContext context)
        {
            _context = context;
        }

        public libros libros { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var libros = await _context.libros.FirstOrDefaultAsync(m => m.Id == id);
            if (libros == null)
            {
                return NotFound();
            }
            else
            {
                libros = libros;
            }
            return Page();
        }
    }
}
