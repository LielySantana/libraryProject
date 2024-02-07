using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using bibliotecaProject.Models;

namespace bibliotecaProject.Data
{
    public class PagesAutoresContext : DbContext
    {
        public PagesAutoresContext (DbContextOptions<PagesAutoresContext> options)
            : base(options)
        {
        }

        public DbSet<bibliotecaProject.Models.autores> autores { get; set; } = default!;
    }
}
