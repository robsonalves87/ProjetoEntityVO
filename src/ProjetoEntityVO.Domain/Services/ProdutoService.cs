using ProjetoEntityVO.Domain.Entities;
using ProjetoEntityVO.Domain.Interfaces.Repositories;
using ProjetoEntityVO.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEntityVO.Domain.Services
{
    public class ProdutoService : ServiceBase<Produto>, IProdutoService
    {
        private IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository) : base(produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }
    }
}
