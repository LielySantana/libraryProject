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
    public class IndexModel : PageModel
    {
        private readonly bibliotecaProject.Data.PagesLibrosContext _context;

        public IndexModel(bibliotecaProject.Data.PagesLibrosContext context)
        {
            _context = context;
        }

        public IList<libros> libros { get;set; } = default!;

        public async Task OnGetAsync()
        {
            libros = await _context.libros
                .Include(l => l.Ciencia)
                .Include(l => l.Idioma)
                .Include(l => l.autores)
                .Include(l => l.editora).ToListAsync();
        }
    }
}
