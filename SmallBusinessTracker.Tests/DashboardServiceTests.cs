using System.Threading.Tasks;
using SmallBusinessTracker.Services;
using Xunit;

namespace SmallBusinessTracker.Tests
{
    public class DashboardServiceTests
    {
        [Fact]
        public async Task GetDashboardAsync_ReturnsDashboardViewModel()
        {
            // Arrange
            var service = new DashboardService();

            // Act
            var result = await service.GetDashboardAsync();

            // Assert
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetDashboardAsync_ReturnsEmptyCollections()
        {
            // Arrange
            var service = new DashboardService();

            // Act
            var result = await service.GetDashboardAsync();

            // Assert
            Assert.NotNull(result.LowStockProducts);
            Assert.NotNull(result.DailySales);
            Assert.NotNull(result.MonthlySales);

            Assert.Empty(result.LowStockProducts);
            Assert.Empty(result.DailySales);
            Assert.Empty(result.MonthlySales);
        }

        [Fact]
        public async Task GetReportsAsync_ReturnsReportsViewModel()
        {
            // Arrange
            var service = new DashboardService();

            // Act
            var result = await service.GetReportsAsync();

            // Assert
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetReportsAsync_ReturnsEmptyCollections()
        {
            // Arrange
            var service = new DashboardService();

            // Act
            var result = await service.GetReportsAsync();

            // Assert
            Assert.NotNull(result.DailySales);
            Assert.NotNull(result.MonthlySales);
            Assert.NotNull(result.LowStockProducts);

            Assert.Empty(result.DailySales);
            Assert.Empty(result.MonthlySales);
            Assert.Empty(result.LowStockProducts);
        }
    }
}