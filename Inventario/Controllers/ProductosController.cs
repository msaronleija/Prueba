using Microsoft.AspNetCore.Mvc;
using Inventario.Models;

namespace Inventario.Controllers
{
    public class ProductosController : Controller
    {
        private readonly IProductoRepository _repository;

        //El framework de inyección de dependencias de ASP.NET Core se 
        //encargará de proporcionar una instancia de IProductoRepository al controlador
        public ProductosController(IProductoRepository repository)
        {
            _repository = repository;
        }

        // GET: Productos
        public IActionResult Index()
        {
            var productos = _repository.ObtenerTodos();
            return View(productos);
        }

        // GET: Productos/Details/3
        public IActionResult Details(int id)
        {
            var producto = _repository.ObtenerPorId(id);
            if (producto == null)
            {
                return NotFound();
            }
            return View(producto);
        }
    }
}
