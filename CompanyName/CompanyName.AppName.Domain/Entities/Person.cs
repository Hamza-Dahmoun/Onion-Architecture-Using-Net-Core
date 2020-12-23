using Reusable.Domain.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CompanyName.AppName.Domain.Entities
{
    public class Person:IEntity<Guid>
    {
        [Required(ErrorMessage="Id is required")]
        public Guid Id { get; set; }

        [Display(Name ="Firstname")]
        [Required(ErrorMessage = "Firstname is equired")]
        public string FirstName { get; set; }

        [Display(Name = "Lastname")]
        [Required(ErrorMessage = "Lastname is equired")]
        public string LastName { get; set; }
    }
}
