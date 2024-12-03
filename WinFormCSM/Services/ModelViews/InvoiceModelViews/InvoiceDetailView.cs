using Services.ModelViews.ProductModelViews;
using Models;

namespace Services.ModelViews.Invoice
{
    public class InvoiceDetailView
    {
        public int DonHangId { get; set; }
        public string KhachHang { get; set; }
        public string? NhanVien { get; set; }
        public decimal TongTien { get; set; }
        public string TinhTrangDonHang { get; set; }
        public DateTime? NgayDatHang { get; set; }
        public string DiaChiGiaoHang { get; set; }
        public string HinhThucThanhToan { get; set; }
        public string TinhTrangThanhToan { get; set; }
        public DateTime? NgayThanhToan { get; set; }
        public List<ProductDetailView> ChiTietSanPhams { get; set; } = new List<ProductDetailView>();

        public static InvoiceDetailView Convert(DonHang invoice)
        {
            return new InvoiceDetailView
            {
                DonHangId = invoice.DonHangId,
                KhachHang = invoice.NguoiDung?.HoTen ?? "N/A",
                NhanVien = invoice.NhanVien?.HoTen,
                TongTien = invoice.TongTien,
                TinhTrangDonHang = invoice.TinhTrangDonHang,
                NgayDatHang = invoice.NgayDatHang,
                DiaChiGiaoHang = invoice.DiaChi?.DiaChiGiaoHang ?? "N/A",
                HinhThucThanhToan = invoice.HinhThucThanhToan,
                TinhTrangThanhToan = invoice.TinhTrangThanhToan,
                NgayThanhToan = invoice.NgayThanhToan,
                ChiTietSanPhams = invoice.ChiTietDonHangs
                    .Select(ct => ProductDetailView.Convert(ct))
                    .ToList()
            };
        }
    }
}