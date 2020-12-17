using Microsoft.EntityFrameworkCore;
using Reusable.Data.Abstractions;
using Reusable.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;
using System.Linq.Expressions;
using System.Security.Authentication.ExtendedProtection;
using System.Text;

namespace Reusable.Data.Core
{
    public class GenericRepository<T, TKey> : IRepository<T, TKey> where T : class, IEntity<TKey>
    {
        protected readonly DbContext _dbContext;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<T>();
        }

        #region IRepository Implementations

        public void Add(T entity)
        {
            _dbContext.Add(entity);
        }

        public int Count()
        {
            return _dbSet.Count();
        }

        public int Count(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.Count(predicate);
        }

        public void Delete(T entity)
        {
            _dbContext.Remove(entity);
        }

        public List<T> GetAll(params Expression<Func<T, object>>[] navigationPropertiesToLoad)
        {
            var query = _dbSet.IncludeAll(navigationPropertiesToLoad).AsNoTracking();
            return query.ToList();
        }

        public List<T> GetAllFiltered(Expression<Func<T, bool>> prediacte, params Expression<Func<T, object>>[] navigationPropertiesToLoad)
        {
            var query = _dbSet.IncludeAll(navigationPropertiesToLoad).Where(prediacte).AsNoTracking();
            return query.ToList();
        }

        public PagedResult<T> GetAllFilteredPaged(Expression<Func<T, bool>> predicate, string orderBy, int startRowIndex = 0, int maxRows = 10, params Expression<Func<T, object>>[] navigationPropertiesToLooad)
        {
            var query = _dbSet.IncludeAll(navigationPropertiesToLooad).Where(predicate).AsNoTracking();
            var totalCount = query.Count();
            var items = query.OrderBy(orderBy).Skip(startRowIndex).Take(maxRows).ToList();

            return new PagedResult<T>(items, totalCount, startRowIndex, maxRows);
        }

        public PagedResult<T> GetAllPaged(string orderBy, int startRowIndex = 0, int maxRows = 10, params Expression<Func<T, object>>[] navigationPropertiesToLoad)
        {
            var query = _dbSet.IncludeAll(navigationPropertiesToLoad).AsNoTracking();
            var totalCount = query.Count();
            var items = query.OrderBy(orderBy).Skip(startRowIndex).Take(maxRows).ToList();

            return new PagedResult<T>(items, totalCount, startRowIndex, maxRows);
        }

        public T GetById(TKey Id)
        {
            return _dbSet.Find(Id);
        }

        public T GetSingle(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] navigationPropertiesToLoad)
        {
            return _dbSet.IncludeAll(navigationPropertiesToLoad).SingleOrDefault();
        }

        public void Update(T entity)
        {
            _dbContext.Update(entity);
        }

        #endregion
    }
}
