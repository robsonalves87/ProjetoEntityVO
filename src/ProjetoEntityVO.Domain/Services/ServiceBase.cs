using ProjetoEntityVO.Domain.Interfaces.Repositories;
using ProjetoEntityVO.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace ProjetoEntityVO.Domain.Services
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repository;

        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            _repository = repository;
        }

        public virtual void Incluir(TEntity obj)
        {
            _repository.Incluir(obj);
        }

        public virtual void Atualizar(TEntity obj)
        {
            _repository.Atualizar(obj);
        }

        public virtual void Excluir(TEntity obj)
        {
            _repository.Excluir(obj);
        }

        public virtual IList<TEntity> BuscarTodos()
        {
            return _repository.BuscarTodos();
        }

        public virtual IList<TEntity> BuscarTodosAtivos()
        {
            return _repository.BuscarTodosAtivos();
        }

        public virtual TEntity BuscaPorId(Guid id)
        {
            return _repository.BuscaPorId(id);
        }

        public int SaveChanges()
        {
            return _repository.SaveChanges();
        }

        public void Dispose()
        {
            _repository.Dispose();
        }
    }
}
