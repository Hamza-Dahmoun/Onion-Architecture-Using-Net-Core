using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyName.AppName.Domain.Entities
{
    public class State:Referentiel
    {
        public State()
        {
            this.Communes = new HashSet<Commune>();
        }

        public virtual ICollection<Commune> Communes { get; set; }
    }
}
