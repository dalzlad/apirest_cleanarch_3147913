using System.ComponentModel.DataAnnotations;

namespace APIConcesionario.DTOs
{
    public class ClienteDto
    {
        [Required(ErrorMessage = "El documento es Obligatorio")]
        public long Documento { get; set; }
        [Required(ErrorMessage = "El nombre es Obligatorio")]
        [StringLength(50, MinimumLength = 3,ErrorMessage = "Debe tener entre 3 y 50 caracteres")]
        public string NombreCompleto { get; set; } = "";
        [Required]
        public long Whatsapp { get; set; }
        [Required]
        public int IdCiudad { get; set; }

    }
}
