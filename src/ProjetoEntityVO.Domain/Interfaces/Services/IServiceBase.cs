using System;
using System.Collections.Generic;

namespace ProjetoEntityVO.Domain.Interfaces.Services
{
    public interface IServiceBase<TEntity> : IDisposable where TEntity : class
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
