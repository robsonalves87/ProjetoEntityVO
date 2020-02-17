using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjetoEntityVO.MVC.ValueObjects
{
    public class Email : ValueObject
    {
        [Required(ErrorMessage = "Preencha o Campo E-mail")]
        [MaxLength(250, ErrorMessage = "Máximo 250 caracteres")]
        [EmailAddress(ErrorMessage = "Preencha um E-mail válido")]
        [DisplayName("E-mail")]
        public string Endereco { get; private set; }
    }
}
