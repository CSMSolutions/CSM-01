using DataAccess;
using Microsoft.EntityFrameworkCore;
using Models;
using Services.ModelViews.Invoice;
using Services.ModelViews.ProductModelViews;

namespace Services.Services
{
    public class InvoiceServices
    {
        private readonly GenericRepository<DonHang> _donHangRepository;

        public InvoiceServices()
        {
            _donHangRepository = new GenericRepository<DonHang>();
        }

        public async Task<List<DonHang>> GetInvoicesWithDetailsAsync()
        {
            var invoices = await _donHangRepository.GetAllAsync();
            return invoices;
        }

        public async Task<List<InvoiceDetailView>> GetInvoicesByCustomerIdAsync(int customerId)
        {
            var invoices = await _donHangRepository.FindListAsync(d => d.NguoiDungId == customerId);
            return invoices.Select(d => new InvoiceDetailView
            {
                DonHangId = d.DonHangId,
                KhachHang = d.NguoiDung.HoTen,
                TongTien = d.TongTien,
                TinhTrangDonHang = d.TinhTrangDonHang,
                NgayDatHang = d.NgayDatHang,
                DiaChiGiaoHang = d.DiaChiGiaoHang
            }).ToList();
        }

        public async Task<List<InvoiceDetailView>> SearchInvoicesAsync(int? invoiceId, string? status, DateTime? orderDate)
        {
            var invoices = await _donHangRepository.GetAllAsync();

            var filteredInvoices = invoices
                .Where(d => !invoiceId.HasValue || d.DonHangId == invoiceId.Value)
                .Where(d => string.IsNullOrEmpty(status) || d.TinhTrangDonHang == status)
                .Where(d => !orderDate.HasValue || (d.NgayDatHang.HasValue && d.NgayDatHang.Value.Date == orderDate.Value.Date))
                .ToList();

            return filteredInvoices.Select(d => new InvoiceDetailView
            {
                DonHangId = d.DonHangId,
                TongTien = d.TongTien,
                TinhTrangDonHang = d.TinhTrangDonHang,
                NgayDatHang = d.NgayDatHang,
                DiaChiGiaoHang = d.DiaChiGiaoHang
            }).ToList();
        }



        public async Task UpdateInvoiceStatusAsync(int invoiceId, string newStatus)
        {
            var invoice = await _donHangRepository.GetByIdAsync(invoiceId);
            if (invoice != null)
            {
                invoice.TinhTrangDonHang = newStatus;
                await _donHangRepository.UpdateAsync(invoice);
            }
            else
            {
                throw new KeyNotFoundException($"Invoice with ID {invoiceId} not found.");
            }
        }

        public async Task<DonHang> GetDetailedInvoicesAsync(int invoiceId)
        {
            var invoices = await _donHangRepository.Entities.Include("ChiTietDonHangs")
                .Where(_=>_.DonHangId == invoiceId).FirstOrDefaultAsync();
            return invoices;

            
        }
    }
}
