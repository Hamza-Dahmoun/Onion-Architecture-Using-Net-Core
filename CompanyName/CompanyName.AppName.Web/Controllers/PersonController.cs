using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CompanyName.AppName.Business;
using Microsoft.AspNetCore.Mvc;

namespace CompanyName.AppName.Web.Controllers
{
    public class PersonController : Controller
    {

        protected readonly PersonBusinessService _personBusinessService;

        public PersonController(PersonBusinessService personBusinessService)
        {
            _personBusinessService = personBusinessService;
        }

        public IActionResult Index()
        {
            return View(_personBusinessService.GetAll());
        }
    }
}
