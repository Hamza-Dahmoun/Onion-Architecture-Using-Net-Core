using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Reusable.Data.Core
{
    //THIS CLASS AND METHOD IS GOING TO BE USED TO LOAD NAVIGATION PROPERTIES INSIDE REPOSITORIES WHEN QUERYING DBSETS

    public static class IQueryableExtensions
    {
        public static IQueryable<T> IncludeAll<T>(this IQueryable<T> query, params Expression<Func<T, object>>[] navigationPropertiesToLoad) where T:class
        {
            foreach (var item in navigationPropertiesToLoad)
            {
                query = query.Include(item);
            }
            return query;
        }
    }
}
