using Microsoft.EntityFrameworkCore;
using Inventario.Models;

namespace Inventario.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        // Una propiedad DbSet para cada entidad que quieras mapear a una tabla de la base de datos
        public DbSet<Producto> Productos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Producto>().HasData(
                new Producto { Id = 1, Nombre = "Laptop", Categoria = "Electrónica", Precio = 999.99m, Stock = 10 },
                new Producto { Id = 2, Nombre = "Smartphone", Categoria = "Electrónica", Precio = 499.99m, Stock = 3 },
                new Producto { Id = 3, Nombre = "Mesa de Oficina", Categoria = "Muebles", Precio = 199.00m, Stock = 15 },
                new Producto { Id = 4, Nombre = "Silla Ergonómica", Categoria = "Muebles", Precio = 149.99m, Stock = 2 },
                new Producto { Id = 5, Nombre = "Mouse Ergonómico", Categoria = "Electrónica", Precio = 700.00m, Stock = 5 }
            );
        }
}
}
