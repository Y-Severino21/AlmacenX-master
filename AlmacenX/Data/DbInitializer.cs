using AlmacenX.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlmacenX.Data
{
    public class DbInitializer
    {
        public static void Initialize (ClienteContext context)
        {
            context.Database.EnsureCreated();

            //Buscar si existen registros en la tabla
            if (context.Cliente.Any())
            {
                return;
            }
            var cliente = new Cliente[]
            {
                new Cliente {Nombre="Programacion", Cedula="Cursos de programacion", Estado=true},
                new Cliente {Nombre="Diseño grafico", Cedula="Cursos de diseño grafico", Estado=true}
            };
            foreach (Cliente c in cliente)
            {
                context.Cliente.Add(c);
            }
            context.SaveChanges();
        }
    }
}
