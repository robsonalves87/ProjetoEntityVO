using ProjetoEntityVO.Domain.ValueObjects;
using ProjetoEntityVO.Shared.Entities;
using System;

namespace ProjetoEntityVO.Domain.Entities
{
    public class Cliente : Entity
    {
        public Cliente(Guid id, Nome nome, Documento documento, Email email, DateTime dataNascimento)
        {
            Id = id;
            Nome = nome;
            Documento = documento;
            Email = email;
            DataNascimento = dataNascimento;
            Ativo = true;
        }

        protected Cliente() { }

        public Nome Nome { get; private set; }
        public Documento Documento { get; private set; }
        public Endereco Endereco { get; private set; }
        public Email Email { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public DateTime DataInclusao { get; private set; }

    }
}
