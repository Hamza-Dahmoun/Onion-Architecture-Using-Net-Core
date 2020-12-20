using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CompanyName.AppName.Domain.Entities
{
    public class City:Referentiel
    {
        [Display(Name= "StateId")]
        [Required(ErrorMessage ="RequiredMessage")]
        public Guid StateId { get; set; }
        public virtual State State { get; set; }
    }
}
