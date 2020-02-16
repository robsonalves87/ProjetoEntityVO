using ProjetoEntityVO.Domain.Entities;
using System.Collections.Generic;

namespace ProjetoEntityVO.Application.Interfaces
{
    public interface ICategoriaDoProdutoAppService : IAppServiceBase<CategoriaDoProduto>
    {
        IList<CategoriaDoProduto> ObterCategoriasDoProdutoAtivas();
    }
}
