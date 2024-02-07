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
    public class IndexModel : PageModel
    {
        private readonly bibliotecaProject.Data.PagesTiposBibliografiaContext _context;

        public IndexModel(bibliotecaProject.Data.PagesTiposBibliografiaContext context)
        {
            _context = context;
        }

        public IList<tiposBibliografia> tiposBibliografia { get;set; } = default!;

        public async Task OnGetAsync()
        {
            tiposBibliografia = await _context.tiposBibliografia.ToListAsync();
        }
    }
}
