using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CompanyName.AppName.Domain.Entities
{
    public class Commune:Referentiel
    {
        [Display(Name="WilayaId")]
        [Required(ErrorMessage ="RequiredMessage")]
        public Guid WilayaId { get; set; }
        public virtual Wilaya Wilaya { get; set; }
    }
}
