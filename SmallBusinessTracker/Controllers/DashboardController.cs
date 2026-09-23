using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SmallBusinessTracker.Services;

namespace SmallBusinessTracker.Controllers
{
    public class DashboardController : Controller
    {
        private readonly IDashboardService _dashboardService;

        public DashboardController(IDashboardService dashboardService)
        {
            _dashboardService = dashboardService;
        }

        public async Task<IActionResult> Index()
        {
            var model = await _dashboardService.GetDashboardAsync();

            return View(model);
        }
    }
}