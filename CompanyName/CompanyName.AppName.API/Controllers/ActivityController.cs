using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CompanyName.AppName.Business;
using CompanyName.AppName.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CompanyName.AppName.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivityController : GenericReferentielApiController<Activity, Guid>
    {
        public ActivityController(ReferentielBusinessService<Activity, Guid> referentielBusinessService):base(referentielBusinessService)
        {
            
        }
    }
}
