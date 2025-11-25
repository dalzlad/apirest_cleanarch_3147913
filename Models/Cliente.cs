using Microsoft.EntityFrameworkCore.Scaffolding;

namespace APIConcesionario.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public required long Documento { get; set; }
        public required string NombreCompleto { get; set; }
        public required long Whatsapp {  get; set; }

        //Clave foránea
        public required int IdCiudad {  get; set; }

        //Navegilidad entre Cliente y ciudad
        public Ciudad? Ciudad { get; set; }
    }
}
