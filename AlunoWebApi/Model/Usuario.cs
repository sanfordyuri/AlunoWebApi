using System;

namespace AlunoWebApi.Model
{
    public class Usuario
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Role { get; set; }
    }
}
