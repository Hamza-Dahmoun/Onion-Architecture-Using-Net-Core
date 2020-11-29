using CompanyName.AppName.Domain.Entities;
using Reusable.Business.Core;
using Reusable.Data.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyName.AppName.Business
{
    public class ReferentielBusinessService : GenericBusinessService<Referentiel, Guid>
    {
        public ReferentielBusinessService(IUnitOfWork unitOfWork): base(unitOfWork)
        {

        }


        
    }
}
