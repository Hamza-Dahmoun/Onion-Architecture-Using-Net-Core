using Reusable.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Reusable.Data.Abstractions
{
    public interface IRepository<T, TKey> where T: class, IEntity<TKey>
    {
        T GetById(TKey Id);
        T GetSingle(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] navigationPropertiesToLoad);
        List<T> GetAll(params Expression<Func<T, object>>[] navigationPropertiesToLoad);
        PagedResult<T> GetAllPaged(string orderBy, int startRowIndex = 0, int maxRows = 10, params Expression<Func<T, object>>[] navigationPropertiesToLoad);
        List<T> GetAllFiltered(Expression<Func<T, bool>> prediacte, params Expression<Func<T, object>>[] navigationPropertiesToLoad);
        PagedResult<T> GetAllFilteredPaged(Expression<Func<T, bool>> predicate, string orderBy, int startRowIndex = 0, int maxRows = 10, params Expression<Func<T, object>>[] navigationPropertiesToLooad);

        int Count();
        int Count(Expression<Func<T, bool>> predicate);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
