using DataAccess;
using Microsoft.EntityFrameworkCore;
using Models;
using Services.ModelViews.Invoice;

namespace Services.Services
{
    public class InvoiceServices
    {
        private readonly GenericRepository<DonHang> _donHangRepository;

        public InvoiceServices()
        {
            _donHangRepository = new GenericRepository<DonHang>();
        }

        public async Task<List<InvoiceDetailView>> GetInvoicesWithDetailsAsync()
        {
            var invoices = await _donHangRepository.Entities
                .Include(d => d.NguoiDung) 
                .Include(d => d.NhanVien)
                .Include(d => d.DiaChi) 
                .Include(d => d.ChiTietDonHangs) 
                .ThenInclude(c => c.SanPham) 
                .ToListAsync();

            return invoices.Select(d => InvoiceDetailView.Convert(d)).ToList();
        }

        public async Task<List<InvoiceDetailView>> GetInvoicesByCustomerIdAsync(int customerId)
        {
            var invoices = await _donHangRepository.FindListAsync(d => d.NguoiDungID == customerId);
            return invoices.Select(d => new InvoiceDetailView
            {
                DonHangId = d.DonHangId,
                KhachHang = d.NguoiDung.HoTen,
                TongTien = d.TongTien,
                TinhTrangDonHang = d.TinhTrangDonHang,
                NgayDatHang = d.NgayDatHang
            }).ToList();
        }

        public async Task<List<InvoiceDetailView>> SearchInvoicesAsync(int? invoiceId, string? status, DateTime? orderDate)
        {
            var invoices = await _donHangRepository.Entities
                .Include(d => d.NguoiDung)
                .Include(d => d.DiaChi)
                .Include(d => d.ChiTietDonHangs)
                .ToListAsync();

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
                NgayDatHang = d.NgayDatHang
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

        public async Task<InvoiceDetailView> GetDetailedInvoicesAsync(int invoiceId)
        {
            var invoice = await _donHangRepository.Entities
                .Include(d => d.NguoiDung)
                .Include(d => d.DiaChi)
                .Include(d => d.ChiTietDonHangs)
                .ThenInclude(c => c.SanPham)
                .FirstOrDefaultAsync(d => d.DonHangId == invoiceId);

            if (invoice == null)
                throw new KeyNotFoundException($"Invoice with ID {invoiceId} not found.");

            return InvoiceDetailView.Convert(invoice);
        }
    }
}
