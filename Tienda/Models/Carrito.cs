using System.ComponentModel.DataAnnotations;

namespace Tienda.Models
{
    public class Carrito
    {
        public int Id { get; set; }
        public Cliente? cliente { get; set; }
        public string ClienteId { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime Fecha { get; set; }
        public List<DetalleCarrito>? detalleCarrito { get; set; }

    }
}
