using ProjetoEntityVO.Application.Interfaces;
using ProjetoEntityVO.Domain.Entities;
using ProjetoEntityVO.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace ProjetoEntityVO.Application.Services
{
    public class CategoriaDoProdutoAppService : AppServiceBase<CategoriaDoProduto>, ICategoriaDoProdutoAppService
    {
        private readonly ICategoriaDoProdutoService _categoriaDoProdutoService;

        public CategoriaDoProdutoAppService(ICategoriaDoProdutoService categoriaDoProdutoService) : base(categoriaDoProdutoService)
        {
            _categoriaDoProdutoService = categoriaDoProdutoService;
        }

        public IList<CategoriaDoProduto> ObterCategoriasDoProdutoAtivas()
        {
            return _categoriaDoProdutoService.ObterCategoriasDoProdutoAtivas(_categoriaDoProdutoService.BuscarTodos());
        }
    }
}
