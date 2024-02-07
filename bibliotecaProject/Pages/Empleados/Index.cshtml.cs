using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using bibliotecaProject.Data;
using bibliotecaProject.Models;

namespace bibliotecaProject.Pages.Empleados
{
    public class IndexModel : PageModel
    {
        private readonly bibliotecaProject.Data.PagesEmpleadosContext _context;

        public IndexModel(bibliotecaProject.Data.PagesEmpleadosContext context)
        {
            _context = context;
        }

        public IList<empleados> empleados { get;set; } = default!;

        public async Task OnGetAsync()
        {
            empleados = await _context.empleados.ToListAsync();
        }
    }
}
