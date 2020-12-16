using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CompanyName.AppName.Business;
using CompanyName.AppName.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CompanyName.AppName.Web.Controllers
{
    public class CommuneController : GenericReferentielController<Commune, Guid>
    {
        private readonly ReferentielBusinessService<State, Guid> _wilayaBusinessService;
        public CommuneController(ReferentielBusinessService<Commune, Guid> communeBusinessService, ReferentielBusinessService<State, Guid> wilayaBusinessService) :base(communeBusinessService)
        {
            _wilayaBusinessService = wilayaBusinessService;
        }
       
    }
}
