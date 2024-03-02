using System;
using bibliotecaProject.Data;
using Microsoft.EntityFrameworkCore;

namespace bibliotecaProject.Models
{
    public static class seedEmployees
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new PagesEmpleadosContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<PagesEmpleadosContext>>()))
            {
                //if (context == null || context.empleados == null)
                //{
                //    throw new ArgumentNullException("Null PagesEmpleadosContext");
                //}

                //// Look for any movies.
                //if (context.e.Any())
                //{
                //    return;   // DB has been seeded
                //}

                //context.empleados.AddRange(
                //    new empleados
                //    {
                //        Id = 1,
                //        Nombre = "Juan Perez",
                //        Cedula = "4022287777",
                //        TandaLabor = "PM",
                //        PorcientoComision = "15"

                //    }
                //);
                context.SaveChanges();
            }
        }
    }
}
