using System;
using System.Linq;
using AlunoWebApi.Data;
using AlunoWebApi.Model;
using Microsoft.AspNetCore.Mvc;

namespace EnderecoWebApi.Controller
{

    [ApiController]
    [Route("endereco")]
    public class EnderecoController : ControllerBase
    {

        private AppDbContext _context;

        public EnderecoController(AppDbContext _context)
        {
            this._context = _context;
        }

        [HttpPost]
        public IActionResult AdicionarEndereco([FromBody] Endereco endereco)
        {
            _context.Enderecos.Add(endereco);
            _context.SaveChanges();

            return CreatedAtAction(nameof(RetornarPorId), new { Id = endereco.Id }, endereco);
        }

        [HttpGet]
        public IActionResult RetonarEnderecos()
        {
            return Ok(_context.Enderecos);
        }

        [HttpGet("{id}")]
        public IActionResult RetornarPorId(Guid Id)
        {
            Endereco endereco = _context.Enderecos.FirstOrDefault(endereco => endereco.Id == Id);
            if (endereco != null)
            {
                return Ok(endereco);
            }
            return NotFound(endereco);
        }

        [HttpPut("{id}")]
        public IActionResult EditarPorId(Guid Id, [FromBody] Endereco novoEndereco)
        {
            Endereco endereco = _context.Enderecos.FirstOrDefault(endereco => endereco.Id == Id);
            if (endereco != null)
            {
                endereco.CEP = novoEndereco.CEP;
                endereco.Numero = endereco.Numero;
                endereco.Bairro = novoEndereco.Bairro;
                endereco.Logradouro = novoEndereco.Logradouro;
                _context.SaveChanges();
                return NoContent();
            }
            return NotFound(endereco);
        }

        [HttpDelete("{id}")]
        public IActionResult ExcluirPorId(Guid Id)
        {
            Endereco endereco = _context.Enderecos.FirstOrDefault(endereco => endereco.Id == Id);
            if (endereco != null)
            {
                _context.Enderecos.Remove(endereco);
                _context.SaveChanges();
                return Ok(endereco);
            }
            return NotFound(endereco);
        }

    }
}
