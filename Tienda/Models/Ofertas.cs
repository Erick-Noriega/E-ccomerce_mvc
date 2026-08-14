namespace Tienda.Models
{
    public class Ofertas
    {
        public int Id { get; set; }
        public string MotivoDeOferta { get; set; }
        public float PorcentajeDeDescuento { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinal { get; set; }
        public bool disponible { get; set; }
        public List<Producto>? Productos { get; set; }

    }
}
