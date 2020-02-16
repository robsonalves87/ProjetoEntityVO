using ProjetoEntityVO.Domain.Entities;
using ProjetoEntityVO.Domain.Interfaces.Repositories;
using ProjetoEntityVO.Domain.Interfaces.Services;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoEntityVO.Domain.Services
{
    public class CategoriaDoProdutoService : ServiceBase<CategoriaDoProduto>, ICategoriaDoProdutoService
    {
        private ICategoriaDoProdutoRepository _categoriaDoProdutoRepository;

        public CategoriaDoProdutoService(ICategoriaDoProdutoRepository categoriaDoProdutoRepository) : base(categoriaDoProdutoRepository)
        {
            _categoriaDoProdutoRepository = categoriaDoProdutoRepository;
        }

        public IList<CategoriaDoProduto> ObterCategoriasDoProdutoAtivas(IList<CategoriaDoProduto> categoriaDoProdutos)
        {
            return categoriaDoProdutos.Where(cp => cp.CategoriaDoProdutoAtiva(cp)).ToList();
        }
    }
}
