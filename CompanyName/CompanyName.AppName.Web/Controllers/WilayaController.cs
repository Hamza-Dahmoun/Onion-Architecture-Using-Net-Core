using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CompanyName.AppName.Business;
using CompanyName.AppName.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CompanyName.AppName.Web.Controllers
{
    public class WilayaController : GenericReferentielController<Wilaya, Guid>
    {
        public WilayaController(ReferentielBusinessService<Wilaya, Guid> referentielBusinessService): base(referentielBusinessService)
        {

        }
    }
}
