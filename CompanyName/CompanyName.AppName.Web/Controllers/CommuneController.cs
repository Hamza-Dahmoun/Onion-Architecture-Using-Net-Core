using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CompanyName.AppName.Business;
using CompanyName.AppName.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CompanyName.AppName.Web.Controllers
{
    public class CommuneController : GenericReferentielController<City, Guid>
    {
        private readonly ReferentielBusinessService<State, Guid> _wilayaBusinessService;
        public CommuneController(ReferentielBusinessService<City, Guid> communeBusinessService, ReferentielBusinessService<State, Guid> wilayaBusinessService) :base(communeBusinessService)
        {
            _wilayaBusinessService = wilayaBusinessService;
        }
       
    }
}
