using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjetoEntityVO.MVC.ValueObjects
{
    public class Endereco : ValueObject
    {
        [Required(ErrorMessage = "Preencha o Campo Rua")]
        [MaxLength(200, ErrorMessage = "Máximo 200 caracteres")]
        [MinLength(2, ErrorMessage = "Minimo 2 caracteres")]
        [DisplayName("Rua")]
        public string Logradouro { get; private set; }

        [Required(ErrorMessage = "Preencha o Campo Numero")]
        [MaxLength(100, ErrorMessage = "Máximo 100 caracteres")]
        [MinLength(2, ErrorMessage = "Minimo 2 caracteres")]
        public string Numero { get; private set; }
        public string Complemento { get; private set; }

        [Required(ErrorMessage = "Preencha o Campo Bairro")]
        [MaxLength(150, ErrorMessage = "Máximo 150 caracteres")]
        [MinLength(2, ErrorMessage = "Minimo 2 caracteres")]
        public string Bairro { get; private set; }

        [Required(ErrorMessage = "Preencha o Campo Cidade")]
        [MaxLength(150, ErrorMessage = "Máximo 150 caracteres")]
        [MinLength(2, ErrorMessage = "Minimo 2 caracteres")]
        public string Cidade { get; private set; }

        [Required(ErrorMessage = "Preencha o Campo CEP")]
        public string CEP { get; private set; }
    }
}
