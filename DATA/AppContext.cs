using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Hidrobo_T1S6.Models;

namespace Hidrobo_T1S6.DATA
{
    public class AppContext : DbContext
    {
        public DbSet<ProductoModel> Productos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Aquí va tu cadena de conexión, ajusta los valores según tu servidor y base
            optionsBuilder.UseMySql(
                "server=localhost;database=productos_pets;user=root;password=",
                new MySqlServerVersion(new Version(8, 0, 36)) // O la versión que estés usando
            );
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configuración personalizada del modelo si necesitas
            modelBuilder.Entity<ProductoModel>().ToTable("productos");
        }
    }
}
