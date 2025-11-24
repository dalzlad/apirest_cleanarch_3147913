using System.ComponentModel.DataAnnotations;

namespace APIConcesionario.DTOs
{
    public class ClienteDto
    {
        [Required]
        public long Documento { get; set; }
        [Required]
        public string NombreCompleto { get; set; } = "";
        [Required]
        public long Whatsapp { get; set; }
    }
}
