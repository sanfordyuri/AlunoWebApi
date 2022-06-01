using System;
using System.ComponentModel.DataAnnotations;

namespace AlunoWebApi.Model.Dto
{
    public class UsuarioDto
    {
        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo Senha é obrigatório.")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "O campo Role é obrigatório.")]
        public string Role { get; set; }
    }
}
