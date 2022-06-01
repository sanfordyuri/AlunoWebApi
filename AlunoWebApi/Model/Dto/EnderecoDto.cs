using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace AlunoWebApi.Model.Dto
{
    public class EnderecoDto
    {
        [Required(ErrorMessage = "O campo Numero é obrigatório")]
        public int Numero { get; set; }

        [Required(ErrorMessage = "O campo CEP é obrigatório")]
        public string CEP { get; set; }

        [Required(ErrorMessage = "O campo Bairro é obrigatório")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "O campo Logradouro é obrigatório")]
        public string Logradouro { get; set; }

        [JsonIgnore]
        public virtual Aluno Aluno { get; set; }
    }
}
