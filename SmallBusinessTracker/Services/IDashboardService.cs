using System.Threading.Tasks;
using SmallBusinessTracker.Models;

namespace SmallBusinessTracker.Services
{
    public interface IDashboardService
    {
        Task<DashboardViewModel> GetDashboardAsync();

        Task<ReportsViewModel> GetReportsAsync();
    }
}