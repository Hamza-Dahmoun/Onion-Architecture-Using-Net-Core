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
        protected readonly ReferentielBusinessService<T, TKey> _referentielBusinessService;

        public GenericReferentielController(ReferentielBusinessService<T, TKey> referentielBusinessService)
        {
            _referentielBusinessService = referentielBusinessService;
        }
    }
}
