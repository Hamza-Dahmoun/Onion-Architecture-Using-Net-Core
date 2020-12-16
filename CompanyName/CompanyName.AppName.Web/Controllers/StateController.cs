using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CompanyName.AppName.Business;
using CompanyName.AppName.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CompanyName.AppName.Web.Controllers
{
    public class StateController : GenericReferentielController<State, Guid>
    {
        public StateController(ReferentielBusinessService<State, Guid> referentielBusinessService): base(referentielBusinessService)
        {

        }
    }
}
