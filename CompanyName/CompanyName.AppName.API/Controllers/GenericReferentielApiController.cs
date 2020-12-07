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

        [Route("id")]
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
        [Route("datatable")]
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
    }
}
