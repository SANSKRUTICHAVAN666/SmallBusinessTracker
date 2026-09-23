using System.Collections.Generic;

namespace SmallBusinessTracker.Models
{
    public class ReportsViewModel
    {
        public List<SalesReportViewModel> DailySales { get; set; }
            = new List<SalesReportViewModel>();

        public List<SalesReportViewModel> MonthlySales { get; set; }
            = new List<SalesReportViewModel>();

        public List<LowStockProductViewModel> LowStockProducts { get; set; }
            = new List<LowStockProductViewModel>();
    }
}