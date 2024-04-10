﻿/* 21HTTT1 - Nhóm 3
 * 21127004 - Trần Nguyễn An Phong
 * 21127135 - Diệp Hữu Phúc
 * 21127149 - Huỳnh Minh Quang
 * 21127296 - Đặng Hà Huy
 */

USE master
GO

IF DB_ID('Nhom3_QLNhaKhoa') IS NOT NULL
BEGIN
    ALTER DATABASE [Nhom3_QLNhaKhoa]
    SET SINGLE_USER WITH ROLLBACK IMMEDIATE
    DROP DATABASE [Nhom3_QLNhaKhoa]
END
GO

CREATE DATABASE [Nhom3_QLNhaKhoa]
GO
USE [Nhom3_QLNhaKhoa]
GO

CREATE TABLE KHACHHANG (
    MAKHACHHANG VARCHAR(5),
    HOTEN NVARCHAR(25),
    NGAYSINH DATE,
    DIACHI NVARCHAR(100),
    SODT VARCHAR(11),
    MATKHAU VARCHAR(20),

    CONSTRAINT PK_KHACHHANG
    PRIMARY KEY(MAKHACHHANG)
)

CREATE TABLE NHANVIEN (
    MANHANVIEN VARCHAR(5),
    HOTEN NVARCHAR(25),
    NGAYSINH DATE,
    DIACHI NVARCHAR(100),
    SODT VARCHAR(11),
    LOAINHANVIEN INT, -- 0: NHANVIEN, 1: NHASI, 2: QUANTRIVIEN
    MATKHAU VARCHAR(20)

    CONSTRAINT PK_NHANVIEN
    PRIMARY KEY(MANHANVIEN),

    CONSTRAINT CHK_NHANVIEN_LOAINHANVIEN
    CHECK (LOAINHANVIEN = 0 OR LOAINHANVIEN = 1 OR LOAINHANVIEN = 2)
)

CREATE TABLE LICHHEN (
    MALICHHEN VARCHAR(5),
    NGAY DATE,
    GIO INT,
    MAKHACHHANG VARCHAR(5),
    MANHASI VARCHAR(5),
    MANVDATLICH VARCHAR(5),

    CONSTRAINT PK_LICHHEN
    PRIMARY KEY(MALICHHEN),

    CONSTRAINT FK_LICHHEN_KHACHHANG
    FOREIGN KEY(MAKHACHHANG)
    REFERENCES KHACHHANG,

    CONSTRAINT FK_LICHHEN_NHANVIEN_MANHASI
    FOREIGN KEY(MANHASI)
    REFERENCES NHANVIEN,

    CONSTRAINT FK_LICHHEN_NHANVIEN_MANVDATLICH
    FOREIGN KEY(MANVDATLICH)
    REFERENCES NHANVIEN,

    CONSTRAINT CHK_LICHHEN_GIO
    CHECK (480 <= GIO AND GIO <= 1020) -- 8.00 - 17.00
)

CREATE TABLE HOSOBENHAN (
    MAHSBA VARCHAR(5),
    MAKHACHHANG VARCHAR(5),
    MANHASI VARCHAR(5),

    CONSTRAINT PK_HOSOBENHAN
    PRIMARY KEY(MAHSBA),

    CONSTRAINT FK_HOSOBENHAN_KHACHHANG
    FOREIGN KEY(MAKHACHHANG)
    REFERENCES KHACHHANG,

    CONSTRAINT FK_HOSOBENHAN_NHANVIEN
    FOREIGN KEY(MANHASI)
    REFERENCES NHANVIEN
)

CREATE TABLE GIAYKHAMBENH (
    MAHSBA VARCHAR(5),
    MAGIAYKHAMBENH VARCHAR(5),
    NGAYKHAM DATE,
    TONGTIENTHUOC INT,
    TONGTIENDICHVU INT,

    CONSTRAINT PK_GIAYKHAMBENH
    PRIMARY KEY(MAHSBA, MAGIAYKHAMBENH),

    CONSTRAINT FK_GIAYKHAMBENH_HOSOBENHAN
    FOREIGN KEY(MAHSBA)
    REFERENCES HOSOBENHAN,

    CONSTRAINT CHK_GIAYKHAMBENH_TONGTIENTHUOC_TONGTIENDICHVU
    CHECK (TONGTIENTHUOC >= 0 AND TONGTIENDICHVU >= 0)
)

CREATE TABLE HOADON (
    MAHOADON VARCHAR(5),
    NGAYLAP DATE,
    TONGTIEN INT,
    MAHSBA VARCHAR(5),
    MAGIAYKHAMBENH VARCHAR(5),
    MANVLAP VARCHAR(5),

    CONSTRAINT PK_HOADON
    PRIMARY KEY(MAHOADON),

    CONSTRAINT FK_HOADON_GIAYKHAMBENH
    FOREIGN KEY(MAHSBA, MAGIAYKHAMBENH)
    REFERENCES GIAYKHAMBENH,

    CONSTRAINT FK_HOADON_NHANVIEN
    FOREIGN KEY(MANVLAP)
    REFERENCES NHANVIEN,

    CONSTRAINT CHK_HOADON_TONGTIEN
    CHECK (TONGTIEN >= 0)
)

CREATE TABLE DICHVUKHAM (
    MADICHVU VARCHAR(5),
    TENDICHVU NVARCHAR(50),
    GIATIEN INT,

    CONSTRAINT PK_DICHVUKHAM
    PRIMARY KEY(MADICHVU),

    CONSTRAINT CHK_DICHVUKHAM_GIATIEN
    CHECK (GIATIEN >= 0)
)

CREATE TABLE DICHVUSUDUNG (
    MAHSBA VARCHAR(5),
    MAGIAYKHAMBENH VARCHAR(5),
    MADICHVU VARCHAR(5),
    GHICHU NVARCHAR(100),

    CONSTRAINT PK_DICHVUSUDUNG
    PRIMARY KEY(MAHSBA, MAGIAYKHAMBENH, MADICHVU),

    CONSTRAINT FK_DICHVUSUDUNG_GIAYKHAMBENH
    FOREIGN KEY(MAHSBA, MAGIAYKHAMBENH)
    REFERENCES GIAYKHAMBENH,

    CONSTRAINT FK_DICHVUSUDUNG_DICHVUKHAM
    FOREIGN KEY(MADICHVU)
    REFERENCES DICHVUKHAM
)

CREATE TABLE THUOC (
    MATHUOC VARCHAR(5),
    TENTHUOC NVARCHAR(25),
    DONVITINH NVARCHAR(5),
    CHIDINH NVARCHAR(100),
    SOLUONGTONKHO INT,
    NGAYHETHAN DATE,
    GIATIEN INT,
    MANVQUANLY VARCHAR(5),

    CONSTRAINT PK_THUOC
    PRIMARY KEY(MATHUOC),

    CONSTRAINT FK_THUOC_NHANVIEN
    FOREIGN KEY(MANVQUANLY)
    REFERENCES NHANVIEN,

    CONSTRAINT CHK_THUOC_DONVITINH
    CHECK (DONVITINH = N'VIÊN' OR DONVITINH = N'GÓI' OR DONVITINH = N'HỘP'),

    CONSTRAINT CHK_THUOC_SOLUONGTONKHO_GIATIEN
    CHECK (SOLUONGTONKHO >= 0 AND GIATIEN >= 0)
)

CREATE TABLE TOATHUOC (
    MAHSBA VARCHAR(5),
    MAGIAYKHAMBENH VARCHAR(5),
    MATHUOC VARCHAR(5),
    SOLUONG INT,
    
    CONSTRAINT PK_TOATHUOC
    PRIMARY KEY(MAHSBA, MAGIAYKHAMBENH, MATHUOC),

    CONSTRAINT FK_TOATHUOC_GIAYKHAMBENH
    FOREIGN KEY(MAHSBA, MAGIAYKHAMBENH)
    REFERENCES GIAYKHAMBENH,

    CONSTRAINT FK_TOATHUOC_THUOC
    FOREIGN KEY(MATHUOC)
    REFERENCES THUOC,

    CONSTRAINT CHK_TOATHUOC_SOLUONG
    CHECK (SOLUONG >= 0)
)

GO