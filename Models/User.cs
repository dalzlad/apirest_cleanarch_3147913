namespace APIConcesionario.Models
{
    public class User
    {
        public int Id { get; set; }

        // Nombre de usuario con el que inicia sesión
        public string Username { get; set; } = "";

        // Contraseña en formato HASH (nunca se guarda la contraseña real)
        public string PasswordHash { get; set; } = "";

        // Rol del usuario (permite control de permisos futuros)
        public string Role { get; set; } = "User";

    }
}
