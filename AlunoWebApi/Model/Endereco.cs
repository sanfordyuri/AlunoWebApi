using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace AlunoWebApi.Model
{
    public class Endereco
    {
        [Key]
        public Guid Id { get; set; }

        public int Numero { get; set; }

        public string CEP { get; set; }

        public string Bairro { get; set; }

        public string Logradouro { get; set; }

        [JsonIgnore]
        public virtual Aluno Aluno { get; set; }
    }
}
