using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CompanyName.AppName.Domain.Entities
{
    public class Dossier
    {
        [Required(ErrorMessage = "Id is required")]
        public Guid id { get; set; }

        [Required(ErrorMessage = "NumDossier is equired")]
        public string NumDossier { get; set; }
    }
}
