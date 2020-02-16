using ProjetoEntityVO.Shared.Entities;
using System;

namespace ProjetoEntityVO.Domain.Entities
{
    public class Produto : Entity
    {
        public Produto(Guid id, string nome, string descricao, Guid categoriaProdutoId, decimal valor)
        {
            Id = id;
            Nome = nome;
            CategoriaProdutoId = categoriaProdutoId;
            Descricao = descricao;
            Valor = valor;
            Ativo = true;
        }

        protected Produto() { }

        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public CategoriaDoProduto CategoriaProduto { get; private set; }
        public Guid CategoriaProdutoId { get; private set; }
        public decimal Valor { get; private set; }
        public DateTime DataInclusao { get; private set; }
    }
}
