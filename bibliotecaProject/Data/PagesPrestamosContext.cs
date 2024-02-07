using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using bibliotecaProject.Models;

namespace bibliotecaProject.Data
{
    public class PagesPrestamosContext : DbContext
    {
        public PagesPrestamosContext (DbContextOptions<PagesPrestamosContext> options)
            : base(options)
        {
        }

        public DbSet<bibliotecaProject.Models.prestamo> prestamo { get; set; } = default!;
    }
}
