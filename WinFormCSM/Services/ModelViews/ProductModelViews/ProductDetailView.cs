using System;
using Models;

namespace Services.ModelViews.ProductModelViews
{
    public class ProductDetailView
    {
        public int ChiTietSanPhamId { get; set; }
        public int SanPhamId { get; set; }
        public string TenSanPham { get; set; }
        public string SizeName { get; set; }
        public string MauName { get; set; }
        public decimal DonGia { get; set; }
        public int SoLuong { get; set; }
        public decimal ThanhTien { get; set; }
        public int? TinhTrangDanhGia { get; set; }

        public static ProductDetailView Convert(ChiTietDonHang chiTiet)
        {
            return new ProductDetailView
            {
                ChiTietSanPhamId = chiTiet.SanPhamId,  // SanPhamId trong ChiTietDonHang trỏ đến ChiTietSanPhamId
                SanPhamId = chiTiet.SanPham.SanPhamId,
                TenSanPham = chiTiet.SanPham.SanPham?.TenSanPham ?? "N/A",
                SizeName = chiTiet.SanPham.Size?.SizeName ?? "N/A",
                MauName = chiTiet.SanPham.Mau?.MauName ?? "N/A",
                DonGia = chiTiet.DonGia,
                SoLuong = chiTiet.SoLuong,
                ThanhTien = chiTiet.SoLuong * chiTiet.DonGia,
                TinhTrangDanhGia = chiTiet.TinhTrangDanhGia
            };
        }
    }
}