using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using DataAccess;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using Models;
using Services.Services;

namespace GUI.Views.DonHang
{
    public partial class Index : Form
    {
        private readonly InvoiceServices _invoiceServices;

        public Index()
        {
            InitializeComponent();
            _invoiceServices = new InvoiceServices();

            LoadDataToGridView().ConfigureAwait(false);

            searchCustomer1.OnCustomerSearchCompleted += SearchCustomer1_OnCustomerSearchCompleted;
            toolSearchAndRefresh1.FindClicked += ToolSearchAndRefresh1_FindClicked;
            toolSearchAndRefresh1.RefreshClicked += ToolSearchAndRefresh1_RefreshClicked;
            dtGInvoice.CellClick += DtGInvoice_CellClick;

            btnApprove.Enabled = false;
            btnExport.Enabled = false;
            btnReject.Enabled = false;

            LoadStatusOptions();

        }
        private async Task LoadDataInvoicesDetail()
        {

            var invoices = await _invoiceServices.GetInvoicesWithDetailsAsync();
            dtGInvoice.DataSource = invoices;

        }

        private async void DtGInvoice_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnApprove.Enabled = true;
                btnExport.Enabled = true;
                btnReject.Enabled = true;

                int invoiceId = Convert.ToInt32(dtGInvoice.Rows[e.RowIndex].Cells["DonHangId"].Value);

                var invoiceDetails = await _invoiceServices.GetDetailedInvoicesAsync(invoiceId);
                if (invoiceDetails != null)
                {
                    txtTotal.Text = invoiceDetails.TongTien.ToString("N0");
                    txtPaymentStatus.Text = invoiceDetails.TinhTrangThanhToan ?? "N/A";
                    txtPaymentMethod.Text = invoiceDetails.HinhThucThanhToan ?? "N/A";
                    txtAddress.Text = invoiceDetails.DiaChiGiaoHang ?? "N/A";
                    dtGDetaiInvoices.DataSource = invoiceDetails.ChiTietSanPhams.Select(c => new
                    {
                        ChiTietSanPhamId = c.ChiTietSanPhamId,
                        SanPhamId = c.SanPhamId ?? 0,
                        TenSanPham = c.TenSanPham ?? "N/A",
                        SizeName = c.SizeName ?? "N/A",
                        MauName = c.MauName ?? "N/A",
                        DonGia = c.DonGia,
                        SoLuong = c.SoLuong,
                        ThanhTien = c.ThanhTien
                    }).ToList();
                }


            }

        }

        private void LoadStatusOptions()
        {
            var statusList = new List<string> { "Đang xử lý", "Đã Xác Nhận", "Đang Vận Chuyển", "Hoàn Thành" };
            cbStatusInvoice.DataSource = statusList;
            cbStatusInvoice.SelectedIndex = 0;
        }

        private async void ToolSearchAndRefresh1_RefreshClicked(object? sender, EventArgs e)
        {

            txtIdInvoice.Clear();
            cbStatusInvoice.SelectedIndex = -1;
            dateOrder.Value = DateTime.Today;
            dateOrder.Checked = false;

            var invoices = await _invoiceServices.GetInvoicesWithDetailsAsync();
            dtGInvoice.DataSource = invoices;
        }

        private async void ToolSearchAndRefresh1_FindClicked(object? sender, EventArgs e)
        {
            int? invoiceId = string.IsNullOrWhiteSpace(txtIdInvoice.Text) ? (int?)null : int.Parse(txtIdInvoice.Text);
            string? status = string.IsNullOrWhiteSpace(cbStatusInvoice.Text) ? null : cbStatusInvoice.Text;
            DateTime? orderDate = dateOrder.Checked ? dateOrder.Value.Date : (DateTime?)null;
            var invoices = await _invoiceServices.SearchInvoicesAsync(invoiceId, status, orderDate);

            dtGInvoice.DataSource = invoices;
        }

        private async void SearchCustomer1_OnCustomerSearchCompleted(List<NguoiDung> customers)
        {
            if (customers.Count == 0)
            {
                await LoadDataToGridView();
                MessageBox.Show("Không tìm thấy khách hàng nào phù hợp.");
                return;
            }
            var customer = customers.FirstOrDefault();
            if (customer != null)
            {
                var invoices = await _invoiceServices.GetInvoicesByCustomerIdAsync(customer.NguoiDungId);
                dtGInvoice.DataSource = invoices;
            }
        }

        private async Task LoadDataToGridView()
        {
            try
            {
                var invoices = await _invoiceServices.GetInvoicesWithDetailsAsync();
                dtGInvoice.DataSource = invoices;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Message: {ex.Message}\nInnerException: {ex.InnerException?.Message}\nStackTrace: {ex.StackTrace}");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolSearchAndRefresh1_Load(object sender, EventArgs e)
        {

        }

        private async void btnApprove_Click(object sender, EventArgs e)
        {
            if (dtGInvoice.CurrentRow != null)
            {
                int invoiceId = Convert.ToInt32(dtGInvoice.CurrentRow.Cells["DonHangId"].Value);
                await _invoiceServices.UpdateInvoiceStatusAsync(invoiceId, "Đã Xác Nhận");
                await LoadDataToGridView();
            }
        }

        private async void btnExport_Click(object sender, EventArgs e)
        {
            if (dtGInvoice.CurrentRow != null)
            {
                int invoiceId = Convert.ToInt32(dtGInvoice.CurrentRow.Cells["DonHangId"].Value);
                await _invoiceServices.UpdateInvoiceStatusAsync(invoiceId, "Đang Vận Chuyển");
                await LoadDataToGridView();
            }
        }

        private async void btnReject_Click(object sender, EventArgs e)
        {
            if (dtGInvoice.CurrentRow != null)
            {
                int invoiceId = Convert.ToInt32(dtGInvoice.CurrentRow.Cells["DonHangId"].Value);
                await _invoiceServices.UpdateInvoiceStatusAsync(invoiceId, "Từ chối");
                await LoadDataToGridView();
            }
        }

        private void tableLayoutPanel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtGDetaiInvoices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void sideBar1_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (dtGInvoice.CurrentRow != null)
            {
                int invoiceId = Convert.ToInt32(dtGInvoice.CurrentRow.Cells["DonHangId"].Value);

                // Lấy thông tin hóa đơn và chi tiết hóa đơn
                var invoiceDetails = await _invoiceServices.GetDetailedInvoicesAsync(invoiceId);
                if (invoiceDetails != null)
                {
                    // Đường dẫn file Excel xuất ra
                    string filePath = $"E:\\HUIT\\HK2_2024_2025\\PTPM\\DoAn\\HoaDon_{invoiceId}.xlsx";

                    // Tạo workbook mới
                    using (var workbook = new XLWorkbook())
                    {
                        // Tạo sheet
                        var worksheet = workbook.Worksheets.Add("Hóa Đơn");

                        // Thêm thông tin hóa đơn
                        worksheet.Cell(1, 1).Value = "HÓA ĐƠN";
                        worksheet.Cell(1, 1).Style.Font.Bold = true;
                        worksheet.Cell(1, 1).Style.Font.FontSize = 16;

                        worksheet.Cell(3, 1).Value = "Mã hóa đơn:";
                        worksheet.Cell(3, 2).Value = invoiceDetails.DonHangId;

                        worksheet.Cell(4, 1).Value = "Khách hàng:";
                        worksheet.Cell(4, 2).Value = invoiceDetails.HoTenKhachHang;

                        worksheet.Cell(5, 1).Value = "Địa chỉ giao hàng:";
                        worksheet.Cell(5, 2).Value = invoiceDetails.DiaChiGiaoHang;

                        worksheet.Cell(6, 1).Value = "Phương thức thanh toán:";
                        worksheet.Cell(6, 2).Value = invoiceDetails.HinhThucThanhToan;

                        worksheet.Cell(7, 1).Value = "Tổng tiền:";
                        worksheet.Cell(7, 2).Value = $"{invoiceDetails.TongTien:N0} VND";


                        worksheet.Cell(9, 1).Value = "STT";
                        worksheet.Cell(9, 2).Value = "Tên sản phẩm";
                        worksheet.Cell(9, 3).Value = "Size";
                        worksheet.Cell(9, 4).Value = "Màu sắc";
                        worksheet.Cell(9, 5).Value = "Số lượng";
                        worksheet.Cell(9, 6).Value = "Đơn giá";
                        worksheet.Cell(9, 7).Value = "Thành tiền";


                        int row = 10;
                        int index = 1;
                        foreach (var detail in invoiceDetails.ChiTietSanPhams)
                        {
                            worksheet.Cell(row, 1).Value = index++;
                            worksheet.Cell(row, 2).Value = detail.TenSanPham;
                            worksheet.Cell(row, 3).Value = detail.SizeName;
                            worksheet.Cell(row, 4).Value = detail.MauName;
                            worksheet.Cell(row, 5).Value = detail.SoLuong;
                            worksheet.Cell(row, 6).Value = detail.DonGia;
                            worksheet.Cell(row, 7).Value = detail.ThanhTien;
                            row++;
                        }

                        // Tùy chỉnh định dạng
                        worksheet.Columns().AdjustToContents();

                        // Lưu file
                        workbook.SaveAs(filePath);

                        MessageBox.Show($"Hóa đơn đã được xuất thành công tại {filePath}");
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy hóa đơn để xuất.");
                }
            }
        }
    }
}
