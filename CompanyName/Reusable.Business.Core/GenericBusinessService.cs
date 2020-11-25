using Reusable.Data.Abstractions;
using Reusable.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Reusable.Business.Core
{
    public class GenericBusinessService<T, TKey>:IBusinessService<T, TKey> where T: class, IEntity<TKey>
    {
        protected readonly IUnitOfWork _unitOfWork;
        protected readonly IRepository<T, TKey> _repository;
        public GenericBusinessService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _repository = _unitOfWork.GetRepository<T, TKey>();
        }


        

        public List<T> GetAll(params Expression<Func<T, object>>[] navigationPropertiesToLoad)
        {
            return _repository.GetAll(navigationPropertiesToLoad);
        }

        public List<T> GetAllFiltered(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] navigationPropertiesToLoad)
        {
            return _repository.GetAllFiltered(predicate, navigationPropertiesToLoad);
        }

        public PagedResult<T> GetAllFilteredPaged(Expression<Func<T, bool>> predicate, string orderBy = "Id", int startRowIndex = 1, int maxRows = 10, params Expression<Func<T, object>>[] navigationPropertiesToLoad)
        {
            return _repository.GetAllFilteredPaged(predicate, orderBy, startRowIndex, maxRows, navigationPropertiesToLoad);
        }

        public PagedResult<T> GetAllPaged(string orderBy = "Id", int startRowIndex = 1, int maxRows = 10, params Expression<Func<T, object>>[] navigationPropertiesToLoad)
        {
            return _repository.GetAllPaged(orderBy, startRowIndex, maxRows, navigationPropertiesToLoad);
        }

        public T GetById(TKey id, params Expression<Func<T, object>>[] navigationPropertiesToLoad)
        {
            return _repository.GetSingle(x => x.Id.Equals(id), navigationPropertiesToLoad);
        }

        public T GetSingle(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] navigationPropertiesToLoad)
        {
            return _repository.GetSingle(predicate, navigationPropertiesToLoad);
        }

        public BusinessResult.BusinessResult Add(T entity)
        {
            throw new NotImplementedException();
        }

        public BusinessResult.BusinessResult Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public BusinessResult.BusinessResult Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
