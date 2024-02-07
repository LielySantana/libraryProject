using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using bibliotecaProject.Models;

namespace bibliotecaProject.Data
{
    public class PagesUsuariosContext : DbContext
    {
        public PagesUsuariosContext (DbContextOptions<PagesUsuariosContext> options)
            : base(options)
        {
        }

        public DbSet<bibliotecaProject.Models.usuarios> usuarios { get; set; } = default!;
    }
}
