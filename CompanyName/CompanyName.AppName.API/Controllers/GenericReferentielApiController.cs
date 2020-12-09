using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CompanyName.AppName.Business;
using CompanyName.AppName.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Reusable.Domain.Core;

namespace CompanyName.AppName.API.Controllers
{
    public class GenericReferentielApiController<T, TKey> : ControllerBase where T: Referentiel, IEntity<TKey>
    {
        private const int MAX_PAGE_SIZE = 100;
        protected readonly ReferentielBusinessService<T, TKey> _referentielBusinessService;

        public GenericReferentielApiController(ReferentielBusinessService<T, TKey> referentielBusinessService)
        {
            _referentielBusinessService = referentielBusinessService;
        }

        [HttpGet]
        [Route("all")]
        public List<T> Get()
        {
            return _referentielBusinessService.GetAll();
        }

        [Route("{id}")]
        public T Get(TKey id)
        {
            return _referentielBusinessService.GetById(id);
        }

        [Route("paged")]
        public PagedResult<T> Get(string term, string orderBy = "Id", int page = 1, int pageSize = 10)
        {

            if (page < 1)
                page = 1;

            if (pageSize > MAX_PAGE_SIZE)
                pageSize = MAX_PAGE_SIZE;


            PagedResult<T> result;

            if (!string.IsNullOrWhiteSpace(term))
            {
                result = _referentielBusinessService.GetAllFilteredPaged(
                    x => x.Code.StartsWith(term) || x.Description.Contains(term),
                    orderBy, (page - 1) * pageSize, pageSize, _referentielBusinessService.GetDefaultLoadProperties()
                    );
            }
            else
            {
                result = _referentielBusinessService.GetAllPaged(orderBy,
                    (page - 1) * pageSize, pageSize, _referentielBusinessService.GetDefaultLoadProperties());
            }

            return result;
        }

        [HttpPost]
        [Route("datatable1")]
        public JQueryDataTableRetunedData<T> DataTable([FromBody] DataTableAjaxModel model)
        {

            GetDataTableParameters(model, out string search, out string orderBy, out int startRowIndex, out int maxRows);

            if (!string.IsNullOrEmpty(search))
            {
                var result = _referentielBusinessService.GetAllFilteredPaged(x => x.Code.StartsWith(search) || x.Description.Contains(search),
                    orderBy, startRowIndex, maxRows, _referentielBusinessService.GetDefaultLoadProperties());
                return new JQueryDataTableRetunedData<T> { draw = model.draw, recordsFiltered = result.TotalCount, recordsTotal = result.TotalCount, data = result.Items };
            }
            else
            {
                var result = _referentielBusinessService.GetAllPaged(orderBy, startRowIndex, maxRows, _referentielBusinessService.GetDefaultLoadProperties());

                return new JQueryDataTableRetunedData<T> { draw = model.draw, recordsFiltered = result.TotalCount, recordsTotal = result.TotalCount, data = result.Items };
            }
        }

        protected static void GetDataTableParameters(DataTableAjaxModel model, out string search, out string orderBy, out int startRowIndex, out int maxRows)
        {
            maxRows = model.length;
            startRowIndex = model.start;
            string sortBy = "", sortDir = "";

            if (model.order != null)
            {
                // in this example we just default sort on the 1st column
                sortBy = model.columns[model.order[0].column].data;
                sortDir = model.order[0].dir.ToLower();
                orderBy = sortBy + " " + sortDir;
            }
            else
            {
                orderBy = "";
            }

            if (model.search.value != null)
            {
                search = model.search.value;
            }
            else
            {
                search = "";
            }

        }

        [HttpPost]
        [Route("datatable")]
        public JQueryDataTableRetunedData<T> DataTable()
        {
            //The difference between this method and Datatable() method above is that the above one uses a helper class
            //'DataTableAjaxModel' as a parameter to get ajax request data parameter ... it didn't work

            //lets first get the variables of the request (of the form), and then build the linq query accordingly
            //above each variable I wrote the official doc of jQuery


            // draw
            // integer Type
            // Draw counter.This is used by DataTables to ensure that the Ajax returns from server - side processing requests
            // are drawn in sequence by DataTables(Ajax requests are asynchronous and thus can return out of sequence). 
            // This is used as part of the draw return parameter(see below).

            int draw1 = int.Parse(HttpContext.Request.Form["draw"].FirstOrDefault());



            // start
            // integer type
            // Paging first record indicator.This is the start point in the current data set(0 index based -i.e. 0 is the first record).

            int start = int.Parse(HttpContext.Request.Form["start"].FirstOrDefault());



            // length
            // integer type
            // Number of records that the table can display in the current draw. It is expected that the number of records returned 
            // will be equal to this number, unless the server has fewer records to return. Note that this can be -1 to indicate that 
            // all records should be returned (although that negates any benefits of server-side processing!)

            int length = int.Parse(HttpContext.Request.Form["length"].FirstOrDefault());



            // search[value]
            // string Type
            // Global search value. To be applied to all columns which have searchable as true.

            var searchValue = HttpContext.Request.Form["search[value]"].FirstOrDefault();


            // order[i][column]
            // integer Type
            // Column to which ordering should be applied. This is an index reference to the columns array of information
            // that is also submitted to the server.

            var sortColumnName = HttpContext.Request.Form["columns[" + Request.Form["order[0][column]"].FirstOrDefault() + "][name]"].FirstOrDefault();


            // order[i][dir]
            // integer Type
            // Ordering direction for this column.It will be asc or desc to indicate ascending ordering or descending ordering, respectively.


            var sortColumnDirection = HttpContext.Request.Form["order[0][dir]"].FirstOrDefault();


            //Page Size (10, 20, 50,100) 
            int pageSize = length != null ? Convert.ToInt32(length) : 0;

            //how many rows too skip?
            int skip = start != null ? Convert.ToInt32(start) : 0;

            //totalRecords too inform user
            int totalRecords = 0;

            if (!string.IsNullOrEmpty(searchValue))
            {
                var result = _referentielBusinessService.GetAllFilteredPaged(x => x.Code.StartsWith(searchValue) || x.Description.Contains(searchValue),
                    sortColumnName, start, pageSize, _referentielBusinessService.GetDefaultLoadProperties());
                return new JQueryDataTableRetunedData<T> { draw= draw1, recordsFiltered = result.TotalCount, recordsTotal = result.TotalCount, data = result.Items };
            }
            else
            {
                var result = _referentielBusinessService.GetAllPaged(sortColumnName, start, pageSize, _referentielBusinessService.GetDefaultLoadProperties());

                return new JQueryDataTableRetunedData<T> { draw = draw1, recordsFiltered = result.TotalCount, recordsTotal = result.TotalCount, data = result.Items };
            }
        }
    }
}
