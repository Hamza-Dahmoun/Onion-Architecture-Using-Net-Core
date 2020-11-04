using Reusable.Data.Abstractions;
using Reusable.Domain.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reusable.Business.Core
{
    public class GenericBusinessService<T, TKey> where T: class, IEntity<TKey>
    {
        protected readonly IUnitOfWork _unitOfWork;
        protected readonly IRepository<T, TKey> _repository;
        public GenericBusinessService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _repository = _unitOfWork.GetRepository<T, TKey>();
        }
    }
}
