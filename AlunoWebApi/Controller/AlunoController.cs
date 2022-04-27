using System;
using AlunoWebApi.Data;
using AlunoWebApi.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace AlunoWebApi.Controller
{

    [ApiController]
    [Route("aluno")]
    public class AlunoController : ControllerBase
    {

        private AppDbContext _context;

        public AlunoController(AppDbContext _context)
        {
            this._context = _context;  
        }

        [HttpPost]
        public void AdicionarAluno([FromBody] Aluno aluno)
        {
            _context.Alunos.Add(aluno);
            _context.SaveChanges();
            Console.WriteLine("Novo aluno adicionado: " + aluno.Nome);
        }

        [HttpGet]
        public IEnumerable<Aluno> RetonarAlunos()
        {
            return _context.Alunos;
        }

    }
}
