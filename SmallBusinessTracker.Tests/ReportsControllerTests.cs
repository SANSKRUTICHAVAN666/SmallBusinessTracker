using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SmallBusinessTracker.Controllers;
using SmallBusinessTracker.Models;
using SmallBusinessTracker.Services;
using Xunit;

namespace SmallBusinessTracker.Tests
{
    public class ReportsControllerTests
    {
        [Fact]
        public async Task Index_ReturnsViewResult()
        {
            var service = new FakeDashboardService();
            var controller = new ReportsController(service);

            var result = await controller.Index();

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public async Task Index_ReturnsReportsViewModel()
        {
            var service = new FakeDashboardService();
            var controller = new ReportsController(service);

            var result = await controller.Index();
            var viewResult = Assert.IsType<ViewResult>(result);

            Assert.IsType<ReportsViewModel>(viewResult.Model);
        }

        private class FakeDashboardService : IDashboardService
        {
            public Task<DashboardViewModel> GetDashboardAsync()
            {
                return Task.FromResult(new DashboardViewModel());
            }

            public Task<ReportsViewModel> GetReportsAsync()
            {
                return Task.FromResult(new ReportsViewModel());
            }
        }
    }
}