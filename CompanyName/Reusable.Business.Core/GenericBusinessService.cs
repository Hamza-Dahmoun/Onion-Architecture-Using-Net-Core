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
            return _repository.GetById(id);
        }

        public T GetSingle(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] navigationPropertiesToLoad)
        {
            return _repository.GetSingle(predicate, navigationPropertiesToLoad);
        }

        //Note that inside Add()/Delete()/Update() methods DataNotUpdatedException is an Error whereas BusinessException is a Warning

        public BusinessResult.BusinessResult Add(T entity)
        {            
            BusinessResult.BusinessResult businessResult;
            try
            {
                OnAdding(entity);
                _repository.Add(entity);
                if (_unitOfWork.SaveChanges() == 0)
                {
                    throw new DataNotUpdatedException("Operation failed!");
                }
                OnAdded(entity);
                businessResult = BusinessResult.BusinessResult.Success;
            }
            catch (DataNotUpdatedException E)
            {
                businessResult = new BusinessResult.BusinessResult();
                businessResult.Messages.Add(new BusinessResult.MessageResult { Message = E.Message, MessageType = MessageType.Error });
            }
            catch (BusinessException E)
            {
                businessResult = new BusinessResult.BusinessResult();
                businessResult.Messages.Add(new BusinessResult.MessageResult { Message = E.Message, MessageType = MessageType.Warning });
            }
            catch (Exception E)
            {
                businessResult = new BusinessResult.BusinessResult();
                businessResult.Messages.Add(new BusinessResult.MessageResult { Message = "Error!", MessageType = MessageType.Error });
            }
            return businessResult;

        }

        public BusinessResult.BusinessResult Delete(T entity)
        {
            BusinessResult.BusinessResult businessResult;
            try
            {
                OnDeleting(entity);
                _repository.Delete(entity);
                if (_unitOfWork.SaveChanges() == 0)
                {
                    throw new DataNotUpdatedException("Operation failed!");
                }
                businessResult = BusinessResult.BusinessResult.Success;
                OnDeleted(entity);
            }
            catch(DataNotUpdatedException E)
            {
                businessResult = new BusinessResult.BusinessResult();
                businessResult.Messages.Add(new BusinessResult.MessageResult { Message = E.Message, MessageType = MessageType.Error});
            }
            catch (BusinessException E)
            {
                businessResult = new BusinessResult.BusinessResult();
                businessResult.Messages.Add(new BusinessResult.MessageResult { Message = E.Message, MessageType = MessageType.Warning});
            }
            catch (Exception E)
            {
                businessResult = new BusinessResult.BusinessResult();
                businessResult.Messages.Add(new BusinessResult.MessageResult { Message = "Error!", MessageType = MessageType.Error });
            }
            return businessResult;
        }

        public BusinessResult.BusinessResult Update(T entity)
        {
            BusinessResult.BusinessResult businessResult;
            try
            {
                OnDeleting(entity);
                _repository.Update(entity);
                if (_unitOfWork.SaveChanges() == 0)
                {
                    throw new DataNotUpdatedException("Operation failed!");
                }
                businessResult = BusinessResult.BusinessResult.Success;
                OnDeleted(entity);
            }
            catch(DataNotUpdatedException E)
            {
                businessResult = new BusinessResult.BusinessResult();
                businessResult.Messages.Add(new BusinessResult.MessageResult { Message = E.Message, MessageType = MessageType.Error});
            }
            catch (BusinessException E)
            {
                businessResult = new BusinessResult.BusinessResult();
                businessResult.Messages.Add(new BusinessResult.MessageResult { Message = E.Message, MessageType = MessageType.Warning });
            }
            catch (Exception E)
            {
                businessResult = new BusinessResult.BusinessResult();
                businessResult.Messages.Add(new BusinessResult.MessageResult { Message = "Error", MessageType = MessageType.Error });
            }
            return businessResult;
        }

        protected virtual void OnAdding(T entity)
        {

        }
        protected virtual void OnAdded(T entity)
        {

        }
        protected virtual void OnUpdating(T entity)
        {

        }
        protected virtual void OnUpdated(T entity)
        {

        }
        protected virtual void OnDeleting(T entity)
        {

        }
        protected virtual void OnDeleted(T entity)
        {

        }
    }
}
