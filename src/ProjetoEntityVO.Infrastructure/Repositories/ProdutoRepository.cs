using Microsoft.EntityFrameworkCore;
using ProjetoEntityVO.Domain.Entities;
using ProjetoEntityVO.Domain.Interfaces.Repositories;
using ProjetoEntityVO.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoEntityVO.Infrastructure.Repositories
{
    public class ProdutoRepository : RepositoryBase<Produto>, IProdutoRepository
    {
        public ProdutoRepository(ProjetoEntityVOContext context) : base(context)
        {
        }

        public override IList<Produto> BuscarTodos()
        {
            return dbSet
                    .Include(p => p.CategoriaProduto)
                    .ToList();
        }

        public override Produto BuscaPorId(Guid id)
        {
            return dbSet
                    .Include(p => p.CategoriaProduto)
                    .Where(p => p.Id == id)
                    .FirstOrDefault();
        }
    }
}
