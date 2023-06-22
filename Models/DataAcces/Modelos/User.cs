using System.ComponentModel.DataAnnotations;

namespace ApuestasWebCaballos.Models
{
    public class User
    {
        public int? Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }

     

        // Definición de la relación con Roles
        [Required]
        public int RolId { get; set; }
        public virtual Rol? Roles { get; set; }
    }


}

