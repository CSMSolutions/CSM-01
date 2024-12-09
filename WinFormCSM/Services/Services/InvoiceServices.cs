using DataAccess;
using Microsoft.EntityFrameworkCore;
using Models;
using Services.ModelViews.Invoice;

namespace Services.Services
{
    public class InvoiceServices
    {
        private readonly GenericRepository<DonHang> _donHangRepository;
        private readonly GenericRepository<ChiTietSanPham> _chitietSanPhamRepo;
        public InvoiceServices()
        {
            _donHangRepository = new GenericRepository<DonHang>();
            _chitietSanPhamRepo = new GenericRepository<ChiTietSanPham>();
        }

        public async Task<List<InvoiceDetailView>> GetInvoicesWithDetailsAsync()
        {
            var invoices = await _donHangRepository.Entities
        .Include(d => d.NguoiDung)
        .Include(d => d.DiaChi)
        .Include(d => d.ChiTietDonHangs)
        .ThenInclude(c => c.SanPham)
        .ToListAsync();

            return invoices.Select(d => new InvoiceDetailView
            {
                DonHangId = d.DonHangId,
                HoTenKhachHang = d.NguoiDung?.HoTen ?? "N/A",
                DiaChiGiaoHang = d.DiaChi?.DiaChiGiaoHang ?? "N/A",
                TongTien = d.TongTien,
                TinhTrangDonHang = d.TinhTrangDonHang,
                NgayDatHang = d.NgayDatHang,
                HinhThucThanhToan = d.HinhThucThanhToan,
                TinhTrangThanhToan = d.TinhTrangThanhToan,
                NgayThanhToan = d.NgayThanhToan
            }).ToList();
        }

        public async Task<List<InvoiceDetailView>> GetInvoicesByCustomerIdAsync(int customerId)
        {
            var invoices = await _donHangRepository.Entities
        .Where(d => d.NguoiDungId == customerId)
        .Include(d => d.NguoiDung)
        .Include(d => d.DiaChi)
        .Include(d => d.ChiTietDonHangs)
        .ThenInclude(c => c.SanPham)
        .ToListAsync();

            return invoices.Select(d => new InvoiceDetailView
            {
                DonHangId = d.DonHangId,
                HoTenKhachHang = d.NguoiDung?.HoTen ?? "N/A",
                DiaChiGiaoHang = d.DiaChi?.DiaChiGiaoHang ?? "N/A",
                TongTien = d.TongTien,
                TinhTrangDonHang = d.TinhTrangDonHang,
                NgayDatHang = d.NgayDatHang,
                HinhThucThanhToan = d.HinhThucThanhToan,
                TinhTrangThanhToan = d.TinhTrangThanhToan,
                NgayThanhToan = d.NgayThanhToan
            }).ToList();
        }

        public async Task<List<InvoiceDetailView>> SearchInvoicesAsync(int? invoiceId, string? status, DateTime? orderDate)
        {
            var invoices = await _donHangRepository.Entities
       .Include(d => d.NguoiDung)
       .Include(d => d.DiaChi)
       .Include(d => d.ChiTietDonHangs)
       .ThenInclude(c => c.SanPham)
       .ToListAsync();

            var filteredInvoices = invoices
                .Where(d => !invoiceId.HasValue || d.DonHangId == invoiceId.Value)
                .Where(d => string.IsNullOrEmpty(status) || d.TinhTrangDonHang == status)
                .Where(d => !orderDate.HasValue || (d.NgayDatHang.HasValue && d.NgayDatHang.Value.Date == orderDate.Value.Date))
                .ToList();

            return filteredInvoices.Select(d => new InvoiceDetailView
            {
                DonHangId = d.DonHangId,
                HoTenKhachHang = d.NguoiDung?.HoTen ?? "N/A",
                DiaChiGiaoHang = d.DiaChi?.DiaChiGiaoHang ?? "N/A",
                TongTien = d.TongTien,
                TinhTrangDonHang = d.TinhTrangDonHang,
                NgayDatHang = d.NgayDatHang
            }).ToList();
        }

        public async Task UpdateInvoiceStatusAsync(int invoiceId, string newStatus)
        {
            var invoice = await _donHangRepository.Entities
         .Include(d => d.ChiTietDonHangs) 
         .ThenInclude(cd => cd.SanPham) 
         .FirstOrDefaultAsync(d => d.DonHangId == invoiceId);

            if (invoice != null)
            {

                invoice.TinhTrangDonHang = newStatus;

                if (newStatus == "Từ chối")
                {
                    foreach (var chiTietDonHang in invoice.ChiTietDonHangs)
                    {
                        var chiTietSanPham = chiTietDonHang.SanPham;
                        if (chiTietSanPham != null)
                        {

                            chiTietSanPham.SoLuongTonKho += chiTietDonHang.SoLuong;
                            await _chitietSanPhamRepo.UpdateAsync(chiTietSanPham);
                        }
                    }
                }
                await _donHangRepository.UpdateAsync(invoice);
            }
            else
            {
                throw new KeyNotFoundException($"Mã hoá đơn: {invoiceId} không tồn tại.");
            }
        }

        public async Task<InvoiceDetailView> GetDetailedInvoicesAsync(int invoiceId)
        {
            var invoice = await _donHangRepository.Entities
            .Include(d => d.NguoiDung)
            .Include(d => d.DiaChi)
            .Include(d => d.ChiTietDonHangs)
                .ThenInclude(c => c.SanPham)
                .ThenInclude(s => s.Size)
            .Include(d => d.ChiTietDonHangs)
                .ThenInclude(c => c.SanPham).ThenInclude(m => m.SanPham)
            .Include(d => d.ChiTietDonHangs)
                .ThenInclude(c => c.SanPham)
                .ThenInclude(m => m.Mau)
            .FirstOrDefaultAsync(d => d.DonHangId == invoiceId);


            if (invoice == null)
                throw new KeyNotFoundException($"Mã hoá đơn: {invoiceId} không tồn tại.");

            return InvoiceDetailView.Convert(invoice);
        }
        public async Task<List<DonHang>> GetOrdersByDateAsync(DateTime? startDate, DateTime? endDate)
        {
            var query = _donHangRepository.Entities
                .Include(d => d.NguoiDung)
                .Include(d => d.DiaChi)
                .Include(d => d.ChiTietDonHangs)
                .ThenInclude(c => c.SanPham)
                .AsQueryable();

            if (startDate.HasValue)
                query = query.Where(d => d.NgayDatHang >= startDate.Value);

            if (endDate.HasValue)
                query = query.Where(d => d.NgayDatHang <= endDate.Value);

            return await query.ToListAsync();
        }

        public async Task<Dictionary<int, decimal>> GetMonthlyRevenueAsync(int year)
        {
            return await _donHangRepository.Entities
                .Where(d => d.NgayDatHang.HasValue && d.NgayDatHang.Value.Year == year)
                .GroupBy(d => d.NgayDatHang.Value.Month)
                .Select(g => new { Month = g.Key, Revenue = g.Sum(d => d.TongTien) })
                .ToDictionaryAsync(g => g.Month, g => g.Revenue);
        }

    }
}
