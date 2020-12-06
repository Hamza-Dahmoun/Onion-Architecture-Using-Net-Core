using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CompanyName.AppName.Domain.Entities;
using CompanyName.AppName.Web.Services;
using Microsoft.AspNetCore.Mvc;

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
    }
}
