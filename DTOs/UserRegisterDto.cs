using System.ComponentModel.DataAnnotations;

namespace APIConcesionario.DTOs
{
    public class UserRegisterDto
    {
        [Required]
        public string Username { get; set; } = "";

        // Contraseña en formato HASH (nunca se guarda la contraseña real)
        [Required]
        public string Password { get; set; } = "";
    }
}
