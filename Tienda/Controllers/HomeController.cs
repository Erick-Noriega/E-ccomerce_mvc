using System.Diagnostics;
using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tienda.Data;
using Tienda.Models;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Tienda.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly EccomerceDbContext _context;
        public HomeController(ILogger<HomeController> logger, EccomerceDbContext context)
        {
            _logger = logger; 
            _context = context;
        }

        public async Task<IActionResult> Index(int page = 1,string txtbusqueda="",int categoriaId=0)
        {
            const int pageSize = 8;
            if (page < 1) page = 1;

            var consulta = _context.Productos.AsQueryable();
            if (!string.IsNullOrEmpty(txtbusqueda))
            {
                consulta= consulta.Where(p => p.Nombre.Contains(txtbusqueda));
            }
            if (categoriaId > 0)
            {
                consulta = consulta.Where(c => c.CategoriaId == categoriaId);
            }






            var totalItems = await consulta.CountAsync();
            var totalPages = (int)Math.Ceiling(totalItems / (double)pageSize);

            var productos = await consulta
                .Include(p => p.Categoria)
                .OrderBy(p => p.Id)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            ViewBag.Page = page;
            ViewBag.PageSize = pageSize;
            ViewBag.TotalItems = totalItems;
            ViewBag.TotalPages = totalPages;
            ViewBag.TxtBusqueda = txtbusqueda;
            var categorias = await _context.Categorias.OrderBy(c => c.Descripcion).ToListAsync();
            categorias.Insert(0, new Categoria { Id = 0, Descripcion = "Todos" });
            ViewBag.CategoriaId = new SelectList
                (
                categorias,
                "Id", "Descripcion", categoriaId
                );

            return View(productos);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
