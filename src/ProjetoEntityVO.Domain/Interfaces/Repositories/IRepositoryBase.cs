using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEntityVO.Domain.Interfaces.Repositories
{
    public interface IRepositoryBase<TEntity> : IDisposable where TEntity : class
    {
        void Incluir(TEntity obj);
        void Atualizar(TEntity obj);
        void Excluir(TEntity obj);
        IList<TEntity> BuscarTodos();
        IList<TEntity> BuscarTodosAtivos();
        TEntity BuscaPorId(Guid id);
        int SaveChanges();

    }
}
