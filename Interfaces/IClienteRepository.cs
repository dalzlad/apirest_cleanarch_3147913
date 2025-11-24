using APIConcesionario.Models;

namespace APIConcesionario.Interfaces
{
    public interface IClienteRepository
    {
        Task<IEnumerable<Cliente>> GetAll();
        Task<Cliente?> GetById(int id);
        Task<Cliente> Add(Cliente cliente);
        Task<Cliente?> Update(int id, Cliente cliente);
        Task<bool> Delete(int id);
    }
}