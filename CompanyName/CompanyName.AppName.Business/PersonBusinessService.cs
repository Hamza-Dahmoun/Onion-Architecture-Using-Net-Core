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

        protected override void OnAdding(Person entity)
        {
            //business rule to check if FirstName and LastName are entered
            if (String.IsNullOrEmpty(entity.FirstName))
                throw new BusinessException("Firstname should not be empty!");
            if (String.IsNullOrEmpty(entity.LastName))
                throw new BusinessException("Lastname should not be empty!");
            base.OnAdding(entity);
        }
    }
}
