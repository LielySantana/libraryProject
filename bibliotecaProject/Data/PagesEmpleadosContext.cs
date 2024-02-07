using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using bibliotecaProject.Models;

namespace bibliotecaProject.Data
{
    public class PagesEmpleadosContext : DbContext
    {
        public PagesEmpleadosContext (DbContextOptions<PagesEmpleadosContext> options)
            : base(options)
        {
        }

        public DbSet<bibliotecaProject.Models.empleados> empleados { get; set; } = default!;
    }
}
