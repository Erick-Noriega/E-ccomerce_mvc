using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Tienda.Models;

namespace Tienda.Data
{
    public class EccomerceDbContext:IdentityDbContext<Cliente>
    {
        public EccomerceDbContext(DbContextOptions<EccomerceDbContext> options) : base(options)
        {
        }
           public DbSet<Producto> Productos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Ofertas> Ofertas { get; set; }
        public DbSet<DetallePedido> DetallePedidos { get; set; }
        public DbSet<DetalleCarrito> DetalleCarritos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Carrito> Carrito { get; set; }

    }
    }
