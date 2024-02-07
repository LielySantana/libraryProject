using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using bibliotecaProject.Data;
using bibliotecaProject.Models;

namespace bibliotecaProject.Pages.Usuarios
{
    public class IndexModel : PageModel
    {
        private readonly bibliotecaProject.Data.PagesUsuariosContext _context;

        public IndexModel(bibliotecaProject.Data.PagesUsuariosContext context)
        {
            _context = context;
        }

        public IList<usuarios> usuarios { get;set; } = default!;

        public async Task OnGetAsync()
        {
            usuarios = await _context.usuarios.ToListAsync();
        }
    }
}
