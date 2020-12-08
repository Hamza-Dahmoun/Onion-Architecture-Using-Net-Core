using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CompanyName.AppName.Domain.Entities;
using CompanyName.AppName.Web.Extensions;
using CompanyName.AppName.Web.Services;
using Microsoft.AspNetCore.Mvc;
using Reusable.Business.Core.BusinessResult;

namespace CompanyName.AppName.Web.Controllers
{
    //[Route("[controller/[action]")]
    public class ActivityController : Controller
    {
        private readonly ActivityApiService _activityApiService;

        public ActivityController(ActivityApiService activityApiService)
        {
            _activityApiService = activityApiService;
        }

        public async Task<IActionResult> Index(string term)
        {
            List<Activity> model = new List<Activity>();

            return View(model);
        }


        [HttpGet]
        public Task<IActionResult> Create()
        {
            return Task.Run(() =>
            {
                return View() as IActionResult;
            });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Activity activite)
        {
            BusinessResult businessResult;

            if (ModelState.IsValid)
            {
                businessResult = await _activityApiService.PostAsync(activite);

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

            return View(activite);
        }
    }
}
