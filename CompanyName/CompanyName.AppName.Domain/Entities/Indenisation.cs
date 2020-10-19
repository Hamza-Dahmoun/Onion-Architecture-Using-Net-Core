using Reusable.Domain.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CompanyName.AppName.Domain.Entities
{
    public class Indenisation:IEntity<Guid>
    {
        [Required(ErrorMessage="Id is required")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Number is equired")]
        public string Number { get; set; }
    }
}
