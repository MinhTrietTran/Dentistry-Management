USE MASTER
GO

CREATE DATABASE QUANLYNHAKHOA
GO

USE QUANLYNHAKHOA
GO

-- Tao bang va rang buoc khoa chinh
CREATE TABLE DangNhap
(
    TaiKhoan VARCHAR(50) NOT NULL,
    pass_word VARCHAR(50) NOT NULL,
    CONSTRAINT PK_DangNhap PRIMARY KEY(TaiKhoan) 
)

CREATE TABLE NhanVien
(
    MaNV INT,
    TenNV NVARCHAR(50) NOT NULL,
    PhaiNV NVARCHAR(5) CHECK(PhaiNV IN (N'Nam',N'Nữ')),
    NgaySinhNV DATE ,
    DienThoaiNV VARCHAR(10) ,
    EmailNV VARCHAR(50) ,
    DiaChiNV NVARCHAR(50) ,
    TaiKhoanNV VARCHAR(50) ,
    --CONSTRAINT PK_NhanVien PRIMARY KEY(MaNV)
)

CREATE TABLE NhaSi
(
    MaNS INT,
    TenNS NVARCHAR(50) NOT NULL,
    PhaiNS NVARCHAR(5) CHECK(PhaiNS IN (N'Nam',N'Nữ')),
    NgaySinhNS DATE ,
    DienThoaiNS VARCHAR(50) ,
    EmailNS VARCHAR(50) ,
    DiaChiNS NVARCHAR(50) ,
    TaiKhoanNS VARCHAR(50) ,
    --CONSTRAINT PK_NhaSi PRIMARY KEY(MaNS)
)

CREATE TABLE LichLamViec
(
    MaNhaSi INT,
    ThuTrongTuan NVARCHAR(10) CHECK(ThuTrongTuan IN (N'Thứ hai', N'Thứ ba', N'Thứ tư', N'Thứ năm', N'Thứ sáu', N'Thứ bảy', N'Chủ nhật')),
    GioBatDau INT CHECK(GioBatDau IN (8,14)),
    GioKetThuc INT CHECK(GioKetThuc IN (12,18)),
    --CONSTRAINT PK_LichLamViec PRIMARY KEY(MaNhaSi,ThuTrongTuan)
)

CREATE TABLE CuocHen
(
    MaCH INT,
    GioCH DATETIME,
    ThuTuCH INT,
    IsLanDau BIT,
    GhiChu NVARCHAR(200),
    NgayGui DATE,
    BenhNhan INT,
    NhaSi INT,
    TroLy INT,
    Phong VARCHAR(10),
    CuocHenTruocDo INT,
    --CONSTRAINT PK_CuocHen PRIMARY KEY(MaCH)
)

CREATE TABLE Phong
(
    SoPhong VARCHAR(10) NOT NULL
    CONSTRAINT PK_Phong PRIMARY KEY(SoPhong)
)

CREATE TABLE BenhNhan
(
    MaBN INT,
    TenBN NVARCHAR(50) NOT NULL,
    PhaiBN NVARCHAR(5) CHECK(PhaiBN IN (N'Nam',N'Nữ')),
    DienThoaiBN VARCHAR(10),
    DiaChiBN NVARCHAR(50),
    NgaySinhBN DATE,
    ThongTinTongQuanSKRangMieng NVARCHAR(200),
    GhiChu NVARCHAR(200),
    NhaSiMacDinh INT,
    --CONSTRAINT PK_BenhNhan PRIMARY KEY(MaBN)
)

CREATE TABLE ThanhToan
(
    MaTT INT,
    TongHoaDon INT,
    DaTra INT,
    TienThoi INT,
    NgayTT DATE,
    GhiChu NVARCHAR(200),
    BenhNhan INT,
    LoaiTT NVARCHAR(10), --Tien Mat hay Online
    --CONSTRAINT PK_ThanhToan PRIMARY KEY(MaTT)
)


CREATE TABLE KeHoachDieuTri
(
    MaKHDT INT,
    MoTa NVARCHAR(200),
    NgayDieuTri DATE,
    GhiChu NVARCHAR(200), 
    TrangThai VARCHAR(10), -- yellow | blue | green
    Gia INT,
    LieuTrinh INT,
    NhaSi INT,
    TroLy INT,
    BenhNhan INT,
    ThanhToan INT,
    --CONSTRAINT PK_KeHoachDieuTri PRIMARY KEY(MaKHDT)
)

CREATE TABLE LieuTrinh
(
    MaLT INT,
    TenLT NVARCHAR(50) NOT NULL,
    --CONSTRAINT PK_LieuTrinh PRIMARY KEY(MaLT)
)

CREATE TABLE RangTrongKeHoach
(
    MaKeHoachDieuTri INT,
    SoRang INT,
    --CONSTRAINT PK_RangTrongKeHoach PRIMARY KEY(MaKeHoachDieuTri,SoRang)
)

CREATE TABLE Rang
(
    SoRang INT, -- La rang so may day!
    CONSTRAINT PK_Rang PRIMARY KEY(SoRang)
)

CREATE TABLE MatRang
(
    MaMR VARCHAR(1), -- Moi mat rang deu co ma. VD: Mat trong: L (Lingual)
    SoRang INT,
    CONSTRAINT PK_MatRang PRIMARY KEY(MaMR)
)

CREATE TABLE DonThuoc
(
    MADT INT,
    NgayKeDon DATE,
    BenhNhan INT,
    --CONSTRAINT PK_DonThuoc PRIMARY KEY(MaDT)
)

CREATE TABLE ThanhPhan -- cac thuoc duoc ke trong don thuoc
(
    MaDonThuoc INT,
    MaThuoc INT,
    SoLuong INT,
    --CONSTRAINT PK_ThanhPhan PRIMARY KEY(MaDonThuoc, MaThuoc)
)

CREATE TABLE Thuoc
(
    MaThuoc INT,
    TenThuoc NVARCHAR(50) NOT NULL,
    XuatXu NVARCHAR(50),
    CongDung NVARCHAR(200),
    --CONSTRAINT PK_Thuoc PRIMARY KEY(MaThuoc)
)

-- Tao rang buoc khoa ngoai
ALTER TABLE NhanVien
ADD CONSTRAINT FK_NhanVien_DangNhap
FOREIGN KEY (TaiKhoanNV)
REFERENCES DangNhap(TaiKhoan)

ALTER TABLE NhaSi
ADD CONSTRAINT FK_NhaSi_DangNhap
FOREIGN KEY (TaiKhoanNS)
REFERENCES DangNhap(TaiKhoan)

ALTER TABLE LichLamViec
ADD CONSTRAINT FK_LichLamViec_NhaSi
FOREIGN KEY (MaNhaSi)
REFERENCES NhaSi(MaNS)

ALTER TABLE CuocHen
ADD CONSTRAINT FK_CuocHen_BenhNhan
FOREIGN KEY (BenhNhan)
REFERENCES BenhNhan(MaBN)

ALTER TABLE CuocHen
ADD CONSTRAINT FK_CuocHen_NhaSi
FOREIGN KEY (NhaSi)
REFERENCES NhaSi(MaNS)

ALTER TABLE CuocHen
ADD CONSTRAINT FK_CuocHen_TroLy
FOREIGN KEY (TroLy)
REFERENCES NhaSi(MaNS)

ALTER TABLE CuocHen
ADD CONSTRAINT FK_CuocHen_Phong
FOREIGN KEY (Phong)
REFERENCES Phong(SoPhong)

ALTER TABLE CuocHen
ADD CONSTRAINT FK_CuocHen_CuocHen
FOREIGN KEY (CuocHenTruocDo)
REFERENCES CuocHen(MaCH)

ALTER TABLE BenhNhan
ADD CONSTRAINT FK_BenhNhan_NhaSi
FOREIGN KEY (NhaSiMacDinh)
REFERENCES NhaSi(MaNS)

ALTER TABLE ThanhToan
ADD CONSTRAINT FK_ThanhToan_BenhNhan
FOREIGN KEY (BenhNhan)
REFERENCES BenhNhan(MaBN)

ALTER TABLE KeHoachDieuTri
ADD CONSTRAINT FK_KeHoachDieuTri_LieuTrinh
FOREIGN KEY (LieuTrinh)
REFERENCES LieuTrinh(MaLT)

ALTER TABLE KeHoachDieuTri
ADD CONSTRAINT FK_KeHoachDieuTri_NhaSi
FOREIGN KEY (NhaSi)
REFERENCES NhaSi(MaNS)

ALTER TABLE KeHoachDieuTri
ADD CONSTRAINT FK_KeHoachDieuTri_TroLy
FOREIGN KEY (TroLy)
REFERENCES NhaSi(MaNS)

ALTER TABLE KeHoachDieuTri
ADD CONSTRAINT FK_KeHoachDieuTri_BenhNhan
FOREIGN KEY (BenhNhan)
REFERENCES BenhNhan(MaBN)

ALTER TABLE KeHoachDieuTri
ADD CONSTRAINT FK_KeHoachDieuTri_ThanhToan
FOREIGN KEY (ThanhToan)
REFERENCES ThanhToan(MaTT)

ALTER TABLE RangTrongKeHoach
ADD CONSTRAINT FK_RangTrongKeHoach_KeHoachDieuTri
FOREIGN KEY (MaKeHoachDieuTri)
REFERENCES KeHoachDieuTri(MaKHDT)

ALTER TABLE RangTrongKeHoach
ADD CONSTRAINT FK_RangTrongKeHoach_Rang
FOREIGN KEY (SoRang)
REFERENCES Rang(SoRang)

ALTER TABLE MatRang
ADD CONSTRAINT FK_MatRang_Rang
FOREIGN KEY (SoRang)
REFERENCES Rang(SoRang)

ALTER TABLE DonThuoc
ADD CONSTRAINT FK_DonThuoc_BenhNhan
FOREIGN KEY (BenhNhan)
REFERENCES BenhNhan(MaBN)

ALTER TABLE ThanhPhan
ADD CONSTRAINT FK_ThanhPhan_DonThuoc
FOREIGN KEY (MaDonThuoc)
REFERENCES DonThuoc(MaDT)

ALTER TABLE ThanhPhan
ADD CONSTRAINT FK_ThanhPhan_Thuoc
FOREIGN KEY (MaThuoc)
REFERENCES Thuoc(MaThuoc)



-- Nhap lieu (Tu dong phat sinh theo format nha )

-- Cap nhat 
