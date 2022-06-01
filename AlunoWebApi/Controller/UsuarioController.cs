using AlunoWebApi.Data;
using AlunoWebApi.Model;
using AlunoWebApi.Model.Dto;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace AlunoWebApi.Controller
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        private AppDbContext _context;
        private IMapper _mapper;

        public UsuarioController(AppDbContext _context, IMapper mapper)
        {
            this._context = _context;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult AdicionarUsuario([FromBody] UsuarioDto usuarioDto)
        {
            Usuario usuario = _mapper.Map<Usuario>(usuarioDto);
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();

            return CreatedAtAction(nameof(RetornarPorId), new { Id = usuario.Id }, usuario);
        }

        [HttpGet]
        public IActionResult RetonarUsuarios()
        {
            return Ok(_context.Usuarios);
        }

        [HttpGet("{id}")]
        public IActionResult RetornarPorId(Guid Id)
        {
            Usuario usuario = _context.Usuarios.FirstOrDefault(usuario => usuario.Id == Id);
            if (usuario != null)
            {
                return Ok(usuario);
            }
            return NotFound(usuario);
        }

        [HttpPut("{id}")]
        public IActionResult EditarPorId(Guid Id, [FromBody] Usuario novoUsuario)
        {
            Usuario usuario = _context.Usuarios.FirstOrDefault(usuario => usuario.Id == Id);
            if (usuario != null)
            {
                usuario.Nome = novoUsuario.Nome;
                usuario.Role = usuario.Role;
                usuario.Senha = novoUsuario.Senha;
                _context.SaveChanges();
                return NoContent();
            }
            return NotFound(usuario);
        }

        [HttpDelete("{id}")]
        public IActionResult ExcluirPorId(Guid Id)
        {
            Usuario usuario = _context.Usuarios.FirstOrDefault(usuario => usuario.Id == Id);
            if (usuario != null)
            {
                _context.Usuarios.Remove(usuario);
                _context.SaveChanges();
                return Ok(usuario);
            }
            return NotFound(usuario);
        }
    }
}
