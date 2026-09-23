using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SmallBusinessTracker.Services;

namespace SmallBusinessTracker.Controllers
{
    public class ReportsController : Controller
    {
        private readonly IDashboardService _dashboardService;

        public ReportsController(IDashboardService dashboardService)
        {
            _dashboardService = dashboardService;
        }

        public async Task<IActionResult> Index()
        {
            var model = await _dashboardService.GetReportsAsync();

            return View(model);
        }
    }
}