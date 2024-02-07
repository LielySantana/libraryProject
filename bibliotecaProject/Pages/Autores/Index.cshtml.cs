using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using bibliotecaProject.Data;
using bibliotecaProject.Models;

namespace bibliotecaProject.Pages.Autores
{
    public class IndexModel : PageModel
    {
        private readonly bibliotecaProject.Data.PagesAutoresContext _context;

        public IndexModel(bibliotecaProject.Data.PagesAutoresContext context)
        {
            _context = context;
        }

        public IList<autores> autores { get;set; } = default!;

        public async Task OnGetAsync()
        {
            autores = await _context.autores.ToListAsync();
        }
    }
}
