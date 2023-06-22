using ApuestasWebCaballos.Models.DataAcces;
using System.ComponentModel.DataAnnotations;

namespace ApuestasWebCaballos.Models
{
    public class Rol
    {
        public int? Id { get; set; }

        [Required]
        public string? Name { get; set; }

        // Definición de la relación con Usuarios
        public virtual ICollection<Usuario>? Usuarios { get; set; }



    }
}
