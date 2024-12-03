using ScottPlot.WinForms;
using Services.Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace GUI.Views.Statistical
{
    public partial class index : Form
    {
        private readonly InvoiceServices _invoiceServices;

        public index()
        {
            InitializeComponent();
            _invoiceServices = new InvoiceServices();
        }

        // Thống kê theo ngày hiện tại
        private async void btnStaFLDay_Click(object sender, EventArgs e)
        {
            var today = DateTime.Today;

            var orders = await _invoiceServices.GetOrdersByDateAsync(today, today);

            var dailyRevenue = orders
                .Where(o => o.NgayDatHang.HasValue)
                .GroupBy(o => o.NgayDatHang.Value.Date)
                .Select(g => new { Date = g.Key, Revenue = g.Sum(o => o.TongTien) })
                .FirstOrDefault();

            // Vẽ biểu đồ
            mainPlot.Plot.Clear();
            if (dailyRevenue != null)
            {
                var revenues = new[] { (double)dailyRevenue.Revenue };
                var positions = new[] { 0.0 }; // Vị trí duy nhất cho ngày hiện tại
                var labels = new[] { dailyRevenue.Date.ToShortDateString() };

                mainPlot.Plot.AddBar(revenues, positions);
                mainPlot.Plot.XTicks(positions, labels);
            }

            mainPlot.Plot.Title("Thống kê doanh thu hôm nay");
            mainPlot.Plot.XLabel("Ngày");
            mainPlot.Plot.YLabel("Doanh thu");
            mainPlot.Refresh();

            // Hiển thị tổng doanh thu
            txtTotal.Text = dailyRevenue != null ? dailyRevenue.Revenue.ToString("N0") : "0";
        }

        // Thống kê theo tháng
        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            var startDate = TimeBegin.Value;
            var endDate = TimeEnd.Value;

            if (endDate < startDate)
            {
                MessageBox.Show("Ngày kết thúc phải lớn hơn hoặc bằng ngày bắt đầu.");
                return;
            }

            var orders = await _invoiceServices.GetOrdersByDateAsync(startDate, endDate);

            var monthlyRevenue = orders
                .Where(o => o.NgayDatHang.HasValue)
                .GroupBy(o => o.NgayDatHang.Value.Month)
                .Select(g => new { Month = g.Key, Revenue = g.Sum(o => o.TongTien) })
                .OrderBy(g => g.Month)
                .ToList();

            var months = monthlyRevenue.Select(m => (double)m.Month).ToArray();
            var revenues = monthlyRevenue.Select(m => (double)m.Revenue).ToArray();

            // Vẽ biểu đồ
            mainPlot.Plot.Clear();
            mainPlot.Plot.AddBar(revenues, months);
            mainPlot.Plot.XTicks(months, months.Select(m => $"Tháng {m}").ToArray());
            mainPlot.Plot.Title("Thống kê doanh thu theo tháng");
            mainPlot.Plot.XLabel("Tháng");
            mainPlot.Plot.YLabel("Doanh thu");
            mainPlot.Refresh();

            // Hiển thị tổng doanh thu
            txtTotal.Text = monthlyRevenue.Sum(m => m.Revenue).ToString("N0");
        }
    }
}
