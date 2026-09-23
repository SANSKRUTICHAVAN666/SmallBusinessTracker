using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SmallBusinessTracker.Controllers;
using SmallBusinessTracker.Models;
using SmallBusinessTracker.Services;
using Xunit;

namespace SmallBusinessTracker.Tests
{
    public class DashboardControllerTests
    {
        [Fact]
        public async Task Index_ReturnsViewResult()
        {
            var service = new FakeDashboardService();
            var controller = new DashboardController(service);

            var result = await controller.Index();

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public async Task Index_ReturnsDashboardViewModel()
        {
            var service = new FakeDashboardService();
            var controller = new DashboardController(service);

            var result = await controller.Index();
            var viewResult = Assert.IsType<ViewResult>(result);

            Assert.IsType<DashboardViewModel>(viewResult.Model);
        }

        private class FakeDashboardService : IDashboardService
        {
            public Task<DashboardViewModel> GetDashboardAsync()
            {
                return Task.FromResult(new DashboardViewModel
                {
                    TotalProducts = 10,
                    AvailableStock = 50,
                    TotalSales = 5,
                    TotalRevenue = 1000
                });
            }

            public Task<ReportsViewModel> GetReportsAsync()
            {
                return Task.FromResult(new ReportsViewModel());
            }
        }
    }
}