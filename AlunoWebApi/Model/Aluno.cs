using System;
using System.ComponentModel.DataAnnotations;

namespace AlunoWebApi.Model
{
    public class Aluno
    {

        [Key]
        [Required]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo nome é obrigatório.")]
        [MinLength(4, ErrorMessage = "O campo nome pode ter no mínimo 4 caracteres.")]
        [MaxLength(64, ErrorMessage = "O campo nome pode ter no máximo 64 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo CPF é obrigatório.")]
        [MinLength(14, ErrorMessage = "O campo CPF precisa de 14 caracteres.")]
        [MaxLength(14, ErrorMessage = "O campo CPF precisa de 14 caracteres.")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "O campo Nascimento é obrigatório.")]
        public DateTime Nascimento { get; set; }

    }
}
