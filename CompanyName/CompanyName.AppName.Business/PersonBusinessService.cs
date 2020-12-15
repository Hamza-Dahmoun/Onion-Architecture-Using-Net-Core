using CompanyName.AppName.Domain.Entities;
using Microsoft.Extensions.Localization;
using Reusable.Business.Core;
using Reusable.Data.Abstractions;
using System;
//using Microsoft.AspNetCore.Localization;
//using Microsoft.Extensions.Localization;

namespace CompanyName.AppName.Business
{
    public class PersonBusinessService:GenericBusinessService<Person, Guid>
    {
        private readonly IStringLocalizer<BusinessMessage> _businessMessageLoclizer;

        public PersonBusinessService(IUnitOfWork unitOfWork):base(unitOfWork)
        {
            //read parent class constructor ... it will initialize the properties _unitOfWork and _repository
        }

        protected override void OnAdding(Person entity)
        {
            //business rule to check if FirstName and LastName are entered
            if (String.IsNullOrEmpty(entity.FirstName))
                throw new BusinessException(_businessMessageLoclizer["Firstname should not be empty!"]);
            if (String.IsNullOrEmpty(entity.LastName))
                throw new BusinessException(_businessMessageLoclizer["Lastname should not be empty!"]);
            base.OnAdding(entity);
        }
    }
}
