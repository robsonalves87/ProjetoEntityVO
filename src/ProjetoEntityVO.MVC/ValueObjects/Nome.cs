using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjetoEntityVO.MVC.ValueObjects
{
    public class Nome : ValueObject
    {
        [Required(ErrorMessage = "Preencha o Campo Nome")]
        [MaxLength(150, ErrorMessage = "Máximo 150 caracteres")]
        [MinLength(2, ErrorMessage = "Minimo 2 caracteres")]
        [DisplayName("Nome")]
        public string PrimeiroNome { get; set; }

        [Required(ErrorMessage = "Preencha o Campo Sobrenome")]
        [MaxLength(250, ErrorMessage = "Máximo 250 caracteres")]
        [MinLength(2, ErrorMessage = "Minimo 2 caracteres")]
        public string Sobrenome { get; private set; }
    }
}
