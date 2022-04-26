using System;

namespace AlunoWebApi.Model
{
    public class Aluno
    {

        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime Nascimento { get; set; }

    }
}
