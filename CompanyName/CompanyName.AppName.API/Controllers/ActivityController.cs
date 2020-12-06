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
        //This controller uses Business services from Business project

        public ActivityController(ReferentielBusinessService<Activity, Guid> referentielBusinessService):base(referentielBusinessService)
        {
            
        }

        [HttpPost]
        public IActionResult Create([FromBody] Activity activity)
        {
            if(activity == null)
            {
                return BadRequest();
            }

            var businessResult = _referentielBusinessService.Add(activity);
            return Ok(businessResult);
        }

        [HttpPut("{id}")]
        public IActionResult Update(Guid id, [FromBody] Activity activity)
        {
            //why are we supposed to receive 'id' in the request header when we're not using it??
            if(activity == null)
            {
                return BadRequest();
            }

            var businessResult = _referentielBusinessService.Update(activity);
            return Ok(businessResult);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var businessResult = _referentielBusinessService.Delete(new Activity{ Id = id});
            return Ok(businessResult);
        }
    }
}
