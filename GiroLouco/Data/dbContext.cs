using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GiroLouco.Models;

namespace GiroLouco.Data
{
    public class dbContext : DbContext
    {
        public dbContext (DbContextOptions<dbContext> options)
            : base(options)
        {
        }

        public DbSet<GiroLouco.Models.Clientes> Clientes { get; set; } = default!;

        public DbSet<GiroLouco.Models.Maquinas> Maquinas { get; set; } = default!;

        public DbSet<GiroLouco.Models.Inventario> Inventario { get; set; } = default!;
    }
}
