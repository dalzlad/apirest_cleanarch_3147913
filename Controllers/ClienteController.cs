using APIConcesionario.DTOs;
using APIConcesionario.Interfaces;
using APIConcesionario.Models;
using APIConcesionario.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APIConcesionario.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteController(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        // GET: api/<ClienteController>
        [HttpGet]
        public async Task<IActionResult> GetAll() =>
            Ok(await _clienteRepository.GetAll());

        // GET api/<ClienteController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
           var cliente = await _clienteRepository.GetById(id);
            if (cliente == null) return NotFound();
           return Ok(cliente);
        }

        // POST api/<ClienteController>
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] ClienteDto clienteDto)
        {
            var newCliente = new Cliente
            {
                Documento = clienteDto.Documento,
                NombreCompleto = clienteDto.NombreCompleto,
                Whatsapp = clienteDto.Whatsapp
            };
            var created = await _clienteRepository.Add(newCliente);
            return CreatedAtAction(nameof(GetById), new {id=created.Id}, created);
        }

        // PUT api/<ClienteController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] ClienteDto clienteDto)
        {
            var updateCliente = new Cliente
            {
                Documento = clienteDto.Documento,
                NombreCompleto = clienteDto.NombreCompleto,
                Whatsapp = clienteDto.Whatsapp
            };
            var updated = await _clienteRepository.Update(id, updateCliente);
            if (updated == null) return NotFound();
            return Ok(updated);
        }

        // DELETE api/<ClienteController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var deleted = await _clienteRepository.Delete(id);
            if(!deleted) return NotFound();
            return NoContent();
        }
    }
}
