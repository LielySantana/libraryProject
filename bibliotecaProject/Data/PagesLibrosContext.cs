using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using bibliotecaProject.Models;

namespace bibliotecaProject.Data
{
    public class PagesLibrosContext : DbContext
    {
        public PagesLibrosContext (DbContextOptions<PagesLibrosContext> options)
            : base(options)
        {
        }

        public DbSet<bibliotecaProject.Models.libros> libros { get; set; } = default!;
    }
}
