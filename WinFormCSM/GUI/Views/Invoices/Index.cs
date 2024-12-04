using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;
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
            var statusList = new List<string> { "Chờ xác nhận", "Đã xác nhận", "Chờ giao hàng", "Đã giao hàng" };
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
    }
}
