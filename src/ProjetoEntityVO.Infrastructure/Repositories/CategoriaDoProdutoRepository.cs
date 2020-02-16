using ProjetoEntityVO.Domain.Entities;
using ProjetoEntityVO.Domain.Interfaces.Repositories;
using ProjetoEntityVO.Infrastructure.Context;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoEntityVO.Infrastructure.Repositories
{
    public class CategoriaDoProdutoRepository : RepositoryBase<CategoriaDoProduto>, ICategoriaDoProdutoRepository
    {
        public CategoriaDoProdutoRepository(ProjetoEntityVOContext context) : base(context)
        {
        }

        //BuscarTodosAtivos direto do banco
        public override IList<CategoriaDoProduto> BuscarTodosAtivos()
        {
            return dbSet
                .Where(cp => cp.Ativo == true)
                .ToList();
        }

    }
}