using ProjetoEntityVO.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoEntityVO.Domain.Interfaces.Services
{
    public interface ICategoriaDoProdutoService : IServiceBase<CategoriaDoProduto>
    {
        IList<CategoriaDoProduto> ObterCategoriasDoProdutoAtivas(IList<CategoriaDoProduto> categoriaDoProdutos);
    }
}
