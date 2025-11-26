using System.Security.Cryptography;
using System.Text;

namespace APIConcesionario.Services
{
    // Servicio que se encarga de convertir contraseñas a HASH seguro.
    public class PasswordService
    {
        // Convierte una contraseña a HASH usando SHA256
         public string Hash(string password)
        {
            var sha = SHA256.Create();
            var bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
            return Convert.ToBase64String(bytes);
        }

        //Verificar el password
        public bool Verify(string password, string hash)
        {
            return Hash(password) == hash;
        }
    }
}
