using Microsoft.EntityFrameworkCore;
using ProjetoEntityVO.Domain.Interfaces.Repositories;
using ProjetoEntityVO.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoEntityVO.Infrastructure.Repositories
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        protected readonly ProjetoEntityVOContext Db;
        protected readonly DbSet<TEntity> dbSet;

        public RepositoryBase(ProjetoEntityVOContext context)
        {
            Db = context;
            dbSet = Db.Set<TEntity>();
        }

        public virtual void Dispose()
        {
            Db.Dispose();
        }

        public virtual void Incluir(TEntity obj)
        {
            dbSet.Add(obj);
        }

        public virtual void Atualizar(TEntity obj)
        {
            dbSet.Update(obj);
        }

        public virtual void Excluir(TEntity obj)
        {
            dbSet.Remove(obj);
        }

        public virtual IList<TEntity> BuscarTodos()
        {
            return dbSet.ToList();
        }

        //BuscarTodosAtivos direto do banco
        public virtual IList<TEntity> BuscarTodosAtivos()
        {
            throw new NotImplementedException();
        }

        public virtual TEntity BuscaPorId(Guid id)
        {
            return dbSet.Find(id);
        }

        public virtual int SaveChanges()
        {
            return Db.SaveChanges();
        }
    }
}
