using System.Collections.Generic;

namespace SmallBusinessTracker.Models
{
    public class DashboardViewModel
    {
        public int TotalProducts { get; set; }

        public int AvailableStock { get; set; }

        public int TotalSales { get; set; }

        public decimal TotalRevenue { get; set; }

        public List<LowStockProductViewModel> LowStockProducts { get; set; }
            = new List<LowStockProductViewModel>();
    }

    public class LowStockProductViewModel
    {
        public string ProductName { get; set; }

        public int Quantity { get; set; }
    }
}