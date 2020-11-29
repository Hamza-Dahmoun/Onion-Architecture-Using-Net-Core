using Reusable.Domain.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CompanyName.AppName.Domain.Entities
{
    public abstract partial class Referentiel : IEntity
    {
        //this cass is a parent class of all coming classes that have {Id, Code, Description} a common properties
        //e.g: Wilaya, Municipalty...etc

        [Display(Name = "Id")]
        [Required(ErrorMessage = "RequiredMessage")]
        public Guid Id { get; set; }

        [Display(Name = "Code")]
        [Required(ErrorMessage = "RequiredMessage"), StringLength(10, ErrorMessage = "StringLengthMessage")]
        public string Code { get; set; }

        [Display(Name = "Description")]
        [Required(ErrorMessage = "RequiredMessage"), StringLength(256, ErrorMessage = "StringLengthMessage")]
        public string Designation { get; set; }
    }
}
