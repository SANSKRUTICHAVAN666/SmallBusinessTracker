using Microsoft.AspNetCore.Mvc;
using SmallBusinessTracker.Models;

namespace SmallBusinessTracker.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            var model = new DashboardViewModel();

            return View(model);
        }
    }
}