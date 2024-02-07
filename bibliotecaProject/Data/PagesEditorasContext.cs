using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using bibliotecaProject.Models;

namespace bibliotecaProject.Data
{
    public class PagesEditorasContext : DbContext
    {
        public PagesEditorasContext (DbContextOptions<PagesEditorasContext> options)
            : base(options)
        {
        }

        public DbSet<bibliotecaProject.Models.editoras> editoras { get; set; } = default!;
    }
}
