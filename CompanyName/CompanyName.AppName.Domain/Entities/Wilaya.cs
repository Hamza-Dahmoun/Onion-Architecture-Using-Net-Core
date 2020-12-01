using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyName.AppName.Domain.Entities
{
    public class Wilaya:Referentiel
    {
        public Wilaya()
        {
            this.Communes = new HashSet<Commune>();
        }

        public virtual ICollection<Commune> Communes { get; set; }
    }
}
