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


        protected override void OnAdding(Referentiel entity)
        {
            //below is a business rule to ensure that it doesn't exist another entitty with the same Code or Description
            if (_repository.Count(x => x.Code == entity.Code || x.Description == entity.Description) > 0)
            {
                throw new BusinessException("Similar entity with same code or descrption already exists!");
            }
            base.OnAdding(entity);
        }

        protected override void OnUpdating(Referentiel entity)
        {
            //below is a business rule to ensure that it doesn't exist another entitty with the same Code or Description
            if (_repository.Count(x => x.Code == entity.Code || x.Description == entity.Description) > 0)
            {
                throw new BusinessException("Similar entity with same code or descrption already exists!");
            }
            base.OnUpdating(entity);
        }
    }
}
