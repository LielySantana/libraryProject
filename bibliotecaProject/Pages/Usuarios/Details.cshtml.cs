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
    public class DetailsModel : PageModel
    {
        private readonly bibliotecaProject.Data.PagesUsuariosContext _context;

        public DetailsModel(bibliotecaProject.Data.PagesUsuariosContext context)
        {
            _context = context;
        }

        public usuarios usuarios { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuarios = await _context.usuarios.FirstOrDefaultAsync(m => m.Id == id);
            if (usuarios == null)
            {
                return NotFound();
            }
            else
            {
                usuarios = usuarios;
            }
            return Page();
        }
    }
}
