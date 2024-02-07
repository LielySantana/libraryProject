using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using bibliotecaProject.Data;
using bibliotecaProject.Models;

namespace bibliotecaProject.Pages.Prestamos
{
    public class IndexModel : PageModel
    {
        private readonly bibliotecaProject.Data.PagesPrestamosContext _context;

        public IndexModel(bibliotecaProject.Data.PagesPrestamosContext context)
        {
            _context = context;
        }

        public IList<prestamo> prestamo { get;set; } = default!;

        public async Task OnGetAsync()
        {
            prestamo = await _context.prestamo
                .Include(p => p.Empleado)
                .Include(p => p.Libro)
                .Include(p => p.Usuario).ToListAsync();
        }
    }
}
