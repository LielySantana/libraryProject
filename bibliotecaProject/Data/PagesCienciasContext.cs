using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using bibliotecaProject.Models;

namespace bibliotecaProject.Data
{
    public class PagesCienciasContext : DbContext
    {
        public PagesCienciasContext (DbContextOptions<PagesCienciasContext> options)
            : base(options)
        {
        }

        public DbSet<bibliotecaProject.Models.ciencias> ciencias { get; set; } = default!;
    }
}
