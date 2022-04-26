using AlunoWebApi.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace AlunoWebApi.Controller
{

    [ApiController]
    [Route("aluno")]
    public class AlunoController : ControllerBase
    {
        public AlunoController()
        {

        }

        public static List<Aluno> Alunos = new List<Aluno>(); //Representação de um Banco de dados.

        [HttpPost]
        public void AdicionarAluno([FromBody] Aluno aluno)
        {
            Alunos.Add(aluno);
            Console.WriteLine("Novo aluno adicionado: " + aluno.Nome);
        }

        [HttpGet]
        public IEnumerable<Aluno> RetonarAlunos()
        {
            return Alunos;
        }

    }
}
