using System.ComponentModel.DataAnnotations;

namespace ProjetoEntityVO.MVC.ValueObjects
{
    public class Documento : ValueObject
    {
        [Required(ErrorMessage = "Preencha o Campo RG")]
        [MaxLength(15, ErrorMessage = "Máximo 15 caracteres")]
        [MinLength(5, ErrorMessage = "Minimo 5 caracteres")]
        public string RG { get; private set; }

        [Required(ErrorMessage = "Preencha o Campo CPF")]
        [MaxLength(11, ErrorMessage = "Máximo 11 caracteres")]
        [MinLength(11, ErrorMessage = "Minimo 11 caracteres")]
        public string CPF { get; private set; }
    }
}
