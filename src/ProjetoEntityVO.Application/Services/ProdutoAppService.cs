using ProjetoEntityVO.Application.Interfaces;
using ProjetoEntityVO.Domain.Entities;
using ProjetoEntityVO.Domain.Interfaces.Services;

namespace ProjetoEntityVO.Application.Services
{
    public class ProdutoAppService : AppServiceBase<Produto>, IProdutoAppService
    {
        private readonly IProdutoService _produtoService;

        public ProdutoAppService(IProdutoService produtoService) : base(produtoService)
        {
            _produtoService = produtoService;
        }
    }
}
