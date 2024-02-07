using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using bibliotecaProject.Models;

namespace bibliotecaProject.Data
{
    public class PagesIdiomasContext : DbContext
    {
        public PagesIdiomasContext (DbContextOptions<PagesIdiomasContext> options)
            : base(options)
        {
        }

        public DbSet<bibliotecaProject.Models.idiomas> idiomas { get; set; } = default!;
    }
}
