using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

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

    public virtual DbSet<ChiTietSanPham> ChiTietSanPhams { get; set; }

    public virtual DbSet<DanhMuc> DanhMucs { get; set; }

    public virtual DbSet<DonHang> DonHangs { get; set; }

    public virtual DbSet<GioHang> GioHangs { get; set; }

    public virtual DbSet<Mau> Maus { get; set; }

    public virtual DbSet<NguoiDung> NguoiDungs { get; set; }

    public virtual DbSet<PhanHoi> PhanHois { get; set; }

    public virtual DbSet<SanPham> SanPhams { get; set; }

    public virtual DbSet<Size> Sizes { get; set; }

    public virtual DbSet<ThongTinGiaoHang> ThongTinGiaoHangs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

        IConfiguration configuration = builder.Build();

        var connectionString = configuration.GetConnectionString("DefaultConnection");

        optionsBuilder.UseSqlServer(connectionString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ChiTietDonHang>(entity =>
        {
            entity.HasKey(e => e.ChiTietDonHangId).HasName("PK__ChiTietD__45B33F8325DDDFB8");

            entity.ToTable("ChiTietDonHang");

            entity.Property(e => e.ChiTietDonHangId).HasColumnName("ChiTietDonHangID");
            entity.Property(e => e.DonGia).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DonHangId).HasColumnName("DonHangID");
            entity.Property(e => e.SanPhamId).HasColumnName("SanPhamID");
            entity.Property(e => e.TinhTrangDanhGia).HasDefaultValue(0);

            entity.HasOne(d => d.DonHang).WithMany(p => p.ChiTietDonHangs)
                .HasForeignKey(d => d.DonHangId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ChiTietDo__DonHa__6E01572D");

            entity.HasOne(d => d.SanPham).WithMany(p => p.ChiTietDonHangs)
                .HasForeignKey(d => d.SanPhamId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ChiTietDo__SanPh__6EF57B66");
        });

        modelBuilder.Entity<ChiTietSanPham>(entity =>
        {
            entity.HasKey(e => e.ChiTietSanPhamId).HasName("PK__ChiTietS__1B6F09704E757446");

            entity.ToTable("ChiTietSanPham");

            entity.Property(e => e.ChiTietSanPhamId).HasColumnName("ChiTietSanPhamID");
            entity.Property(e => e.Gia).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.HinhAnhUrl).HasMaxLength(255);
            entity.Property(e => e.KichHoat).HasDefaultValue(true);
            entity.Property(e => e.MauId).HasColumnName("MauID");
            entity.Property(e => e.SanPhamId).HasColumnName("SanPhamID");
            entity.Property(e => e.SizeId).HasColumnName("SizeID");

            entity.HasOne(d => d.Mau).WithMany(p => p.ChiTietSanPhams)
                .HasForeignKey(d => d.MauId)
                .HasConstraintName("FK__ChiTietSa__MauID__6383C8BA");

            entity.HasOne(d => d.SanPham).WithMany(p => p.ChiTietSanPhams)
                .HasForeignKey(d => d.SanPhamId)
                .HasConstraintName("FK__ChiTietSa__SanPh__619B8048");

            entity.HasOne(d => d.Size).WithMany(p => p.ChiTietSanPhams)
                .HasForeignKey(d => d.SizeId)
                .HasConstraintName("FK__ChiTietSa__SizeI__628FA481");
        });

        modelBuilder.Entity<DanhMuc>(entity =>
        {
            entity.HasKey(e => e.DanhMucId).HasName("PK__DanhMuc__1C53BA7B099B5100");

            entity.ToTable("DanhMuc");

            entity.Property(e => e.DanhMucId).HasColumnName("DanhMucID");
            entity.Property(e => e.TenDanhMuc).HasMaxLength(100);
        });

        modelBuilder.Entity<DonHang>(entity =>
        {
            entity.HasKey(e => e.DonHangId).HasName("PK__DonHang__D159F4DECC408988");

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
                .HasConstraintName("FK__DonHang__DiaChiI__6A30C649");

            entity.HasOne(d => d.NguoiDung).WithMany(p => p.DonHangNguoiDungs)
                .HasForeignKey(d => d.NguoiDungId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DonHang__NguoiDu__68487DD7");

            entity.HasOne(d => d.NhanVien).WithMany(p => p.DonHangNhanViens)
                .HasForeignKey(d => d.NhanVienId)
                .HasConstraintName("FK__DonHang__NhanVie__693CA210");
        });

        modelBuilder.Entity<GioHang>(entity =>
        {
            entity.HasKey(e => e.GioHangId).HasName("PK__GioHang__4242280D2F08E2AB");

            entity.ToTable("GioHang");

            entity.Property(e => e.GioHangId).HasColumnName("GioHangID");
            entity.Property(e => e.NguoiDungId).HasColumnName("NguoiDungID");
            entity.Property(e => e.SanPhamId).HasColumnName("SanPhamID");

            entity.HasOne(d => d.NguoiDung).WithMany(p => p.GioHangs)
                .HasForeignKey(d => d.NguoiDungId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__GioHang__NguoiDu__71D1E811");

            entity.HasOne(d => d.SanPham).WithMany(p => p.GioHangs)
                .HasForeignKey(d => d.SanPhamId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__GioHang__SanPham__72C60C4A");
        });

        modelBuilder.Entity<Mau>(entity =>
        {
            entity.HasKey(e => e.MauId).HasName("PK__Mau__28166A686C6D6D59");

            entity.ToTable("Mau");

            entity.Property(e => e.MauId).HasColumnName("MauID");
            entity.Property(e => e.MauName).HasMaxLength(20);
        });

        modelBuilder.Entity<NguoiDung>(entity =>
        {
            entity.HasKey(e => e.NguoiDungId).HasName("PK__NguoiDun__C4BBA4DD31A22809");

            entity.ToTable("NguoiDung");

            entity.HasIndex(e => e.TenDangNhap, "UQ__NguoiDun__55F68FC0AB86FA35").IsUnique();

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
            entity.HasKey(e => e.PhanHoiId).HasName("PK__PhanHoi__7480288BD0316FF2");

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
                .HasConstraintName("FK__PhanHoi__NguoiDu__787EE5A0");

            entity.HasOne(d => d.SanPham).WithMany(p => p.PhanHois)
                .HasForeignKey(d => d.SanPhamId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PhanHoi__SanPham__778AC167");
        });

        modelBuilder.Entity<SanPham>(entity =>
        {
            entity.HasKey(e => e.SanPhamId).HasName("PK__SanPham__05180FF4566ECF24");

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
                .HasConstraintName("FK__SanPham__DanhMuc__59FA5E80");
        });

        modelBuilder.Entity<Size>(entity =>
        {
            entity.HasKey(e => e.SizeId).HasName("PK__Size__83BD095A953F7560");

            entity.ToTable("Size");

            entity.Property(e => e.SizeId).HasColumnName("SizeID");
            entity.Property(e => e.SizeName).HasMaxLength(10);
        });

        modelBuilder.Entity<ThongTinGiaoHang>(entity =>
        {
            entity.HasKey(e => e.DiaChiId).HasName("PK__ThongTin__94E668E6D07F1250");

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
                .HasConstraintName("FK__ThongTinG__Nguoi__52593CB8");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
