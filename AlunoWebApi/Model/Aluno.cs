using System;
using System.ComponentModel.DataAnnotations;

namespace AlunoWebApi.Model
{
    public class Aluno
    {
        public Guid Id { get; set; }

        public string Nome { get; set; }

        public string CPF { get; set; }

        public DateTime Nascimento { get; set; }

        public Guid idEndereco { get; set; }

        public virtual Endereco Endereco { get; set; }
    }
}
