using APIConcesionario.Models;

namespace APIConcesionario.Interfaces
{
    public interface IUserRepository
    {
        Task<User?> GetByUsernameAsync (string username);
        Task<User> RegisterAsync(User user);
    }
}
