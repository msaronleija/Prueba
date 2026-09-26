using Inventario.Data;
using Inventario.Models;

namespace Inventario.Repository
{
    public class ProductosRepositoryEF : IProductoRepository
    {
        private readonly AppDbContext _context; //Inyección de dependencias del contexto de la base de datos
        public ProductosRepositoryEF(AppDbContext context)
        {
            _context = context; //Inicializa el contexto de la base de datos
        }
        public IEnumerable<Producto> ObtenerTodos()
        {
            return _context.Productos.ToList(); //SELECT * FROM Productos
        }
        public Producto? ObtenerPorId(int id)
        {
            return _context.Productos.Find(id); //SELECT * FROM Productos WHERE Id = id
        }
        public void Agregar(Producto producto)
        {
            _context.Productos.Add(producto); //INSERT INTO Productos (Nombre, Categoria, Precio, Stock) VALUES (...)
            _context.SaveChanges(); //Guarda los cambios en la base de datos
        }
        public void Eliminar(int id)
        {
            var producto = _context.Productos.Find(id); //SELECT * FROM Productos WHERE Id = id
            if (producto != null)
            {
                _context.Productos.Remove(producto); //DELETE FROM Productos WHERE Id = id
                _context.SaveChanges(); //Guarda los cambios en la base de datos
            }
        }
    
    }
}
