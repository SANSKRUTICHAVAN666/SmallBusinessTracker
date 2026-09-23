using System.Threading.Tasks;
using SmallBusinessTracker.Models;

namespace SmallBusinessTracker.Services
{
    public class DashboardService : IDashboardService
    {
        public Task<DashboardViewModel> GetDashboardAsync()
        {
            var model = new DashboardViewModel();

            return Task.FromResult(model);
        }

        public Task<ReportsViewModel> GetReportsAsync()
        {
            var model = new ReportsViewModel();

            return Task.FromResult(model);
        }
    }
}