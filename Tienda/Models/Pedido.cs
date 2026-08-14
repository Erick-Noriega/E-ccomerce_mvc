using System.ComponentModel.DataAnnotations;

namespace Tienda.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public Cliente cliente { get; set; }
        public string ClienteId { get; set; }
        public string direcciondeenvio { get; set; }
        public string EstadoPedido { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime fecha_pedido { get; set; }
        //row version for concurrency control
        [Timestamp]
        public byte[] RowVersion { get; set; }


    }
}
