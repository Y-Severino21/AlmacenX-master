using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AlmacenX.Models;

namespace AlmacenX.Data
{
    public class ClienteContext : DbContext
    {
        public ClienteContext (DbContextOptions<ClienteContext> options)
            : base(options)
        {
        }

        public DbSet<AlmacenX.Models.Cliente> Cliente { get; set; }
    }
}
