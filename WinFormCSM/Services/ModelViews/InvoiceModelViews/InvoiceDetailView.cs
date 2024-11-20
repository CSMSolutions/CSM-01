using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.ModelViews.ProductModelViews;
using Models;
namespace Services.ModelViews.Invoice
{
    public class InvoiceDetailView
    {
        public int DonHangId { get; set; }
        public string KhachHang { get; set; }
        public decimal TongTien { get; set; }
        public string TinhTrangDonHang { get; set; }
        public DateTime? NgayDatHang { get; set; }
        public string? DiaChiGiaoHang { get; set; }
        public string? PhuongThucThanhToan { get; set; }
        public string? TinhTrangThanhToan { get; set; }
        public List<ProductDetailView> ChiTietSanPhams { get; set; } = new List<ProductDetailView>();

        public static InvoiceDetailView Convert(ChiTietDonHang invoiceDetail)
        {
            InvoiceDetailView invoiceDetailView = new InvoiceDetailView();
            invoiceDetailView.DonHangId = invoiceDetail.DonHangId;
            invoiceDetailView.KhachHang = invoiceDetail.DonHang.NguoiDung?.HoTen ?? "N/A";
            invoiceDetailView.TongTien = invoiceDetail.DonHang.TongTien;
            invoiceDetailView.TinhTrangDonHang = invoiceDetail.DonHang.TinhTrangDonHang;
            invoiceDetailView.NgayDatHang = invoiceDetail.DonHang.NgayDatHang;
            invoiceDetailView.DiaChiGiaoHang = invoiceDetail.DonHang.DiaChiGiaoHang;
            invoiceDetailView.PhuongThucThanhToan = invoiceDetail.DonHang.ThanhToans.FirstOrDefault()?.HinhThucThanhToan;
            invoiceDetailView.TinhTrangThanhToan = invoiceDetail.DonHang.ThanhToans.FirstOrDefault()?.TinhTrangThanhToan;
            return invoiceDetailView;
        }
    }
}
