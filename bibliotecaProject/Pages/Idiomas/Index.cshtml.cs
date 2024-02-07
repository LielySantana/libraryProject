using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using bibliotecaProject.Data;
using bibliotecaProject.Models;

namespace bibliotecaProject.Pages.Idiomas
{
    public class IndexModel : PageModel
    {
        private readonly bibliotecaProject.Data.PagesIdiomasContext _context;

        public IndexModel(bibliotecaProject.Data.PagesIdiomasContext context)
        {
            _context = context;
        }

        public IList<idiomas> idiomas { get;set; } = default!;

        public async Task OnGetAsync()
        {
            idiomas = await _context.idiomas.ToListAsync();
        }
    }
}
