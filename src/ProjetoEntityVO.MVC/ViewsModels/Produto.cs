using System;

namespace ProjetoEntityVO.MVC.ViewsModels
{
    public class Produto
    {
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public CategoriaDoProduto CategoriaProduto { get; private set; }
        public Guid CategoriaProdutoId { get; private set; }
        public decimal Valor { get; private set; }
        public DateTime DataInclusao { get; private set; }
    }
}
