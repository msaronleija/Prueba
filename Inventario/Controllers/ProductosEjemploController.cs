using AspNetCoreGeneratedDocument;
using Microsoft.AspNetCore.Mvc;
using Inventario.Models;

namespace Inventario.Controllers
{
    public class ProductosEjemploController : Controller
    {
        //Lista simulada en memoria de productos (se cambiar una base de datos en una aplicación real)
        public static List<Producto> _productos = new List<Producto>
        {
            new Producto { Id = 1, Nombre = "Laptop", Categoria = "Electrónica", Precio = 999.99m, Stock = 10 },
            new Producto { Id = 2, Nombre = "Smartphone", Categoria = "Electrónica", Precio = 499.99m, Stock = 3 },
            new Producto { Id = 3, Nombre = "Mesa de Oficina", Categoria = "Muebles", Precio = 199.00m, Stock = 15 },
            new Producto { Id = 4, Nombre = "Silla Ergonómica", Categoria = "Muebles", Precio = 149.99m, Stock = 2 },
            new Producto { Id = 5, Nombre = "Mouse Ergonómico", Categoria = "Electrónica", Precio = 700.00m, Stock = 5 }
        };


        // GET: /Productos/Index
        public IActionResult Index()
        {
            return View(_productos);
        }
    }
}
