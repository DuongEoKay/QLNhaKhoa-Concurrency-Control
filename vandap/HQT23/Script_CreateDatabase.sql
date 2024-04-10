USE MASTER
GO
IF DB_ID('NHAKHOA') IS NOT NULL
BEGIN
    ALTER DATABASE [NHAKHOA]
    SET SINGLE_USER WITH ROLLBACK IMMEDIATE
    DROP DATABASE [NHAKHOA]
END
GO

CREATE DATABASE NHAKHOA
GO
USE NHAKHOA
GO


CREATE TABLE KhachHang
(
  IDKhachHang varchar(10) ,
  HoTen NVARCHAR(30),
  SDT varchar(11),
  NgaySinh date,
  MatKhau NVARCHAR(16),
  PRIMARY KEY CLUSTERED (IDKhachHang ASC)
)

 CREATE TABLE NhanSu
(
  IDNhanSu varchar(10) ,
  HoTen NVARCHAR(30),
  SDT varchar(11),
  DiaChi NVARCHAR(100),
  LoaiNhanSu NVARCHAR(16),
  MatKhau varchar(10),
  IDQuanTriVien varchar(10),
  PRIMARY KEY CLUSTERED (IDNhanSu ASC),
  FOREIGN KEY (IDQuanTriVien) REFERENCES NhanSu(IDNhanSu)
  
)


CREATE TABLE LichHen
(
  IDLichHen varchar(10),
  ThoiGianKham DATETIME,
  IDKhachHang varchar(10),
  NguoiKham varchar(10),
  NguoiLap varchar(10),
  PRIMARY KEY CLUSTERED (IDLichHen),
  FOREIGN KEY (NguoiLap) REFERENCES NhanSu(IDNhanSu),
  FOREIGN KEY (NguoiKham) REFERENCES NhanSu(IDNhanSu),
  FOREIGN KEY (IDKhachHang) REFERENCES KhachHang(IDKhachHang),
)



CREATE TABLE HoSoBenhNhan
(
  IDHoSo varchar(10),
  ThoiGianKham DATETIME,
  IDBenhNhan varchar(10),
  NhaSi varchar(10),
  PRIMARY KEY CLUSTERED (IDHoSo ASC),
  FOREIGN KEY (IDBenhNhan) REFERENCES KhachHang(IDKhachHang),
  FOREIGN KEY (NhaSi) REFERENCES NhanSu(IDNhanSu)
)

CREATE TABLE HoaDon
(
  IDHoSo varchar(10),
  NguoiLap varchar(10),
  TongTien varchar(10),
  PRIMARY KEY CLUSTERED (IDHoSo ASC),
  FOREIGN KEY (NguoiLap) REFERENCES NhanSu(IDNhanSu),
  FOREIGN KEY (IDHoSo) REFERENCES HoSoBenhNhan(IDHoSo),
)


CREATE TABLE Thuoc
(
  MaThuoc varchar(10),
  TenThuoc nvarchar(30),
  DVT nvarchar(10),
  ChiDinh nvarchar(10),
  SoLuongTon int,
  NgayHetHan DATE,
  DonGia int,
  NguoiQuanLi varchar(10),
  PRIMARY KEY CLUSTERED (MaThuoc ASC),
  FOREIGN KEY (NguoiQuanLI) REFERENCES NhanSu(IDNhanSu)
)


CREATE TABLE DichVu
(
  IDDichVu varchar(10),
  TenDichVu varchar(100),
  PhiDichVu varchar(10),
  PRIMARY KEY CLUSTERED (IDDichVu ASC)
)



CREATE TABLE SuDungThuoc
(
  IDThuoc varchar(10),
  IDHoSo varchar(10),
  SoLuong int,
  PRIMARY KEY CLUSTERED (IDThuoc ASC,IDHoSo ASC),
  FOREIGN KEY (IDHoSo) REFERENCES HoSoBenhNhan(IDHoSo),
  FOREIGN KEY (IDThuoc) REFERENCES Thuoc(MaThuoc),

)

CREATE TABLE SuDungDV
(
  IDDichVu varchar(10),
  IDHoSo varchar(10),
  PRIMARY KEY CLUSTERED (IDDichVu ASC,IDHoSo ASC),
  FOREIGN KEY (IDHoSo) REFERENCES HoSoBenhNhan(IDHoSo),
  FOREIGN KEY (IDDichVu) REFERENCES DichVu(IDDichVu)
)



CREATE TABLE LichNhaSi
(
  IDNhaSi varchar(10),
  ThoiGianTrong datetime,
  PRIMARY KEY CLUSTERED (IDNhaSi ASC, ThoiGianTrong),
  FOREIGN KEY (IDNhaSi) REFERENCES NhanSu(IDNhanSu),
  
)
