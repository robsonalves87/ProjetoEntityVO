using ProjetoEntityVO.Application.Interfaces;
using ProjetoEntityVO.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace ProjetoEntityVO.Application.Services
{
    public class AppServiceBase<TEntity> : IAppServiceBase<TEntity> where TEntity : class
    {
        private IServiceBase<TEntity> _serviceBase;

        public AppServiceBase(IServiceBase<TEntity> serviceBase)
        {
            _serviceBase = serviceBase;
        }

        public void Dispose()
        {
            _serviceBase.Dispose();
        }

        public void Incluir(TEntity obj)
        {
            _serviceBase.Incluir(obj);
        }

        public void Atualizar(TEntity obj)
        {
            _serviceBase.Atualizar(obj);
        }

        public void Excluir(TEntity obj)
        {
            _serviceBase.Excluir(obj);
        }

        public IList<TEntity> BuscarTodos()
        {
            return _serviceBase.BuscarTodos();
        }

        //BuscarTodosAtivos direto do banco
        public IList<TEntity> BuscarTodosAtivos()
        {
            return _serviceBase.BuscarTodosAtivos();
        }

        public TEntity BuscaPorId(Guid id)
        {
            return _serviceBase.BuscaPorId(id);
        }

        public int SaveChanges()
        {
            return _serviceBase.SaveChanges();
        }
    }
}
