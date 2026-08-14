using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Tienda.Models
{
    public class Cliente :IdentityUser  
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }
        [Required]
        [StringLength(50)]
        public string Apellido { get; set; }
        public string? ImagenurlPerfil { get; set; }
        public DateTime FechaNac { get; set; }
        [Required]
        [StringLength(50)]
        public string Correo { get; set; }
        [Required]
        [StringLength(50)]
        public string Contraseña { get; set; }
        public List<Pedido>? pedidos { get; set; }



    }
}
