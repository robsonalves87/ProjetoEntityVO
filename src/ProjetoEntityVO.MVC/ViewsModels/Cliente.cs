using ProjetoEntityVO.MVC.ValueObjects;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjetoEntityVO.MVC.Entities
{
    public class Cliente
    {
        public Nome Nome { get; private set; }
        public Documento Documento { get; private set; }
        public Endereco Endereco { get; private set; }
        public Email Email { get; private set; }

        [Required(ErrorMessage = "Preencha o Campo Data de Nascimento")]
        [DisplayName("Data de Nascimento")]
        public DateTime DataNascimento { get; private set; }
        //public DateTime DataInclusao { get; private set; }
    }
}
