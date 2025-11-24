using Microsoft.EntityFrameworkCore.Scaffolding;

namespace APIConcesionario.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public long Documento { get; set; }
        public string NombreCompleto { get; set; }
        public long Whatsapp {  get; set; }
    }
}
