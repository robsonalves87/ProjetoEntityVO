using System;
using System.Collections.Generic;

namespace ProjetoEntityVO.Application.Interfaces
{
    public interface IAppServiceBase<TEntity> : IDisposable where TEntity : class
    {
        void Incluir(TEntity obj);
        void Atualizar(TEntity obj);
        void Excluir(TEntity obj);
        IList<TEntity> BuscarTodos();

        //BuscarTodosAtivos direto do banco
        IList<TEntity> BuscarTodosAtivos();
        TEntity BuscaPorId(Guid id);
        int SaveChanges();
    }
}
