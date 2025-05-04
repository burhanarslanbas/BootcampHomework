using BootcampHomework.Repositories.Abstracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BootcampHomework.Repositories.Concretes.EntityFramework
{
    public abstract class EfRepositoryBase<TEntity, TEntityId, TContext> : IRepository<TEntity, TEntityId>
        where TContext : DbContext
        where TEntity : class
    {
        protected readonly TContext _context;

        protected EfRepositoryBase(TContext context)
        {
            _context = context;
        }

        public IQueryable<TEntity> Query() => _context.Set<TEntity>();

        public TEntity Add(TEntity entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public TEntity Delete(TEntity entity)
        {
            _context.Remove(entity);
            _context.SaveChanges();
            return entity;
        }

        public TEntity Get(Expression<Func<TEntity, bool>> predicate, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null)
        {
            IQueryable<TEntity> queryable = Query();
            if (include != null)
                queryable = include(queryable);
            return queryable.FirstOrDefault(predicate);
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate = null, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null)
        {
            IQueryable<TEntity> queryable = Query();
            if (include != null)
                queryable = include(queryable);
            if (predicate != null)
                queryable = queryable.Where(predicate);
            return queryable.ToList();
        }

        public TEntity Update(TEntity entity)
        {
            _context.Update(entity);
            _context.SaveChanges();
            return entity;
        }
    }
}