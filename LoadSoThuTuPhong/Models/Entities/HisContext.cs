using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace LoadSoThuTuPhong.Models.Entities;

public partial class HisContext : DbContext
{
    public HisContext()
    {
    }

    public HisContext(DbContextOptions<HisContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ApiZlAccesstoken> ApiZlAccesstokens { get; set; }

    public virtual DbSet<ApiZlHeThong> ApiZlHeThongs { get; set; }

    public virtual DbSet<ApiZlKetQuaZn> ApiZlKetQuaZns { get; set; }

    public virtual DbSet<ApiZlLoaiChamSoc> ApiZlLoaiChamSocs { get; set; }

    public virtual DbSet<ApiZlMaLoi> ApiZlMaLois { get; set; }

    public virtual DbSet<BaDmDoiTuongChiTra> BaDmDoiTuongChiTras { get; set; }

    public virtual DbSet<BenhNhanTheoNgay> BenhNhanTheoNgays { get; set; }

    public virtual DbSet<CaLuuTruKy> CaLuuTruKies { get; set; }

    public virtual DbSet<CaThuTuKy> CaThuTuKies { get; set; }

    public virtual DbSet<CcDanhMucViTri> CcDanhMucViTris { get; set; }

    public virtual DbSet<CcNoiDungVietTat> CcNoiDungVietTats { get; set; }

    public virtual DbSet<CdLoaiphi> CdLoaiphis { get; set; }

    public virtual DbSet<CdNgay> CdNgays { get; set; }

    public virtual DbSet<CdNoidungdieutri> CdNoidungdieutris { get; set; }

    public virtual DbSet<CdNoidunglabo> CdNoidunglabos { get; set; }

    public virtual DbSet<CdPhieuthu> CdPhieuthus { get; set; }

    public virtual DbSet<CdPhieuthuct> CdPhieuthucts { get; set; }

    public virtual DbSet<CdSocot> CdSocots { get; set; }

    public virtual DbSet<CdSodieutri> CdSodieutris { get; set; }

    public virtual DbSet<CdSolabo> CdSolabos { get; set; }

    public virtual DbSet<CdTinhhinhdieutri> CdTinhhinhdieutris { get; set; }

    public virtual DbSet<CskhDinhNghiaThamSo> CskhDinhNghiaThamSos { get; set; }

    public virtual DbSet<CskhLoaiCskh> CskhLoaiCskhs { get; set; }

    public virtual DbSet<CskhTemplateCt> CskhTemplateCts { get; set; }

    public virtual DbSet<DmBanner> DmBanners { get; set; }

    public virtual DbSet<DmBenhAn> DmBenhAns { get; set; }

    public virtual DbSet<DmBenhNhan> DmBenhNhans { get; set; }

    public virtual DbSet<DmBenhNhanDuBi> DmBenhNhanDuBis { get; set; }

    public virtual DbSet<DmBntheoBacSi> DmBntheoBacSis { get; set; }

    public virtual DbSet<DmBoDungCu> DmBoDungCus { get; set; }

    public virtual DbSet<DmBoDungCuCt> DmBoDungCuCts { get; set; }

    public virtual DbSet<DmCaLamViec> DmCaLamViecs { get; set; }

    public virtual DbSet<DmChiNhanh> DmChiNhanhs { get; set; }

    public virtual DbSet<DmChitietphi> DmChitietphis { get; set; }

    public virtual DbSet<DmCoSoVatTuThietYeu> DmCoSoVatTuThietYeus { get; set; }

    public virtual DbSet<DmDanToc> DmDanTocs { get; set; }

    public virtual DbSet<DmDichVuKyThuat> DmDichVuKyThuats { get; set; }

    public virtual DbSet<DmDichVuKyThuatGium> DmDichVuKyThuatGia { get; set; }

    public virtual DbSet<DmDichVuKyThuatSoLanDung> DmDichVuKyThuatSoLanDungs { get; set; }

    public virtual DbSet<DmDoiTac> DmDoiTacs { get; set; }

    public virtual DbSet<DmDoiTacBaoHiem> DmDoiTacBaoHiems { get; set; }

    public virtual DbSet<DmDuongDung> DmDuongDungs { get; set; }

    public virtual DbSet<DmGioiTinh> DmGioiTinhs { get; set; }

    public virtual DbSet<DmHienTrangRang> DmHienTrangRangs { get; set; }

    public virtual DbSet<DmHinhThucThanhToan> DmHinhThucThanhToans { get; set; }

    public virtual DbSet<DmIcd> DmIcds { get; set; }

    public virtual DbSet<DmKetQuaDieuTri> DmKetQuaDieuTris { get; set; }

    public virtual DbSet<DmKhoanThuChi> DmKhoanThuChis { get; set; }

    public virtual DbSet<DmKhungGioHen> DmKhungGioHens { get; set; }

    public virtual DbSet<DmKip> DmKips { get; set; }

    public virtual DbSet<DmLoaiBenhNhan> DmLoaiBenhNhans { get; set; }

    public virtual DbSet<DmLoaiHangHoa> DmLoaiHangHoas { get; set; }

    public virtual DbSet<DmLopHoc> DmLopHocs { get; set; }

    public virtual DbSet<DmLyDoHen> DmLyDoHens { get; set; }

    public virtual DbSet<DmLyDoRaVien> DmLyDoRaViens { get; set; }

    public virtual DbSet<DmLyDoVaoVien> DmLyDoVaoViens { get; set; }

    public virtual DbSet<DmLyDoXuat> DmLyDoXuats { get; set; }

    public virtual DbSet<DmMarKetting> DmMarKettings { get; set; }

    public virtual DbSet<DmMauBenhAn> DmMauBenhAns { get; set; }

    public virtual DbSet<DmMoiLienHe> DmMoiLienHes { get; set; }

    public virtual DbSet<DmNganHangDoanhNghiep> DmNganHangDoanhNghieps { get; set; }

    public virtual DbSet<DmNgheNghiep> DmNgheNghieps { get; set; }

    public virtual DbSet<DmNguonTin> DmNguonTins { get; set; }

    public virtual DbSet<DmNhanVien> DmNhanViens { get; set; }

    public virtual DbSet<DmNhomChiPhi> DmNhomChiPhis { get; set; }

    public virtual DbSet<DmNhomDichVuKyThuat> DmNhomDichVuKyThuats { get; set; }

    public virtual DbSet<DmNienKhoa> DmNienKhoas { get; set; }

    public virtual DbSet<DmNoiSuDung> DmNoiSuDungs { get; set; }

    public virtual DbSet<DmPhongThucHien> DmPhongThucHiens { get; set; }

    public virtual DbSet<DmPhucHinh> DmPhucHinhs { get; set; }

    public virtual DbSet<DmPhucHinhNcc> DmPhucHinhNccs { get; set; }

    public virtual DbSet<DmProfileGiayCamKet> DmProfileGiayCamKets { get; set; }

    public virtual DbSet<DmProfileHd> DmProfileHds { get; set; }

    public virtual DbSet<DmQuanCuTru> DmQuanCuTrus { get; set; }

    public virtual DbSet<DmQuocGium> DmQuocGia { get; set; }

    public virtual DbSet<DmRang> DmRangs { get; set; }

    public virtual DbSet<DmRangCt> DmRangCts { get; set; }

    public virtual DbSet<DmSinhVien> DmSinhViens { get; set; }

    public virtual DbSet<DmTemplate> DmTemplates { get; set; }

    public virtual DbSet<DmThoiGian> DmThoiGians { get; set; }

    public virtual DbSet<DmThoiGianHen> DmThoiGianHens { get; set; }

    public virtual DbSet<DmTiLeHoaHong> DmTiLeHoaHongs { get; set; }

    public virtual DbSet<DmTiLeLuong> DmTiLeLuongs { get; set; }

    public virtual DbSet<DmTinhCach> DmTinhCaches { get; set; }

    public virtual DbSet<DmTinhCuTru> DmTinhCuTrus { get; set; }

    public virtual DbSet<DmTinhTrang> DmTinhTrangs { get; set; }

    public virtual DbSet<DmTinhXaDoiChieu> DmTinhXaDoiChieus { get; set; }

    public virtual DbSet<DmVaiTro> DmVaiTros { get; set; }

    public virtual DbSet<DmXaCuTru> DmXaCuTrus { get; set; }

    public virtual DbSet<HhCachXuat> HhCachXuats { get; set; }

    public virtual DbSet<HhDmDonViTinh> HhDmDonViTinhs { get; set; }

    public virtual DbSet<HhDmHangHoa> HhDmHangHoas { get; set; }

    public virtual DbSet<HhDmHangHoaNcc> HhDmHangHoaNccs { get; set; }

    public virtual DbSet<HhDmHangSanXuat> HhDmHangSanXuats { get; set; }

    public virtual DbSet<HhDmNganHang> HhDmNganHangs { get; set; }

    public virtual DbSet<HhDmNganKe> HhDmNganKes { get; set; }

    public virtual DbSet<HhDmNguonNhapXuat> HhDmNguonNhapXuats { get; set; }

    public virtual DbSet<HhDmNhaCungCap> HhDmNhaCungCaps { get; set; }

    public virtual DbSet<HhDmNhomHangHoa> HhDmNhomHangHoas { get; set; }

    public virtual DbSet<HhDmNoiSuDung> HhDmNoiSuDungs { get; set; }

    public virtual DbSet<HhDmNuocSanXuat> HhDmNuocSanXuats { get; set; }

    public virtual DbSet<HhHangTonKho> HhHangTonKhos { get; set; }

    public virtual DbSet<HhPhieuNhapCcdc> HhPhieuNhapCcdcs { get; set; }

    public virtual DbSet<HhPhieuNhapCcdcCt> HhPhieuNhapCcdcCts { get; set; }

    public virtual DbSet<HhPhieuNhapCt> HhPhieuNhapCts { get; set; }

    public virtual DbSet<HhPhieuNhapKho> HhPhieuNhapKhos { get; set; }

    public virtual DbSet<HhPhieuXuatCt> HhPhieuXuatCts { get; set; }

    public virtual DbSet<HhPhieuXuatKho> HhPhieuXuatKhos { get; set; }

    public virtual DbSet<HhPhieuXuatThanhLy> HhPhieuXuatThanhLies { get; set; }

    public virtual DbSet<HhPhieuXuatThanhLyCt> HhPhieuXuatThanhLyCts { get; set; }

    public virtual DbSet<HhTiLeCanhBao> HhTiLeCanhBaos { get; set; }

    public virtual DbSet<HhTinhGiaXuat> HhTinhGiaXuats { get; set; }

    public virtual DbSet<HtChucNang> HtChucNangs { get; set; }

    public virtual DbSet<HtConfig> HtConfigs { get; set; }

    public virtual DbSet<HtKhoaSo> HtKhoaSos { get; set; }

    public virtual DbSet<HtLichNghi> HtLichNghis { get; set; }

    public virtual DbSet<HtLichNghiMoi> HtLichNghiMois { get; set; }

    public virtual DbSet<HtPhanHe> HtPhanHes { get; set; }

    public virtual DbSet<HtPhanQuyen> HtPhanQuyens { get; set; }

    public virtual DbSet<HtQuanLyMa> HtQuanLyMas { get; set; }

    public virtual DbSet<HtQuyLuatMa> HtQuyLuatMas { get; set; }

    public virtual DbSet<HtQuyenVaiTro> HtQuyenVaiTros { get; set; }

    public virtual DbSet<HtTaiKhoanDangNhap> HtTaiKhoanDangNhaps { get; set; }

    public virtual DbSet<HtTiLe> HtTiLes { get; set; }

    public virtual DbSet<KsCauHoi> KsCauHois { get; set; }

    public virtual DbSet<KsCauHoiTraLoi> KsCauHoiTraLois { get; set; }

    public virtual DbSet<KsCauTraLoi> KsCauTraLois { get; set; }

    public virtual DbSet<KsKetQuaK> KsKetQuaKs { get; set; }

    public virtual DbSet<NhanVien> NhanViens { get; set; }

    public virtual DbSet<QlBenhAn> QlBenhAns { get; set; }

    public virtual DbSet<QlChanDoan> QlChanDoans { get; set; }

    public virtual DbSet<QlChanDoanCt> QlChanDoanCts { get; set; }

    public virtual DbSet<QlChiDinh> QlChiDinhs { get; set; }

    public virtual DbSet<QlDinhMucVatTuTieuHao> QlDinhMucVatTuTieuHaos { get; set; }

    public virtual DbSet<QlHen> QlHens { get; set; }

    public virtual DbSet<QlHinhAnh> QlHinhAnhs { get; set; }

    public virtual DbSet<QlHoaDon> QlHoaDons { get; set; }

    public virtual DbSet<QlHoaDonCt> QlHoaDonCts { get; set; }

    public virtual DbSet<QlHopDongCt> QlHopDongCts { get; set; }

    public virtual DbSet<QlKeHoachDieuTri> QlKeHoachDieuTris { get; set; }

    public virtual DbSet<QlKeHoachDieuTriCt> QlKeHoachDieuTriCts { get; set; }

    public virtual DbSet<QlKhamTongQuat> QlKhamTongQuats { get; set; }

    public virtual DbSet<QlLaBo> QlLaBos { get; set; }

    public virtual DbSet<QlLichHenBenhNhan> QlLichHenBenhNhans { get; set; }

    public virtual DbSet<QlMuonTra> QlMuonTras { get; set; }

    public virtual DbSet<QlPhieuChi> QlPhieuChis { get; set; }

    public virtual DbSet<QlPhieuChiCt> QlPhieuChiCts { get; set; }

    public virtual DbSet<QlPhieuDatCoc> QlPhieuDatCocs { get; set; }

    public virtual DbSet<QlPhieuDeNghi> QlPhieuDeNghis { get; set; }

    public virtual DbSet<QlPhieuDeNghiCapHang> QlPhieuDeNghiCapHangs { get; set; }

    public virtual DbSet<QlPhieuDeNghiCapHangCt> QlPhieuDeNghiCapHangCts { get; set; }

    public virtual DbSet<QlPhieuDeNghiCt> QlPhieuDeNghiCts { get; set; }

    public virtual DbSet<QlPhieuDieuTri> QlPhieuDieuTris { get; set; }

    public virtual DbSet<QlPhieuDuTru> QlPhieuDuTrus { get; set; }

    public virtual DbSet<QlPhieuDuTruCt> QlPhieuDuTruCts { get; set; }

    public virtual DbSet<QlPhieuLaBo> QlPhieuLaBos { get; set; }

    public virtual DbSet<QlPhieuLaBoCt> QlPhieuLaBoCts { get; set; }

    public virtual DbSet<QlPhieuThu> QlPhieuThus { get; set; }

    public virtual DbSet<QlPhieuThuCt> QlPhieuThuCts { get; set; }

    public virtual DbSet<QlPhieuThuNo> QlPhieuThuNos { get; set; }

    public virtual DbSet<QlPhieuThuNoCt> QlPhieuThuNoCts { get; set; }

    public virtual DbSet<QlPhieuTraNo> QlPhieuTraNos { get; set; }

    public virtual DbSet<QlPhieuTraNoCt> QlPhieuTraNoCts { get; set; }

    public virtual DbSet<QlPhieuVatLieu> QlPhieuVatLieus { get; set; }

    public virtual DbSet<QlPhieuVatLieuCt> QlPhieuVatLieuCts { get; set; }

    public virtual DbSet<QlQuaTrinhTinhLabo> QlQuaTrinhTinhLabos { get; set; }

    public virtual DbSet<QlQuaTrinhTinhLuong> QlQuaTrinhTinhLuongs { get; set; }

    public virtual DbSet<QlScanHd> QlScanHds { get; set; }

    public virtual DbSet<QlSoDoRang> QlSoDoRangs { get; set; }

    public virtual DbSet<QlSoHd> QlSoHds { get; set; }

    public virtual DbSet<QlThuTienDieuTri> QlThuTienDieuTris { get; set; }

    public virtual DbSet<QlThuTienDieuTriCt> QlThuTienDieuTriCts { get; set; }

    public virtual DbSet<QlThuTienDieuTriDatCoc> QlThuTienDieuTriDatCocs { get; set; }

    public virtual DbSet<QlToaThuoc> QlToaThuocs { get; set; }

    public virtual DbSet<QlToaThuocCd> QlToaThuocCds { get; set; }

    public virtual DbSet<QlToaThuocCt> QlToaThuocCts { get; set; }

    public virtual DbSet<QlToaThuocMau> QlToaThuocMaus { get; set; }

    public virtual DbSet<QlToaThuocMauCd> QlToaThuocMauCds { get; set; }

    public virtual DbSet<QlToaThuocMauCt> QlToaThuocMauCts { get; set; }

    public virtual DbSet<QlTuongQuanDvktQt> QlTuongQuanDvktQts { get; set; }

    public virtual DbSet<QlVaoVien> QlVaoViens { get; set; }

    public virtual DbSet<SttCapSoTheoBacSi> SttCapSoTheoBacSis { get; set; }

    public virtual DbSet<SttCapSoTheoPhong> SttCapSoTheoPhongs { get; set; }

    public virtual DbSet<TempQuyTrinhDieuTri> TempQuyTrinhDieuTris { get; set; }

    public virtual DbSet<TempQuyTrinhDieuTriCt> TempQuyTrinhDieuTriCts { get; set; }

    public virtual DbSet<TemplateBenhAnRhm> TemplateBenhAnRhms { get; set; }

    public virtual DbSet<TemplateBenhAnRhmngoaiTru> TemplateBenhAnRhmngoaiTrus { get; set; }

    public virtual DbSet<TinhLuongCongViecHoTro> TinhLuongCongViecHoTros { get; set; }

    public virtual DbSet<TinhLuongDinhMucLaboTinhLuong> TinhLuongDinhMucLaboTinhLuongs { get; set; }

    public virtual DbSet<TinhLuongHoaHongVatLieu> TinhLuongHoaHongVatLieus { get; set; }

    public virtual DbSet<TinhLuongPhanTramChinhNha> TinhLuongPhanTramChinhNhas { get; set; }

    public virtual DbSet<TinhLuongTongHopLuong> TinhLuongTongHopLuongs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=ConnectionStrings:Connection");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ApiZlAccesstoken>(entity =>
        {
            entity.ToTable("API_ZL_Accesstoken");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AccessToken)
                .HasMaxLength(500)
                .HasColumnName("Access_token");
            entity.Property(e => e.ExpireIn)
                .HasMaxLength(50)
                .HasColumnName("Expire_in");
            entity.Property(e => e.NgayNhan).HasColumnType("datetime");
            entity.Property(e => e.RefreshCreateTime)
                .HasColumnType("datetime")
                .HasColumnName("Refresh_create_time");
            entity.Property(e => e.RefreshToken)
                .HasMaxLength(500)
                .HasColumnName("Refresh_token");
        });

        modelBuilder.Entity<ApiZlHeThong>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("API_ZL_HeThong");

            entity.Property(e => e.AppId).HasColumnName("App_id");
            entity.Property(e => e.SecretKey).HasColumnName("Secret_Key");
        });

        modelBuilder.Entity<ApiZlKetQuaZn>(entity =>
        {
            entity.ToTable("API_ZL_KetQuaZNS");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdbenhNhan).HasColumnName("IDBenhNhan");
            entity.Property(e => e.IdvaoVien).HasColumnName("IDVaoVien");
            entity.Property(e => e.Message).HasMaxLength(500);
            entity.Property(e => e.MsgId)
                .HasMaxLength(500)
                .HasColumnName("Msg_id");
            entity.Property(e => e.SendingMode).HasColumnName("Sending_mode");
            entity.Property(e => e.SentTime)
                .HasColumnType("datetime")
                .HasColumnName("Sent_time");

            entity.HasOne(d => d.IdbenhNhanNavigation).WithMany(p => p.ApiZlKetQuaZns)
                .HasForeignKey(d => d.IdbenhNhan)
                .HasConstraintName("fk_BN_KetQuaZNS");

            entity.HasOne(d => d.LoaiNavigation).WithMany(p => p.ApiZlKetQuaZns)
                .HasForeignKey(d => d.Loai)
                .HasConstraintName("FK_API_ZL_KetQuaZNS_CSKH_LoaiCSKH");
        });

        modelBuilder.Entity<ApiZlLoaiChamSoc>(entity =>
        {
            entity.ToTable("API_ZL_LoaiChamSoc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.MaLoaiChamSoc).HasMaxLength(50);
            entity.Property(e => e.MauTemplate).HasMaxLength(4000);
            entity.Property(e => e.TenLoaiChamSoc).HasMaxLength(100);
        });

        modelBuilder.Entity<ApiZlMaLoi>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__API_ZL_M__3214EC0717CFACD1");

            entity.ToTable("API_ZL_MaLoi");

            entity.Property(e => e.MoTaLoi).HasMaxLength(500);
            entity.Property(e => e.ThongTinLoi).HasMaxLength(500);
        });

        modelBuilder.Entity<BaDmDoiTuongChiTra>(entity =>
        {
            entity.ToTable("BA_DM_DoiTuongChiTra");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.MaDoiTuong).HasMaxLength(50);
            entity.Property(e => e.TenDoiTuong).HasMaxLength(50);
        });

        modelBuilder.Entity<BenhNhanTheoNgay>(entity =>
        {
            entity.ToTable("BenhNhan_TheoNgay");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdbacSiHienTai).HasColumnName("IDBacSiHienTai");
            entity.Property(e => e.IdbenhNhan).HasColumnName("IDBenhNhan");
            entity.Property(e => e.Idcn).HasColumnName("IDCN");
            entity.Property(e => e.IdlichHen).HasColumnName("IDLichHen");
            entity.Property(e => e.IdphongBuong).HasColumnName("IDPhongBuong");
            entity.Property(e => e.NgayGioDen).HasColumnType("datetime");

            entity.HasOne(d => d.IdbenhNhanNavigation).WithMany(p => p.BenhNhanTheoNgays)
                .HasForeignKey(d => d.IdbenhNhan)
                .HasConstraintName("FK_BenhNhan_TheoNgay_DM_BenhNhan");

            entity.HasOne(d => d.IdcnNavigation).WithMany(p => p.BenhNhanTheoNgays)
                .HasForeignKey(d => d.Idcn)
                .HasConstraintName("FK_BenhNhan_TheoNgay_DM_ChiNhanh");

            entity.HasOne(d => d.IdlichHenNavigation).WithMany(p => p.BenhNhanTheoNgays)
                .HasForeignKey(d => d.IdlichHen)
                .HasConstraintName("FK_BenhNhan_TheoNgay_QL_LichHenBenhNhan");

            entity.HasOne(d => d.IdphongBuongNavigation).WithMany(p => p.BenhNhanTheoNgays)
                .HasForeignKey(d => d.IdphongBuong)
                .HasConstraintName("FK__BenhNhan___IDPho__0880433F");
        });

        modelBuilder.Entity<CaLuuTruKy>(entity =>
        {
            entity.ToTable("CA_LuuTruKy");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DenNgay).HasColumnType("datetime");
            entity.Property(e => e.Idaccount).HasColumnName("IDAccount");
            entity.Property(e => e.IdbenhNhan).HasColumnName("IDBenhNhan");
            entity.Property(e => e.IdchiNhanh).HasColumnName("IDChiNhanh");
            entity.Property(e => e.IdcongVan).HasColumnName("IDCongVan");
            entity.Property(e => e.IdtrangThaiKy).HasColumnName("IDTrangThaiKy");
            entity.Property(e => e.IdvaoVien).HasColumnName("IDVaoVien");
            entity.Property(e => e.MaCongVan).HasMaxLength(50);
            entity.Property(e => e.NgayKy).HasColumnType("datetime");
            entity.Property(e => e.TuNgay).HasColumnType("datetime");
            entity.Property(e => e.Url).HasMaxLength(500);

            entity.HasOne(d => d.IdbenhNhanNavigation).WithMany(p => p.CaLuuTruKies)
                .HasForeignKey(d => d.IdbenhNhan)
                .HasConstraintName("FK_CA_LuuTruKy_DM_BenhNhan");

            entity.HasOne(d => d.IdvaoVienNavigation).WithMany(p => p.CaLuuTruKies)
                .HasForeignKey(d => d.IdvaoVien)
                .HasConstraintName("FK_CA_LuuTruKy_QL_VaoVien");
        });

        modelBuilder.Entity<CaThuTuKy>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CA_ThuTuKy");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.MaLoai).HasMaxLength(50);
            entity.Property(e => e.Stt).HasColumnName("STT");
            entity.Property(e => e.Url).HasMaxLength(500);
        });

        modelBuilder.Entity<CcDanhMucViTri>(entity =>
        {
            entity.ToTable("CC_DanhMucViTri");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.MoTa).HasMaxLength(500);
        });

        modelBuilder.Entity<CcNoiDungVietTat>(entity =>
        {
            entity.ToTable("CC_NoiDungVietTat");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdnhanVien).HasColumnName("IDNhanVien");
            entity.Property(e => e.IdviTri).HasColumnName("IDViTri");
            entity.Property(e => e.NoiDung).HasMaxLength(1000);
            entity.Property(e => e.VietTat).HasMaxLength(50);
        });

        modelBuilder.Entity<CdLoaiphi>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CD_LOAIPHI");

            entity.Property(e => e.Heso).HasColumnName("HESO");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Kyhieu)
                .HasMaxLength(50)
                .HasColumnName("KYHIEU");
            entity.Property(e => e.Maloai)
                .HasMaxLength(20)
                .HasColumnName("MALOAI");
            entity.Property(e => e.Manhom).HasColumnName("MANHOM");
            entity.Property(e => e.Nameid)
                .HasMaxLength(100)
                .HasColumnName("NAMEID");
            entity.Property(e => e.Tenloai)
                .HasMaxLength(100)
                .HasColumnName("TENLOAI");
            entity.Property(e => e.Tien).HasColumnName("TIEN");
        });

        modelBuilder.Entity<CdNgay>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CD_Ngay");

            entity.Property(e => e.Id).HasColumnName("ID");
        });

        modelBuilder.Entity<CdNoidungdieutri>(entity =>
        {
            entity.ToTable("CD_NOIDUNGDIEUTRI");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Diengiai)
                .HasMaxLength(255)
                .HasColumnName("DIENGIAI");
            entity.Property(e => e.Dongia).HasColumnName("DONGIA");
            entity.Property(e => e.Heso).HasColumnName("HESO");
            entity.Property(e => e.Idcv).HasColumnName("IDCV");
            entity.Property(e => e.Idpdt).HasColumnName("IDPDT");
            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.Tencv)
                .HasMaxLength(255)
                .HasColumnName("TENCV");
            entity.Property(e => e.Thanhtien).HasColumnName("THANHTIEN");
            entity.Property(e => e.Tienlabo).HasColumnName("TIENLABO");
            entity.Property(e => e.Tilegiam).HasColumnName("TILEGIAM");
        });

        modelBuilder.Entity<CdNoidunglabo>(entity =>
        {
            entity.HasKey(e => e.Idlb);

            entity.ToTable("CD_NOIDUNGLABO");

            entity.Property(e => e.LoaiPh)
                .HasMaxLength(100)
                .HasColumnName("LoaiPH");
            entity.Property(e => e.Maloai)
                .HasMaxLength(20)
                .HasColumnName("MALOAI");
            entity.Property(e => e.Sl).HasColumnName("SL");
        });

        modelBuilder.Entity<CdPhieuthu>(entity =>
        {
            entity.HasKey(e => e.Maso);

            entity.ToTable("CD_PHIEUTHU");

            entity.Property(e => e.Maso)
                .ValueGeneratedNever()
                .HasColumnName("MASO");
            entity.Property(e => e.Ck).HasColumnName("CK");
            entity.Property(e => e.Diachi)
                .HasMaxLength(150)
                .HasColumnName("DIACHI");
            entity.Property(e => e.Dienthoai)
                .HasMaxLength(50)
                .HasColumnName("DIENTHOAI");
            entity.Property(e => e.Huy).HasColumnName("HUY");
            entity.Property(e => e.Idbn).HasColumnName("IDBN");
            entity.Property(e => e.Idcn).HasColumnName("IDCN");
            entity.Property(e => e.Idnv).HasColumnName("IDNV");
            entity.Property(e => e.Khoa).HasColumnName("KHOA");
            entity.Property(e => e.Kip).HasColumnName("KIP");
            entity.Property(e => e.Loaihd)
                .HasMaxLength(20)
                .HasColumnName("LOAIHD");
            entity.Property(e => e.Mst)
                .HasMaxLength(50)
                .HasColumnName("MST");
            entity.Property(e => e.Ngay)
                .HasColumnType("datetime")
                .HasColumnName("NGAY");
            entity.Property(e => e.Ngayck)
                .HasColumnType("datetime")
                .HasColumnName("NGAYCK");
            entity.Property(e => e.Ngaylap)
                .HasColumnType("datetime")
                .HasColumnName("NGAYLAP");
            entity.Property(e => e.Nguoilap).HasColumnName("NGUOILAP");
            entity.Property(e => e.Ptid).HasColumnName("PTID");
            entity.Property(e => e.Ptname)
                .HasMaxLength(100)
                .HasColumnName("PTNAME");
            entity.Property(e => e.Quyen).HasMaxLength(20);
            entity.Property(e => e.Seri)
                .HasMaxLength(20)
                .HasColumnName("SERI");
            entity.Property(e => e.Sohd).HasColumnName("SOHD");
            entity.Property(e => e.Thanhtien).HasColumnName("THANHTIEN");
            entity.Property(e => e.Tuan).HasColumnName("TUAN");
            entity.Property(e => e.Vat).HasColumnName("VAT");
        });

        modelBuilder.Entity<CdPhieuthuct>(entity =>
        {
            entity.ToTable("CD_PHIEUTHUCT");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Bsgm).HasColumnName("BSGM");
            entity.Property(e => e.Ghichu)
                .HasMaxLength(100)
                .HasColumnName("GHICHU");
            entity.Property(e => e.Heso).HasColumnName("HESO");
            entity.Property(e => e.Labo).HasColumnName("LABO");
            entity.Property(e => e.Maloai)
                .HasMaxLength(20)
                .HasColumnName("MALOAI");
            entity.Property(e => e.Maso).HasColumnName("MASO");
            entity.Property(e => e.Sotien).HasColumnName("SOTIEN");
        });

        modelBuilder.Entity<CdSocot>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CD_SOCOT");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Kyhieu)
                .HasMaxLength(50)
                .HasColumnName("KYHIEU");
            entity.Property(e => e.Manhom).HasColumnName("MANHOM");
            entity.Property(e => e.Stt).HasColumnName("STT");
            entity.Property(e => e.Tennhom)
                .HasMaxLength(50)
                .HasColumnName("TENNHOM");
            entity.Property(e => e.Tm).HasColumnName("TM");
        });

        modelBuilder.Entity<CdSodieutri>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CD_SODIEUTRI");

            entity.Property(e => e.Chiphi).HasColumnName("CHIPHI");
            entity.Property(e => e.Conno).HasColumnName("CONNO");
            entity.Property(e => e.Datra).HasColumnName("DATRA");
            entity.Property(e => e.Diengiai)
                .HasMaxLength(1000)
                .HasColumnName("DIENGIAI");
            entity.Property(e => e.Giam).HasColumnName("GIAM");
            entity.Property(e => e.Idbn).HasColumnName("IDBN");
            entity.Property(e => e.Idnv).HasColumnName("IDNV");
            entity.Property(e => e.Idpdt).HasColumnName("IDPDT");
            entity.Property(e => e.Kip).HasColumnName("KIP");
            entity.Property(e => e.Manv).HasColumnName("MANV");
            entity.Property(e => e.Ngaydt)
                .HasColumnType("smalldatetime")
                .HasColumnName("NGAYDT");
            entity.Property(e => e.Ptid).HasColumnName("PTID");
            entity.Property(e => e.Thanhtien).HasColumnName("THANHTIEN");
            entity.Property(e => e.Tienbs).HasColumnName("TIENBS");
            entity.Property(e => e.Ttid).HasColumnName("TTID");
        });

        modelBuilder.Entity<CdSolabo>(entity =>
        {
            entity.HasKey(e => e.Stt);

            entity.ToTable("CD_SOLABO");

            entity.Property(e => e.Bstl).HasColumnName("BSTL");
            entity.Property(e => e.Idbn).HasColumnName("IDBN");
            entity.Property(e => e.Idncc).HasColumnName("IDNCC");
            entity.Property(e => e.Idnv).HasColumnName("IDNV");
            entity.Property(e => e.Idphieu).HasColumnName("IDPhieu");
            entity.Property(e => e.Kip).HasMaxLength(10);
            entity.Property(e => e.Ngay).HasColumnType("datetime");
            entity.Property(e => e.Ngaylap)
                .HasColumnType("datetime")
                .HasColumnName("NGAYLAP");
            entity.Property(e => e.Nguoilap).HasMaxLength(50);
        });

        modelBuilder.Entity<CdTinhhinhdieutri>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CD_TINHHINHDIEUTRI");

            entity.Property(e => e.Dtid).HasColumnName("DTID");
            entity.Property(e => e.Ename)
                .HasMaxLength(255)
                .HasColumnName("ENAME");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Idnv).HasColumnName("IDNV");
            entity.Property(e => e.Jid).HasColumnName("JID");
            entity.Property(e => e.Jname)
                .HasMaxLength(255)
                .HasColumnName("JNAME");
            entity.Property(e => e.Kip).HasColumnName("KIP");
            entity.Property(e => e.Mabn)
                .HasMaxLength(50)
                .HasColumnName("MABN");
            entity.Property(e => e.Ngay)
                .HasColumnType("datetime")
                .HasColumnName("NGAY");
            entity.Property(e => e.Ptid).HasColumnName("PTID");
            entity.Property(e => e.Ptname)
                .HasMaxLength(100)
                .HasColumnName("PTNAME");
            entity.Property(e => e.Rang)
                .HasMaxLength(255)
                .HasColumnName("RANG");
            entity.Property(e => e.Sotiendieutri).HasColumnName("SOTIENDIEUTRI");
            entity.Property(e => e.Sotientra).HasColumnName("SOTIENTRA");
        });

        modelBuilder.Entity<CskhDinhNghiaThamSo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_CSKH_ThuocTinhThamSo");

            entity.ToTable("CSKH_DinhNghiaThamSo");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CauLenh).HasMaxLength(1000);
            entity.Property(e => e.DinhNghiaThamSo).HasMaxLength(500);
            entity.Property(e => e.Dvkt).HasColumnName("DVKT");
            entity.Property(e => e.MaThamSo).HasMaxLength(50);
        });

        modelBuilder.Entity<CskhLoaiCskh>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CSKH_Loa__3214EC07678F697E");

            entity.ToTable("CSKH_LoaiCSKH");

            entity.Property(e => e.Ma).HasMaxLength(50);
            entity.Property(e => e.Ten).HasMaxLength(50);

            entity.HasOne(d => d.Template).WithMany(p => p.CskhLoaiCskhs)
                .HasForeignKey(d => d.TemplateId)
                .HasConstraintName("FK_CSCH_LoaiCSKH_DM_Template");
        });

        modelBuilder.Entity<CskhTemplateCt>(entity =>
        {
            entity.ToTable("CSKH_Template_CT");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IddinhNghiaThamSo).HasColumnName("IDDinhNghiaThamSo");
            entity.Property(e => e.IdloaiCskh).HasColumnName("IDLoaiCSKH");
            entity.Property(e => e.ThamSoZalo).HasMaxLength(50);

            entity.HasOne(d => d.IddinhNghiaThamSoNavigation).WithMany(p => p.CskhTemplateCts)
                .HasForeignKey(d => d.IddinhNghiaThamSo)
                .HasConstraintName("fk_tempCT_DinhNghia");

            entity.HasOne(d => d.IdloaiCskhNavigation).WithMany(p => p.CskhTemplateCts)
                .HasForeignKey(d => d.IdloaiCskh)
                .HasConstraintName("fk_LoaiCSKH_CSKHCT");
        });

        modelBuilder.Entity<DmBanner>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DM_Banne__3214EC2715C5A46B");

            entity.ToTable("DM_Banner");

            entity.HasIndex(e => e.HoatDong, "IX_DM_Banner_HoatDong");

            entity.HasIndex(e => e.IdchiNhanh, "IX_DM_Banner_IDChiNhanh");

            entity.HasIndex(e => e.ThuTu, "IX_DM_Banner_ThuTu");

            entity.HasIndex(e => e.ViTri, "IX_DM_Banner_ViTri");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DuongDan).HasMaxLength(500);
            entity.Property(e => e.HinhAnh).HasMaxLength(500);
            entity.Property(e => e.HoatDong).HasDefaultValue(true);
            entity.Property(e => e.IdchiNhanh).HasColumnName("IDChiNhanh");
            entity.Property(e => e.NgayCapNhat).HasColumnType("datetime");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.NoiDung).HasMaxLength(1000);
            entity.Property(e => e.TieuDe).HasMaxLength(200);
            entity.Property(e => e.ViTri)
                .HasMaxLength(50)
                .HasDefaultValue("left");

            entity.HasOne(d => d.IdchiNhanhNavigation).WithMany(p => p.DmBanners)
                .HasForeignKey(d => d.IdchiNhanh)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK_DM_Banner_DM_ChiNhanh");
        });

        modelBuilder.Entity<DmBenhAn>(entity =>
        {
            entity.ToTable("DM_BenhAn");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.MaBenhAn).HasMaxLength(50);
            entity.Property(e => e.TenBenhAn).HasMaxLength(500);
            entity.Property(e => e.ViewName).HasMaxLength(50);
        });

        modelBuilder.Entity<DmBenhNhan>(entity =>
        {
            entity.ToTable("DM_BenhNhan");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Cccd)
                .HasMaxLength(50)
                .HasColumnName("CCCD");
            entity.Property(e => e.CccdnguoiNha)
                .HasMaxLength(100)
                .HasColumnName("CCCDNguoiNha");
            entity.Property(e => e.DiaChi).HasMaxLength(500);
            entity.Property(e => e.DiaChiCongTyThue).HasMaxLength(500);
            entity.Property(e => e.DiaChiMoi).HasMaxLength(1000);
            entity.Property(e => e.DiaChiNguoiNha).HasMaxLength(100);
            entity.Property(e => e.DienThoai).HasMaxLength(50);
            entity.Property(e => e.DienThoaiKhac).HasMaxLength(50);
            entity.Property(e => e.DienThoaiNguoiNha).HasMaxLength(100);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.EmailNhanHoaDon).HasMaxLength(50);
            entity.Property(e => e.GhiChu).HasMaxLength(500);
            entity.Property(e => e.GhiChuChuyen).HasMaxLength(500);
            entity.Property(e => e.HoTenNguoiNha).HasMaxLength(100);
            entity.Property(e => e.HoTenNguoiThan).HasMaxLength(500);
            entity.Property(e => e.IdchiNhanh).HasColumnName("IDChiNhanh");
            entity.Property(e => e.IdchiNhanhTao).HasColumnName("IDChiNhanhTao");
            entity.Property(e => e.IddanToc).HasColumnName("IDDanToc");
            entity.Property(e => e.IdgioiTinh).HasColumnName("IDGioiTinh");
            entity.Property(e => e.IdloaiBenhNhan).HasColumnName("IDLoaiBenhNhan");
            entity.Property(e => e.IdmoiLienHe).HasColumnName("IDMoiLienHe");
            entity.Property(e => e.IdngheNghiep).HasColumnName("IDNgheNghiep");
            entity.Property(e => e.IdnguonTin).HasColumnName("IDNguonTin");
            entity.Property(e => e.IdnhanVienCapNhat).HasColumnName("IDNhanVienCapNhat");
            entity.Property(e => e.IdnhanVienTao).HasColumnName("IDNhanVienTao");
            entity.Property(e => e.Idpx).HasColumnName("IDPX");
            entity.Property(e => e.Idquan).HasColumnName("IDQuan");
            entity.Property(e => e.IdquocGia).HasColumnName("IDQuocGia");
            entity.Property(e => e.Idtinh).HasColumnName("IDTinh");
            entity.Property(e => e.LyDoDenKham).HasMaxLength(2000);
            entity.Property(e => e.LyDoDenKhamLanDau).HasMaxLength(1000);
            entity.Property(e => e.MaBenhNhan).HasMaxLength(50);
            entity.Property(e => e.MaSinhVien).HasMaxLength(50);
            entity.Property(e => e.MaSoThue).HasMaxLength(500);
            entity.Property(e => e.MaSvnhan)
                .HasMaxLength(50)
                .HasColumnName("MaSVNhan");
            entity.Property(e => e.NgayTddc)
                .HasColumnType("datetime")
                .HasColumnName("NgayTDDC");
            entity.Property(e => e.SoNhaTenDuong).HasMaxLength(500);
            entity.Property(e => e.TenBenhNhan).HasMaxLength(500);
            entity.Property(e => e.TenCongTyThue).HasMaxLength(500);
            entity.Property(e => e.TenKhongDau).HasMaxLength(500);
            entity.Property(e => e.TinhCachBenhNhan).HasMaxLength(500);
            entity.Property(e => e.TkfaceBook)
                .HasMaxLength(500)
                .HasColumnName("TKFaceBook");
            entity.Property(e => e.Tktelegram)
                .HasMaxLength(500)
                .HasColumnName("TKTelegram");
            entity.Property(e => e.Tkzalo)
                .HasMaxLength(500)
                .HasColumnName("TKZalo");

            entity.HasOne(d => d.IdchiNhanhNavigation).WithMany(p => p.DmBenhNhans)
                .HasForeignKey(d => d.IdchiNhanh)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DM_BenhNhan_DM_ChiNhanh");

            entity.HasOne(d => d.IddanTocNavigation).WithMany(p => p.DmBenhNhans)
                .HasForeignKey(d => d.IddanToc)
                .HasConstraintName("FK_DM_BenhNhan_DM_DanToc");

            entity.HasOne(d => d.IdgioiTinhNavigation).WithMany(p => p.DmBenhNhans)
                .HasForeignKey(d => d.IdgioiTinh)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DM_BenhNhan_DM_GioiTinh");

            entity.HasOne(d => d.IdloaiBenhNhanNavigation).WithMany(p => p.DmBenhNhans)
                .HasForeignKey(d => d.IdloaiBenhNhan)
                .HasConstraintName("FK_DM_BenhNhan_DM_LoaiBenhNhan");

            entity.HasOne(d => d.IdmoiLienHeNavigation).WithMany(p => p.DmBenhNhans)
                .HasForeignKey(d => d.IdmoiLienHe)
                .HasConstraintName("FK_DM_BenhNhan_DM_MoiLienHe");

            entity.HasOne(d => d.IdngheNghiepNavigation).WithMany(p => p.DmBenhNhans)
                .HasForeignKey(d => d.IdngheNghiep)
                .HasConstraintName("FK_DM_BenhNhan_DM_NgheNghiep");

            entity.HasOne(d => d.IdnguonTinNavigation).WithMany(p => p.DmBenhNhans)
                .HasForeignKey(d => d.IdnguonTin)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DM_BenhNhan_DM_NguonTin");

            entity.HasOne(d => d.IdnhanVienCapNhatNavigation).WithMany(p => p.DmBenhNhanIdnhanVienCapNhatNavigations)
                .HasForeignKey(d => d.IdnhanVienCapNhat)
                .HasConstraintName("FK_DM_BenhNhan_DM_NhanVien");

            entity.HasOne(d => d.IdnhanVienTaoNavigation).WithMany(p => p.DmBenhNhanIdnhanVienTaoNavigations)
                .HasForeignKey(d => d.IdnhanVienTao)
                .HasConstraintName("fk_BN_NhanVien");

            entity.HasOne(d => d.IdpxNavigation).WithMany(p => p.DmBenhNhans)
                .HasForeignKey(d => d.Idpx)
                .HasConstraintName("FK_DM_BenhNhan_DM_XaCuTru");

            entity.HasOne(d => d.IdquanNavigation).WithMany(p => p.DmBenhNhans)
                .HasForeignKey(d => d.Idquan)
                .HasConstraintName("FK_DM_BenhNhan_DM_QuanCuTru");

            entity.HasOne(d => d.IdquocGiaNavigation).WithMany(p => p.DmBenhNhans)
                .HasForeignKey(d => d.IdquocGia)
                .HasConstraintName("FK_DM_BenhNhan_DM_QuocGia");

            entity.HasOne(d => d.IdtinhNavigation).WithMany(p => p.DmBenhNhans)
                .HasForeignKey(d => d.Idtinh)
                .HasConstraintName("FK_DM_BenhNhan_DM_TinhCuTru");
        });

        modelBuilder.Entity<DmBenhNhanDuBi>(entity =>
        {
            entity.ToTable("DM_BenhNhanDuBi");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DiaChi).HasMaxLength(500);
            entity.Property(e => e.DienThoai).HasMaxLength(50);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.IdchiNhanh).HasColumnName("IDChiNhanh");
            entity.Property(e => e.IddanToc).HasColumnName("IDDanToc");
            entity.Property(e => e.IdgioiTinh).HasColumnName("IDGioiTinh");
            entity.Property(e => e.IdloaiBenhNhan).HasColumnName("IDLoaiBenhNhan");
            entity.Property(e => e.IdngheNghiep).HasColumnName("IDNgheNghiep");
            entity.Property(e => e.IdnguonTin).HasColumnName("IDNguonTin");
            entity.Property(e => e.IdnhanVienCapNhat).HasColumnName("IDNhanVienCapNhat");
            entity.Property(e => e.Idpx).HasColumnName("IDPX");
            entity.Property(e => e.Idquan).HasColumnName("IDQuan");
            entity.Property(e => e.IdquocGia).HasColumnName("IDQuocGia");
            entity.Property(e => e.Idtinh).HasColumnName("IDTinh");
            entity.Property(e => e.MaBenhNhan).HasMaxLength(50);
            entity.Property(e => e.TenBenhNhan).HasMaxLength(500);
            entity.Property(e => e.TkfaceBook)
                .HasMaxLength(500)
                .HasColumnName("TKFaceBook");
            entity.Property(e => e.Tktelegram)
                .HasMaxLength(500)
                .HasColumnName("TKTelegram");
            entity.Property(e => e.Tkzalo)
                .HasMaxLength(500)
                .HasColumnName("TKZalo");

            entity.HasOne(d => d.IdchiNhanhNavigation).WithMany(p => p.DmBenhNhanDuBis)
                .HasForeignKey(d => d.IdchiNhanh)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DM_BenhNhanDuBi_DM_ChiNhanh");

            entity.HasOne(d => d.IddanTocNavigation).WithMany(p => p.DmBenhNhanDuBis)
                .HasForeignKey(d => d.IddanToc)
                .HasConstraintName("FK_DM_BenhNhanDuBi_DM_DanToc");

            entity.HasOne(d => d.IdgioiTinhNavigation).WithMany(p => p.DmBenhNhanDuBis)
                .HasForeignKey(d => d.IdgioiTinh)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DM_BenhNhanDuBi_DM_GioiTinh");

            entity.HasOne(d => d.IdloaiBenhNhanNavigation).WithMany(p => p.DmBenhNhanDuBis)
                .HasForeignKey(d => d.IdloaiBenhNhan)
                .HasConstraintName("FK_DM_BenhNhanDuBi_DM_LoaiBenhNhan");

            entity.HasOne(d => d.IdngheNghiepNavigation).WithMany(p => p.DmBenhNhanDuBis)
                .HasForeignKey(d => d.IdngheNghiep)
                .HasConstraintName("FK_DM_BenhNhanDuBi_DM_NgheNghiep");

            entity.HasOne(d => d.IdnguonTinNavigation).WithMany(p => p.DmBenhNhanDuBis)
                .HasForeignKey(d => d.IdnguonTin)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DM_BenhNhanDuBi_DM_NguonTin");

            entity.HasOne(d => d.IdnhanVienCapNhatNavigation).WithMany(p => p.DmBenhNhanDuBis)
                .HasForeignKey(d => d.IdnhanVienCapNhat)
                .HasConstraintName("FK_DM_BenhNhanDuBi_DM_NhanVien");

            entity.HasOne(d => d.IdpxNavigation).WithMany(p => p.DmBenhNhanDuBis)
                .HasForeignKey(d => d.Idpx)
                .HasConstraintName("FK_DM_BenhNhanDuBi_DM_XaCuTru");

            entity.HasOne(d => d.IdquanNavigation).WithMany(p => p.DmBenhNhanDuBis)
                .HasForeignKey(d => d.Idquan)
                .HasConstraintName("FK_DM_BenhNhanDuBi_DM_QuanCuTru");

            entity.HasOne(d => d.IdquocGiaNavigation).WithMany(p => p.DmBenhNhanDuBis)
                .HasForeignKey(d => d.IdquocGia)
                .HasConstraintName("FK_DM_BenhNhanDuBi_DM_QuocGia");

            entity.HasOne(d => d.IdtinhNavigation).WithMany(p => p.DmBenhNhanDuBis)
                .HasForeignKey(d => d.Idtinh)
                .HasConstraintName("FK_DM_BenhNhanDuBi_DM_TinhCuTru");
        });

        modelBuilder.Entity<DmBntheoBacSi>(entity =>
        {
            entity.ToTable("DM_BNTheoBacSi");

            entity.HasIndex(e => new { e.IdnhanVien, e.Idbn, e.IdvaoVien }, "UC_BNTheoBacSi").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Idbn).HasColumnName("IDBN");
            entity.Property(e => e.IdnhanVien).HasColumnName("IDNhanVien");
            entity.Property(e => e.IdvaoVien).HasColumnName("IDVaoVien");

            entity.HasOne(d => d.IdbnNavigation).WithMany(p => p.DmBntheoBacSis)
                .HasForeignKey(d => d.Idbn)
                .HasConstraintName("FK__DM_BNTheoB__IDBN__57D2EA43");

            entity.HasOne(d => d.IdnhanVienNavigation).WithMany(p => p.DmBntheoBacSis)
                .HasForeignKey(d => d.IdnhanVien)
                .HasConstraintName("FK__DM_BNTheo__IDNha__55EAA1D1");

            entity.HasOne(d => d.IdvaoVienNavigation).WithMany(p => p.DmBntheoBacSis)
                .HasForeignKey(d => d.IdvaoVien)
                .HasConstraintName("FK__DM_BNTheo__IDVao__56DEC60A");
        });

        modelBuilder.Entity<DmBoDungCu>(entity =>
        {
            entity.ToTable("DM_BoDungCu");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Idkhoa).HasColumnName("IDKhoa");
            entity.Property(e => e.IdnhanVienTao).HasColumnName("IDNhanVienTao");
            entity.Property(e => e.Ma).HasMaxLength(50);
            entity.Property(e => e.NgayTao).HasColumnType("datetime");
            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.Ten).HasMaxLength(255);

            entity.HasOne(d => d.IdnhanVienTaoNavigation).WithMany(p => p.DmBoDungCus)
                .HasForeignKey(d => d.IdnhanVienTao)
                .HasConstraintName("FK_BDC_NVTao");
        });

        modelBuilder.Entity<DmBoDungCuCt>(entity =>
        {
            entity.ToTable("DM_BoDungCu_CT");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdboDungCu).HasColumnName("IDBoDungCu");
            entity.Property(e => e.IdhangHoa).HasColumnName("IDHangHoa");
            entity.Property(e => e.IdtrangThai).HasColumnName("IDTrangThai");
            entity.Property(e => e.Sl).HasColumnName("SL");

            entity.HasOne(d => d.IdboDungCuNavigation).WithMany(p => p.DmBoDungCuCts)
                .HasForeignKey(d => d.IdboDungCu)
                .HasConstraintName("FK_CT_BDC");

            entity.HasOne(d => d.IdhangHoaNavigation).WithMany(p => p.DmBoDungCuCts)
                .HasForeignKey(d => d.IdhangHoa)
                .HasConstraintName("FK_CT_HH");

            entity.HasOne(d => d.IdtrangThaiNavigation).WithMany(p => p.DmBoDungCuCts)
                .HasForeignKey(d => d.IdtrangThai)
                .HasConstraintName("FK_CT_TT");
        });

        modelBuilder.Entity<DmCaLamViec>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DM_CaLam__3214EC0726C8B477");

            entity.ToTable("DM_CaLamViec");

            entity.Property(e => e.MaCa).HasMaxLength(50);
            entity.Property(e => e.TenCa).HasMaxLength(50);
        });

        modelBuilder.Entity<DmChiNhanh>(entity =>
        {
            entity.ToTable("DM_ChiNhanh");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ApicongVan)
                .HasMaxLength(500)
                .HasColumnName("APICongVan");
            entity.Property(e => e.ApisignPad)
                .HasMaxLength(500)
                .HasColumnName("APISignPad");
            entity.Property(e => e.ChuTk).HasMaxLength(50);
            entity.Property(e => e.DiaChi).HasMaxLength(500);
            entity.Property(e => e.DiaChi2).HasMaxLength(500);
            entity.Property(e => e.DienThoai).HasMaxLength(500);
            entity.Property(e => e.DienThoai2).HasMaxLength(500);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.IdkeToan).HasColumnName("IDKeToan");
            entity.Property(e => e.IdnganHang).HasColumnName("IDNganHang");
            entity.Property(e => e.IdthuQuy).HasColumnName("IDThuQuy");
            entity.Property(e => e.IdthuTruongDonVi).HasColumnName("IDThuTruongDonVi");
            entity.Property(e => e.Logo).HasMaxLength(500);
            entity.Property(e => e.MaChiNhanh).HasMaxLength(50);
            entity.Property(e => e.MaCskcb)
                .HasMaxLength(50)
                .HasColumnName("MaCSKCB");
            entity.Property(e => e.Mst)
                .HasMaxLength(50)
                .HasColumnName("MST");
            entity.Property(e => e.SoTk).HasMaxLength(50);
            entity.Property(e => e.Sttbn).HasColumnName("STTBN");
            entity.Property(e => e.TenChiNhanh).HasMaxLength(500);
            entity.Property(e => e.TenCoQuanChuyenMon).HasMaxLength(500);
            entity.Property(e => e.TenCskcb)
                .HasMaxLength(500)
                .HasColumnName("TenCSKCB");

            entity.HasOne(d => d.IdkeToanNavigation).WithMany(p => p.DmChiNhanhIdkeToanNavigations)
                .HasForeignKey(d => d.IdkeToan)
                .HasConstraintName("FK_DM_ChiNhanh_KeToan");

            entity.HasOne(d => d.IdnganHangNavigation).WithMany(p => p.DmChiNhanhs)
                .HasForeignKey(d => d.IdnganHang)
                .HasConstraintName("FK_CN_NganHang");

            entity.HasOne(d => d.IdthuQuyNavigation).WithMany(p => p.DmChiNhanhIdthuQuyNavigations)
                .HasForeignKey(d => d.IdthuQuy)
                .HasConstraintName("FK_DM_ChiNhanh_ThuQuy");

            entity.HasOne(d => d.IdthuTruongDonViNavigation).WithMany(p => p.DmChiNhanhIdthuTruongDonViNavigations)
                .HasForeignKey(d => d.IdthuTruongDonVi)
                .HasConstraintName("FK_DM_ChiNhanh_ThuTruongDonVi");
        });

        modelBuilder.Entity<DmChitietphi>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_DM_CHITIETPHI");

            entity.Property(e => e.Bsgm).HasColumnName("BSGM");
            entity.Property(e => e.Ghichu)
                .HasMaxLength(100)
                .HasColumnName("GHICHU");
            entity.Property(e => e.Heso).HasColumnName("HESO");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Labo).HasColumnName("LABO");
            entity.Property(e => e.Maloai)
                .HasMaxLength(20)
                .HasColumnName("MALOAI");
            entity.Property(e => e.Maso).HasColumnName("MASO");
            entity.Property(e => e.Sotien).HasColumnName("SOTIEN");
        });

        modelBuilder.Entity<DmCoSoVatTuThietYeu>(entity =>
        {
            entity.ToTable("DM_CoSoVatTuThietYeu");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Idcn).HasColumnName("IDCN");
            entity.Property(e => e.Idhh).HasColumnName("IDHH");

            entity.HasOne(d => d.IdcnNavigation).WithMany(p => p.DmCoSoVatTuThietYeus)
                .HasForeignKey(d => d.Idcn)
                .HasConstraintName("fk_cn_coso");

            entity.HasOne(d => d.IdhhNavigation).WithMany(p => p.DmCoSoVatTuThietYeus)
                .HasForeignKey(d => d.Idhh)
                .HasConstraintName("fk_hh_coso");
        });

        modelBuilder.Entity<DmDanToc>(entity =>
        {
            entity.ToTable("DM_DanToc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.MaDanToc).HasMaxLength(50);
            entity.Property(e => e.TenDanToc).HasMaxLength(500);
            entity.Property(e => e.TenGoiKhac).HasMaxLength(500);
        });

        modelBuilder.Entity<DmDichVuKyThuat>(entity =>
        {
            entity.ToTable("DM_DichVuKyThuat");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IddonViTinh).HasColumnName("IDDonViTinh");
            entity.Property(e => e.IdnhomChiPhi).HasColumnName("IDNhomChiPhi");
            entity.Property(e => e.IdnhomDichVu).HasColumnName("IDNhomDichVu");
            entity.Property(e => e.IdthoiGianBaoHanh).HasColumnName("IDThoiGianBaoHanh");
            entity.Property(e => e.IdthoiGianChamSocDinhKy).HasColumnName("IDThoiGianChamSocDinhKy");
            entity.Property(e => e.IdthoiGianChamSocSauDieuTri).HasColumnName("IDThoiGianChamSocSauDieuTri");
            entity.Property(e => e.Loaittpt).HasColumnName("LOAITTPT");
            entity.Property(e => e.MaDichVu).HasMaxLength(50);
            entity.Property(e => e.MaQuyTrinh).HasMaxLength(50);
            entity.Property(e => e.Stt).HasColumnName("STT");
            entity.Property(e => e.Stttt14).HasColumnName("STTTT14");
            entity.Property(e => e.TenDichVu).HasMaxLength(500);
            entity.Property(e => e.TenDichVuTa)
                .HasMaxLength(500)
                .HasColumnName("TenDichVuTA");
            entity.Property(e => e.ThueVat).HasColumnName("ThueVAT");

            entity.HasOne(d => d.IddonViTinhNavigation).WithMany(p => p.DmDichVuKyThuats)
                .HasForeignKey(d => d.IddonViTinh)
                .HasConstraintName("FK_DM_DichVuKyThuat_HH_DM_DonViTinh");

            entity.HasOne(d => d.IdnhomChiPhiNavigation).WithMany(p => p.DmDichVuKyThuats)
                .HasForeignKey(d => d.IdnhomChiPhi)
                .HasConstraintName("FK_DVKT_NhomChiPhi");

            entity.HasOne(d => d.IdnhomDichVuNavigation).WithMany(p => p.DmDichVuKyThuats)
                .HasForeignKey(d => d.IdnhomDichVu)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DM_DichVuKyThuat_DM_NhomDichVuKyThuat");

            entity.HasOne(d => d.IdthoiGianBaoHanhNavigation).WithMany(p => p.DmDichVuKyThuatIdthoiGianBaoHanhNavigations)
                .HasForeignKey(d => d.IdthoiGianBaoHanh)
                .HasConstraintName("FK_DM_DichVuKyThuat_DM_ThoiGian");

            entity.HasOne(d => d.IdthoiGianChamSocDinhKyNavigation).WithMany(p => p.DmDichVuKyThuatIdthoiGianChamSocDinhKyNavigations)
                .HasForeignKey(d => d.IdthoiGianChamSocDinhKy)
                .HasConstraintName("FK_DM_DichVuKyThuat_DM_ThoiGian1");

            entity.HasOne(d => d.IdthoiGianChamSocSauDieuTriNavigation).WithMany(p => p.DmDichVuKyThuatIdthoiGianChamSocSauDieuTriNavigations)
                .HasForeignKey(d => d.IdthoiGianChamSocSauDieuTri)
                .HasConstraintName("FK_DM_DichVuKyThuat_DM_ThoiGian2");
        });

        modelBuilder.Entity<DmDichVuKyThuatGium>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DM_DichV__3214EC27777E41F7");

            entity.ToTable("DM_DichVuKyThuat_Gia");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Iddvkt).HasColumnName("IDDVKT");
            entity.Property(e => e.Idkhu).HasColumnName("IDKhu");
            entity.Property(e => e.MoTa).HasMaxLength(200);

            entity.HasOne(d => d.IddvktNavigation).WithMany(p => p.DmDichVuKyThuatGia)
                .HasForeignKey(d => d.Iddvkt)
                .HasConstraintName("FK__DM_DichVu__IDDVK__4924D839");

            entity.HasOne(d => d.IdkhuNavigation).WithMany(p => p.DmDichVuKyThuatGia)
                .HasForeignKey(d => d.Idkhu)
                .HasConstraintName("FK_DVKTG_CN");
        });

        modelBuilder.Entity<DmDichVuKyThuatSoLanDung>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DM_DichV__3214EC074AF65AA7");

            entity.ToTable("DM_DichVuKyThuat_SoLanDung");

            entity.Property(e => e.Iddvkt).HasColumnName("IDDVKT");
            entity.Property(e => e.Idkhu).HasColumnName("IDKhu");

            entity.HasOne(d => d.IddvktNavigation).WithMany(p => p.DmDichVuKyThuatSoLanDungs)
                .HasForeignKey(d => d.Iddvkt)
                .HasConstraintName("FK_DM_DichVuKyThuat_SoLanDung_DM_DichVuKyThuat");

            entity.HasOne(d => d.IdkhuNavigation).WithMany(p => p.DmDichVuKyThuatSoLanDungs)
                .HasForeignKey(d => d.Idkhu)
                .HasConstraintName("FK_DM_DichVuKyThuat_SoLanDung_DM_ChiNhanh");
        });

        modelBuilder.Entity<DmDoiTac>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DM_DoiTa__3214EC2760F7282A");

            entity.ToTable("DM_DoiTac");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DiaChi).HasMaxLength(255);
            entity.Property(e => e.DienThoai).HasMaxLength(50);
            entity.Property(e => e.MaDoiTac).HasMaxLength(50);
            entity.Property(e => e.TenDoiTac).HasMaxLength(255);
        });

        modelBuilder.Entity<DmDoiTacBaoHiem>(entity =>
        {
            entity.ToTable("DM_DoiTacBaoHiem");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DiaChi).HasMaxLength(500);
            entity.Property(e => e.DienThoai).HasMaxLength(500);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.GhiChu).HasMaxLength(500);
            entity.Property(e => e.MaDoiTac).HasMaxLength(50);
            entity.Property(e => e.TenDoiTac).HasMaxLength(500);
        });

        modelBuilder.Entity<DmDuongDung>(entity =>
        {
            entity.ToTable("DM_DuongDung");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.MaDuongDung).HasMaxLength(20);
            entity.Property(e => e.TenDuongDung).HasMaxLength(500);
        });

        modelBuilder.Entity<DmGioiTinh>(entity =>
        {
            entity.ToTable("DM_GioiTinh");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.MaGioiTinh).HasMaxLength(50);
            entity.Property(e => e.TenGioiTinh).HasMaxLength(100);
        });

        modelBuilder.Entity<DmHienTrangRang>(entity =>
        {
            entity.ToTable("DM_HienTrangRang");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Logo).HasMaxLength(300);
            entity.Property(e => e.MoTa).HasMaxLength(500);
            entity.Property(e => e.RangBaChan).HasMaxLength(500);
            entity.Property(e => e.RangMotChan).HasMaxLength(500);
            entity.Property(e => e.StthienThi).HasColumnName("STTHienThi");
            entity.Property(e => e.StthienTrang).HasColumnName("STTHienTrang");
        });

        modelBuilder.Entity<DmHinhThucThanhToan>(entity =>
        {
            entity.ToTable("DM_HinhThucThanhToan");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.TenHinhThucThanhToan).HasMaxLength(50);
        });

        modelBuilder.Entity<DmIcd>(entity =>
        {
            entity.ToTable("DM_ICD");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BenhCua).HasMaxLength(50);
            entity.Property(e => e.BenhNam).HasMaxLength(50);
            entity.Property(e => e.ChuyenKhoa).HasMaxLength(500);
            entity.Property(e => e.HieuLuc).HasMaxLength(500);
            entity.Property(e => e.KhongBh)
                .HasMaxLength(50)
                .HasColumnName("KhongBH");
            entity.Property(e => e.MaBenh).HasMaxLength(50);
            entity.Property(e => e.ManTinh).HasMaxLength(50);
            entity.Property(e => e.MoTa).HasMaxLength(500);
            entity.Property(e => e.NgoaiDs)
                .HasMaxLength(50)
                .HasColumnName("NgoaiDS");
            entity.Property(e => e.NhomBenh).HasMaxLength(500);
            entity.Property(e => e.TenBenh).HasMaxLength(500);
            entity.Property(e => e.ThuongGap).HasMaxLength(50);
        });

        modelBuilder.Entity<DmKetQuaDieuTri>(entity =>
        {
            entity.ToTable("DM_KetQuaDieuTri");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.KetQuaDieuTri).HasMaxLength(500);
        });

        modelBuilder.Entity<DmKhoanThuChi>(entity =>
        {
            entity.ToTable("DM_KhoanThuChi");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.KhoanThuChi).HasMaxLength(100);
        });

        modelBuilder.Entity<DmKhungGioHen>(entity =>
        {
            entity.ToTable("DM_KhungGioHen");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Stt)
                .HasMaxLength(50)
                .HasColumnName("STT");
            entity.Property(e => e.TenKhungGio).HasMaxLength(500);
        });

        modelBuilder.Entity<DmKip>(entity =>
        {
            entity.ToTable("DM_Kip");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.TenKip).HasMaxLength(50);
        });

        modelBuilder.Entity<DmLoaiBenhNhan>(entity =>
        {
            entity.ToTable("DM_LoaiBenhNhan");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.MaLbn)
                .HasMaxLength(50)
                .HasColumnName("MaLBN");
            entity.Property(e => e.TenLbn)
                .HasMaxLength(500)
                .HasColumnName("TenLBN");
        });

        modelBuilder.Entity<DmLoaiHangHoa>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DM_NhomHangHoa");

            entity.ToTable("DM_LoaiHangHoa");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.MaLoaiHang).HasMaxLength(50);
            entity.Property(e => e.NhomVldemDuoc).HasColumnName("NhomVLDemDuoc");
            entity.Property(e => e.NhomVlkhongDemDuoc).HasColumnName("NhomVLKhongDemDuoc");
            entity.Property(e => e.TenLoaiHang).HasMaxLength(500);
        });

        modelBuilder.Entity<DmLopHoc>(entity =>
        {
            entity.ToTable("DM_LopHoc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdnienKhoa).HasColumnName("IDNienKhoa");
            entity.Property(e => e.MaLopHoc).HasMaxLength(50);
            entity.Property(e => e.TenLopHoc).HasMaxLength(500);

            entity.HasOne(d => d.IdnienKhoaNavigation).WithMany(p => p.DmLopHocs)
                .HasForeignKey(d => d.IdnienKhoa)
                .HasConstraintName("FK_LopHoc_NienKhoa");
        });

        modelBuilder.Entity<DmLyDoHen>(entity =>
        {
            entity.ToTable("DM_LyDoHen");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.LyDoHen).HasMaxLength(500);
        });

        modelBuilder.Entity<DmLyDoRaVien>(entity =>
        {
            entity.ToTable("DM_LyDoRaVien");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.LyDoRaVien).HasMaxLength(500);
        });

        modelBuilder.Entity<DmLyDoVaoVien>(entity =>
        {
            entity.ToTable("DM_LyDoVaoVien");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.LyDoVaoVien).HasMaxLength(500);
        });

        modelBuilder.Entity<DmLyDoXuat>(entity =>
        {
            entity.ToTable("DM_LyDoXuat");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.TenLyDo).HasMaxLength(500);
        });

        modelBuilder.Entity<DmMarKetting>(entity =>
        {
            entity.ToTable("DM_MarKetting");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.MaMarKetting).HasMaxLength(50);
            entity.Property(e => e.TenMarKetting).HasMaxLength(500);
        });

        modelBuilder.Entity<DmMauBenhAn>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_QL_MauBenhAn");

            entity.ToTable("DM_MauBenhAn");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdbenhAn).HasColumnName("IDBenhAn");
            entity.Property(e => e.TenMauBenhAn).HasMaxLength(255);

            entity.HasOne(d => d.IdbenhAnNavigation).WithMany(p => p.DmMauBenhAns)
                .HasForeignKey(d => d.IdbenhAn)
                .HasConstraintName("FK_MBA_BA");
        });

        modelBuilder.Entity<DmMoiLienHe>(entity =>
        {
            entity.ToTable("DM_MoiLienHe");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.TenMoiLienHe).HasMaxLength(100);
        });

        modelBuilder.Entity<DmNganHangDoanhNghiep>(entity =>
        {
            entity.ToTable("DM_NganHangDoanhNghiep");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdchiNhanh).HasColumnName("IDChiNhanh");
            entity.Property(e => e.IdnganHang).HasColumnName("IDNganHang");
            entity.Property(e => e.Stk)
                .HasMaxLength(50)
                .HasColumnName("STK");
            entity.Property(e => e.TenChuTk)
                .HasMaxLength(100)
                .HasColumnName("TenChuTK");

            entity.HasOne(d => d.IdchiNhanhNavigation).WithMany(p => p.DmNganHangDoanhNghieps)
                .HasForeignKey(d => d.IdchiNhanh)
                .HasConstraintName("FK_NHDN_CN");

            entity.HasOne(d => d.IdnganHangNavigation).WithMany(p => p.DmNganHangDoanhNghieps)
                .HasForeignKey(d => d.IdnganHang)
                .HasConstraintName("FK_NHDN_NganHang");
        });

        modelBuilder.Entity<DmNgheNghiep>(entity =>
        {
            entity.ToTable("DM_NgheNghiep");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Cap1).HasMaxLength(50);
            entity.Property(e => e.Cap2).HasMaxLength(50);
            entity.Property(e => e.Cap3).HasMaxLength(50);
            entity.Property(e => e.Cap4).HasMaxLength(50);
            entity.Property(e => e.MaNgheNghiep).HasMaxLength(50);
        });

        modelBuilder.Entity<DmNguonTin>(entity =>
        {
            entity.ToTable("DM_NguonTin");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.TenNguonTin).HasMaxLength(500);
        });

        modelBuilder.Entity<DmNhanVien>(entity =>
        {
            entity.ToTable("DM_NhanVien");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DiaChi).HasMaxLength(500);
            entity.Property(e => e.DienThoai)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Idcd).HasColumnName("IDCD");
            entity.Property(e => e.Idcn).HasColumnName("IDCN");
            entity.Property(e => e.Idgt).HasColumnName("IDGT");
            entity.Property(e => e.Idnh).HasColumnName("IDNH");
            entity.Property(e => e.Idtk).HasColumnName("IDTK");
            entity.Property(e => e.KyTuDinhDanh).HasMaxLength(5);
            entity.Property(e => e.MaNhanVien).HasMaxLength(50);
            entity.Property(e => e.MaSoThue).HasMaxLength(50);
            entity.Property(e => e.Mabhxh)
                .HasMaxLength(50)
                .HasColumnName("MABHXH");
            entity.Property(e => e.Macchn)
                .HasMaxLength(50)
                .HasColumnName("MACCHN");
            entity.Property(e => e.MauLichHen).HasMaxLength(50);
            entity.Property(e => e.Ngaycapcchn).HasColumnName("NGAYCAPCCHN");
            entity.Property(e => e.NhomBsktv).HasColumnName("NhomBSKTV");
            entity.Property(e => e.Noicapcchn)
                .HasMaxLength(500)
                .HasColumnName("NOICAPCCHN");
            entity.Property(e => e.Phamvicm)
                .HasMaxLength(50)
                .HasColumnName("PHAMVICM");
            entity.Property(e => e.QueQuan).HasMaxLength(500);
            entity.Property(e => e.SoTk)
                .HasMaxLength(50)
                .HasColumnName("SoTK");
            entity.Property(e => e.TenCu).HasMaxLength(500);
            entity.Property(e => e.TenNhanVien).HasMaxLength(255);
            entity.Property(e => e.TenVietGon).HasMaxLength(100);
            entity.Property(e => e.Vbphancong)
                .HasMaxLength(500)
                .HasColumnName("VBPHANCONG");

            entity.HasOne(d => d.IdcnNavigation).WithMany(p => p.DmNhanViens)
                .HasForeignKey(d => d.Idcn)
                .HasConstraintName("FK_DM_NhanVien_DM_ChiNhanh");

            entity.HasOne(d => d.IdgtNavigation).WithMany(p => p.DmNhanViens)
                .HasForeignKey(d => d.Idgt)
                .HasConstraintName("FK_DM_NhanVien_DM_GioiTinh");

            entity.HasOne(d => d.IdnhNavigation).WithMany(p => p.DmNhanViens)
                .HasForeignKey(d => d.Idnh)
                .HasConstraintName("FK_DM_NhanVien_HH_DM_NganHang");

            entity.HasOne(d => d.IdtkNavigation).WithMany(p => p.DmNhanViens)
                .HasForeignKey(d => d.Idtk)
                .HasConstraintName("FK_DM_NhanVien_HT_TaiKhoanDangNhap");
        });

        modelBuilder.Entity<DmNhomChiPhi>(entity =>
        {
            entity.ToTable("DM_NhomChiPhi");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.KyHieu).HasMaxLength(50);
            entity.Property(e => e.Ma).HasMaxLength(50);
            entity.Property(e => e.Stt).HasColumnName("STT");
            entity.Property(e => e.TenNhomChiPhi).HasMaxLength(255);
        });

        modelBuilder.Entity<DmNhomDichVuKyThuat>(entity =>
        {
            entity.ToTable("DM_NhomDichVuKyThuat");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.MaChiNhanh).HasMaxLength(50);
            entity.Property(e => e.MaNhomDichVu).HasMaxLength(50);
            entity.Property(e => e.TenNhomDichVu).HasMaxLength(500);
            entity.Property(e => e.Vat).HasColumnName("VAT");
        });

        modelBuilder.Entity<DmNienKhoa>(entity =>
        {
            entity.ToTable("DM_NienKhoa");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.MaNienKhoa).HasMaxLength(50);
            entity.Property(e => e.NienKhoa).HasMaxLength(500);
        });

        modelBuilder.Entity<DmNoiSuDung>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DM_NoiSu__3214EC275BF36D78");

            entity.ToTable("DM_NoiSuDung");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Idcn).HasColumnName("IDCN");
            entity.Property(e => e.MaNoi).HasMaxLength(50);
            entity.Property(e => e.TenNoi).HasMaxLength(255);

            entity.HasOne(d => d.IdcnNavigation).WithMany(p => p.DmNoiSuDungs)
                .HasForeignKey(d => d.Idcn)
                .HasConstraintName("FK__DM_NoiSuDu__IDCN__269AB60B");
        });

        modelBuilder.Entity<DmPhongThucHien>(entity =>
        {
            entity.ToTable("DM_PhongThucHien");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdchiNhanh).HasColumnName("IDChiNhanh");
            entity.Property(e => e.MaPhong).HasMaxLength(50);
            entity.Property(e => e.TenPhong).HasMaxLength(50);

            entity.HasOne(d => d.IdchiNhanhNavigation).WithMany(p => p.DmPhongThucHiens)
                .HasForeignKey(d => d.IdchiNhanh)
                .HasConstraintName("FK_DM_PhongThucHien_DM_ChiNhanh");
        });

        modelBuilder.Entity<DmPhucHinh>(entity =>
        {
            entity.ToTable("DM_PhucHinh");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IddonViTinh).HasColumnName("IDDonViTinh");
            entity.Property(e => e.IdnhomDichVu).HasColumnName("IDNhomDichVu");
            entity.Property(e => e.MaPhucHinh).HasMaxLength(50);
            entity.Property(e => e.TenPhucHinh).HasMaxLength(500);

            entity.HasOne(d => d.IdThoiGianNavigation).WithMany(p => p.DmPhucHinhs)
                .HasForeignKey(d => d.IdThoiGian)
                .HasConstraintName("fk_ph_tg");

            entity.HasOne(d => d.IddonViTinhNavigation).WithMany(p => p.DmPhucHinhs)
                .HasForeignKey(d => d.IddonViTinh)
                .HasConstraintName("FK_PH_DVT");

            entity.HasOne(d => d.IdnhomDichVuNavigation).WithMany(p => p.DmPhucHinhs)
                .HasForeignKey(d => d.IdnhomDichVu)
                .HasConstraintName("FK_DM_PhucHinh_DM_NhomDichVuKyThuat");
        });

        modelBuilder.Entity<DmPhucHinhNcc>(entity =>
        {
            entity.ToTable("DM_PhucHinhNCC");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdnhaCungCap).HasColumnName("IDNhaCungCap");
            entity.Property(e => e.IdphucHinh).HasColumnName("IDPhucHinh");

            entity.HasOne(d => d.IdnhaCungCapNavigation).WithMany(p => p.DmPhucHinhNccs)
                .HasForeignKey(d => d.IdnhaCungCap)
                .HasConstraintName("FK_DM_PhucHinhNCC_HH_DM_NhaCungCap");

            entity.HasOne(d => d.IdphucHinhNavigation).WithMany(p => p.DmPhucHinhNccs)
                .HasForeignKey(d => d.IdphucHinh)
                .HasConstraintName("FK_DM_PhucHinhNCC_DM_PhucHinh");
        });

        modelBuilder.Entity<DmProfileGiayCamKet>(entity =>
        {
            entity.ToTable("DM_Profile_GiayCamKet");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Footer).HasColumnType("ntext");
            entity.Property(e => e.Header).HasColumnType("ntext");
            entity.Property(e => e.TenMau).HasMaxLength(200);
        });

        modelBuilder.Entity<DmProfileHd>(entity =>
        {
            entity.ToTable("DM_ProfileHD");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.NoiDung).HasColumnType("ntext");
            entity.Property(e => e.TenHd)
                .HasMaxLength(255)
                .HasColumnName("TenHD");
        });

        modelBuilder.Entity<DmQuanCuTru>(entity =>
        {
            entity.ToTable("DM_QuanCuTru");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Idtinh).HasColumnName("IDTinh");
            entity.Property(e => e.MaQuan).HasMaxLength(50);
            entity.Property(e => e.TenQuan).HasMaxLength(500);

            entity.HasOne(d => d.IdtinhNavigation).WithMany(p => p.DmQuanCuTrus)
                .HasForeignKey(d => d.Idtinh)
                .HasConstraintName("FK_DM_QuanCuTru_DM_TinhCuTru");
        });

        modelBuilder.Entity<DmQuocGium>(entity =>
        {
            entity.ToTable("DM_QuocGia");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.MaQuocGia).HasMaxLength(50);
            entity.Property(e => e.TenQuocGia).HasMaxLength(500);
        });

        modelBuilder.Entity<DmRang>(entity =>
        {
            entity.ToTable("DM_Rang");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Ten).HasMaxLength(50);
        });

        modelBuilder.Entity<DmRangCt>(entity =>
        {
            entity.ToTable("DM_Rang_CT");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Anh).HasMaxLength(300);
            entity.Property(e => e.GhiChu).HasMaxLength(500);
            entity.Property(e => e.IdhienTrangRang).HasColumnName("IDHienTrangRang");
            entity.Property(e => e.Idrang).HasColumnName("IDRang");
            entity.Property(e => e.IdvaoVien).HasColumnName("IDVaoVien");
            entity.Property(e => e.MoTaKhac).HasMaxLength(500);
            entity.Property(e => e.NiengRang).HasMaxLength(50);

            entity.HasOne(d => d.IdhienTrangRangNavigation).WithMany(p => p.DmRangCts)
                .HasForeignKey(d => d.IdhienTrangRang)
                .HasConstraintName("FK_DM_Rang_CT_DM_HienTrangRang");

            entity.HasOne(d => d.IdrangNavigation).WithMany(p => p.DmRangCts)
                .HasForeignKey(d => d.Idrang)
                .HasConstraintName("FK_DM_Rang_CT_DM_Rang");

            entity.HasOne(d => d.IdvaoVienNavigation).WithMany(p => p.DmRangCts)
                .HasForeignKey(d => d.IdvaoVien)
                .HasConstraintName("FK_DM_Rang_CT_QL_VaoVien");
        });

        modelBuilder.Entity<DmSinhVien>(entity =>
        {
            entity.ToTable("DM_SinhVien");

            entity.HasIndex(e => e.TaiKhoan, "UQ_SinhVien_TaiKhoan")
                .IsUnique()
                .HasFilter("([TaiKhoan] IS NOT NULL)");

            entity.HasIndex(e => e.MaSinhVien, "UQ__DM_SinhV__939AE7740F3688E6").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DiaChi).HasMaxLength(500);
            entity.Property(e => e.DienThoai).HasMaxLength(50);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.IdgioiTinh).HasColumnName("IDGioiTinh");
            entity.Property(e => e.Idlop).HasColumnName("IDLop");
            entity.Property(e => e.MaSinhVien).HasMaxLength(50);
            entity.Property(e => e.MatKhau).HasMaxLength(50);
            entity.Property(e => e.TaiKhoan).HasMaxLength(50);
            entity.Property(e => e.TenSinhVien).HasMaxLength(200);

            entity.HasOne(d => d.IdgioiTinhNavigation).WithMany(p => p.DmSinhViens)
                .HasForeignKey(d => d.IdgioiTinh)
                .HasConstraintName("FK_SinhVien_GioiTinh");

            entity.HasOne(d => d.IdlopNavigation).WithMany(p => p.DmSinhViens)
                .HasForeignKey(d => d.Idlop)
                .HasConstraintName("FK_SinhVien_LopHoc");
        });

        modelBuilder.Entity<DmTemplate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__DM_Templ__3214EC07A6DDBDC3");

            entity.ToTable("DM_Template");
        });

        modelBuilder.Entity<DmThoiGian>(entity =>
        {
            entity.ToTable("DM_ThoiGian");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.TenThoiGian).HasMaxLength(500);
        });

        modelBuilder.Entity<DmThoiGianHen>(entity =>
        {
            entity.ToTable("DM_ThoiGian_Hen");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.HasOne(d => d.IdCaNavigation).WithMany(p => p.DmThoiGianHens)
                .HasForeignKey(d => d.IdCa)
                .HasConstraintName("fk_TGH_CA");
        });

        modelBuilder.Entity<DmTiLeHoaHong>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DM_TiLeHoaHongBacSi");

            entity.ToTable("DM_TiLeHoaHong");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdCn).HasColumnName("IdCN");
            entity.Property(e => e.Iddvkt).HasColumnName("IDDVKT");
            entity.Property(e => e.IdnhanVien).HasColumnName("IDNhanVien");

            entity.HasOne(d => d.IdCnNavigation).WithMany(p => p.DmTiLeHoaHongs)
                .HasForeignKey(d => d.IdCn)
                .HasConstraintName("fk_TiLeHoaHong_ChiNhanh");

            entity.HasOne(d => d.IddvktNavigation).WithMany(p => p.DmTiLeHoaHongs)
                .HasForeignKey(d => d.Iddvkt)
                .HasConstraintName("FK_DM_TiLeHoaHong_DM_DichVuKyThuat");

            entity.HasOne(d => d.IdnhanVienNavigation).WithMany(p => p.DmTiLeHoaHongs)
                .HasForeignKey(d => d.IdnhanVien)
                .HasConstraintName("FK_DM_TiLeHoaHong_DM_NhanVien");
        });

        modelBuilder.Entity<DmTiLeLuong>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DM_TiLeLuongBacSi");

            entity.ToTable("DM_TiLeLuong");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdCn).HasColumnName("IdCN");
            entity.Property(e => e.IdnhanVien).HasColumnName("IDNhanVien");
            entity.Property(e => e.IdnhomDvkt).HasColumnName("IDNhomDVKT");

            entity.HasOne(d => d.IdCnNavigation).WithMany(p => p.DmTiLeLuongs)
                .HasForeignKey(d => d.IdCn)
                .HasConstraintName("fk_TiLeLuong_ChiNhanh");

            entity.HasOne(d => d.IdnhanVienNavigation).WithMany(p => p.DmTiLeLuongs)
                .HasForeignKey(d => d.IdnhanVien)
                .HasConstraintName("FK_DM_TiLeLuong_DM_NhanVien");

            entity.HasOne(d => d.IdnhomDvktNavigation).WithMany(p => p.DmTiLeLuongs)
                .HasForeignKey(d => d.IdnhomDvkt)
                .HasConstraintName("FK_TLL_NhomDVKT");
        });

        modelBuilder.Entity<DmTinhCach>(entity =>
        {
            entity.ToTable("DM_TinhCach");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.TinhCach).HasMaxLength(500);
        });

        modelBuilder.Entity<DmTinhCuTru>(entity =>
        {
            entity.ToTable("DM_TinhCuTru");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Cq2c).HasColumnName("CQ2C");
            entity.Property(e => e.MaTinh).HasMaxLength(50);
            entity.Property(e => e.TenTinh).HasMaxLength(500);
        });

        modelBuilder.Entity<DmTinhTrang>(entity =>
        {
            entity.ToTable("DM_TinhTrang");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Ma).HasMaxLength(50);
            entity.Property(e => e.Ten).HasMaxLength(255);
        });

        modelBuilder.Entity<DmTinhXaDoiChieu>(entity =>
        {
            entity.ToTable("DM_TinhXaDoiChieu");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.MaTinhMoi).HasMaxLength(50);
            entity.Property(e => e.MaXaCu).HasMaxLength(50);
            entity.Property(e => e.MaXaMoi).HasMaxLength(50);
        });

        modelBuilder.Entity<DmVaiTro>(entity =>
        {
            entity.ToTable("DM_VaiTro");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.MaVaiTro).HasMaxLength(50);
            entity.Property(e => e.TenVaiTro).HasMaxLength(200);
        });

        modelBuilder.Entity<DmXaCuTru>(entity =>
        {
            entity.ToTable("DM_XaCuTru");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Cq2c).HasColumnName("CQ2C");
            entity.Property(e => e.Idquan).HasColumnName("IDQuan");
            entity.Property(e => e.Idtinh).HasColumnName("IDTinh");
            entity.Property(e => e.MaXa).HasMaxLength(50);
            entity.Property(e => e.TenXa).HasMaxLength(500);

            entity.HasOne(d => d.IdquanNavigation).WithMany(p => p.DmXaCuTrus)
                .HasForeignKey(d => d.Idquan)
                .HasConstraintName("FK_DM_XaCuTru_DM_QuanCuTru");
        });

        modelBuilder.Entity<HhCachXuat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_CachXuat");

            entity.ToTable("HH_CachXuat");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.TheoHsd).HasColumnName("TheoHSD");
            entity.Property(e => e.TheoTgnhap).HasColumnName("TheoTGNhap");
        });

        modelBuilder.Entity<HhDmDonViTinh>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DonViTinh");

            entity.ToTable("HH_DM_DonViTinh");

            entity.HasIndex(e => e.MaDvt, "UQ__DonViTin__3D895AFF12F05779").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.MaDvt)
                .HasMaxLength(50)
                .HasColumnName("MaDVT");
            entity.Property(e => e.NgaySua).HasColumnType("datetime");
            entity.Property(e => e.NgayTao).HasColumnType("datetime");
            entity.Property(e => e.Nvsua).HasColumnName("NVSua");
            entity.Property(e => e.Nvtao).HasColumnName("NVTao");
            entity.Property(e => e.TenDvt)
                .HasMaxLength(500)
                .HasColumnName("TenDVT");
        });

        modelBuilder.Entity<HhDmHangHoa>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_HangHoa");

            entity.ToTable("HH_DM_HangHoa");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Avatar).HasMaxLength(250);
            entity.Property(e => e.GhiChu).HasMaxLength(1000);
            entity.Property(e => e.HoatChat).HasMaxLength(500);
            entity.Property(e => e.Iddvtchinh).HasColumnName("IDDVTChinh");
            entity.Property(e => e.Idhsx).HasColumnName("IDHSX");
            entity.Property(e => e.Idnhh).HasColumnName("IDNHH");
            entity.Property(e => e.Idnsx).HasColumnName("IDNSX");
            entity.Property(e => e.MaHh)
                .HasMaxLength(50)
                .HasColumnName("MaHH");
            entity.Property(e => e.NgaySua).HasColumnType("datetime");
            entity.Property(e => e.NgayTao).HasColumnType("datetime");
            entity.Property(e => e.Nvsua).HasColumnName("NVSua");
            entity.Property(e => e.Nvtao).HasColumnName("NVTao");
            entity.Property(e => e.TenHh)
                .HasMaxLength(500)
                .HasColumnName("TenHH");

            entity.HasOne(d => d.IdDuongDungNavigation).WithMany(p => p.HhDmHangHoas)
                .HasForeignKey(d => d.IdDuongDung)
                .HasConstraintName("FK_HH_DM_HangHoa_DM_DuongDung");

            entity.HasOne(d => d.IddvtchinhNavigation).WithMany(p => p.HhDmHangHoas)
                .HasForeignKey(d => d.Iddvtchinh)
                .HasConstraintName("FK__HH_DM_Han__IDDVT__4C364F0E");

            entity.HasOne(d => d.IdhsxNavigation).WithMany(p => p.HhDmHangHoas)
                .HasForeignKey(d => d.Idhsx)
                .HasConstraintName("FK__HH_DM_Han__IDHSX__4A4E069C");

            entity.HasOne(d => d.IdnhhNavigation).WithMany(p => p.HhDmHangHoas)
                .HasForeignKey(d => d.Idnhh)
                .HasConstraintName("FK__HH_DM_Han__IDNHH__4959E263");

            entity.HasOne(d => d.IdnsxNavigation).WithMany(p => p.HhDmHangHoas)
                .HasForeignKey(d => d.Idnsx)
                .HasConstraintName("FK__HH_DM_Han__IDNSX__4B422AD5");
        });

        modelBuilder.Entity<HhDmHangHoaNcc>(entity =>
        {
            entity.ToTable("HH_DM_HangHoa_NCC");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Idhh).HasColumnName("IDHH");
            entity.Property(e => e.Idncc).HasColumnName("IDNCC");

            entity.HasOne(d => d.IdhhNavigation).WithMany(p => p.HhDmHangHoaNccs)
                .HasForeignKey(d => d.Idhh)
                .HasConstraintName("fk_NCC_HH_HH");

            entity.HasOne(d => d.IdnccNavigation).WithMany(p => p.HhDmHangHoaNccs)
                .HasForeignKey(d => d.Idncc)
                .HasConstraintName("fk_NCC_HH_NCC");
        });

        modelBuilder.Entity<HhDmHangSanXuat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_HangSanXuat");

            entity.ToTable("HH_DM_HangSanXuat");

            entity.HasIndex(e => e.MaHsx, "UQ__HH_DM_Ha__3C90113D8B6C25FD").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.MaHsx)
                .HasMaxLength(50)
                .HasColumnName("MaHSX");
            entity.Property(e => e.NgaySua).HasColumnType("datetime");
            entity.Property(e => e.NgayTao).HasColumnType("datetime");
            entity.Property(e => e.Nvsua).HasColumnName("NVSua");
            entity.Property(e => e.Nvtao).HasColumnName("NVTao");
            entity.Property(e => e.TenHsx)
                .HasMaxLength(500)
                .HasColumnName("TenHSX");
        });

        modelBuilder.Entity<HhDmNganHang>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_NganHang");

            entity.ToTable("HH_DM_NganHang");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Bin)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("BIN");
            entity.Property(e => e.MaNganHang).HasMaxLength(50);
            entity.Property(e => e.NgaySua).HasColumnType("datetime");
            entity.Property(e => e.NgayTao).HasColumnType("datetime");
            entity.Property(e => e.Nvsua).HasColumnName("NVSua");
            entity.Property(e => e.Nvtao).HasColumnName("NVTao");
            entity.Property(e => e.TenNgan).HasMaxLength(50);
            entity.Property(e => e.TenNganHang).HasMaxLength(200);
        });

        modelBuilder.Entity<HhDmNganKe>(entity =>
        {
            entity.ToTable("HH_DM_NganKe");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.NganKe).HasMaxLength(50);
        });

        modelBuilder.Entity<HhDmNguonNhapXuat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_HH_DanhMucNguonNhapXuat");

            entity.ToTable("HH_DM_NguonNhapXuat");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.MaNguon).HasMaxLength(50);
            entity.Property(e => e.TenNguon).HasMaxLength(500);
        });

        modelBuilder.Entity<HhDmNhaCungCap>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_NhaCungCap");

            entity.ToTable("HH_DM_NhaCungCap");

            entity.HasIndex(e => e.MaNcc, "UQ__NhaCungC__3A185DEA397DBD88").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ChuTaiKhoan).HasMaxLength(500);
            entity.Property(e => e.DiaChi).HasMaxLength(500);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.GhiChu).HasMaxLength(500);
            entity.Property(e => e.IdnganHang).HasColumnName("IDNganHang");
            entity.Property(e => e.MaNcc)
                .HasMaxLength(50)
                .HasColumnName("MaNCC");
            entity.Property(e => e.NgaySua).HasColumnType("datetime");
            entity.Property(e => e.NgayTao).HasColumnType("datetime");
            entity.Property(e => e.Nvsua).HasColumnName("NVSua");
            entity.Property(e => e.Nvtao).HasColumnName("NVTao");
            entity.Property(e => e.Sdt)
                .HasMaxLength(50)
                .HasColumnName("SDT");
            entity.Property(e => e.SoTk)
                .HasMaxLength(50)
                .HasColumnName("SoTK");
            entity.Property(e => e.TenNcc)
                .HasMaxLength(500)
                .HasColumnName("TenNCC");

            entity.HasOne(d => d.IdnganHangNavigation).WithMany(p => p.HhDmNhaCungCaps)
                .HasForeignKey(d => d.IdnganHang)
                .HasConstraintName("FK__HH_DM_Nha__IDNga__5006DFF2");
        });

        modelBuilder.Entity<HhDmNhomHangHoa>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_NhomHangHoa");

            entity.ToTable("HH_DM_NhomHangHoa");

            entity.HasIndex(e => e.MaNhh, "UQ__HH_DM_Nh__3A1BF20FE0143905").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Ccdc).HasColumnName("CCDC");
            entity.Property(e => e.HhdemDuoc).HasColumnName("HHDemDuoc");
            entity.Property(e => e.HhkhongDemDuoc).HasColumnName("HHKhongDemDuoc");
            entity.Property(e => e.IdnhomDvkt).HasColumnName("IDNhomDVKT");
            entity.Property(e => e.MaNhh)
                .HasMaxLength(50)
                .HasColumnName("MaNHH");
            entity.Property(e => e.NgaySua).HasColumnType("datetime");
            entity.Property(e => e.NgayTao).HasColumnType("datetime");
            entity.Property(e => e.Nvsua).HasColumnName("NVSua");
            entity.Property(e => e.Nvtao).HasColumnName("NVTao");
            entity.Property(e => e.TenNhh)
                .HasMaxLength(500)
                .HasColumnName("TenNHH");
            entity.Property(e => e.TscoDinh).HasColumnName("TSCoDinh");
            entity.Property(e => e.Vpp).HasColumnName("VPP");
        });

        modelBuilder.Entity<HhDmNoiSuDung>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_HH_DmNoiSuDung");

            entity.ToTable("HH_DM_NoiSuDung");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.TenNoiSuDung).HasMaxLength(500);
        });

        modelBuilder.Entity<HhDmNuocSanXuat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_NuocSanXuat");

            entity.ToTable("HH_DM_NuocSanXuat");

            entity.HasIndex(e => e.MaNsx, "UQ__HH_DM_Nu__3A1BDBD3880A6395").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.MaNsx)
                .HasMaxLength(50)
                .HasColumnName("MaNSX");
            entity.Property(e => e.NgaySua).HasColumnType("datetime");
            entity.Property(e => e.NgayTao).HasColumnType("datetime");
            entity.Property(e => e.Nvsua).HasColumnName("NVSua");
            entity.Property(e => e.Nvtao).HasColumnName("NVTao");
            entity.Property(e => e.TenNsx)
                .HasMaxLength(500)
                .HasColumnName("TenNSX");
        });

        modelBuilder.Entity<HhHangTonKho>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_HangTonKho");

            entity.ToTable("HH_HangTonKho");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Cktm).HasColumnName("CKTM");
            entity.Property(e => e.GhiChu).HasMaxLength(500);
            entity.Property(e => e.Hsd)
                .HasColumnType("datetime")
                .HasColumnName("HSD");
            entity.Property(e => e.Idcn).HasColumnName("IDCN");
            entity.Property(e => e.Idcnxuat).HasColumnName("IDCNXuat");
            entity.Property(e => e.Idctpn).HasColumnName("IDCTPN");
            entity.Property(e => e.Iddvtnhap).HasColumnName("IDDVTNhap");
            entity.Property(e => e.Iddvtton).HasColumnName("IDDVTTon");
            entity.Property(e => e.Idhh).HasColumnName("IDHH");
            entity.Property(e => e.Idncc).HasColumnName("IDNCC");
            entity.Property(e => e.Idpn).HasColumnName("IDPN");
            entity.Property(e => e.NgayNhap).HasColumnType("datetime");
            entity.Property(e => e.Nsx).HasColumnName("NSX");
            entity.Property(e => e.Slcon).HasColumnName("SLCon");
            entity.Property(e => e.SoLo).HasMaxLength(50);

            entity.HasOne(d => d.IdctpnNavigation).WithMany(p => p.HhHangTonKhos)
                .HasForeignKey(d => d.Idctpn)
                .HasConstraintName("FK__HH_HangTo__IDCTP__50FB042B");

            entity.HasOne(d => d.IdhhNavigation).WithMany(p => p.HhHangTonKhos)
                .HasForeignKey(d => d.Idhh)
                .HasConstraintName("FK__HH_HangTon__IDHH__51EF2864");
        });

        modelBuilder.Entity<HhPhieuNhapCcdc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_HH_PhieuNhapKho");

            entity.ToTable("HH_PhieuNhapCCDC");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.GhiChuPhieuNhap).HasMaxLength(1000);
            entity.Property(e => e.Idcn).HasColumnName("IDCN");
            entity.Property(e => e.IdnhaCungCap).HasColumnName("IDNhaCungCap");
            entity.Property(e => e.IdnhanVienNhap).HasColumnName("IDNhanVienNhap");
            entity.Property(e => e.IdnhanVienSua).HasColumnName("IDNhanVienSua");
            entity.Property(e => e.KyHieuHoaDon).HasMaxLength(50);
            entity.Property(e => e.NgayGioNhap).HasColumnType("datetime");
            entity.Property(e => e.SoHoaDon).HasMaxLength(50);
            entity.Property(e => e.SoPhieuNhap).HasMaxLength(50);

            entity.HasOne(d => d.IdcnNavigation).WithMany(p => p.HhPhieuNhapCcdcs)
                .HasForeignKey(d => d.Idcn)
                .HasConstraintName("FK_PNCCDC_IDCN");

            entity.HasOne(d => d.IdnhaCungCapNavigation).WithMany(p => p.HhPhieuNhapCcdcs)
                .HasForeignKey(d => d.IdnhaCungCap)
                .HasConstraintName("FK_PN_NCC");

            entity.HasOne(d => d.IdnhanVienNhapNavigation).WithMany(p => p.HhPhieuNhapCcdcIdnhanVienNhapNavigations)
                .HasForeignKey(d => d.IdnhanVienNhap)
                .HasConstraintName("FK_PN_NVN");

            entity.HasOne(d => d.IdnhanVienSuaNavigation).WithMany(p => p.HhPhieuNhapCcdcIdnhanVienSuaNavigations)
                .HasForeignKey(d => d.IdnhanVienSua)
                .HasConstraintName("FK_PN_NVS");
        });

        modelBuilder.Entity<HhPhieuNhapCcdcCt>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_HH_PhieuNhapKhoCT");

            entity.ToTable("HH_PhieuNhapCCDC_CT");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.GhiChuHangNhap).HasMaxLength(500);
            entity.Property(e => e.IddonViTinhNhap).HasColumnName("IDDonViTinhNhap");
            entity.Property(e => e.IdhangHoa).HasColumnName("IDHangHoa");
            entity.Property(e => e.IdphieuNhapKho).HasColumnName("IDPhieuNhapKho");
            entity.Property(e => e.SldaXuat).HasColumnName("SLDaXuat");
            entity.Property(e => e.SoLo).HasMaxLength(50);
            entity.Property(e => e.ThueVat).HasColumnName("ThueVAT");

            entity.HasOne(d => d.IddonViTinhNhapNavigation).WithMany(p => p.HhPhieuNhapCcdcCts)
                .HasForeignKey(d => d.IddonViTinhNhap)
                .HasConstraintName("FK_PNCCDCCT_DVTN");

            entity.HasOne(d => d.IdhangHoaNavigation).WithMany(p => p.HhPhieuNhapCcdcCts)
                .HasForeignKey(d => d.IdhangHoa)
                .HasConstraintName("FK_PNCCDCCT_HH");

            entity.HasOne(d => d.IdphieuNhapKhoNavigation).WithMany(p => p.HhPhieuNhapCcdcCts)
                .HasForeignKey(d => d.IdphieuNhapKho)
                .HasConstraintName("FK_PNCCDCCT_PN");
        });

        modelBuilder.Entity<HhPhieuNhapCt>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ChiTietPhieuNhap");

            entity.ToTable("HH_PhieuNhapCT");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Cktm).HasColumnName("CKTM");
            entity.Property(e => e.GhiChu).HasMaxLength(2000);
            entity.Property(e => e.Hsd)
                .HasColumnType("datetime")
                .HasColumnName("HSD");
            entity.Property(e => e.Iddvtnhap).HasColumnName("IDDVTNhap");
            entity.Property(e => e.Idhh).HasColumnName("IDHH");
            entity.Property(e => e.Idpn).HasColumnName("IDPN");
            entity.Property(e => e.NgaySua).HasColumnType("datetime");
            entity.Property(e => e.NgayTao).HasColumnType("datetime");
            entity.Property(e => e.Nsx)
                .HasColumnType("datetime")
                .HasColumnName("NSX");
            entity.Property(e => e.Nvsua).HasColumnName("NVSua");
            entity.Property(e => e.Nvtao).HasColumnName("NVTao");
            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.Slqd).HasColumnName("SLQD");
            entity.Property(e => e.SoLo).HasMaxLength(50);

            entity.HasOne(d => d.IddvtnhapNavigation).WithMany(p => p.HhPhieuNhapCts)
                .HasForeignKey(d => d.Iddvtnhap)
                .HasConstraintName("FK__HH_PhieuN__IDDVT__54CB950F");

            entity.HasOne(d => d.IdhhNavigation).WithMany(p => p.HhPhieuNhapCts)
                .HasForeignKey(d => d.Idhh)
                .HasConstraintName("FK__HH_PhieuNh__IDHH__53D770D6");

            entity.HasOne(d => d.IdpnNavigation).WithMany(p => p.HhPhieuNhapCts)
                .HasForeignKey(d => d.Idpn)
                .HasConstraintName("FK__HH_PhieuNh__IDPN__52E34C9D");
        });

        modelBuilder.Entity<HhPhieuNhapKho>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_PhieuNhapKho");

            entity.ToTable("HH_PhieuNhapKho");

            entity.HasIndex(e => e.SoPn, "UQ__PhieuNha__BC3C6A726F8BFF7E").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.GhiChu).HasMaxLength(2000);
            entity.Property(e => e.Idcn).HasColumnName("IDCN");
            entity.Property(e => e.Idcnxuat).HasColumnName("IDCNXuat");
            entity.Property(e => e.Idncc).HasColumnName("IDNCC");
            entity.Property(e => e.IdnguonNhapXuat).HasColumnName("IDNguonNhapXuat");
            entity.Property(e => e.IdnoiSuDung).HasColumnName("IDNoiSuDung");
            entity.Property(e => e.Idnv).HasColumnName("IDNV");
            entity.Property(e => e.IdphieuXuatNoi).HasColumnName("IDPhieuXuatNoi");
            entity.Property(e => e.NgayHd).HasColumnName("NgayHD");
            entity.Property(e => e.NgaySua).HasColumnType("datetime");
            entity.Property(e => e.NgayTao).HasColumnType("datetime");
            entity.Property(e => e.Nvsua).HasColumnName("NVSua");
            entity.Property(e => e.SoHd)
                .HasMaxLength(50)
                .HasColumnName("SoHD");
            entity.Property(e => e.SoPn)
                .HasMaxLength(50)
                .HasColumnName("SoPN");

            entity.HasOne(d => d.IdcnNavigation).WithMany(p => p.HhPhieuNhapKhoIdcnNavigations)
                .HasForeignKey(d => d.Idcn)
                .HasConstraintName("FK__HH_PhieuNh__IDCN__589C25F3");

            entity.HasOne(d => d.IdcnxuatNavigation).WithMany(p => p.HhPhieuNhapKhoIdcnxuatNavigations)
                .HasForeignKey(d => d.Idcnxuat)
                .HasConstraintName("FK__HH_PhieuN__IDCNX__56B3DD81");

            entity.HasOne(d => d.IdnccNavigation).WithMany(p => p.HhPhieuNhapKhos)
                .HasForeignKey(d => d.Idncc)
                .HasConstraintName("FK__HH_PhieuN__IDNCC__57A801BA");

            entity.HasOne(d => d.IdnguonNhapXuatNavigation).WithMany(p => p.HhPhieuNhapKhos)
                .HasForeignKey(d => d.IdnguonNhapXuat)
                .HasConstraintName("FK__HH_PhieuN__IDNgu__5E54FF49");

            entity.HasOne(d => d.IdnoiSuDungNavigation).WithMany(p => p.HhPhieuNhapKhos)
                .HasForeignKey(d => d.IdnoiSuDung)
                .HasConstraintName("FK__HH_PhieuN__IDNoi__5F492382");

            entity.HasOne(d => d.IdnvNavigation).WithMany(p => p.HhPhieuNhapKhos)
                .HasForeignKey(d => d.Idnv)
                .HasConstraintName("FK__HH_PhieuNh__IDNV__59904A2C");

            entity.HasOne(d => d.IdphieuXuatNoiNavigation).WithMany(p => p.HhPhieuNhapKhos)
                .HasForeignKey(d => d.IdphieuXuatNoi)
                .HasConstraintName("FK__HH_PhieuN__IDPhi__55BFB948");
        });

        modelBuilder.Entity<HhPhieuXuatCt>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ChiTietPhieuXuat");

            entity.ToTable("HH_PhieuXuatCT");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Cktm).HasColumnName("CKTM");
            entity.Property(e => e.GhiChu).HasMaxLength(1000);
            entity.Property(e => e.Idctpn).HasColumnName("IDCTPN");
            entity.Property(e => e.Iddvt).HasColumnName("IDDVT");
            entity.Property(e => e.Idhh).HasColumnName("IDHH");
            entity.Property(e => e.Idkhdtct).HasColumnName("IDKHDTCT");
            entity.Property(e => e.IdnoiSuDung).HasColumnName("IDNoiSuDung");
            entity.Property(e => e.IdphieuDeNghiCt).HasColumnName("IDPhieuDeNghiCT");
            entity.Property(e => e.Idpx).HasColumnName("IDPX");
            entity.Property(e => e.NgayTao).HasColumnType("datetime");
            entity.Property(e => e.Nvtao).HasColumnName("NVTao");
            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.Slqd).HasColumnName("SLQD");

            entity.HasOne(d => d.IdctpnNavigation).WithMany(p => p.HhPhieuXuatCts)
                .HasForeignKey(d => d.Idctpn)
                .HasConstraintName("FK__HH_PhieuX__IDCTP__6319B466");

            entity.HasOne(d => d.IddvtNavigation).WithMany(p => p.HhPhieuXuatCts)
                .HasForeignKey(d => d.Iddvt)
                .HasConstraintName("FK__HH_PhieuX__IDDVT__6225902D");

            entity.HasOne(d => d.IdhhNavigation).WithMany(p => p.HhPhieuXuatCts)
                .HasForeignKey(d => d.Idhh)
                .HasConstraintName("FK__HH_PhieuXu__IDHH__61316BF4");

            entity.HasOne(d => d.IdkhdtctNavigation).WithMany(p => p.HhPhieuXuatCts)
                .HasForeignKey(d => d.Idkhdtct)
                .HasConstraintName("fk_PhieuXuatCT_KHDTCT");

            entity.HasOne(d => d.IdnoiSuDungNavigation).WithMany(p => p.HhPhieuXuatCts)
                .HasForeignKey(d => d.IdnoiSuDung)
                .HasConstraintName("FK_HH_PhieuXuatCT_HH_DM_NoiSuDung");

            entity.HasOne(d => d.IdphieuDeNghiCtNavigation).WithMany(p => p.HhPhieuXuatCts)
                .HasForeignKey(d => d.IdphieuDeNghiCt)
                .HasConstraintName("fk_PhieuXuatCT_PhieuDeNghiCT");

            entity.HasOne(d => d.IdpxNavigation).WithMany(p => p.HhPhieuXuatCts)
                .HasForeignKey(d => d.Idpx)
                .HasConstraintName("FK__HH_PhieuXu__IDPX__603D47BB");
        });

        modelBuilder.Entity<HhPhieuXuatKho>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_PhieuXuat");

            entity.ToTable("HH_PhieuXuatKho");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.GhiChu).HasMaxLength(2000);
            entity.Property(e => e.Idbn).HasColumnName("IDBN");
            entity.Property(e => e.Idcn).HasColumnName("IDCN");
            entity.Property(e => e.Idcnnhan).HasColumnName("IDCNNhan");
            entity.Property(e => e.Idkip).HasColumnName("IDKip");
            entity.Property(e => e.IdnguonNhapXuat).HasColumnName("IDNguonNhapXuat");
            entity.Property(e => e.IdnoiSuDung).HasColumnName("IDNoiSuDung");
            entity.Property(e => e.Idnv).HasColumnName("IDNV");
            entity.Property(e => e.Idnvnhan).HasColumnName("IDNVNhan");
            entity.Property(e => e.Idnvtao).HasColumnName("IDNVTao");
            entity.Property(e => e.IdphieuDeNghi).HasColumnName("IDPhieuDeNghi");
            entity.Property(e => e.IdvaoVien).HasColumnName("IDVaoVien");
            entity.Property(e => e.NgayHd)
                .HasColumnType("datetime")
                .HasColumnName("NgayHD");
            entity.Property(e => e.NgayNhan).HasColumnType("datetime");
            entity.Property(e => e.NgayTao).HasColumnType("datetime");
            entity.Property(e => e.SoHd)
                .HasMaxLength(50)
                .HasColumnName("SoHD");
            entity.Property(e => e.SoPx)
                .HasMaxLength(50)
                .HasColumnName("SoPX");

            entity.HasOne(d => d.IdToaThuocNavigation).WithMany(p => p.HhPhieuXuatKhos)
                .HasForeignKey(d => d.IdToaThuoc)
                .HasConstraintName("FK_HH_PhieuXuatKho_QL_ToaThuoc");

            entity.HasOne(d => d.IdbnNavigation).WithMany(p => p.HhPhieuXuatKhos)
                .HasForeignKey(d => d.Idbn)
                .HasConstraintName("FK_HH_PhieuXuatKho_DM_BenhNhan");

            entity.HasOne(d => d.IdcnNavigation).WithMany(p => p.HhPhieuXuatKhoIdcnNavigations)
                .HasForeignKey(d => d.Idcn)
                .HasConstraintName("FK__HH_PhieuXu__IDCN__65F62111");

            entity.HasOne(d => d.IdcnnhanNavigation).WithMany(p => p.HhPhieuXuatKhoIdcnnhanNavigations)
                .HasForeignKey(d => d.Idcnnhan)
                .HasConstraintName("FK__HH_PhieuX__IDCNN__640DD89F");

            entity.HasOne(d => d.IdkipNavigation).WithMany(p => p.HhPhieuXuatKhos)
                .HasForeignKey(d => d.Idkip)
                .HasConstraintName("FK_PXK_Kip");

            entity.HasOne(d => d.IdnguonNhapXuatNavigation).WithMany(p => p.HhPhieuXuatKhos)
                .HasForeignKey(d => d.IdnguonNhapXuat)
                .HasConstraintName("FK__HH_PhieuX__IDNgu__68D28DBC");

            entity.HasOne(d => d.IdnoiSuDungNavigation).WithMany(p => p.HhPhieuXuatKhos)
                .HasForeignKey(d => d.IdnoiSuDung)
                .HasConstraintName("FK__HH_PhieuX__IDNoi__69C6B1F5");

            entity.HasOne(d => d.IdnvNavigation).WithMany(p => p.HhPhieuXuatKhoIdnvNavigations)
                .HasForeignKey(d => d.Idnv)
                .HasConstraintName("FK__HH_PhieuXu__IDNV__66EA454A");

            entity.HasOne(d => d.IdnvnhanNavigation).WithMany(p => p.HhPhieuXuatKhoIdnvnhanNavigations)
                .HasForeignKey(d => d.Idnvnhan)
                .HasConstraintName("FK__HH_PhieuX__IDNVN__67DE6983");

            entity.HasOne(d => d.IdnvtaoNavigation).WithMany(p => p.HhPhieuXuatKhoIdnvtaoNavigations)
                .HasForeignKey(d => d.Idnvtao)
                .HasConstraintName("FK_HH_PhieuXuatKho_DM_NhanVien");

            entity.HasOne(d => d.IdphieuDeNghiNavigation).WithMany(p => p.HhPhieuXuatKhos)
                .HasForeignKey(d => d.IdphieuDeNghi)
                .HasConstraintName("fk_PhieuXuatCT_PhieuDeNghi");

            entity.HasOne(d => d.IdvaoVienNavigation).WithMany(p => p.HhPhieuXuatKhos)
                .HasForeignKey(d => d.IdvaoVien)
                .HasConstraintName("fk_PhieuXuatCT_QLVaoVien");
        });

        modelBuilder.Entity<HhPhieuXuatThanhLy>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_HH_PhieuXuatKho");

            entity.ToTable("HH_PhieuXuatThanhLy");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.GhiChuPhieuXuat).HasMaxLength(1000);
            entity.Property(e => e.IdlyDoXuat).HasColumnName("IDLyDoXuat");
            entity.Property(e => e.IdnhanVienXuat).HasColumnName("IDNhanVienXuat");
            entity.Property(e => e.NgayGioXuat).HasColumnType("datetime");
            entity.Property(e => e.SoPhieuXuat).HasMaxLength(50);

            entity.HasOne(d => d.IdlyDoXuatNavigation).WithMany(p => p.HhPhieuXuatThanhLies)
                .HasForeignKey(d => d.IdlyDoXuat)
                .HasConstraintName("FK_PXTL_LyDo");

            entity.HasOne(d => d.IdnhanVienXuatNavigation).WithMany(p => p.HhPhieuXuatThanhLies)
                .HasForeignKey(d => d.IdnhanVienXuat)
                .HasConstraintName("FK_PXTL_NVX");
        });

        modelBuilder.Entity<HhPhieuXuatThanhLyCt>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_HH_PhieuXuatKhoCT");

            entity.ToTable("HH_PhieuXuatThanhLy_CT");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.GhiChuHangXuat).HasMaxLength(500);
            entity.Property(e => e.IddonViXuat).HasColumnName("IDDonViXuat");
            entity.Property(e => e.IdhangHoa).HasColumnName("IDHangHoa");
            entity.Property(e => e.IdphieuNhapCt).HasColumnName("IDPhieuNhapCT");
            entity.Property(e => e.IdphieuXuatKho).HasColumnName("IDPhieuXuatKho");

            entity.HasOne(d => d.IddonViXuatNavigation).WithMany(p => p.HhPhieuXuatThanhLyCts)
                .HasForeignKey(d => d.IddonViXuat)
                .HasConstraintName("FK_PXTLCT_DVT");

            entity.HasOne(d => d.IdhangHoaNavigation).WithMany(p => p.HhPhieuXuatThanhLyCts)
                .HasForeignKey(d => d.IdhangHoa)
                .HasConstraintName("FK_PXTLCT_HH");

            entity.HasOne(d => d.IdphieuNhapCtNavigation).WithMany(p => p.HhPhieuXuatThanhLyCts)
                .HasForeignKey(d => d.IdphieuNhapCt)
                .HasConstraintName("FK_PXTLCT_PNCT");

            entity.HasOne(d => d.IdphieuXuatKhoNavigation).WithMany(p => p.HhPhieuXuatThanhLyCts)
                .HasForeignKey(d => d.IdphieuXuatKho)
                .HasConstraintName("FK_PXTLCT_PX");
        });

        modelBuilder.Entity<HhTiLeCanhBao>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_TiLeCanhBao");

            entity.ToTable("HH_TiLeCanhBao");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.TenTiLe).HasMaxLength(50);
        });

        modelBuilder.Entity<HhTinhGiaXuat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_TinhGiaXuat");

            entity.ToTable("HH_TinhGiaXuat");

            entity.HasIndex(e => e.MaCach, "UQ__TinhGiaX__20E4AE2D591A9E80").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.MaCach).HasMaxLength(50);
            entity.Property(e => e.TenCach).HasMaxLength(50);
        });

        modelBuilder.Entity<HtChucNang>(entity =>
        {
            entity.ToTable("HT_ChucNang");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdphanHe).HasColumnName("IDPhanHe");
            entity.Property(e => e.MaChucNang).HasMaxLength(50);
            entity.Property(e => e.PhanLoai).HasMaxLength(50);
            entity.Property(e => e.TenChucNang).HasMaxLength(200);

            entity.HasOne(d => d.IdphanHeNavigation).WithMany(p => p.HtChucNangs)
                .HasForeignKey(d => d.IdphanHe)
                .HasConstraintName("FK_HT_ChucNang_HT_ChucNang");
        });

        modelBuilder.Entity<HtConfig>(entity =>
        {
            entity.ToTable("HT_Config");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.GhiChu).HasMaxLength(700);
            entity.Property(e => e.MaChucNang).HasMaxLength(200);
            entity.Property(e => e.Ngay).HasColumnType("datetime");
        });

        modelBuilder.Entity<HtKhoaSo>(entity =>
        {
            entity.ToTable("HT_KhoaSo");

            entity.Property(e => e.Id).HasColumnName("ID");
        });

        modelBuilder.Entity<HtLichNghi>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__HT_LichN__3214EC07EFA78714");

            entity.ToTable("HT_LichNghi");

            entity.Property(e => e.IdNv).HasColumnName("IdNV");
            entity.Property(e => e.Ngay).HasColumnType("datetime");

            entity.HasOne(d => d.IdCaNavigation).WithMany(p => p.HtLichNghis)
                .HasForeignKey(d => d.IdCa)
                .HasConstraintName("fk_Ca_LichNghi");

            entity.HasOne(d => d.IdNvNavigation).WithMany(p => p.HtLichNghis)
                .HasForeignKey(d => d.IdNv)
                .HasConstraintName("fk_NV_LichNghi");
        });

        modelBuilder.Entity<HtLichNghiMoi>(entity =>
        {
            entity.ToTable("HT_LichNghiMoi");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdNv).HasColumnName("IdNV");
            entity.Property(e => e.Ngay).HasColumnType("datetime");

            entity.HasOne(d => d.IdThoiGianNavigation).WithMany(p => p.HtLichNghiMois)
                .HasForeignKey(d => d.IdThoiGian)
                .HasConstraintName("FK_LichNghi_TGHen");
        });

        modelBuilder.Entity<HtPhanHe>(entity =>
        {
            entity.ToTable("HT_PhanHe");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.SoThuTu).HasMaxLength(50);
            entity.Property(e => e.TenPhanHe).HasMaxLength(500);
        });

        modelBuilder.Entity<HtPhanQuyen>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_HT_PhanQuyen_1");

            entity.ToTable("HT_PhanQuyen");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Idcn).HasColumnName("IDCN");
            entity.Property(e => e.Idnv).HasColumnName("IDNV");
            entity.Property(e => e.IdsinhVien).HasColumnName("IDSinhVien");
            entity.Property(e => e.Idvt).HasColumnName("IDVT");

            entity.HasOne(d => d.IdcnNavigation).WithMany(p => p.HtPhanQuyens)
                .HasForeignKey(d => d.Idcn)
                .HasConstraintName("FK_HT_PhanQuyen_DM_ChiNhanh");

            entity.HasOne(d => d.IdnvNavigation).WithMany(p => p.HtPhanQuyens)
                .HasForeignKey(d => d.Idnv)
                .HasConstraintName("FK_HT_PhanQuyen_DM_NhanVien");

            entity.HasOne(d => d.IdsinhVienNavigation).WithMany(p => p.HtPhanQuyens)
                .HasForeignKey(d => d.IdsinhVien)
                .HasConstraintName("FK_PhanQuyen_SinhVien");

            entity.HasOne(d => d.IdvtNavigation).WithMany(p => p.HtPhanQuyens)
                .HasForeignKey(d => d.Idvt)
                .HasConstraintName("FK_HT_PhanQuyen_DM_VaiTro");
        });

        modelBuilder.Entity<HtQuanLyMa>(entity =>
        {
            entity.ToTable("HT_QuanLyMa");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Idcn).HasColumnName("IDCN");
            entity.Property(e => e.IdquyLuatMa).HasColumnName("IDQuyLuatMa");
            entity.Property(e => e.MaQuay).HasMaxLength(3);

            entity.HasOne(d => d.IdquyLuatMaNavigation).WithMany(p => p.HtQuanLyMas)
                .HasForeignKey(d => d.IdquyLuatMa)
                .HasConstraintName("FK__HT_QuanLy__IDQuy__27F8EE98");
        });

        modelBuilder.Entity<HtQuyLuatMa>(entity =>
        {
            entity.ToTable("HT_QuyLuatMa");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.KyTuDau).HasMaxLength(3);
            entity.Property(e => e.TenBang).HasMaxLength(50);
        });

        modelBuilder.Entity<HtQuyenVaiTro>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_HT_PhanQuyen");

            entity.ToTable("HT_QuyenVaiTro");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdchucNang).HasColumnName("IDChucNang");
            entity.Property(e => e.IdvaiTro).HasColumnName("IDVaiTro");

            entity.HasOne(d => d.IdchucNangNavigation).WithMany(p => p.HtQuyenVaiTros)
                .HasForeignKey(d => d.IdchucNang)
                .HasConstraintName("FK_HT_QuyenVaiTro_HT_ChucNang");

            entity.HasOne(d => d.IdvaiTroNavigation).WithMany(p => p.HtQuyenVaiTros)
                .HasForeignKey(d => d.IdvaiTro)
                .HasConstraintName("FK__HT_PhanQu__IDVai__7B5B524B");
        });

        modelBuilder.Entity<HtTaiKhoanDangNhap>(entity =>
        {
            entity.ToTable("HT_TaiKhoanDangNhap");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.MatKhau).HasMaxLength(50);
            entity.Property(e => e.TaiKhoan).HasMaxLength(50);
        });

        modelBuilder.Entity<HtTiLe>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_HT_TiLeTienLuong");

            entity.ToTable("HT_TiLe");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Ma).HasMaxLength(50);
            entity.Property(e => e.Ten).HasMaxLength(255);
        });

        modelBuilder.Entity<KsCauHoi>(entity =>
        {
            entity.ToTable("KS_CauHoi");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CauHoi).HasMaxLength(1000);
        });

        modelBuilder.Entity<KsCauHoiTraLoi>(entity =>
        {
            entity.ToTable("KS_CauHoi_TraLoi");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdcauHoi).HasColumnName("IDCauHoi");
            entity.Property(e => e.IdcauTraLoi).HasColumnName("IDCauTraLoi");

            entity.HasOne(d => d.IdcauHoiNavigation).WithMany(p => p.KsCauHoiTraLois)
                .HasForeignKey(d => d.IdcauHoi)
                .HasConstraintName("FK_KS_CauHoi_TraLoi_KS_CauHoi");

            entity.HasOne(d => d.IdcauTraLoiNavigation).WithMany(p => p.KsCauHoiTraLois)
                .HasForeignKey(d => d.IdcauTraLoi)
                .HasConstraintName("FK_KS_CauHoi_TraLoi_KS_CauTraLoi");
        });

        modelBuilder.Entity<KsCauTraLoi>(entity =>
        {
            entity.ToTable("KS_CauTraLoi");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CauTraLoi).HasMaxLength(1000);
        });

        modelBuilder.Entity<KsKetQuaK>(entity =>
        {
            entity.ToTable("KS_KetQuaKS");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CauTraLoi).HasMaxLength(1000);
            entity.Property(e => e.Idbn).HasColumnName("IDBN");
            entity.Property(e => e.IdcauHoi).HasColumnName("IDCauHoi");
            entity.Property(e => e.IdcauTraLoi).HasColumnName("IDCauTraLoi");
            entity.Property(e => e.Idvv).HasColumnName("IDVV");
            entity.Property(e => e.NgayKhaoSat).HasColumnType("datetime");
            entity.Property(e => e.Sdt)
                .HasMaxLength(50)
                .HasColumnName("SDT");
            entity.Property(e => e.TenBn)
                .HasMaxLength(500)
                .HasColumnName("TenBN");

            entity.HasOne(d => d.IdcauHoiNavigation).WithMany(p => p.KsKetQuaKs)
                .HasForeignKey(d => d.IdcauHoi)
                .HasConstraintName("FK_KS_KetQuaKS_KS_CauHoi");

            entity.HasOne(d => d.IdcauTraLoiNavigation).WithMany(p => p.KsKetQuaKs)
                .HasForeignKey(d => d.IdcauTraLoi)
                .HasConstraintName("FK_KS_KetQuaKS_KS_CauTraLoi");
        });

        modelBuilder.Entity<NhanVien>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("_NhanVien");

            entity.Property(e => e.GhiChú)
                .HasMaxLength(255)
                .HasColumnName("Ghi chú");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.MaNhanVien).HasMaxLength(255);
            entity.Property(e => e.NhomBsktv).HasColumnName("NhomBSKTV");
            entity.Property(e => e.NhomDuoc).HasMaxLength(255);
            entity.Property(e => e.NhomKeToan).HasMaxLength(255);
            entity.Property(e => e.NhomPhuTa).HasMaxLength(255);
            entity.Property(e => e.NhomTiepTan).HasMaxLength(255);
            entity.Property(e => e.TenNhanVien)
                .HasMaxLength(255)
                .HasColumnName("TenNhanVien ");
            entity.Property(e => e.Xoa).HasMaxLength(255);
        });

        modelBuilder.Entity<QlBenhAn>(entity =>
        {
            entity.ToTable("QL_BenhAn");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdbenhAn).HasColumnName("IDBenhAn");
            entity.Property(e => e.IdnganKe).HasColumnName("IDNganKe");
            entity.Property(e => e.IdvaoVien).HasColumnName("IDVaoVien");
            entity.Property(e => e.MaLuuTru).HasMaxLength(50);
            entity.Property(e => e.NgayLuuHoSo).HasColumnType("datetime");

            entity.HasOne(d => d.IdbenhAnNavigation).WithMany(p => p.QlBenhAns)
                .HasForeignKey(d => d.IdbenhAn)
                .HasConstraintName("FK__QL_BenhAn__IDBen__3BCBA872");

            entity.HasOne(d => d.IdnganKeNavigation).WithMany(p => p.QlBenhAns)
                .HasForeignKey(d => d.IdnganKe)
                .HasConstraintName("FK__QL_BenhAn__IDNga__3CBFCCAB");

            entity.HasOne(d => d.IdvaoVienNavigation).WithMany(p => p.QlBenhAns)
                .HasForeignKey(d => d.IdvaoVien)
                .HasConstraintName("FK__QL_BenhAn__IDVao__3AD78439");
        });

        modelBuilder.Entity<QlChanDoan>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__QL_ChanD__3214EC27454004D5");

            entity.ToTable("QL_ChanDoan");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdbacSiThucHien).HasColumnName("IDBacSiThucHien");
            entity.Property(e => e.IdbenhNhan).HasColumnName("IDBenhNhan");
            entity.Property(e => e.IdnhanVienThucHien).HasColumnName("IDNhanVienThucHien");
            entity.Property(e => e.IdvaoVien).HasColumnName("IDVaoVien");
            entity.Property(e => e.MaBenhBanDau).HasMaxLength(50);
            entity.Property(e => e.MaBenhChinh).HasMaxLength(50);
            entity.Property(e => e.MaBenhKhac).HasMaxLength(100);
            entity.Property(e => e.MaVaTenBenh).HasMaxLength(4000);
            entity.Property(e => e.MaVaTenBenhVao).HasMaxLength(3000);
            entity.Property(e => e.NgayCapNhat).HasColumnType("datetime");
            entity.Property(e => e.NgayTao).HasColumnType("datetime");
            entity.Property(e => e.SoPhieu).HasMaxLength(50);
            entity.Property(e => e.TenBenhBanDau).HasMaxLength(3000);
            entity.Property(e => e.TenBenhChinh).HasMaxLength(3000);
            entity.Property(e => e.TenBenhKhac).HasMaxLength(3000);
            entity.Property(e => e.TrieuChung).HasMaxLength(3000);

            entity.HasOne(d => d.IdbacSiThucHienNavigation).WithMany(p => p.QlChanDoanIdbacSiThucHienNavigations)
                .HasForeignKey(d => d.IdbacSiThucHien)
                .HasConstraintName("FK_QL_ChanDoan_DM_NhanVien");

            entity.HasOne(d => d.IdbenhNhanNavigation).WithMany(p => p.QlChanDoans)
                .HasForeignKey(d => d.IdbenhNhan)
                .HasConstraintName("FK_QL_ChanDoan_DM_BenhNhan");

            entity.HasOne(d => d.IdnhanVienThucHienNavigation).WithMany(p => p.QlChanDoanIdnhanVienThucHienNavigations)
                .HasForeignKey(d => d.IdnhanVienThucHien)
                .HasConstraintName("FK_QL_ChanDoan_DM_NhanVien1");

            entity.HasOne(d => d.IdvaoVienNavigation).WithMany(p => p.QlChanDoans)
                .HasForeignKey(d => d.IdvaoVien)
                .HasConstraintName("FK_QL_ChanDoan_QL_VaoVien");
        });

        modelBuilder.Entity<QlChanDoanCt>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__QL_ChanD__3214EC27BDC3D0C1");

            entity.ToTable("QL_ChanDoan_CT");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdchanDoan).HasColumnName("IDChanDoan");
            entity.Property(e => e.IdmaBenhIcd10).HasColumnName("IDMaBenhICD10");
            entity.Property(e => e.MaBenh).HasMaxLength(50);
            entity.Property(e => e.TenBenh).HasMaxLength(500);

            entity.HasOne(d => d.IdchanDoanNavigation).WithMany(p => p.QlChanDoanCts)
                .HasForeignKey(d => d.IdchanDoan)
                .HasConstraintName("FK_QL_ChanDoan_CT_QL_ChanDoan");

            entity.HasOne(d => d.IdmaBenhIcd10Navigation).WithMany(p => p.QlChanDoanCts)
                .HasForeignKey(d => d.IdmaBenhIcd10)
                .HasConstraintName("FK_QL_ChanDoan_CT_DM_ICD");
        });

        modelBuilder.Entity<QlChiDinh>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__QL_ChiDi__3214EC278B14AA15");

            entity.ToTable("QL_ChiDinh");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.GhiChu).HasMaxLength(1000);
            entity.Property(e => e.IdbacSi).HasColumnName("IDBacSi");
            entity.Property(e => e.Idcn).HasColumnName("IDCN");
            entity.Property(e => e.IddoiTac).HasColumnName("IDDoiTac");
            entity.Property(e => e.Iddvkt).HasColumnName("IDDVKT");
            entity.Property(e => e.IdvaoVien).HasColumnName("IDVaoVien");
            entity.Property(e => e.NgayGioChiDinh).HasColumnType("datetime");
            entity.Property(e => e.NgayGioKetQua).HasColumnType("datetime");
            entity.Property(e => e.SoPhieu).HasMaxLength(50);

            entity.HasOne(d => d.IdbacSiNavigation).WithMany(p => p.QlChiDinhs)
                .HasForeignKey(d => d.IdbacSi)
                .HasConstraintName("FK__QL_ChiDin__IDBac__184C96B4");

            entity.HasOne(d => d.IdcnNavigation).WithMany(p => p.QlChiDinhs)
                .HasForeignKey(d => d.Idcn)
                .HasConstraintName("FK__QL_ChiDinh__IDCN__15702A09");

            entity.HasOne(d => d.IddoiTacNavigation).WithMany(p => p.QlChiDinhs)
                .HasForeignKey(d => d.IddoiTac)
                .HasConstraintName("FK__QL_ChiDin__IDDoi__1940BAED");

            entity.HasOne(d => d.IddvktNavigation).WithMany(p => p.QlChiDinhs)
                .HasForeignKey(d => d.Iddvkt)
                .HasConstraintName("FK__QL_ChiDin__IDDVK__1758727B");

            entity.HasOne(d => d.IdvaoVienNavigation).WithMany(p => p.QlChiDinhs)
                .HasForeignKey(d => d.IdvaoVien)
                .HasConstraintName("FK__QL_ChiDin__IDVao__16644E42");
        });

        modelBuilder.Entity<QlDinhMucVatTuTieuHao>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__QL_DinhM__3214EC273A11C833");

            entity.ToTable("QL_DinhMucVatTuTieuHao");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Iddvkt).HasColumnName("IDDVKT");
            entity.Property(e => e.Idhh).HasColumnName("IDHH");

            entity.HasOne(d => d.IddvktNavigation).WithMany(p => p.QlDinhMucVatTuTieuHaos)
                .HasForeignKey(d => d.Iddvkt)
                .HasConstraintName("FK_DMVT_DVKT");

            entity.HasOne(d => d.IdhhNavigation).WithMany(p => p.QlDinhMucVatTuTieuHaos)
                .HasForeignKey(d => d.Idhh)
                .HasConstraintName("FK_DMVT_HH");
        });

        modelBuilder.Entity<QlHen>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__QL_Hen__3214EC276038A6B7");

            entity.ToTable("QL_Hen");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DiaChi).HasMaxLength(255);
            entity.Property(e => e.DienThoai).HasMaxLength(50);
            entity.Property(e => e.Idbn).HasColumnName("IDBN");
            entity.Property(e => e.Idbs).HasColumnName("IDBS");
            entity.Property(e => e.Idcn).HasColumnName("IDCN");
            entity.Property(e => e.IdlyDoHen).HasColumnName("IDLyDoHen");
            entity.Property(e => e.IdthoiGian).HasColumnName("IDThoiGian");
            entity.Property(e => e.IdvaoVien).HasColumnName("IDVaoVien");
            entity.Property(e => e.LyDoKhac).HasMaxLength(255);
            entity.Property(e => e.Ngay).HasColumnType("datetime");
            entity.Property(e => e.TenBn)
                .HasMaxLength(255)
                .HasColumnName("TenBN");

            entity.HasOne(d => d.IdbnNavigation).WithMany(p => p.QlHens)
                .HasForeignKey(d => d.Idbn)
                .HasConstraintName("FK_QL_Hen_DM_BenhNhan");

            entity.HasOne(d => d.IdbsNavigation).WithMany(p => p.QlHens)
                .HasForeignKey(d => d.Idbs)
                .HasConstraintName("FK__QL_Hen__IDBS__22CA2527");

            entity.HasOne(d => d.IdcnNavigation).WithMany(p => p.QlHens)
                .HasForeignKey(d => d.Idcn)
                .HasConstraintName("FK__QL_Hen__IDCN__20E1DCB5");

            entity.HasOne(d => d.IdlyDoHenNavigation).WithMany(p => p.QlHens)
                .HasForeignKey(d => d.IdlyDoHen)
                .HasConstraintName("FK__QL_Hen__IDLyDoHe__24B26D99");

            entity.HasOne(d => d.IdthoiGianNavigation).WithMany(p => p.QlHens)
                .HasForeignKey(d => d.IdthoiGian)
                .HasConstraintName("FK__QL_Hen__IDThoiGi__23BE4960");

            entity.HasOne(d => d.IdvaoVienNavigation).WithMany(p => p.QlHens)
                .HasForeignKey(d => d.IdvaoVien)
                .HasConstraintName("FK__QL_Hen__IDVaoVie__21D600EE");
        });

        modelBuilder.Entity<QlHinhAnh>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__QL_HinhA__3214EC278EE85DCF");

            entity.ToTable("QL_HinhAnh");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DuongDan).HasMaxLength(255);
            entity.Property(e => e.GhiChu).HasMaxLength(255);
            entity.Property(e => e.Idcd).HasColumnName("IDCD");
            entity.Property(e => e.Idcn).HasColumnName("IDCN");
            entity.Property(e => e.IdnhanVienThem).HasColumnName("IDNhanVienThem");
            entity.Property(e => e.IdvaoVien).HasColumnName("IDVaoVien");
            entity.Property(e => e.LoaiHinh).HasMaxLength(10);
            entity.Property(e => e.MaHa)
                .HasMaxLength(50)
                .HasColumnName("MaHA");
            entity.Property(e => e.Ngay).HasColumnType("datetime");

            entity.HasOne(d => d.IdcdNavigation).WithMany(p => p.QlHinhAnhs)
                .HasForeignKey(d => d.Idcd)
                .HasConstraintName("FK__QL_HinhAnh__IDCD__1C1D2798");

            entity.HasOne(d => d.IdcnNavigation).WithMany(p => p.QlHinhAnhs)
                .HasForeignKey(d => d.Idcn)
                .HasConstraintName("FK__QL_HinhAnh__IDCN__1A34DF26");

            entity.HasOne(d => d.IdnhanVienThemNavigation).WithMany(p => p.QlHinhAnhs)
                .HasForeignKey(d => d.IdnhanVienThem)
                .HasConstraintName("fk_nhanvien_hinhanh");

            entity.HasOne(d => d.IdvaoVienNavigation).WithMany(p => p.QlHinhAnhs)
                .HasForeignKey(d => d.IdvaoVien)
                .HasConstraintName("FK__QL_HinhAn__IDVao__1B29035F");
        });

        modelBuilder.Entity<QlHoaDon>(entity =>
        {
            entity.ToTable("QL_HoaDon");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DiaChiDn)
                .HasMaxLength(500)
                .HasColumnName("DiaChiDN");
            entity.Property(e => e.EmailHd)
                .HasMaxLength(100)
                .HasColumnName("EmailHD");
            entity.Property(e => e.GhiChu).HasMaxLength(1000);
            entity.Property(e => e.Idcn).HasColumnName("IDCN");
            entity.Property(e => e.Idkip).HasColumnName("IDKip");
            entity.Property(e => e.IdnhanVienTao).HasColumnName("IDNhanVienTao");
            entity.Property(e => e.IdphieuThuTien).HasColumnName("IDPhieuThuTien");
            entity.Property(e => e.KyHieuHd)
                .HasMaxLength(50)
                .HasColumnName("KyHieuHD");
            entity.Property(e => e.LoaiHd)
                .HasMaxLength(255)
                .HasColumnName("LoaiHD");
            entity.Property(e => e.Mst)
                .HasMaxLength(255)
                .HasColumnName("MST");
            entity.Property(e => e.NgayHd)
                .HasColumnType("datetime")
                .HasColumnName("NgayHD");
            entity.Property(e => e.NgayLapHd)
                .HasColumnType("datetime")
                .HasColumnName("NgayLapHD");
            entity.Property(e => e.Seri).HasMaxLength(50);
            entity.Property(e => e.SoHd)
                .HasMaxLength(50)
                .HasColumnName("SoHD");
            entity.Property(e => e.TenDn)
                .HasMaxLength(255)
                .HasColumnName("TenDN");

            entity.HasOne(d => d.IdcnNavigation).WithMany(p => p.QlHoaDons)
                .HasForeignKey(d => d.Idcn)
                .HasConstraintName("FK_HD_CN");

            entity.HasOne(d => d.IdkipNavigation).WithMany(p => p.QlHoaDons)
                .HasForeignKey(d => d.Idkip)
                .HasConstraintName("FK_HD_Kip");

            entity.HasOne(d => d.IdnhanVienTaoNavigation).WithMany(p => p.QlHoaDons)
                .HasForeignKey(d => d.IdnhanVienTao)
                .HasConstraintName("FK_HD_NVTao");

            entity.HasOne(d => d.IdphieuThuTienNavigation).WithMany(p => p.QlHoaDons)
                .HasForeignKey(d => d.IdphieuThuTien)
                .HasConstraintName("FK_HD_PhieuThuTien");
        });

        modelBuilder.Entity<QlHoaDonCt>(entity =>
        {
            entity.ToTable("QL_HoaDon_CT");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdhoaDon).HasColumnName("IDHoaDon");
            entity.Property(e => e.IdkhdieuTriCt).HasColumnName("IDKHDieuTriCT");
            entity.Property(e => e.IdphieuThuCt).HasColumnName("IDPhieuThuCT");
            entity.Property(e => e.IdvaoVien).HasColumnName("IDVaoVien");
            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.Vat).HasColumnName("VAT");

            entity.HasOne(d => d.IdhoaDonNavigation).WithMany(p => p.QlHoaDonCts)
                .HasForeignKey(d => d.IdhoaDon)
                .HasConstraintName("FK_HDCT_HD");

            entity.HasOne(d => d.IdkhdieuTriCtNavigation).WithMany(p => p.QlHoaDonCts)
                .HasForeignKey(d => d.IdkhdieuTriCt)
                .HasConstraintName("FK_HDCT_KHDTCT");

            entity.HasOne(d => d.IdphieuThuCtNavigation).WithMany(p => p.QlHoaDonCts)
                .HasForeignKey(d => d.IdphieuThuCt)
                .HasConstraintName("FK_HDCT_PTCT");

            entity.HasOne(d => d.IdvaoVienNavigation).WithMany(p => p.QlHoaDonCts)
                .HasForeignKey(d => d.IdvaoVien)
                .HasConstraintName("FK_HDCT_VV");
        });

        modelBuilder.Entity<QlHopDongCt>(entity =>
        {
            entity.ToTable("QL_HopDongCT");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdkeHoachDt).HasColumnName("IDKeHoachDT");

            entity.HasOne(d => d.IdkeHoachDtNavigation).WithMany(p => p.QlHopDongCts)
                .HasForeignKey(d => d.IdkeHoachDt)
                .HasConstraintName("FK_HDCT_KHDT");
        });

        modelBuilder.Entity<QlKeHoachDieuTri>(entity =>
        {
            entity.ToTable("QL_KeHoachDieuTri");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdbacSi).HasColumnName("IDBacSi");
            entity.Property(e => e.IdchiNhanh).HasColumnName("IDChiNhanh");
            entity.Property(e => e.Idkip).HasColumnName("IDKip");
            entity.Property(e => e.IdsinhVien).HasColumnName("IDSinhVien");
            entity.Property(e => e.Idtt).HasColumnName("IDTT");
            entity.Property(e => e.IdvaoVien).HasColumnName("IDVaoVien");
            entity.Property(e => e.Ngay).HasColumnType("datetime");
            entity.Property(e => e.SoPhieu).HasMaxLength(50);

            entity.HasOne(d => d.IdbacSiNavigation).WithMany(p => p.QlKeHoachDieuTriIdbacSiNavigations)
                .HasForeignKey(d => d.IdbacSi)
                .HasConstraintName("FK_QL_KeHoachDieuTri_DM_NhanVien");

            entity.HasOne(d => d.IdkipNavigation).WithMany(p => p.QlKeHoachDieuTris)
                .HasForeignKey(d => d.Idkip)
                .HasConstraintName("FK_KHDT_Kip");

            entity.HasOne(d => d.IdsinhVienNavigation).WithMany(p => p.QlKeHoachDieuTris)
                .HasForeignKey(d => d.IdsinhVien)
                .HasConstraintName("FK_KeHoachDieuTri_SinhVien");

            entity.HasOne(d => d.IdttNavigation).WithMany(p => p.QlKeHoachDieuTriIdttNavigations)
                .HasForeignKey(d => d.Idtt)
                .HasConstraintName("fk_kehoachdieutri_tieptan");

            entity.HasOne(d => d.IdvaoVienNavigation).WithMany(p => p.QlKeHoachDieuTris)
                .HasForeignKey(d => d.IdvaoVien)
                .HasConstraintName("FK_QL_KeHoachDieuTri_QL_VaoVien");
        });

        modelBuilder.Entity<QlKeHoachDieuTriCt>(entity =>
        {
            entity.ToTable("QL_KeHoachDieuTriCT");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.GhiChu).HasMaxLength(500);
            entity.Property(e => e.GhiChuLabo).HasMaxLength(500);
            entity.Property(e => e.GhiChuTra).HasMaxLength(500);
            entity.Property(e => e.GhiChuXoaNo).HasMaxLength(500);
            entity.Property(e => e.IdBstuVanThem).HasColumnName("IdBSTuVanThem");
            entity.Property(e => e.IdDdtuVanThem).HasColumnName("IdDDTuVanThem");
            entity.Property(e => e.IdbacSi).HasColumnName("IDBacSi");
            entity.Property(e => e.Idbslabo).HasColumnName("IDBSLabo");
            entity.Property(e => e.IdcongViec).HasColumnName("IDCongViec");
            entity.Property(e => e.IdkeHoach).HasColumnName("IDKeHoach");
            entity.Property(e => e.IdketQuaDieuTri).HasColumnName("IDKetQuaDieuTri");
            entity.Property(e => e.Idkip).HasColumnName("IDKip");
            entity.Property(e => e.Idncclabo).HasColumnName("IDNCCLabo");
            entity.Property(e => e.IdnguoiXoaNo).HasColumnName("IDNguoiXoaNo");
            entity.Property(e => e.IdnhanVienGui).HasColumnName("IDNhanVienGui");
            entity.Property(e => e.IdnhanVienNhan).HasColumnName("IDNhanVienNhan");
            entity.Property(e => e.IdnhanVienTra).HasColumnName("IDNhanVienTra");
            entity.Property(e => e.Idnvtao).HasColumnName("IDNVTao");
            entity.Property(e => e.IdphieuDieuTri).HasColumnName("IDPhieuDieuTri");
            entity.Property(e => e.IdphucHinh).HasColumnName("IDPhucHinh");
            entity.Property(e => e.IdtroThu).HasColumnName("IDTroThu");
            entity.Property(e => e.MaSinhVien).HasMaxLength(50);
            entity.Property(e => e.Mau).HasMaxLength(50);
            entity.Property(e => e.NgayBatDau).HasColumnType("datetime");
            entity.Property(e => e.NgayGui).HasColumnType("datetime");
            entity.Property(e => e.NgayKetThuc).HasColumnType("datetime");
            entity.Property(e => e.NgayNhan).HasColumnType("datetime");
            entity.Property(e => e.NgayTao).HasColumnType("datetime");
            entity.Property(e => e.NgayTaoMap).HasMaxLength(50);
            entity.Property(e => e.NgayThu).HasColumnType("datetime");
            entity.Property(e => e.NgayTra).HasColumnType("datetime");
            entity.Property(e => e.NgayXoaCongNo).HasColumnType("datetime");
            entity.Property(e => e.NgayXoaNo).HasColumnType("datetime");
            entity.Property(e => e.Rang).HasMaxLength(500);
            entity.Property(e => e.Stt).HasColumnName("STT");

            entity.HasOne(d => d.IdBstuVanThemNavigation).WithMany(p => p.QlKeHoachDieuTriCtIdBstuVanThemNavigations)
                .HasForeignKey(d => d.IdBstuVanThem)
                .HasConstraintName("fk_NV_BSTVT");

            entity.HasOne(d => d.IdDdtuVanThemNavigation).WithMany(p => p.QlKeHoachDieuTriCtIdDdtuVanThemNavigations)
                .HasForeignKey(d => d.IdDdtuVanThem)
                .HasConstraintName("fk_NV_DDTVT");

            entity.HasOne(d => d.IdbacSiNavigation).WithMany(p => p.QlKeHoachDieuTriCtIdbacSiNavigations)
                .HasForeignKey(d => d.IdbacSi)
                .HasConstraintName("FK_BacSi");

            entity.HasOne(d => d.IdcongViecNavigation).WithMany(p => p.QlKeHoachDieuTriCts)
                .HasForeignKey(d => d.IdcongViec)
                .HasConstraintName("FK_QL_KeHoachDieuTriCT_DM_DichVuKyThuat");

            entity.HasOne(d => d.IdkeHoachNavigation).WithMany(p => p.QlKeHoachDieuTriCts)
                .HasForeignKey(d => d.IdkeHoach)
                .HasConstraintName("FK_QL_KeHoachDieuTriCT_QL_KeHoachDieuTri");

            entity.HasOne(d => d.IdketQuaDieuTriNavigation).WithMany(p => p.QlKeHoachDieuTriCts)
                .HasForeignKey(d => d.IdketQuaDieuTri)
                .HasConstraintName("FK_QL_KeHoachDieuTriCT_DM_KetQuaDieuTri");

            entity.HasOne(d => d.IdncclaboNavigation).WithMany(p => p.QlKeHoachDieuTriCts)
                .HasForeignKey(d => d.Idncclabo)
                .HasConstraintName("fk_KHDTCT_NCCLABO");

            entity.HasOne(d => d.IdnhanVienGuiNavigation).WithMany(p => p.QlKeHoachDieuTriCtIdnhanVienGuiNavigations)
                .HasForeignKey(d => d.IdnhanVienGui)
                .HasConstraintName("fk_KHDTCT_NVG");

            entity.HasOne(d => d.IdnhanVienNhanNavigation).WithMany(p => p.QlKeHoachDieuTriCtIdnhanVienNhanNavigations)
                .HasForeignKey(d => d.IdnhanVienNhan)
                .HasConstraintName("fk_KHDTCT_NVN");

            entity.HasOne(d => d.IdnhanVienTraNavigation).WithMany(p => p.QlKeHoachDieuTriCtIdnhanVienTraNavigations)
                .HasForeignKey(d => d.IdnhanVienTra)
                .HasConstraintName("FK_QL_KeHoachDieuTriCT_DM_NhanVien");

            entity.HasOne(d => d.IdnvtaoNavigation).WithMany(p => p.QlKeHoachDieuTriCtIdnvtaoNavigations)
                .HasForeignKey(d => d.Idnvtao)
                .HasConstraintName("FK_KHDTCT_IDNVTao");

            entity.HasOne(d => d.IdphucHinhNavigation).WithMany(p => p.QlKeHoachDieuTriCts)
                .HasForeignKey(d => d.IdphucHinh)
                .HasConstraintName("fk_KHDTCT_PH");

            entity.HasOne(d => d.IdtroThuNavigation).WithMany(p => p.QlKeHoachDieuTriCtIdtroThuNavigations)
                .HasForeignKey(d => d.IdtroThu)
                .HasConstraintName("FK_TroThu");
        });

        modelBuilder.Entity<QlKhamTongQuat>(entity =>
        {
            entity.ToTable("QL_KhamTongQuat");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BenhKhac).HasMaxLength(1000);
            entity.Property(e => e.Bmi)
                .HasMaxLength(50)
                .HasColumnName("BMI");
            entity.Property(e => e.CanNang).HasMaxLength(50);
            entity.Property(e => e.ChieuCao).HasMaxLength(50);
            entity.Property(e => e.HuyetAp).HasMaxLength(50);
            entity.Property(e => e.IdbacSiKham).HasColumnName("IDBacSiKham");
            entity.Property(e => e.IdsinhVien).HasColumnName("IDSinhVien");
            entity.Property(e => e.IdvaoVien).HasColumnName("IDVaoVien");
            entity.Property(e => e.Khchrm).HasColumnName("KHCHRM");
            entity.Property(e => e.KhchuaTuy).HasColumnName("KHChuaTuy");
            entity.Property(e => e.Khimp).HasColumnName("KHImp");
            entity.Property(e => e.KhnhaChu).HasColumnName("KHNhaChu");
            entity.Property(e => e.KhnhoRang).HasColumnName("KHNhoRang");
            entity.Property(e => e.Khphcd).HasColumnName("KHPHCD");
            entity.Property(e => e.KhphongNgua).HasColumnName("KHPhongNgua");
            entity.Property(e => e.Khphtl).HasColumnName("KHPHTL");
            entity.Property(e => e.KhtayTrang).HasColumnName("KHTayTrang");
            entity.Property(e => e.KhtramRang).HasColumnName("KHTramRang");
            entity.Property(e => e.LyDoDenKham).HasMaxLength(1000);
            entity.Property(e => e.Mach).HasMaxLength(50);
            entity.Property(e => e.NgayKham).HasColumnType("datetime");
            entity.Property(e => e.NhietDo).HasMaxLength(50);
            entity.Property(e => e.SoPhieuKham).HasMaxLength(50);

            entity.HasOne(d => d.IdbacSiKhamNavigation).WithMany(p => p.QlKhamTongQuats)
                .HasForeignKey(d => d.IdbacSiKham)
                .HasConstraintName("fk_ktq_nhanvien");

            entity.HasOne(d => d.IdsinhVienNavigation).WithMany(p => p.QlKhamTongQuats)
                .HasForeignKey(d => d.IdsinhVien)
                .HasConstraintName("FK_KhamTongQuat_SinhVien");
        });

        modelBuilder.Entity<QlLaBo>(entity =>
        {
            entity.ToTable("QL_LaBo");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.IdmaMau)
                .ValueGeneratedOnAdd()
                .HasColumnName("IDMaMau");
            entity.Property(e => e.IdnhaCungCap).HasColumnName("IDNhaCungCap");
            entity.Property(e => e.IdnhanVienNhan).HasColumnName("IDNhanVienNhan");
            entity.Property(e => e.IdnhanVienTao).HasColumnName("IDNhanVienTao");
            entity.Property(e => e.IdnoiDungKeHoach).HasColumnName("IDNoiDungKeHoach");
            entity.Property(e => e.IdphucHinh).HasColumnName("IDPhucHinh");
            entity.Property(e => e.NgayChinhThucNhan).HasColumnType("datetime");
            entity.Property(e => e.NgayDat).HasColumnType("datetime");
            entity.Property(e => e.NgayNhanDuKien).HasColumnType("datetime");
        });

        modelBuilder.Entity<QlLichHenBenhNhan>(entity =>
        {
            entity.ToTable("QL_LichHenBenhNhan");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.GhiChu).HasMaxLength(500);
            entity.Property(e => e.IdbacSiHen).HasColumnName("IDBacSiHen");
            entity.Property(e => e.IdbenhNhan).HasColumnName("IDBenhNhan");
            entity.Property(e => e.IdbenhNhanDuBi).HasColumnName("IDBenhNhanDuBi");
            entity.Property(e => e.IdlyDoHen).HasColumnName("IDLyDoHen");
            entity.Property(e => e.IdnoiDungKeHoach).HasColumnName("IDNoiDungKeHoach");
            entity.Property(e => e.IdvaoVien).HasColumnName("IDVaoVien");
        });

        modelBuilder.Entity<QlMuonTra>(entity =>
        {
            entity.ToTable("QL_MuonTra");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdbntheoNgay).HasColumnName("IDBNTheoNgay");
            entity.Property(e => e.IdboCongCu).HasColumnName("IDBoCongCu");
            entity.Property(e => e.IdnhanVienMuon).HasColumnName("IDNhanVienMuon");
            entity.Property(e => e.IdnhanVienTra).HasColumnName("IDNhanVienTra");
            entity.Property(e => e.IdvaoVien).HasColumnName("IDVaoVien");
            entity.Property(e => e.NgayMuon).HasColumnType("datetime");
            entity.Property(e => e.NgayTra).HasColumnType("datetime");
            entity.Property(e => e.NgayTraDuKien).HasColumnType("datetime");

            entity.HasOne(d => d.IdbntheoNgayNavigation).WithMany(p => p.QlMuonTras)
                .HasForeignKey(d => d.IdbntheoNgay)
                .HasConstraintName("FK_MT_BNTheoNgay");

            entity.HasOne(d => d.IdboCongCuNavigation).WithMany(p => p.QlMuonTras)
                .HasForeignKey(d => d.IdboCongCu)
                .HasConstraintName("FK_MuonTra_BDC");

            entity.HasOne(d => d.IdnhanVienMuonNavigation).WithMany(p => p.QlMuonTraIdnhanVienMuonNavigations)
                .HasForeignKey(d => d.IdnhanVienMuon)
                .HasConstraintName("FK_MuonTra_NVMuon");

            entity.HasOne(d => d.IdnhanVienTraNavigation).WithMany(p => p.QlMuonTraIdnhanVienTraNavigations)
                .HasForeignKey(d => d.IdnhanVienTra)
                .HasConstraintName("FK_MuonTra_NVTra");

            entity.HasOne(d => d.IdvaoVienNavigation).WithMany(p => p.QlMuonTras)
                .HasForeignKey(d => d.IdvaoVien)
                .HasConstraintName("FK_MuonTra_VV");
        });

        modelBuilder.Entity<QlPhieuChi>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__QL_Phieu__3214EC277BEF7892");

            entity.ToTable("QL_PhieuChi");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.GhiChu).HasMaxLength(255);
            entity.Property(e => e.Idcn).HasColumnName("IDCN");
            entity.Property(e => e.IdnhanVienTao).HasColumnName("IDNhanVienTao");
            entity.Property(e => e.NgayTaoPhieu).HasColumnType("datetime");
            entity.Property(e => e.NguoiNhanTien).HasMaxLength(500);
            entity.Property(e => e.SoPhieu).HasMaxLength(50);

            entity.HasOne(d => d.IdcnNavigation).WithMany(p => p.QlPhieuChis)
                .HasForeignKey(d => d.Idcn)
                .HasConstraintName("FK__QL_PhieuCh__IDCN__0539C240");

            entity.HasOne(d => d.IdnhanVienTaoNavigation).WithMany(p => p.QlPhieuChis)
                .HasForeignKey(d => d.IdnhanVienTao)
                .HasConstraintName("FK__QL_PhieuC__IDNha__04459E07");
        });

        modelBuilder.Entity<QlPhieuChiCt>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__QL_Phieu__3214EC27686EBD92");

            entity.ToTable("QL_PhieuChiCT");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DienGiai).HasMaxLength(255);
            entity.Property(e => e.IdkhoanChi).HasColumnName("IDKhoanChi");
            entity.Property(e => e.IdphieuChi).HasColumnName("IDPhieuChi");

            entity.HasOne(d => d.IdkhoanChiNavigation).WithMany(p => p.QlPhieuChiCts)
                .HasForeignKey(d => d.IdkhoanChi)
                .HasConstraintName("FK__QL_PhieuC__IDKho__07220AB2");

            entity.HasOne(d => d.IdphieuChiNavigation).WithMany(p => p.QlPhieuChiCts)
                .HasForeignKey(d => d.IdphieuChi)
                .HasConstraintName("FK__QL_PhieuC__IDPhi__062DE679");
        });

        modelBuilder.Entity<QlPhieuDatCoc>(entity =>
        {
            entity.ToTable("QL_PhieuDatCoc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.GhiChuTao).HasMaxLength(500);
            entity.Property(e => e.GhiChuTra).HasMaxLength(500);
            entity.Property(e => e.Idbn).HasColumnName("IDBN");
            entity.Property(e => e.Idnvtao).HasColumnName("IDNVTao");
            entity.Property(e => e.Idnvtra).HasColumnName("IDNVTra");
            entity.Property(e => e.NgayTao).HasColumnType("datetime");
            entity.Property(e => e.NgayTra).HasColumnType("datetime");
            entity.Property(e => e.SoPhieu).HasMaxLength(50);

            entity.HasOne(d => d.IdbnNavigation).WithMany(p => p.QlPhieuDatCocs)
                .HasForeignKey(d => d.Idbn)
                .HasConstraintName("FK_QL_PhieuDatCoc_DM_BenhNhan");

            entity.HasOne(d => d.IdnvtaoNavigation).WithMany(p => p.QlPhieuDatCocIdnvtaoNavigations)
                .HasForeignKey(d => d.Idnvtao)
                .HasConstraintName("FK_QL_PhieuDatCoc_DM_NhanVien");

            entity.HasOne(d => d.IdnvtraNavigation).WithMany(p => p.QlPhieuDatCocIdnvtraNavigations)
                .HasForeignKey(d => d.Idnvtra)
                .HasConstraintName("FK_QL_PhieuDatCoc_DM_NhanVien1");
        });

        modelBuilder.Entity<QlPhieuDeNghi>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__QL_Phieu__3214EC272C7FFAC3");

            entity.ToTable("QL_PhieuDeNghi");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.GhiChu).HasMaxLength(255);
            entity.Property(e => e.Idcn).HasColumnName("IDCN");
            entity.Property(e => e.IdvaoVien).HasColumnName("IDVaoVien");
            entity.Property(e => e.NgayDeNghi).HasColumnType("datetime");
            entity.Property(e => e.SoPhieu).HasMaxLength(50);

            entity.HasOne(d => d.IdNhanVienDeNghiNavigation).WithMany(p => p.QlPhieuDeNghis)
                .HasForeignKey(d => d.IdNhanVienDeNghi)
                .HasConstraintName("FK__QL_PhieuD__IdNha__740F363E");

            entity.HasOne(d => d.IdcnNavigation).WithMany(p => p.QlPhieuDeNghis)
                .HasForeignKey(d => d.Idcn)
                .HasConstraintName("FK__QL_PhieuDe__IDCN__75035A77");

            entity.HasOne(d => d.IdvaoVienNavigation).WithMany(p => p.QlPhieuDeNghis)
                .HasForeignKey(d => d.IdvaoVien)
                .HasConstraintName("FK__QL_PhieuD__IDVao__731B1205");
        });

        modelBuilder.Entity<QlPhieuDeNghiCapHang>(entity =>
        {
            entity.ToTable("QL_PhieuDeNghiCapHang");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.GhiChu).HasMaxLength(500);
            entity.Property(e => e.IdCnnhanDeNghi).HasColumnName("IdCNNhanDeNghi");
            entity.Property(e => e.IdchiNhanhDeNghi).HasColumnName("IDChiNhanhDeNghi");
            entity.Property(e => e.IdnhanVien).HasColumnName("IDNhanVien");
            entity.Property(e => e.IdnhanVienDeNghi).HasColumnName("IDNhanVienDeNghi");
            entity.Property(e => e.SoPhieu).HasMaxLength(50);
            entity.Property(e => e.ThoiGianDeNghi).HasColumnType("datetime");

            entity.HasOne(d => d.IdCnnhanDeNghiNavigation).WithMany(p => p.QlPhieuDeNghiCapHangIdCnnhanDeNghiNavigations)
                .HasForeignKey(d => d.IdCnnhanDeNghi)
                .HasConstraintName("fk_DNCH_IDCN");

            entity.HasOne(d => d.IdchiNhanhDeNghiNavigation).WithMany(p => p.QlPhieuDeNghiCapHangIdchiNhanhDeNghiNavigations)
                .HasForeignKey(d => d.IdchiNhanhDeNghi)
                .HasConstraintName("FK_QL_PhieuDeNghiCapHang_DM_ChiNhanh");

            entity.HasOne(d => d.IdnhanVienNavigation).WithMany(p => p.QlPhieuDeNghiCapHangIdnhanVienNavigations)
                .HasForeignKey(d => d.IdnhanVien)
                .HasConstraintName("FK_QL_PhieuDeNghiCapHang_DM_NhanVien");

            entity.HasOne(d => d.IdnhanVienDeNghiNavigation).WithMany(p => p.QlPhieuDeNghiCapHangIdnhanVienDeNghiNavigations)
                .HasForeignKey(d => d.IdnhanVienDeNghi)
                .HasConstraintName("FK_QL_PhieuDeNghiCapHang_DM_NhanVien1");
        });

        modelBuilder.Entity<QlPhieuDeNghiCapHangCt>(entity =>
        {
            entity.ToTable("QL_PhieuDeNghiCapHang_CT");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.GhiChu).HasMaxLength(500);
            entity.Property(e => e.Iddvt).HasColumnName("IDDVT");
            entity.Property(e => e.Idhh).HasColumnName("IDHH");
            entity.Property(e => e.Idphieu).HasColumnName("IDPhieu");
            entity.Property(e => e.SldaCap).HasColumnName("SLDaCap");
            entity.Property(e => e.SldeNghi).HasColumnName("SLDeNghi");

            entity.HasOne(d => d.IddvtNavigation).WithMany(p => p.QlPhieuDeNghiCapHangCts)
                .HasForeignKey(d => d.Iddvt)
                .HasConstraintName("FK_QL_PhieuDeNghiCapHang_CT_HH_DM_DonViTinh");

            entity.HasOne(d => d.IdhhNavigation).WithMany(p => p.QlPhieuDeNghiCapHangCts)
                .HasForeignKey(d => d.Idhh)
                .HasConstraintName("FK_QL_PhieuDeNghiCapHang_CT_HH_DM_HangHoa");

            entity.HasOne(d => d.IdphieuNavigation).WithMany(p => p.QlPhieuDeNghiCapHangCts)
                .HasForeignKey(d => d.Idphieu)
                .HasConstraintName("FK_QL_PhieuDeNghiCapHang_CT_QL_PhieuDeNghiCapHang");
        });

        modelBuilder.Entity<QlPhieuDeNghiCt>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__QL_Phieu__3214EC27A5213375");

            entity.ToTable("QL_PhieuDeNghiCT");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IddeNghi).HasColumnName("IDDeNghi");
            entity.Property(e => e.Idkhct).HasColumnName("IDKHCT");

            entity.HasOne(d => d.IddeNghiNavigation).WithMany(p => p.QlPhieuDeNghiCts)
                .HasForeignKey(d => d.IddeNghi)
                .HasConstraintName("FK__QL_PhieuD__IDDeN__75F77EB0");

            entity.HasOne(d => d.IdkhctNavigation).WithMany(p => p.QlPhieuDeNghiCts)
                .HasForeignKey(d => d.Idkhct)
                .HasConstraintName("FK__QL_PhieuD__IDKHC__76EBA2E9");
        });

        modelBuilder.Entity<QlPhieuDieuTri>(entity =>
        {
            entity.ToTable("QL_PhieuDieuTri");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdbacSi).HasColumnName("IDBacSi");
            entity.Property(e => e.IdbenhNhan).HasColumnName("IDBenhNhan");
            entity.Property(e => e.IdchiNhanh).HasColumnName("IDChiNhanh");
            entity.Property(e => e.IdgioHen).HasColumnName("IDGioHen");
            entity.Property(e => e.IdhoLy).HasColumnName("IDHoLy");
            entity.Property(e => e.IdketQuaDt).HasColumnName("IDKetQuaDT");
            entity.Property(e => e.Idkhdtct).HasColumnName("IDKHDTCT");
            entity.Property(e => e.Idkip).HasColumnName("IDKip");
            entity.Property(e => e.IdlyDoHen).HasColumnName("IDLyDoHen");
            entity.Property(e => e.IdquyTrinhCt).HasColumnName("IDQuyTrinhCT");
            entity.Property(e => e.IdsinhVien).HasColumnName("IDSinhVien");
            entity.Property(e => e.IdtroThu).HasColumnName("IDTroThu");
            entity.Property(e => e.LyDoKhac).HasMaxLength(500);
            entity.Property(e => e.MoTa).HasMaxLength(2000);
            entity.Property(e => e.Ngay).HasColumnType("datetime");
            entity.Property(e => e.SoPhieu).HasMaxLength(50);

            entity.HasOne(d => d.IdbacSiNavigation).WithMany(p => p.QlPhieuDieuTriIdbacSiNavigations)
                .HasForeignKey(d => d.IdbacSi)
                .HasConstraintName("FK_QL_PhieuDieuTri_BacSi");

            entity.HasOne(d => d.IdbenhNhanNavigation).WithMany(p => p.QlPhieuDieuTris)
                .HasForeignKey(d => d.IdbenhNhan)
                .HasConstraintName("FK_QL_PhieuDieuTri_DM_BenhNhan");

            entity.HasOne(d => d.IdgioHenNavigation).WithMany(p => p.QlPhieuDieuTris)
                .HasForeignKey(d => d.IdgioHen)
                .HasConstraintName("FK_QL_PhieuDieuTri_DM_KhungGioHen");

            entity.HasOne(d => d.IdketQuaDtNavigation).WithMany(p => p.QlPhieuDieuTris)
                .HasForeignKey(d => d.IdketQuaDt)
                .HasConstraintName("FK_QL_PhieuDieuTri_DM_KetQuaDieuTri");

            entity.HasOne(d => d.IdkhdtctNavigation).WithMany(p => p.QlPhieuDieuTris)
                .HasForeignKey(d => d.Idkhdtct)
                .HasConstraintName("FK_QL_PhieuDieuTri_QL_KeHoachDieuTriCT");

            entity.HasOne(d => d.IdlyDoHenNavigation).WithMany(p => p.QlPhieuDieuTris)
                .HasForeignKey(d => d.IdlyDoHen)
                .HasConstraintName("FK_QL_PhieuDieuTri_DM_LyDoHen");

            entity.HasOne(d => d.IdquyTrinhCtNavigation).WithMany(p => p.QlPhieuDieuTris)
                .HasForeignKey(d => d.IdquyTrinhCt)
                .HasConstraintName("FK_PhieuDieuTri_QuyTrinhCT");

            entity.HasOne(d => d.IdsinhVienNavigation).WithMany(p => p.QlPhieuDieuTris)
                .HasForeignKey(d => d.IdsinhVien)
                .HasConstraintName("FK_PhieuDieuTri_SinhVien");

            entity.HasOne(d => d.IdtroThuNavigation).WithMany(p => p.QlPhieuDieuTriIdtroThuNavigations)
                .HasForeignKey(d => d.IdtroThu)
                .HasConstraintName("FK_QL_PhieuDieuTri_TroThu");
        });

        modelBuilder.Entity<QlPhieuDuTru>(entity =>
        {
            entity.ToTable("QL_PhieuDuTru");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.GhiChu).HasMaxLength(500);
            entity.Property(e => e.IdchiNhanhDuTru).HasColumnName("IDChiNhanhDuTru");
            entity.Property(e => e.IdnhanVien).HasColumnName("IDNhanVien");
            entity.Property(e => e.IdnhanVienDuTru).HasColumnName("IDNhanVienDuTru");
            entity.Property(e => e.SoPhieu).HasMaxLength(50);
            entity.Property(e => e.ThoiGianDuTru).HasColumnType("datetime");

            entity.HasOne(d => d.IdchiNhanhDuTruNavigation).WithMany(p => p.QlPhieuDuTrus)
                .HasForeignKey(d => d.IdchiNhanhDuTru)
                .HasConstraintName("FK_QL_PhieuDuTru_DM_ChiNhanh");

            entity.HasOne(d => d.IdnhanVienNavigation).WithMany(p => p.QlPhieuDuTruIdnhanVienNavigations)
                .HasForeignKey(d => d.IdnhanVien)
                .HasConstraintName("FK_QL_PhieuDuTru_DM_NhanVien");

            entity.HasOne(d => d.IdnhanVienDuTruNavigation).WithMany(p => p.QlPhieuDuTruIdnhanVienDuTruNavigations)
                .HasForeignKey(d => d.IdnhanVienDuTru)
                .HasConstraintName("FK_QL_PhieuDuTru_DM_NhanVien1");
        });

        modelBuilder.Entity<QlPhieuDuTruCt>(entity =>
        {
            entity.ToTable("QL_PhieuDuTru_CT");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.GhiChu).HasMaxLength(500);
            entity.Property(e => e.Iddvt).HasColumnName("IDDVT");
            entity.Property(e => e.Idhh).HasColumnName("IDHH");
            entity.Property(e => e.Idphieu).HasColumnName("IDPhieu");
            entity.Property(e => e.SldaCap).HasColumnName("SLDaCap");
            entity.Property(e => e.SlduTru).HasColumnName("SLDuTru");

            entity.HasOne(d => d.IddvtNavigation).WithMany(p => p.QlPhieuDuTruCts)
                .HasForeignKey(d => d.Iddvt)
                .HasConstraintName("FK_QL_PhieuDuTru_CT_HH_DM_DonViTinh");

            entity.HasOne(d => d.IdhhNavigation).WithMany(p => p.QlPhieuDuTruCts)
                .HasForeignKey(d => d.Idhh)
                .HasConstraintName("FK_QL_PhieuDuTru_CT_HH_DM_HangHoa");

            entity.HasOne(d => d.IdphieuNavigation).WithMany(p => p.QlPhieuDuTruCts)
                .HasForeignKey(d => d.Idphieu)
                .HasConstraintName("FK_QL_PhieuDuTru_CT_QL_PhieuDuTru");
        });

        modelBuilder.Entity<QlPhieuLaBo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__QL_Phieu__3214EC275E28409A");

            entity.ToTable("QL_PhieuLaBo");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.GhiChu).HasMaxLength(255);
            entity.Property(e => e.Idcn).HasColumnName("IDCN");
            entity.Property(e => e.IdvaoVien).HasColumnName("IDVaoVien");
            entity.Property(e => e.NgayDeNghi).HasColumnType("datetime");
            entity.Property(e => e.SoPhieu).HasMaxLength(50);

            entity.HasOne(d => d.IdNhanVienTaoNavigation).WithMany(p => p.QlPhieuLaBos)
                .HasForeignKey(d => d.IdNhanVienTao)
                .HasConstraintName("FK__QL_PhieuL__IdNha__7F80E8EA");

            entity.HasOne(d => d.IdcnNavigation).WithMany(p => p.QlPhieuLaBos)
                .HasForeignKey(d => d.Idcn)
                .HasConstraintName("FK__QL_PhieuLa__IDCN__00750D23");

            entity.HasOne(d => d.IdvaoVienNavigation).WithMany(p => p.QlPhieuLaBos)
                .HasForeignKey(d => d.IdvaoVien)
                .HasConstraintName("FK__QL_PhieuL__IDVao__7E8CC4B1");
        });

        modelBuilder.Entity<QlPhieuLaBoCt>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__QL_Phieu__3214EC2754549D86");

            entity.ToTable("QL_PhieuLaBoCT");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Idkhct).HasColumnName("IDKHCT");
            entity.Property(e => e.Idph).HasColumnName("IDPH");
            entity.Property(e => e.Idplb).HasColumnName("IDPLB");

            entity.HasOne(d => d.IdkhctNavigation).WithMany(p => p.QlPhieuLaBoCts)
                .HasForeignKey(d => d.Idkhct)
                .HasConstraintName("FK__QL_PhieuL__IDKHC__025D5595");

            entity.HasOne(d => d.IdphNavigation).WithMany(p => p.QlPhieuLaBoCts)
                .HasForeignKey(d => d.Idph)
                .HasConstraintName("FK__QL_PhieuLa__IDPH__035179CE");

            entity.HasOne(d => d.IdplbNavigation).WithMany(p => p.QlPhieuLaBoCts)
                .HasForeignKey(d => d.Idplb)
                .HasConstraintName("FK__QL_PhieuL__IDPLB__0169315C");
        });

        modelBuilder.Entity<QlPhieuThu>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__QL_Phieu__3214EC27AD9CD5F1");

            entity.ToTable("QL_PhieuThu");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.GhiChu).HasMaxLength(255);
            entity.Property(e => e.Idcn).HasColumnName("IDCN");
            entity.Property(e => e.IdnhanVienTao).HasColumnName("IDNhanVienTao");
            entity.Property(e => e.NgayTaoPhieu).HasColumnType("datetime");
            entity.Property(e => e.NguoiTraTien).HasMaxLength(500);
            entity.Property(e => e.SoPhieu).HasMaxLength(50);

            entity.HasOne(d => d.IdcnNavigation).WithMany(p => p.QlPhieuThus)
                .HasForeignKey(d => d.Idcn)
                .HasConstraintName("FK__QL_PhieuTh__IDCN__1D114BD1");

            entity.HasOne(d => d.IdnhanVienTaoNavigation).WithMany(p => p.QlPhieuThus)
                .HasForeignKey(d => d.IdnhanVienTao)
                .HasConstraintName("FK__QL_PhieuT__IDNha__1E05700A");
        });

        modelBuilder.Entity<QlPhieuThuCt>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__QL_Phieu__3214EC27DAAC2FC4");

            entity.ToTable("QL_PhieuThu_CT");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DienGiai).HasMaxLength(255);
            entity.Property(e => e.IdkhoanThu).HasColumnName("IDKhoanThu");
            entity.Property(e => e.IdphieuThu).HasColumnName("IDPhieuThu");

            entity.HasOne(d => d.IdkhoanThuNavigation).WithMany(p => p.QlPhieuThuCts)
                .HasForeignKey(d => d.IdkhoanThu)
                .HasConstraintName("FK__QL_PhieuT__IDKho__1FEDB87C");

            entity.HasOne(d => d.IdphieuThuNavigation).WithMany(p => p.QlPhieuThuCts)
                .HasForeignKey(d => d.IdphieuThu)
                .HasConstraintName("FK__QL_PhieuT__IDPhi__1EF99443");
        });

        modelBuilder.Entity<QlPhieuThuNo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_PhieuThuNo");

            entity.ToTable("QL_PhieuThuNo");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.GhiChu).HasMaxLength(2000);
            entity.Property(e => e.Idcn).HasColumnName("IDCN");
            entity.Property(e => e.Idcnnhap).HasColumnName("IDCNNhap");
            entity.Property(e => e.Idhttt).HasColumnName("IDHTTT");
            entity.Property(e => e.Idkh).HasColumnName("IDKH");
            entity.Property(e => e.Idnv).HasColumnName("IDNV");
            entity.Property(e => e.NgayLap).HasColumnType("datetime");
            entity.Property(e => e.NguoiTraTien).HasMaxLength(500);
            entity.Property(e => e.SoPhieu).HasMaxLength(50);
            entity.Property(e => e.Stk)
                .HasMaxLength(50)
                .HasColumnName("STK");

            entity.HasOne(d => d.IdcnNavigation).WithMany(p => p.QlPhieuThuNoIdcnNavigations)
                .HasForeignKey(d => d.Idcn)
                .HasConstraintName("FK__QL_PhieuTh__IDCN__12C8C788");

            entity.HasOne(d => d.IdcnnhapNavigation).WithMany(p => p.QlPhieuThuNoIdcnnhapNavigations)
                .HasForeignKey(d => d.Idcnnhap)
                .HasConstraintName("FK__QL_PhieuT__IDCNN__0FEC5ADD");

            entity.HasOne(d => d.IdhtttNavigation).WithMany(p => p.QlPhieuThuNos)
                .HasForeignKey(d => d.Idhttt)
                .HasConstraintName("FK__QL_PhieuT__IDHTT__10E07F16");

            entity.HasOne(d => d.IdnvNavigation).WithMany(p => p.QlPhieuThuNos)
                .HasForeignKey(d => d.Idnv)
                .HasConstraintName("FK__QL_PhieuTh__IDNV__11D4A34F");
        });

        modelBuilder.Entity<QlPhieuThuNoCt>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_PhieuThuNoCT");

            entity.ToTable("QL_PhieuThuNoCT");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Idptn).HasColumnName("IDPTN");
            entity.Property(e => e.Idpxk).HasColumnName("IDPXK");

            entity.HasOne(d => d.IdptnNavigation).WithMany(p => p.QlPhieuThuNoCts)
                .HasForeignKey(d => d.Idptn)
                .HasConstraintName("FK__QL_PhieuT__IDPTN__13BCEBC1");

            entity.HasOne(d => d.IdpxkNavigation).WithMany(p => p.QlPhieuThuNoCts)
                .HasForeignKey(d => d.Idpxk)
                .HasConstraintName("FK__QL_PhieuT__IDPXK__14B10FFA");
        });

        modelBuilder.Entity<QlPhieuTraNo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_PhieuTraNo");

            entity.ToTable("QL_PhieuTraNo");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.GhiChu).HasMaxLength(2000);
            entity.Property(e => e.Idcn).HasColumnName("IDCN");
            entity.Property(e => e.Idcnxuat).HasColumnName("IDCNXuat");
            entity.Property(e => e.Idhttt).HasColumnName("IDHTTT");
            entity.Property(e => e.Idncc).HasColumnName("IDNCC");
            entity.Property(e => e.Idnv).HasColumnName("IDNV");
            entity.Property(e => e.NgayNhap).HasColumnType("datetime");
            entity.Property(e => e.NguoiNhanTien).HasMaxLength(500);
            entity.Property(e => e.SoPhieu).HasMaxLength(50);
            entity.Property(e => e.Stk)
                .HasMaxLength(50)
                .HasColumnName("STK");

            entity.HasOne(d => d.IdcnNavigation).WithMany(p => p.QlPhieuTraNoIdcnNavigations)
                .HasForeignKey(d => d.Idcn)
                .HasConstraintName("FK__QL_PhieuTr__IDCN__74444068");

            entity.HasOne(d => d.IdcnxuatNavigation).WithMany(p => p.QlPhieuTraNoIdcnxuatNavigations)
                .HasForeignKey(d => d.Idcnxuat)
                .HasConstraintName("FK__QL_PhieuT__IDCNX__73501C2F");

            entity.HasOne(d => d.IdhtttNavigation).WithMany(p => p.QlPhieuTraNos)
                .HasForeignKey(d => d.Idhttt)
                .HasConstraintName("FK__QL_PhieuT__IDHTT__7814D14C");

            entity.HasOne(d => d.IdnccNavigation).WithMany(p => p.QlPhieuTraNos)
                .HasForeignKey(d => d.Idncc)
                .HasConstraintName("FK__QL_PhieuT__IDNCC__725BF7F6");

            entity.HasOne(d => d.IdnvNavigation).WithMany(p => p.QlPhieuTraNos)
                .HasForeignKey(d => d.Idnv)
                .HasConstraintName("FK__QL_PhieuTr__IDNV__753864A1");
        });

        modelBuilder.Entity<QlPhieuTraNoCt>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_PhieuTraNoCT");

            entity.ToTable("QL_PhieuTraNoCT");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Idpnk).HasColumnName("IDPNK");
            entity.Property(e => e.Idptn).HasColumnName("IDPTN");

            entity.HasOne(d => d.IdpnkNavigation).WithMany(p => p.QlPhieuTraNoCts)
                .HasForeignKey(d => d.Idpnk)
                .HasConstraintName("FK__QL_PhieuT__IDPNK__79FD19BE");

            entity.HasOne(d => d.IdptnNavigation).WithMany(p => p.QlPhieuTraNoCts)
                .HasForeignKey(d => d.Idptn)
                .HasConstraintName("FK__QL_PhieuT__IDPTN__7908F585");
        });

        modelBuilder.Entity<QlPhieuVatLieu>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__QL_Phieu__3214EC276AC2F7CE");

            entity.ToTable("QL_PhieuVatLieu");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.GhiChu).HasMaxLength(255);
            entity.Property(e => e.Idcn).HasColumnName("IDCN");
            entity.Property(e => e.IdvaoVien).HasColumnName("IDVaoVien");
            entity.Property(e => e.NgayDeNghi).HasColumnType("datetime");
            entity.Property(e => e.SoPhieu).HasMaxLength(50);

            entity.HasOne(d => d.IdNhanVienTaoNavigation).WithMany(p => p.QlPhieuVatLieus)
                .HasForeignKey(d => d.IdNhanVienTao)
                .HasConstraintName("FK__QL_PhieuV__IdNha__79C80F94");

            entity.HasOne(d => d.IdcnNavigation).WithMany(p => p.QlPhieuVatLieus)
                .HasForeignKey(d => d.Idcn)
                .HasConstraintName("FK__QL_PhieuVa__IDCN__7ABC33CD");

            entity.HasOne(d => d.IdvaoVienNavigation).WithMany(p => p.QlPhieuVatLieus)
                .HasForeignKey(d => d.IdvaoVien)
                .HasConstraintName("FK__QL_PhieuV__IDVao__77DFC722");
        });

        modelBuilder.Entity<QlPhieuVatLieuCt>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__QL_Phieu__3214EC27F93B6BC3");

            entity.ToTable("QL_PhieuVatLieuCT");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Idhh).HasColumnName("IDHH");
            entity.Property(e => e.Idkhct).HasColumnName("IDKHCT");
            entity.Property(e => e.IdphieuVl).HasColumnName("IDPhieuVL");

            entity.HasOne(d => d.IdhhNavigation).WithMany(p => p.QlPhieuVatLieuCts)
                .HasForeignKey(d => d.Idhh)
                .HasConstraintName("FK__QL_PhieuVa__IDHH__7D98A078");

            entity.HasOne(d => d.IdkhctNavigation).WithMany(p => p.QlPhieuVatLieuCts)
                .HasForeignKey(d => d.Idkhct)
                .HasConstraintName("FK__QL_PhieuV__IDKHC__7CA47C3F");

            entity.HasOne(d => d.IdphieuVlNavigation).WithMany(p => p.QlPhieuVatLieuCts)
                .HasForeignKey(d => d.IdphieuVl)
                .HasConstraintName("FK__QL_PhieuV__IDPhi__7BB05806");
        });

        modelBuilder.Entity<QlQuaTrinhTinhLabo>(entity =>
        {
            entity.ToTable("QL_QuaTrinhTinhLabo");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Idbacsi).HasColumnName("IDBacsi");
            entity.Property(e => e.Idcn).HasColumnName("IDCN");
            entity.Property(e => e.Idkhdtct).HasColumnName("IDKHDTCT");
            entity.Property(e => e.Idkip).HasColumnName("IDKip");
            entity.Property(e => e.IdnhomCp).HasColumnName("IDNhomCP");
        });

        modelBuilder.Entity<QlQuaTrinhTinhLuong>(entity =>
        {
            entity.ToTable("QL_QuaTrinhTinhLuong");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdbacSi).HasColumnName("IDBacSi");
            entity.Property(e => e.Idkhdtct).HasColumnName("IDKHDTCT");
            entity.Property(e => e.Idkip).HasColumnName("IDKip");
            entity.Property(e => e.IdtroThu).HasColumnName("IDTroThu");

            entity.HasOne(d => d.IdbacSiNavigation).WithMany(p => p.QlQuaTrinhTinhLuongIdbacSiNavigations)
                .HasForeignKey(d => d.IdbacSi)
                .HasConstraintName("FK_BacSiLuong");

            entity.HasOne(d => d.IdkhdtctNavigation).WithMany(p => p.QlQuaTrinhTinhLuongs)
                .HasForeignKey(d => d.Idkhdtct)
                .HasConstraintName("FK_KeHoachDieuTriCT");

            entity.HasOne(d => d.IdkipNavigation).WithMany(p => p.QlQuaTrinhTinhLuongs)
                .HasForeignKey(d => d.Idkip)
                .HasConstraintName("FK_QTTL_Kip");

            entity.HasOne(d => d.IdtroThuNavigation).WithMany(p => p.QlQuaTrinhTinhLuongIdtroThuNavigations)
                .HasForeignKey(d => d.IdtroThu)
                .HasConstraintName("FK_TroThuLuong");
        });

        modelBuilder.Entity<QlScanHd>(entity =>
        {
            entity.ToTable("QL_ScanHD");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DuongDan).HasMaxLength(255);
            entity.Property(e => e.IdkeHoachDt).HasColumnName("IDKeHoachDT");

            entity.HasOne(d => d.IdkeHoachDtNavigation).WithMany(p => p.QlScanHds)
                .HasForeignKey(d => d.IdkeHoachDt)
                .HasConstraintName("FK_ScanHD_KHDT");
        });

        modelBuilder.Entity<QlSoDoRang>(entity =>
        {
            entity.ToTable("QL_SoDoRang");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IHeight).HasColumnName("iHeight");
            entity.Property(e => e.ILeft).HasColumnName("iLeft");
            entity.Property(e => e.ITop).HasColumnName("iTop");
            entity.Property(e => e.IWidth).HasColumnName("iWidth");
            entity.Property(e => e.IdphieuKham).HasColumnName("IDPhieuKham");
            entity.Property(e => e.MaHinh).HasMaxLength(50);
        });

        modelBuilder.Entity<QlSoHd>(entity =>
        {
            entity.ToTable("QL_SoHD");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.KyHieuHd)
                .HasMaxLength(50)
                .HasColumnName("KyHieuHD");
            entity.Property(e => e.LoaiHd)
                .HasMaxLength(255)
                .HasColumnName("LoaiHD");
            entity.Property(e => e.Quyen).HasMaxLength(50);
            entity.Property(e => e.Seri).HasMaxLength(50);

            entity.HasOne(d => d.IdNhanVienNavigation).WithMany(p => p.QlSoHds)
                .HasForeignKey(d => d.IdNhanVien)
                .HasConstraintName("fk_nv_shd");
        });

        modelBuilder.Entity<QlThuTienDieuTri>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_QL_ThuTienCT");

            entity.ToTable("QL_ThuTienDieuTri");

            entity.HasIndex(e => new { e.LoaiHd, e.Seri, e.Quyen, e.SoBienLai, e.ChongTrungUnique }, "UK_bienlai").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.GhiChu).HasMaxLength(4000);
            entity.Property(e => e.GhiChuRieng).HasMaxLength(1000);
            entity.Property(e => e.Idcn).HasColumnName("IDCN");
            entity.Property(e => e.IddoiTacBh).HasColumnName("IDDoiTacBH");
            entity.Property(e => e.IdhtthanhToan).HasColumnName("IDHTThanhToan");
            entity.Property(e => e.IdkeHoach).HasColumnName("IDKeHoach");
            entity.Property(e => e.Idkip).HasColumnName("IDKip");
            entity.Property(e => e.IdnganHangDn).HasColumnName("IDNganHangDN");
            entity.Property(e => e.IdnhanVien).HasColumnName("IDNhanVien");
            entity.Property(e => e.IdphieuDatCoc).HasColumnName("IDPhieuDatCoc");
            entity.Property(e => e.IdvaoVien).HasColumnName("IDVaoVien");
            entity.Property(e => e.LoaiHd)
                .HasMaxLength(255)
                .HasColumnName("LoaiHD");
            entity.Property(e => e.NgayBaoCao).HasColumnType("datetime");
            entity.Property(e => e.Quyen).HasMaxLength(50);
            entity.Property(e => e.Seri).HasMaxLength(50);
            entity.Property(e => e.SoBienLai).HasMaxLength(50);
            entity.Property(e => e.SoPhieu).HasMaxLength(50);

            entity.HasOne(d => d.IdcnNavigation).WithMany(p => p.QlThuTienDieuTris)
                .HasForeignKey(d => d.Idcn)
                .HasConstraintName("FK_QL_ThuTienDieuTri_DM_ChiNhanh");

            entity.HasOne(d => d.IddoiTacBhNavigation).WithMany(p => p.QlThuTienDieuTris)
                .HasForeignKey(d => d.IddoiTacBh)
                .HasConstraintName("FK_TTDT_DoiTacBH");

            entity.HasOne(d => d.IdhtthanhToanNavigation).WithMany(p => p.QlThuTienDieuTris)
                .HasForeignKey(d => d.IdhtthanhToan)
                .HasConstraintName("FK_TTDT_HTTT");

            entity.HasOne(d => d.IdkeHoachNavigation).WithMany(p => p.QlThuTienDieuTris)
                .HasForeignKey(d => d.IdkeHoach)
                .HasConstraintName("FK_QL_ThuTienDieuTri_QL_KeHoachDieuTri");

            entity.HasOne(d => d.IdkipNavigation).WithMany(p => p.QlThuTienDieuTris)
                .HasForeignKey(d => d.Idkip)
                .HasConstraintName("FK_TTDT_Kip");

            entity.HasOne(d => d.IdnganHangDnNavigation).WithMany(p => p.QlThuTienDieuTris)
                .HasForeignKey(d => d.IdnganHangDn)
                .HasConstraintName("FK_TTDT_NHDN");

            entity.HasOne(d => d.IdnhanVienNavigation).WithMany(p => p.QlThuTienDieuTris)
                .HasForeignKey(d => d.IdnhanVien)
                .HasConstraintName("FK_QL_ThuTienDieuTri_DM_NhanVien");

            entity.HasOne(d => d.IdphieuDatCocNavigation).WithMany(p => p.QlThuTienDieuTris)
                .HasForeignKey(d => d.IdphieuDatCoc)
                .HasConstraintName("FK_TT_DC");

            entity.HasOne(d => d.IdvaoVienNavigation).WithMany(p => p.QlThuTienDieuTris)
                .HasForeignKey(d => d.IdvaoVien)
                .HasConstraintName("FK_QL_ThuTienDieuTri_QL_VaoVien");
        });

        modelBuilder.Entity<QlThuTienDieuTriCt>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_QL_DieuTriDTCT");

            entity.ToTable("QL_ThuTienDieuTriCT");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.GhiChuHoanTien).HasMaxLength(500);
            entity.Property(e => e.IdbacSi).HasColumnName("IDBacSi");
            entity.Property(e => e.IdkeHoachDtct).HasColumnName("IDKeHoachDTCT");
            entity.Property(e => e.IdnguoiHoanTien).HasColumnName("IDNguoiHoanTien");
            entity.Property(e => e.IdthuTienDt).HasColumnName("IDThuTienDT");
            entity.Property(e => e.IdtroThu).HasColumnName("IDTroThu");
            entity.Property(e => e.NgayHoanTien).HasColumnType("datetime");

            entity.HasOne(d => d.IdkeHoachDtctNavigation).WithMany(p => p.QlThuTienDieuTriCts)
                .HasForeignKey(d => d.IdkeHoachDtct)
                .HasConstraintName("FK_QL_ThuTienDieuTriCT_QL_KeHoachDieuTriCT");

            entity.HasOne(d => d.IdthuTienDtNavigation).WithMany(p => p.QlThuTienDieuTriCts)
                .HasForeignKey(d => d.IdthuTienDt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_QL_ThuTienDieuTriCT_QL_ThuTienDieuTri");
        });

        modelBuilder.Entity<QlThuTienDieuTriDatCoc>(entity =>
        {
            entity.ToTable("QL_ThuTienDieuTri_DatCoc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdphieuDatCoc).HasColumnName("IDPhieuDatCoc");
            entity.Property(e => e.IdthuTienDt).HasColumnName("IDThuTienDT");

            entity.HasOne(d => d.IdphieuDatCocNavigation).WithMany(p => p.QlThuTienDieuTriDatCocs)
                .HasForeignKey(d => d.IdphieuDatCoc)
                .HasConstraintName("FK_QL_ThuTienDieuTri_DatCoc_QL_PhieuDatCoc");

            entity.HasOne(d => d.IdthuTienDtNavigation).WithMany(p => p.QlThuTienDieuTriDatCocs)
                .HasForeignKey(d => d.IdthuTienDt)
                .HasConstraintName("FK_QL_ThuTienDieuTri_DatCoc_QL_ThuTienDieuTri");
        });

        modelBuilder.Entity<QlToaThuoc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__QL_ToaTh__3214EC27963C468E");

            entity.ToTable("QL_ToaThuoc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.GhiChu).HasMaxLength(255);
            entity.Property(e => e.IdbacSiKe).HasColumnName("IDBacSiKe");
            entity.Property(e => e.IdvaoVien).HasColumnName("IDVaoVien");
            entity.Property(e => e.LoaiToa).HasMaxLength(50);
            entity.Property(e => e.MaToa).HasMaxLength(50);
            entity.Property(e => e.NgayKe).HasColumnType("datetime");
            entity.Property(e => e.TrieuChung).HasMaxLength(255);

            entity.HasOne(d => d.IdbacSiKeNavigation).WithMany(p => p.QlToaThuocs)
                .HasForeignKey(d => d.IdbacSiKe)
                .HasConstraintName("FK__QL_ToaThu__IDBac__6F4A8121");

            entity.HasOne(d => d.IdvaoVienNavigation).WithMany(p => p.QlToaThuocs)
                .HasForeignKey(d => d.IdvaoVien)
                .HasConstraintName("FK__QL_ToaThu__IDVao__6E565CE8");
        });

        modelBuilder.Entity<QlToaThuocCd>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__QL_ToaTh__3214EC270D8DBC8D");

            entity.ToTable("QL_ToaThuocCD");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Idtoa).HasColumnName("IDToa");
            entity.Property(e => e.MaBenh).HasMaxLength(50);
            entity.Property(e => e.TenBenh).HasMaxLength(250);

            entity.HasOne(d => d.IdtoaNavigation).WithMany(p => p.QlToaThuocCds)
                .HasForeignKey(d => d.Idtoa)
                .HasConstraintName("FK__QL_ToaThu__IDToa__7226EDCC");
        });

        modelBuilder.Entity<QlToaThuocCt>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__QL_ToaTh__3214EC27C9309DFD");

            entity.ToTable("QL_ToaThuocCT");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CachDungKhac).HasMaxLength(255);
            entity.Property(e => e.Chieu).HasMaxLength(10);
            entity.Property(e => e.IdhangHoa).HasColumnName("IDHangHoa");
            entity.Property(e => e.Idtoa).HasColumnName("IDToa");
            entity.Property(e => e.LieuDung).HasMaxLength(255);
            entity.Property(e => e.Sang).HasMaxLength(10);
            entity.Property(e => e.Toi).HasMaxLength(10);
            entity.Property(e => e.Trua).HasMaxLength(10);

            entity.HasOne(d => d.IdhangHoaNavigation).WithMany(p => p.QlToaThuocCts)
                .HasForeignKey(d => d.IdhangHoa)
                .HasConstraintName("FK__QL_ToaThu__IDHan__7132C993");

            entity.HasOne(d => d.IdtoaNavigation).WithMany(p => p.QlToaThuocCts)
                .HasForeignKey(d => d.Idtoa)
                .HasConstraintName("FK__QL_ToaThu__IDToa__703EA55A");
        });

        modelBuilder.Entity<QlToaThuocMau>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__QL_ToaTh__3214EC27B7F380DD");

            entity.ToTable("QL_ToaThuocMau");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.LoaiToa).HasMaxLength(50);
            entity.Property(e => e.MaToaMau).HasMaxLength(50);
            entity.Property(e => e.TenToaMau).HasMaxLength(250);
            entity.Property(e => e.TrieuChung).HasMaxLength(255);
        });

        modelBuilder.Entity<QlToaThuocMauCd>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__QL_ToaTh__3214EC27EA58B5ED");

            entity.ToTable("QL_ToaThuocMauCD");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdmauToa).HasColumnName("IDMauToa");
            entity.Property(e => e.MaBenh).HasMaxLength(50);
            entity.Property(e => e.TenBenh).HasMaxLength(250);

            entity.HasOne(d => d.IdmauToaNavigation).WithMany(p => p.QlToaThuocMauCds)
                .HasForeignKey(d => d.IdmauToa)
                .HasConstraintName("FK__QL_ToaThu__IDMau__6D6238AF");
        });

        modelBuilder.Entity<QlToaThuocMauCt>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__QL_ToaTh__3214EC27A51E00EB");

            entity.ToTable("QL_ToaThuocMauCT");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CachDungKhac).HasMaxLength(255);
            entity.Property(e => e.Chieu).HasMaxLength(10);
            entity.Property(e => e.IdhangHoa).HasColumnName("IDHangHoa");
            entity.Property(e => e.IdmauToa).HasColumnName("IDMauToa");
            entity.Property(e => e.LieuDung).HasMaxLength(255);
            entity.Property(e => e.Sang).HasMaxLength(10);
            entity.Property(e => e.Toi).HasMaxLength(10);
            entity.Property(e => e.Trua).HasMaxLength(10);

            entity.HasOne(d => d.IdhangHoaNavigation).WithMany(p => p.QlToaThuocMauCts)
                .HasForeignKey(d => d.IdhangHoa)
                .HasConstraintName("FK__QL_ToaThu__IDHan__6C6E1476");

            entity.HasOne(d => d.IdmauToaNavigation).WithMany(p => p.QlToaThuocMauCts)
                .HasForeignKey(d => d.IdmauToa)
                .HasConstraintName("FK__QL_ToaThu__IDMau__6B79F03D");
        });

        modelBuilder.Entity<QlTuongQuanDvktQt>(entity =>
        {
            entity.ToTable("QL_TuongQuanDVKT_QT");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Iddvkt).HasColumnName("IDDVKT");
            entity.Property(e => e.Idqt).HasColumnName("IDQT");

            entity.HasOne(d => d.IddvktNavigation).WithMany(p => p.QlTuongQuanDvktQts)
                .HasForeignKey(d => d.Iddvkt)
                .HasConstraintName("FK_TQDVKTQT_DVKT");

            entity.HasOne(d => d.IdqtNavigation).WithMany(p => p.QlTuongQuanDvktQts)
                .HasForeignKey(d => d.Idqt)
                .HasConstraintName("FK_TQDVKTQT_QTDR");
        });

        modelBuilder.Entity<QlVaoVien>(entity =>
        {
            entity.ToTable("QL_VaoVien");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.GhiChuLucRa).HasMaxLength(2000);
            entity.Property(e => e.GhiChuLucVao).HasMaxLength(2000);
            entity.Property(e => e.IdbacSiHienTai).HasColumnName("IDBacSiHienTai");
            entity.Property(e => e.IdbenhNhan).HasColumnName("IDBenhNhan");
            entity.Property(e => e.IdchiNhanh).HasColumnName("IDChiNhanh");
            entity.Property(e => e.IdkeHoach).HasColumnName("IDKeHoach");
            entity.Property(e => e.IdlyDoRaVien).HasColumnName("IDLyDoRaVien");
            entity.Property(e => e.IdlyDoVaoVien).HasColumnName("IDLyDoVaoVien");
            entity.Property(e => e.IdmarKetting).HasColumnName("IDMarKetting");
            entity.Property(e => e.IdnhanVienKetThuc).HasColumnName("IDNhanVienKetThuc");
            entity.Property(e => e.IdnhanVienTao).HasColumnName("IDNhanVienTao");
            entity.Property(e => e.IdphongHienTai).HasColumnName("IDPhongHienTai");
            entity.Property(e => e.IdtinhCach).HasColumnName("IDTinhCach");
            entity.Property(e => e.MaKeHoach).HasMaxLength(1);
            entity.Property(e => e.MaVaoVien).HasMaxLength(50);
            entity.Property(e => e.NgayRa).HasColumnType("datetime");
            entity.Property(e => e.NgayVao).HasColumnType("datetime");

            entity.HasOne(d => d.IdbenhNhanNavigation).WithMany(p => p.QlVaoViens)
                .HasForeignKey(d => d.IdbenhNhan)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_QL_VaoVien_DM_BenhNhan");

            entity.HasOne(d => d.IdchiNhanhNavigation).WithMany(p => p.QlVaoViens)
                .HasForeignKey(d => d.IdchiNhanh)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__QL_VaoVie__IDChi__01D345B0");

            entity.HasOne(d => d.IdlyDoRaVienNavigation).WithMany(p => p.QlVaoViens)
                .HasForeignKey(d => d.IdlyDoRaVien)
                .HasConstraintName("FK__QL_VaoVie__IDLyD__0697FACD");

            entity.HasOne(d => d.IdlyDoVaoVienNavigation).WithMany(p => p.QlVaoViens)
                .HasForeignKey(d => d.IdlyDoVaoVien)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__QL_VaoVie__IDLyD__02C769E9");

            entity.HasOne(d => d.IdmarKettingNavigation).WithMany(p => p.QlVaoViens)
                .HasForeignKey(d => d.IdmarKetting)
                .HasConstraintName("FK_QL_VaoVien_DM_MarKetting");

            entity.HasOne(d => d.IdnhanVienKetThucNavigation).WithMany(p => p.QlVaoVienIdnhanVienKetThucNavigations)
                .HasForeignKey(d => d.IdnhanVienKetThuc)
                .HasConstraintName("FK__QL_VaoVie__IDNha__078C1F06");

            entity.HasOne(d => d.IdnhanVienTaoNavigation).WithMany(p => p.QlVaoVienIdnhanVienTaoNavigations)
                .HasForeignKey(d => d.IdnhanVienTao)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__QL_VaoVie__IDNha__05A3D694");

            entity.HasOne(d => d.IdphongHienTaiNavigation).WithMany(p => p.QlVaoViens)
                .HasForeignKey(d => d.IdphongHienTai)
                .HasConstraintName("FK_VV_PhongHienTai");

            entity.HasOne(d => d.IdtinhCachNavigation).WithMany(p => p.QlVaoViens)
                .HasForeignKey(d => d.IdtinhCach)
                .HasConstraintName("FK__QL_VaoVie__IDTin__04AFB25B");
        });

        modelBuilder.Entity<SttCapSoTheoBacSi>(entity =>
        {
            entity.ToTable("STT_CapSoTheoBacSi");

            entity.HasIndex(e => new { e.Ngay, e.IdbacSiHienTai, e.SoThuTu }, "UQ__STT_CapSoTheoBacSi__Unique").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdbnTheoNgay).HasColumnName("IDBN_TheoNgay");

            entity.HasOne(d => d.IdbacSiHienTaiNavigation).WithMany(p => p.SttCapSoTheoBacSis)
                .HasForeignKey(d => d.IdbacSiHienTai)
                .HasConstraintName("FK_STT_BacSi_NhanVien");

            entity.HasOne(d => d.IdbnTheoNgayNavigation).WithMany(p => p.SttCapSoTheoBacSis)
                .HasForeignKey(d => d.IdbnTheoNgay)
                .HasConstraintName("FK_STT_BacSi_BN_TheoNgay");
        });

        modelBuilder.Entity<SttCapSoTheoPhong>(entity =>
        {
            entity.ToTable("STT_CapSoTheoPhong");

            entity.HasIndex(e => new { e.Ngay, e.IdphongBuong, e.SoThuTu }, "UQ__STT_CapS__1800EFFBB6E9AEFD").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdbnTheoNgay).HasColumnName("IDBN_TheoNgay");
            entity.Property(e => e.IdphongBuong).HasColumnName("IDPhongBuong");

            entity.HasOne(d => d.IdbnTheoNgayNavigation).WithMany(p => p.SttCapSoTheoPhongs)
                .HasForeignKey(d => d.IdbnTheoNgay)
                .HasConstraintName("FK_BN_TheoNgay_PhongBuong");

            entity.HasOne(d => d.IdphongBuongNavigation).WithMany(p => p.SttCapSoTheoPhongs)
                .HasForeignKey(d => d.IdphongBuong)
                .HasConstraintName("FK_STTP_PhongBuong");
        });

        modelBuilder.Entity<TempQuyTrinhDieuTri>(entity =>
        {
            entity.ToTable("Temp_QuyTrinhDieuTri");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.TenQuyTrinh).HasMaxLength(500);
        });

        modelBuilder.Entity<TempQuyTrinhDieuTriCt>(entity =>
        {
            entity.ToTable("Temp_QuyTrinhDieuTriCT");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Idqt).HasColumnName("IDQT");
            entity.Property(e => e.ThuTu).HasMaxLength(50);

            entity.HasOne(d => d.IdqtNavigation).WithMany(p => p.TempQuyTrinhDieuTriCts)
                .HasForeignKey(d => d.Idqt)
                .HasConstraintName("FK_QTDTCT_QTDT");
        });

        modelBuilder.Entity<TemplateBenhAnRhm>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Template_Template_BenhAnRHM");

            entity.ToTable("Template_BenhAnRHM");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdmauBenhAn).HasColumnName("IDMauBenhAn");
            entity.Property(e => e.Ma).HasMaxLength(200);
            entity.Property(e => e.MacDinh).HasMaxLength(500);
            entity.Property(e => e.MoTa).HasMaxLength(500);

            entity.HasOne(d => d.IdmauBenhAnNavigation).WithMany(p => p.TemplateBenhAnRhms)
                .HasForeignKey(d => d.IdmauBenhAn)
                .HasConstraintName("FK_TBAYHCTNgT_MBA");
        });

        modelBuilder.Entity<TemplateBenhAnRhmngoaiTru>(entity =>
        {
            entity.ToTable("Template_BenhAnRHMNgoaiTru");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdmauBenhAn).HasColumnName("IDMauBenhAn");
            entity.Property(e => e.Ma).HasMaxLength(200);
            entity.Property(e => e.MacDinh).HasMaxLength(500);
            entity.Property(e => e.MoTa).HasMaxLength(500);

            entity.HasOne(d => d.IdmauBenhAnNavigation).WithMany(p => p.TemplateBenhAnRhmngoaiTrus)
                .HasForeignKey(d => d.IdmauBenhAn)
                .HasConstraintName("FK_TBARHMNgT_MBA");
        });

        modelBuilder.Entity<TinhLuongCongViecHoTro>(entity =>
        {
            entity.ToTable("TinhLuong_CongViecHoTro");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.MaCongViec).HasMaxLength(50);
            entity.Property(e => e.TenCongViec).HasMaxLength(100);
        });

        modelBuilder.Entity<TinhLuongDinhMucLaboTinhLuong>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_DM_DinhMucLaboTinhLuong");

            entity.ToTable("TinhLuong_DinhMucLaboTinhLuong");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.HasOne(d => d.IdChiNhanhNavigation).WithMany(p => p.TinhLuongDinhMucLaboTinhLuongs)
                .HasForeignKey(d => d.IdChiNhanh)
                .HasConstraintName("fk_cn_dmlbtl");
        });

        modelBuilder.Entity<TinhLuongHoaHongVatLieu>(entity =>
        {
            entity.ToTable("TinhLuong_HoaHongVatLieu");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Idhh).HasColumnName("IDHH");

            entity.HasOne(d => d.IdhhNavigation).WithMany(p => p.TinhLuongHoaHongVatLieus)
                .HasForeignKey(d => d.Idhh)
                .HasConstraintName("FK_TinhLuong_HoaHongVatLieu_HH_DM_HangHoa");
        });

        modelBuilder.Entity<TinhLuongPhanTramChinhNha>(entity =>
        {
            entity.ToTable("TinhLuong_PhanTramChinhNha");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IdnhanVien).HasColumnName("IDNhanVien");

            entity.HasOne(d => d.IdnhanVienNavigation).WithMany(p => p.TinhLuongPhanTramChinhNhas)
                .HasForeignKey(d => d.IdnhanVien)
                .HasConstraintName("FK_TinhLuong_PhanTramChinhNha_DM_NhanVien");
        });

        modelBuilder.Entity<TinhLuongTongHopLuong>(entity =>
        {
            entity.ToTable("TinhLuong_TongHopLuong");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Idbn).HasColumnName("IDBN");
            entity.Property(e => e.IdcongViec).HasColumnName("IDCongViec");
            entity.Property(e => e.Idnv).HasColumnName("IDNV");
            entity.Property(e => e.Idvv).HasColumnName("IDVV");
            entity.Property(e => e.Ngay).HasColumnType("datetime");

            entity.HasOne(d => d.IdbnNavigation).WithMany(p => p.TinhLuongTongHopLuongs)
                .HasForeignKey(d => d.Idbn)
                .HasConstraintName("FK_TinhLuong_TongHopLuong_DM_BenhNhan");

            entity.HasOne(d => d.IdcongViecNavigation).WithMany(p => p.TinhLuongTongHopLuongs)
                .HasForeignKey(d => d.IdcongViec)
                .HasConstraintName("FK_TinhLuong_TongHopLuong_TinhLuong_CongViecHoTro");

            entity.HasOne(d => d.IdnvNavigation).WithMany(p => p.TinhLuongTongHopLuongs)
                .HasForeignKey(d => d.Idnv)
                .HasConstraintName("FK_TinhLuong_TongHopLuong_DM_NhanVien");

            entity.HasOne(d => d.IdvvNavigation).WithMany(p => p.TinhLuongTongHopLuongs)
                .HasForeignKey(d => d.Idvv)
                .HasConstraintName("FK_TinhLuong_TongHopLuong_QL_VaoVien");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
