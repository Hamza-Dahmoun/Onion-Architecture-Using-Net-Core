using System;
using System.Collections.Generic;
using System.Text;

namespace Reusable.Domain.Core
{
    public interface IEntity<TKey>
    {
        TKey Id { get; set; }

        /*
         Mentor:
        Note: IEntity<TKey> acts as a contract with domain entities to support different types of
        primary key named Id.
         */
    }

    public interface IEntity : IEntity<Guid>
    {
        //IEntity inherits implements IEntity with 'Guid' instead of 'TKey'
        //In future, all models (entities) are going to implement IEntity (or inherits from class that implement
        //the interface) so that they all have an 'Id' of type Guid
        //Models can implement directly IEntity<TKey> and they will have a primary key named 'Id' of a type they 
        //select
    }
}
