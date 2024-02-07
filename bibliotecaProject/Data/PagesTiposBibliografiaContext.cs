using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using bibliotecaProject.Models;

namespace bibliotecaProject.Data
{
    public class PagesTiposBibliografiaContext : DbContext
    {
        public PagesTiposBibliografiaContext (DbContextOptions<PagesTiposBibliografiaContext> options)
            : base(options)
        {
        }

        public DbSet<bibliotecaProject.Models.tiposBibliografia> tiposBibliografia { get; set; } = default!;
    }
}
