using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using bibliotecaProject.Data;
using bibliotecaProject.Models;

namespace bibliotecaProject.Pages.Editoras
{
    public class IndexModel : PageModel
    {
        private readonly bibliotecaProject.Data.PagesEditorasContext _context;

        public IndexModel(bibliotecaProject.Data.PagesEditorasContext context)
        {
            _context = context;
        }

        public IList<editoras> editoras { get;set; } = default!;

        public async Task OnGetAsync()
        {
            editoras = await _context.editoras.ToListAsync();
        }
    }
}
