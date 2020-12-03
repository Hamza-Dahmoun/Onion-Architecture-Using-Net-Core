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
    }
}
