using APIConcesionario.Data;
using APIConcesionario.Interfaces;
using APIConcesionario.Models;
using Microsoft.EntityFrameworkCore;

namespace APIConcesionario.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        public readonly ApplicationDbContext _context;

        public ClienteRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Cliente>> GetAll() =>
            await _context.Clientes.ToListAsync();

        public async Task<Cliente?> GetById(int id) =>
            await _context.Clientes.FindAsync(id);

        public async Task<Cliente> Add(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            await _context.SaveChangesAsync();
            return cliente;
        }

        public async Task<Cliente?> Update(int id, Cliente cliente)
        {
            var existing = await _context.Clientes.FindAsync(id);
            if (existing == null) return null;
            existing.Documento = cliente.Documento;
            existing.NombreCompleto = cliente.NombreCompleto;
            existing.Whatsapp = cliente.Whatsapp;
            existing.IdCiudad = cliente.IdCiudad;

            await _context.SaveChangesAsync();
            return existing;
        }

        public async Task<bool> Delete(int id)
        {
            var existing = await _context.Clientes.FindAsync(id);
            if (existing == null) return false;

            _context.Clientes.Remove(existing);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}


/*
 Crear la api de Ciudad
 */