using Reusable.Domain.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reusable.Data.Abstractions
{
    public interface IUnitOfWork
    {
        IRepository<T, TKey> GetRepository<T, TKey>() where T : class, IEntity<TKey>;
        int SaveChanges();
    }
}
