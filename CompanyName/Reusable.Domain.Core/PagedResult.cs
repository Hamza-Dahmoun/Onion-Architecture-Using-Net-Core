using System;
using System.Collections.Generic;
using System.Text;

namespace Reusable.Domain.Core
{
    public class PagedResult<T>
    {
        /*
         Mentor:
        generic class PagedResult<T>. it will be used with methods returning server-side paged items 
        (from the data store).
         */
        public PagedResult(List<T> items, int totalCount, int startRowIndex, int maxRows)
        {
            Items = items;
            TotalCount = totalCount;
            PageSize = maxRows;
            Page = (int)Math.Ceiling((double)(startRowIndex / maxRows)) + 1;
        }

        public List<T> Items { get; }
        public int TotalCount { get; }
        public int Page { get; }
        public int PageSize { get; }
    }
}
