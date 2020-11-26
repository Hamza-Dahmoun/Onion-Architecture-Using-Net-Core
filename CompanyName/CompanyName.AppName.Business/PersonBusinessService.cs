using CompanyName.AppName.Domain.Entities;
using Reusable.Business.Core;
using Reusable.Data.Abstractions;
using System;

namespace CompanyName.AppName.Business
{
    public class PersonBusinessService:GenericBusinessService<Person, Guid>
    {
        public PersonBusinessService(IUnitOfWork unitOfWork):base(unitOfWork)
        {
            //read parent class constructor ... it will initialize the properties _unitOfWork and _repository
        }
    }
}
