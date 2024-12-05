using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Models;

public partial class CSMContext : DbContext
{
    public CSMContext()
    {
    }

    public CSMContext(DbContextOptions<CSMContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ChiTietDonHang> ChiTietDonHangs { get; set; }

    public virtual DbSet<ChiTietKhuyenMai> ChiTietKhuyenMais { get; set; }

    public virtual DbSet<ChiTietSanPham> ChiTietSanPhams { get; set; }

    public virtual DbSet<DanhMuc> DanhMucs { get; set; }

    public virtual DbSet<DonHang> DonHangs { get; set; }

    public virtual DbSet<GioHang> GioHangs { get; set; }

    public virtual DbSet<KhuyenMai> KhuyenMais { get; set; }

    public virtual DbSet<Mau> Maus { get; set; }

    public virtual DbSet<NguoiDung> NguoiDungs { get; set; }

    public virtual DbSet<PhanHoi> PhanHois { get; set; }

    public virtual DbSet<SanPham> SanPhams { get; set; }

    public virtual DbSet<Size> Sizes { get; set; }

    public virtual DbSet<ThongTinGiaoHang> ThongTinGiaoHangs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost;Database=CSM;Trusted_Connection=True;Integrated Security=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ChiTietDonHang>(entity =>
        {
            entity.HasKey(e => e.ChiTietDonHangId).HasName("PK__ChiTietD__45B33F83451B0D87");

            entity.ToTable("ChiTietDonHang");

            entity.Property(e => e.ChiTietDonHangId).HasColumnName("ChiTietDonHangID");
            entity.Property(e => e.DonGia).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DonHangId).HasColumnName("DonHangID");
            entity.Property(e => e.SanPhamId).HasColumnName("SanPhamID");
            entity.Property(e => e.TinhTrangDanhGia).HasDefaultValue(0);

            entity.HasOne(d => d.DonHang).WithMany(p => p.ChiTietDonHangs)
                .HasForeignKey(d => d.DonHangId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ChiTietDo__DonHa__5CD6CB2B");

            entity.HasOne(d => d.SanPham).WithMany(p => p.ChiTietDonHangs)
                .HasForeignKey(d => d.SanPhamId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ChiTietDo__SanPh__5DCAEF64");
        });

        modelBuilder.Entity<ChiTietKhuyenMai>(entity =>
        {
            entity.HasKey(e => e.ChiTietKhuyenMaiId).HasName("PK__ChiTietK__FDC5C4B298E77999");

            entity.ToTable("ChiTietKhuyenMai");

            entity.Property(e => e.ChiTietKhuyenMaiId).HasColumnName("ChiTietKhuyenMaiID");
            entity.Property(e => e.DaHetHan).HasDefaultValue(false);
            entity.Property(e => e.KhuyenMaiId).HasColumnName("KhuyenMaiID");
            entity.Property(e => e.SanPhamId).HasColumnName("SanPhamID");

            entity.HasOne(d => d.KhuyenMai).WithMany(p => p.ChiTietKhuyenMais)
                .HasForeignKey(d => d.KhuyenMaiId)
                .HasConstraintName("FK__ChiTietKh__Khuye__6E01572D");

            entity.HasOne(d => d.SanPham).WithMany(p => p.ChiTietKhuyenMais)
                .HasForeignKey(d => d.SanPhamId)
                .HasConstraintName("FK__ChiTietKh__SanPh__6D0D32F4");
        });

        modelBuilder.Entity<ChiTietSanPham>(entity =>
        {
            entity.HasKey(e => e.ChiTietSanPhamId).HasName("PK__ChiTietS__1B6F0970B7ED9D57");

            entity.ToTable("ChiTietSanPham");

            entity.Property(e => e.ChiTietSanPhamId).HasColumnName("ChiTietSanPhamID");
            entity.Property(e => e.Gia).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.GiaDuocGiam)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.HinhAnhUrl).HasMaxLength(255);
            entity.Property(e => e.KichHoat).HasDefaultValue(true);
            entity.Property(e => e.MauId).HasColumnName("MauID");
            entity.Property(e => e.SanPhamId).HasColumnName("SanPhamID");
            entity.Property(e => e.SizeId).HasColumnName("SizeID");

            entity.HasOne(d => d.Mau).WithMany(p => p.ChiTietSanPhams)
                .HasForeignKey(d => d.MauId)
                .HasConstraintName("FK__ChiTietSa__MauID__52593CB8");

            entity.HasOne(d => d.SanPham).WithMany(p => p.ChiTietSanPhams)
                .HasForeignKey(d => d.SanPhamId)
                .HasConstraintName("FK__ChiTietSa__SanPh__5070F446");

            entity.HasOne(d => d.Size).WithMany(p => p.ChiTietSanPhams)
                .HasForeignKey(d => d.SizeId)
                .HasConstraintName("FK__ChiTietSa__SizeI__5165187F");
        });

        modelBuilder.Entity<DanhMuc>(entity =>
        {
            entity.HasKey(e => e.DanhMucId).HasName("PK__DanhMuc__1C53BA7B6C7EDA0B");

            entity.ToTable("DanhMuc");

            entity.Property(e => e.DanhMucId).HasColumnName("DanhMucID");
            entity.Property(e => e.TenDanhMuc).HasMaxLength(100);
        });

        modelBuilder.Entity<DonHang>(entity =>
        {
            entity.HasKey(e => e.DonHangId).HasName("PK__DonHang__D159F4DEBA52C55B");

            entity.ToTable("DonHang");

            entity.Property(e => e.DonHangId).HasColumnName("DonHangID");
            entity.Property(e => e.DiaChiId).HasColumnName("DiaChiID");
            entity.Property(e => e.HinhThucThanhToan).HasMaxLength(50);
            entity.Property(e => e.NgayDatHang)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.NgayThanhToan)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.NguoiDungId).HasColumnName("NguoiDungID");
            entity.Property(e => e.NhanVienId).HasColumnName("NhanVienID");
            entity.Property(e => e.TinhTrangDonHang).HasMaxLength(50);
            entity.Property(e => e.TinhTrangThanhToan).HasMaxLength(50);
            entity.Property(e => e.TongTien).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.DiaChi).WithMany(p => p.DonHangs)
                .HasForeignKey(d => d.DiaChiId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DonHang__DiaChiI__59063A47");

            entity.HasOne(d => d.NguoiDung).WithMany(p => p.DonHangNguoiDungs)
                .HasForeignKey(d => d.NguoiDungId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DonHang__NguoiDu__571DF1D5");

            entity.HasOne(d => d.NhanVien).WithMany(p => p.DonHangNhanViens)
                .HasForeignKey(d => d.NhanVienId)
                .HasConstraintName("FK__DonHang__NhanVie__5812160E");
        });

        modelBuilder.Entity<GioHang>(entity =>
        {
            entity.HasKey(e => e.GioHangId).HasName("PK__GioHang__4242280D19FAD4C8");

            entity.ToTable("GioHang");

            entity.Property(e => e.GioHangId).HasColumnName("GioHangID");
            entity.Property(e => e.NguoiDungId).HasColumnName("NguoiDungID");
            entity.Property(e => e.SanPhamId).HasColumnName("SanPhamID");

            entity.HasOne(d => d.NguoiDung).WithMany(p => p.GioHangs)
                .HasForeignKey(d => d.NguoiDungId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__GioHang__NguoiDu__60A75C0F");

            entity.HasOne(d => d.SanPham).WithMany(p => p.GioHangs)
                .HasForeignKey(d => d.SanPhamId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__GioHang__SanPham__619B8048");
        });

        modelBuilder.Entity<KhuyenMai>(entity =>
        {
            entity.HasKey(e => e.MaKhuyenMai).HasName("PK__KhuyenMa__6F56B3BDD4E969BD");

            entity.ToTable("KhuyenMai");

            entity.Property(e => e.MoTa).HasMaxLength(255);
            entity.Property(e => e.TenChuongTrinhKm)
                .HasMaxLength(100)
                .HasColumnName("TenChuongTrinhKM");
        });

        modelBuilder.Entity<Mau>(entity =>
        {
            entity.HasKey(e => e.MauId).HasName("PK__Mau__28166A68E3C9CDE0");

            entity.ToTable("Mau");

            entity.Property(e => e.MauId).HasColumnName("MauID");
            entity.Property(e => e.MauName).HasMaxLength(20);
        });

        modelBuilder.Entity<NguoiDung>(entity =>
        {
            entity.HasKey(e => e.NguoiDungId).HasName("PK__NguoiDun__C4BBA4DDD0EE475E");

            entity.ToTable("NguoiDung");

            entity.HasIndex(e => e.TenDangNhap, "UQ__NguoiDun__55F68FC099405F10").IsUnique();

            entity.Property(e => e.NguoiDungId).HasColumnName("NguoiDungID");
            entity.Property(e => e.DiaChi).HasMaxLength(255);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.GioiTinh).HasMaxLength(10);
            entity.Property(e => e.HoTen).HasMaxLength(100);
            entity.Property(e => e.KichHoat).HasDefaultValue(true);
            entity.Property(e => e.MatKhau).HasMaxLength(255);
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.PhanKhucKh)
                .HasMaxLength(100)
                .HasDefaultValue("Khách Hàng Mới")
                .HasColumnName("PhanKhucKH");
            entity.Property(e => e.SoDienThoai).HasMaxLength(15);
            entity.Property(e => e.SoThich).HasMaxLength(255);
            entity.Property(e => e.TenDangNhap).HasMaxLength(50);
            entity.Property(e => e.Train).HasDefaultValue(true);
            entity.Property(e => e.VaiTro)
                .HasMaxLength(50)
                .HasDefaultValue("user");
        });

        modelBuilder.Entity<PhanHoi>(entity =>
        {
            entity.HasKey(e => e.PhanHoiId).HasName("PK__PhanHoi__7480288B8E56671D");

            entity.ToTable("PhanHoi");

            entity.Property(e => e.PhanHoiId).HasColumnName("PhanHoiID");
            entity.Property(e => e.NgayPhanHoi)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.NguoiDungId).HasColumnName("NguoiDungID");
            entity.Property(e => e.SanPhamId).HasColumnName("SanPhamID");

            entity.HasOne(d => d.NguoiDung).WithMany(p => p.PhanHois)
                .HasForeignKey(d => d.NguoiDungId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PhanHoi__NguoiDu__6754599E");

            entity.HasOne(d => d.SanPham).WithMany(p => p.PhanHois)
                .HasForeignKey(d => d.SanPhamId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PhanHoi__SanPham__66603565");
        });

        modelBuilder.Entity<SanPham>(entity =>
        {
            entity.HasKey(e => e.SanPhamId).HasName("PK__SanPham__05180FF4DDD5A168");

            entity.ToTable("SanPham");

            entity.Property(e => e.SanPhamId).HasColumnName("SanPhamID");
            entity.Property(e => e.DanhMucId).HasColumnName("DanhMucID");
            entity.Property(e => e.KichHoat).HasDefaultValue(true);
            entity.Property(e => e.SoLuongDaBan).HasDefaultValue(0);
            entity.Property(e => e.SoSaoTb)
                .HasDefaultValue(0)
                .HasColumnName("SoSaoTB");
            entity.Property(e => e.TenSanPham).HasMaxLength(100);

            entity.HasOne(d => d.DanhMuc).WithMany(p => p.SanPhams)
                .HasForeignKey(d => d.DanhMucId)
                .HasConstraintName("FK__SanPham__DanhMuc__47DBAE45");
        });

        modelBuilder.Entity<Size>(entity =>
        {
            entity.HasKey(e => e.SizeId).HasName("PK__Size__83BD095A49388E2D");

            entity.ToTable("Size");

            entity.Property(e => e.SizeId).HasColumnName("SizeID");
            entity.Property(e => e.SizeName).HasMaxLength(10);
        });

        modelBuilder.Entity<ThongTinGiaoHang>(entity =>
        {
            entity.HasKey(e => e.DiaChiId).HasName("PK__ThongTin__94E668E68C731E31");

            entity.ToTable("ThongTinGiaoHang");

            entity.Property(e => e.DiaChiId).HasColumnName("DiaChiID");
            entity.Property(e => e.DiaChiGiaoHang).HasMaxLength(255);
            entity.Property(e => e.DiaChiMacDinh).HasDefaultValue(false);
            entity.Property(e => e.NguoiDungId).HasColumnName("NguoiDungID");
            entity.Property(e => e.SoDienThoai).HasMaxLength(15);
            entity.Property(e => e.TenNguoiNhan).HasMaxLength(100);

            entity.HasOne(d => d.NguoiDung).WithMany(p => p.ThongTinGiaoHangs)
                .HasForeignKey(d => d.NguoiDungId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ThongTinG__Nguoi__403A8C7D");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
