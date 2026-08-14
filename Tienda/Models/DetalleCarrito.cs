namespace Tienda.Models
{
    public class DetalleCarrito
    {

        public int Id { get; set; }
        public Producto? producto { get; set; }
        public Carrito? carrito { get; set; }
        public int Cantidad { get; set; }
        public float precio_por_unidad { get; set; }
    }
}
