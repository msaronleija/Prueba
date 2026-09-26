using System.ComponentModel.DataAnnotations;

namespace Inventario.Models
{
    public class Producto
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "El nombre del producto es obligatorio.")]
        [StringLength(100)]
        public string Nombre { get; set; }


        [Required] //NOT NULL
        [StringLength(50)] //VARCHAR(50)
        public string Categoria { get; set; }

        //NULL - DOUBLE - DECIMAL
        [Range(0,double.MaxValue, ErrorMessage = "El precio debe ser un valor positivo.")]
        public decimal Precio { get; set; }


        [Range(0, int.MaxValue)]
        public int Stock { get; set; }

        //Propiedad calculada: indica si el stock es bajo (menos de 5 unidades)
        public bool EsStockBajo => Stock <= 5;
    }
}
