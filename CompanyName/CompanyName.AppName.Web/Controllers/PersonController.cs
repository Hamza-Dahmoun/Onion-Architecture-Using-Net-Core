using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CompanyName.AppName.Business;
using CompanyName.AppName.Domain.Entities;
using CompanyName.AppName.Web.Extensions;
using Microsoft.AspNetCore.Mvc;
using Reusable.Business.Core.BusinessResult;

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

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Person person)
        {
            BusinessResult businessResult;
            if (ModelState.IsValid)
            {
                businessResult = _personBusinessService.Add(person);
                if (businessResult.Succeeded)
                {
                    TempData["Message"] = businessResult.ToBootstrapAlerts();
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ViewData["Message"] = businessResult.ToBootstrapAlerts();
                }
            }
            return View(person);
        }
    }
}
