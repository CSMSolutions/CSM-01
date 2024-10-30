using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Microsoft.EntityFrameworkCore;


namespace Services.Services
{
    public class InvoiceServices
    {
        private readonly GenericRepository<DonHang> _donHangRepository;

        public InvoiceServices()
        {
            _donHangRepository = new GenericRepository<DonHang>();
        }
        public async Task<List<object>> GetInvoicesWithDetailsAsync()
        {
            using var context = new CSMContext();

            var invoices = await context.DonHangs
                .Include(d => d.NguoiDung) // Liên kết với người dùng
                .Include(d => d.ThanhToans) // Liên kết với thông tin thanh toán
                .Include(d => d.ChiTietDonHangs) // Liên kết với chi tiết đơn hàng
                .ThenInclude(ct => ct.SanPham) // Liên kết với sản phẩm trong chi tiết đơn hàng
                .Select(static d => new
                {
                    d.DonHangId,
                    KhachHang = d.NguoiDung.HoTen,
                    d.TongTien,
                    d.TinhTrangDonHang,
                    d.NgayDatHang,
                    DiaChiGiaoHang = d.DiaChiGiaoHang,
                    HinhThucThanhToan = d.ThanhToans.FirstOrDefault().HinhThucThanhToan,
                    TinhTrangThanhToan = d.ThanhToans.FirstOrDefault().TinhTrangThanhToan,
                    SoLuongSanPham = d.ChiTietDonHangs.Sum(ct => ct.SoLuong),
                })
                .ToListAsync();

            return invoices.Cast<object>().ToList();
        }
        public async Task<List<object>> GetInvoicesByCustomerIdAsync(int customerId)
        {
            using var context = new CSMContext();

            var invoices = await context.DonHangs
                .Where(d => d.NguoiDungId == customerId)
                .Select(d => new
                {
                    d.DonHangId,
                    d.TongTien,
                    d.TinhTrangDonHang,
                    d.NgayDatHang,
                    d.DiaChiGiaoHang
                })
                .ToListAsync();

            return invoices.Cast<object>().ToList();
        }
        public async Task<List<object>> SearchInvoicesAsync(int? invoiceId, string? status, DateTime? orderDate)
        {
            using var context = new CSMContext();

            var query = context.DonHangs.AsQueryable();

            if (invoiceId.HasValue)
            {
                query = query.Where(d => d.DonHangId == invoiceId.Value);
            }

            if (!string.IsNullOrEmpty(status))
            {
                query = query.Where(d => d.TinhTrangDonHang == status);
            }

            if (orderDate.HasValue)
            {
                query = query.Where(d => d.NgayDatHang.HasValue && d.NgayDatHang.Value.Date == orderDate.Value.Date);
            }
            var invoices = await query.Select(d => new
            {
                d.DonHangId,
                d.TongTien,
                d.TinhTrangDonHang,
                d.NgayDatHang,
                d.DiaChiGiaoHang
            }).ToListAsync();

            return invoices.Cast<object>().ToList();
        }
        public async Task UpdateInvoiceStatusAsync(int invoiceId, string newStatus)
        {
            using var context = new CSMContext();
            var invoice = await context.DonHangs.FindAsync(invoiceId);

            if (invoice != null)
            {
                invoice.TinhTrangDonHang = newStatus;
                await context.SaveChangesAsync();
            }
        }

    }
}
