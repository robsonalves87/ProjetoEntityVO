using ProjetoEntityVO.Shared.Entities;
using System;

namespace ProjetoEntityVO.Domain.Entities
{
    public class CategoriaDoProduto : Entity
    {
        public CategoriaDoProduto(Guid id, string nome, string descricao)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            Ativo = true;
        }

        protected CategoriaDoProduto() { }

        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public DateTime DataInclusao { get; private set; }

        //Categoria ativas por regra de negocio
        public bool CategoriaDoProdutoAtiva(CategoriaDoProduto categoriaDoProduto)
        {
            return categoriaDoProduto.Ativo;
        }
    }
}
