using System.ComponentModel.DataAnnotations;

namespace Tienda.Models
{
    public class Producto
    {
            public  int Id { get; set; }
            public float Precio { get; set; }
            [Required]
            [StringLength(50)]
            public string Nombre { get; set; }
            public int NroProducto { get; set; }
            public string ImagenUrl { get; set; }
            public int Stock { get; set; }
            public Categoria? Categoria { get; set; }
            public int CategoriaId { get; set; }
            public List<Ofertas>? ofertas { get; set; }
            public List<DetalleCarrito>? detalleCarrito { get; set; }
   


    }
}
