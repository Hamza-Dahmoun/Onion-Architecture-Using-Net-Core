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


        //[HttpGet("{id}")]
        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            Activity activity = await _activityApiService.GetByIdAsync(id);
            return View(activity);
        }

        [ValidateAntiForgeryToken]
        //[HttpPost("{id}")]
        [HttpPost]
        public async Task<IActionResult> Edit(Guid id, Activity activity)
        {
            BusinessResult businessResult;
            if (ModelState.IsValid)
            {
                businessResult = await _activityApiService.PutAsync(id, activity);

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

            return View(activity);
        }

        //[HttpGet("{id}")]
        [HttpGet]
        public async Task<IActionResult> Delete(Guid id)
        {
            Activity activity = await _activityApiService.GetByIdAsync(id);
            return View(activity);
        }
        [ValidateAntiForgeryToken]
        //[HttpPost("{id}")]
        [HttpPost]
        public async Task<IActionResult> Delete(Guid id, Activity activity)
        {
            BusinessResult businessResult;
            businessResult = await _activityApiService.DeleteAsync(id, activity);

            if (businessResult.Succeeded)
            {
                TempData["Message"] = businessResult.ToBootstrapAlerts();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                ViewData["Message"] = businessResult.ToBootstrapAlerts();
            }

            return View(activity);
        }

        [HttpGet]
        public async Task<IActionResult> Details(Guid id)
        {
            Activity activity = await _activityApiService.GetByIdAsync(id);
            return View(activity);
        }
    }
}
