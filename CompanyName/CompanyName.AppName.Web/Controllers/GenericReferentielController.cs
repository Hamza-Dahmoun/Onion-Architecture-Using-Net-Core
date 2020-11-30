using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CompanyName.AppName.Business;
using CompanyName.AppName.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Reusable.Domain.Core;

namespace CompanyName.AppName.Web.Controllers
{
    public class GenericReferentielController<T, TKey> : Controller where T: Referentiel, IEntity<TKey>
    {
        //Mentor:
        //this controller is used as base controller for any Referentiel entity to take advantage of this
        //default implementation and override any action when needed in derived controllers.

        protected readonly ReferentielBusinessService<T, TKey> _referentielBusinessService;

        public GenericReferentielController(ReferentielBusinessService<T, TKey> referentielBusinessService)
        {
            _referentielBusinessService = referentielBusinessService;
        }

        public virtual ActionResult Index(string search, int page =1, int pageSize=10)
        {
            PagedResult<T> model;

            if (page < 1)
                page = 1;

            if (pageSize > 50)
                pageSize = 50;

            if (string.IsNullOrEmpty(search))
            {
                model = _referentielBusinessService.GetAllFilteredPaged(x => x.Code.StartsWith(search) || x.Description.Contains(search),
                    "Code", (page-1)*pageSize, pageSize);
            }
            else
            {
                model = _referentielBusinessService.GetAllPaged("Code", (page-1)*pageSize, pageSize);
            }

            //the below data 'ViewBag.search' is going to be re-written inside the search input in the UI 
            ViewBag.search = search;

            return View(model);
        }

        public virtual ActionResult Details(TKey id)
        {
            var model = _referentielBusinessService.GetById(id);

            if (model == null)
                return NotFound();
            else return View(model);
        }
    }
}
