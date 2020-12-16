using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyName.AppName.Domain.Entities
{
    public class State:Referentiel
    {
        public State()
        {
            this.Communes = new HashSet<City>();
        }

        public virtual ICollection<City> Communes { get; set; }
    }
}
