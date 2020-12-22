using CompanyName.AppName.Domain.Entities;
using Microsoft.Extensions.Localization;
using Reusable.Business.Core;
using Reusable.Data.Abstractions;
using Reusable.Domain.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyName.AppName.Business
{
    public class ReferentielBusinessService<T, TKey> : GenericBusinessService<T, TKey> where T : Referentiel, IEntity<TKey>
    {
        private readonly IStringLocalizer<BusinessMessage> _businessMessageLoclizer;
        public ReferentielBusinessService(IStringLocalizer<BusinessMessage> businessMessageLoclizer, IUnitOfWork unitOfWork): base(unitOfWork)
        {
            _businessMessageLoclizer = businessMessageLoclizer;
        }


        protected override void OnAdding(T entity)
        {
            //below is a business rule to ensure that it doesn't exist another entitty with the same Code or Description
            if (_repository.Count(x => x.Code == entity.Code || x.Description == entity.Description) > 0)
            {
                throw new BusinessException(_businessMessageLoclizer["Similar entity with same code or descrption already exists!"]);
            }
            base.OnAdding(entity);
        }

        protected override void OnUpdating(T entity)
        {
            //below is a business rule to ensure that it doesn't exist another entitty with the same Code or Description
            if (_repository.Count(x => x.Code == entity.Code || x.Description == entity.Description) > 0)
            {
                throw new BusinessException(_businessMessageLoclizer["Similar entity with same code or descrption already exists!"]);
            }
            base.OnUpdating(entity);
        }
    }
}
