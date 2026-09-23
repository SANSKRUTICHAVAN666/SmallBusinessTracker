using System;
using System.Collections.Generic;

namespace SmallBusinessTracker.Models
{
    public class DashboardViewModel
    {
        public int TotalProducts { get; set; }

        public int AvailableStock { get; set; }

        public int TotalSales { get; set; }

        public decimal TotalRevenue { get; set; }

        public decimal TodayRevenue { get; set; }

        public decimal ThisMonthRevenue { get; set; }

        public List<LowStockProductViewModel> LowStockProducts { get; set; }
            = new List<LowStockProductViewModel>();

        public List<SalesReportViewModel> DailySales { get; set; }
            = new List<SalesReportViewModel>();

        public List<SalesReportViewModel> MonthlySales { get; set; }
            = new List<SalesReportViewModel>();
    }

    public class LowStockProductViewModel
    {
        public string ProductName { get; set; }

        public int Quantity { get; set; }
    }

    public class SalesReportViewModel
    {
        public DateTime Date { get; set; }

        public int NumberOfSales { get; set; }

        public decimal Revenue { get; set; }
    }
}