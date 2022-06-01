using System;
using System.Linq;
using AlunoWebApi.Data;
using AlunoWebApi.Model;
using AlunoWebApi.Model.Dto;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AlunoWebApi.Controller
{

    [ApiController]
    [Route("aluno")]
    public class AlunoController : ControllerBase
    {

        private AppDbContext _context;
        private IMapper _mapper;

        public AlunoController(AppDbContext _context, IMapper mapper)
        {
            this._context = _context;
            _mapper = mapper;   
        }

        [HttpPost]
        public IActionResult AdicionarAluno([FromBody] AlunoDto alunoDto)
        {
            Aluno aluno = _mapper.Map<Aluno>(alunoDto);
            _context.Alunos.Add(aluno);
            _context.SaveChanges();

            return CreatedAtAction(nameof(RetornarPorId), new { Id = aluno.Id }, aluno);
        }

        [HttpGet]
        public IActionResult RetonarAlunos()
        {
            return Ok(_context.Alunos);
        }

        [HttpGet("{id}")]
        public IActionResult RetornarPorId(Guid Id)
        {
            Console.WriteLine("Id: " + Id);
            Aluno aluno = _context.Alunos.FirstOrDefault(aluno => aluno.Id == Id);
            if (aluno != null)
            {
                return Ok(aluno);
            }
            return NotFound(aluno);
        }

        [HttpPut("{id}")]
        public IActionResult EditarPorId(Guid Id, [FromBody] Aluno novoAluno)
        {
            Aluno aluno = _context.Alunos.FirstOrDefault(aluno => aluno.Id == Id);
            if (aluno != null)
            {
                aluno.CPF = novoAluno.CPF;
                aluno.Nome = novoAluno.Nome;
                aluno.Nascimento = novoAluno.Nascimento;
                _context.SaveChanges();
                return NoContent();
            }
            return NotFound(aluno);
        }

        [HttpDelete("{id}")]
        public IActionResult ExcluirPorId(Guid Id)
        {
            Aluno aluno = _context.Alunos.FirstOrDefault(aluno => aluno.Id == Id);
            if (aluno != null)
            {
                _context.Alunos.Remove(aluno);
                _context.SaveChanges();
                return Ok(aluno);
            }
            return NotFound(aluno);
        }

    }
}
