namespace Tienda.Models
{
    public class DetallePedido
    {
        public int Id { get; set; }
        public Pedido? pedido { get; set; }
        public int PedidoId { get; set; }
        public Producto? producto { get; set; }
        public int ProductoId { get; set; }
        public DateTime Fecha { get; set; }
        public float  precio_x_uni { get; set; }

    }
}
