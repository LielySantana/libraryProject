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
    public class IndexModel : PageModel
    {
        private readonly bibliotecaProject.Data.PagesCienciasContext _context;

        public IndexModel(bibliotecaProject.Data.PagesCienciasContext context)
        {
            _context = context;
        }

        public IList<ciencias> ciencias { get;set; } = default!;

        public async Task OnGetAsync()
        {
            ciencias = await _context.ciencias.ToListAsync();
        }
    }
}
