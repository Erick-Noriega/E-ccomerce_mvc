using Tienda.Models;

namespace Tienda.Data
{
    public static class DbSeeder
    {
       
            public static void Seed(EccomerceDbContext context)
            {
                context.Database.EnsureCreated();

                // Si ya hay productos, no vuelve a cargar el Seeder
                if (context.Productos.Any())
                    return;


                // =========================
                // CATEGORÍAS
                // =========================

                var electronica = new Categoria
                {
                    Descripcion = "Electrónica"
                };

                var ropa = new Categoria
                {
                    Descripcion = "Ropa"
                };

                var hogar = new Categoria
                {
                    Descripcion = "Hogar"
                };

                var deportes = new Categoria
                {
                    Descripcion = "Deportes"
                };

                context.Categorias.AddRange(
                    electronica,
                    ropa,
                    hogar,
                    deportes
                );

                context.SaveChanges();


                // =========================
                // PRODUCTOS
                // =========================

                var productos = new List<Producto>
        {
            new Producto
            {
                Nombre = "Auriculares Bluetooth",
                NroProducto = 1001,
                Precio = 25999,
                Stock = 25,
                Categoria = electronica,
                ImagenUrl = "/images/productos/auriculares.jpg"
            },

            new Producto
            {
                Nombre = "Teclado Mecánico",
                NroProducto = 1002,
                Precio = 45999,
                Stock = 15,
                Categoria = electronica,
                ImagenUrl = "/images/productos/teclado.jpg"
            },

            new Producto
            {
                Nombre = "Mouse Gamer",
                NroProducto = 1003,
                Precio = 32999,
                Stock = 30,
                Categoria = electronica,
                ImagenUrl = "/images/productos/mouse.jpg"
            },

            new Producto
            {
                Nombre = "Remera Básica",
                NroProducto = 2001,
                Precio = 14999,
                Stock = 50,
                Categoria = ropa,
                ImagenUrl = "/images/productos/remera.jpg"
            },

            new Producto
            {
                Nombre = "Buzo Deportivo",
                NroProducto = 2002,
                Precio = 32999,
                Stock = 20,
                Categoria = ropa,
                ImagenUrl = "/images/productos/buzo.jpg"
            },

            new Producto
            {
                Nombre = "Zapatillas Running",
                NroProducto = 3001,
                Precio = 79999,
                Stock = 12,
                Categoria = deportes,
                ImagenUrl = "/images/productos/zapatillas.jpg"
            },

            new Producto
            {
                Nombre = "Botella Deportiva",
                NroProducto = 3002,
                Precio = 12999,
                Stock = 35,
                Categoria = deportes,
                ImagenUrl = "/images/productos/botella.jpg"
            },

            new Producto
            {
                Nombre = "Lámpara LED",
                NroProducto = 4001,
                Precio = 18999,
                Stock = 18,
                Categoria = hogar,
                ImagenUrl = "/images/productos/lampara.jpg"
            }
        };

                context.Productos.AddRange(productos);

                context.SaveChanges();


                // =========================
                // OFERTAS
                // =========================

                var ofertaElectronica = new Ofertas
                {
                    MotivoDeOferta = "Oferta de lanzamiento",
                    PorcentajeDeDescuento = 15,
                    FechaInicio = DateTime.Now,
                    FechaFinal = DateTime.Now.AddDays(15),
                    disponible = true,

                    Productos = new List<Producto>
            {
                productos[0], // Auriculares
                productos[1], // Teclado
                productos[2]  // Mouse
            }
                };

                var ofertaRopa = new Ofertas
                {
                    MotivoDeOferta = "Liquidación de temporada",
                    PorcentajeDeDescuento = 20,
                    FechaInicio = DateTime.Now,
                    FechaFinal = DateTime.Now.AddDays(30),
                    disponible = true,

                    Productos = new List<Producto>
            {
                productos[3], // Remera
                productos[4]  // Buzo
            }
                };

                var ofertaDeportes = new Ofertas
                {
                    MotivoDeOferta = "Oferta deportiva",
                    PorcentajeDeDescuento = 10,
                    FechaInicio = DateTime.Now,
                    FechaFinal = DateTime.Now.AddDays(20),
                    disponible = true,

                    Productos = new List<Producto>
            {
                productos[5], // Zapatillas
                productos[6]  // Botella
            }
                };

                context.Ofertas.AddRange(
                    ofertaElectronica,
                    ofertaRopa,
                    ofertaDeportes
                );

                context.SaveChanges();
            }
        }
    
}
