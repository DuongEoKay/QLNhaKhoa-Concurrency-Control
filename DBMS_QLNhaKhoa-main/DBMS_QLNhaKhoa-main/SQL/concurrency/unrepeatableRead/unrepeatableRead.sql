/* 21HTTT1 - Nhóm 3
 * 21127004 - Trần Nguyễn An Phong
 * 21127135 - Diệp Hữu Phúc
 * 21127149 - Huỳnh Minh Quang
 * 21127296 - Đặng Hà Huy
 */
USE [Nhom3_QLNhaKhoa]
GO

-- TRAN 1
CREATE OR ALTER PROC USP_THUOC_SEARCH
    @MATHUOC VARCHAR(5) = NULL,
    @TENTHUOC NVARCHAR(25) = NULL,
    @DONVITINH NVARCHAR(5) = NULL,
    @CHIDINH NVARCHAR(100) = NULL,
    @SOLUONGTONKHO INT = NULL,
    @NGAYHETHAN DATE = NULL,
    @GIATIEN INT = NULL,
    @MANVQUANLY VARCHAR(5) = NULL
AS BEGIN TRAN
    DECLARE @SQL NVARCHAR(MAX)
    SET @SQL = N' FROM THUOC WHERE 1 = 1'

    IF @MATHUOC IS NOT NULL
        SET @SQL += N' AND MATHUOC LIKE ''%''+@MATHUOC+''%'''
    IF @TENTHUOC IS NOT NULL
        SET @SQL += N' AND TENTHUOC LIKE ''%''+@TENTHUOC+''%'''
    IF @DONVITINH IS NOT NULL
        SET @SQL += N' AND DONVITINH LIKE ''%''+@DONVITINH+''%'''
    IF @CHIDINH IS NOT NULL
        SET @SQL += N' AND CHIDINH LIKE ''%''+@CHIDINH+''%'''
    IF @SOLUONGTONKHO IS NOT NULL
        SET @SQL += N' AND SOLUONGTONKHO <= @SOLUONGTONKHO'
    IF @NGAYHETHAN IS NOT NULL
        SET @SQL += N' AND NGAYHETHAN <= @NGAYHETHAN'
    IF @GIATIEN IS NOT NULL
        SET @SQL += N' AND GIATIEN <= GIATIEN'
    IF @MANVQUANLY IS NOT NULL
        SET @SQL += N' AND MANVQUANLY LIKE ''%''+@MANVQUANLY+''%'''

    DECLARE @SQLCHK NVARCHAR(MAX), @RC INT
    SET @SQLCHK = N'SELECT @RC = COUNT(*)' + @SQL
    SET @SQL = N'SELECT *' + @SQL

    EXEC sp_executesql @SQLCHK,
        N'@MATHUOC VARCHAR(5), @TENTHUOC NVARCHAR(25),
        @DONVITINH NVARCHAR(5), @CHIDINH NVARCHAR(100),
        @SOLUONGTONKHO INT, @NGAYHETHAN DATE,
        @GIATIEN INT, @MANVQUANLY VARCHAR(5), @RC INT OUTPUT',
        @MATHUOC, @TENTHUOC, @DONVITINH, @CHIDINH,
        @SOLUONGTONKHO, @NGAYHETHAN, @GIATIEN, @MANVQUANLY, @RC OUTPUT

    IF @RC = 0 BEGIN
        RAISERROR('NO RESULT FOUND!', 16, 1)
        ROLLBACK TRAN
        RETURN -1
    END

    WAITFOR DELAY '00:00:10'
    EXEC sp_executesql @SQL,
        N'@MATHUOC VARCHAR(5), @TENTHUOC NVARCHAR(25),
        @DONVITINH NVARCHAR(5), @CHIDINH NVARCHAR(100),
        @SOLUONGTONKHO INT, @NGAYHETHAN DATE,
        @GIATIEN INT, @MANVQUANLY VARCHAR(5)',
        @MATHUOC, @TENTHUOC, @DONVITINH, @CHIDINH,
        @SOLUONGTONKHO, @NGAYHETHAN, @GIATIEN, @MANVQUANLY
COMMIT TRAN
RETURN 0
GO

-- TRAN 2
CREATE OR ALTER PROC USP_THUOC_UPD
    @MATHUOC VARCHAR(5),
    @TENTHUOC NVARCHAR(25),
    @DONVITINH NVARCHAR(5),
    @CHIDINH NVARCHAR(100),
    @SOLUONGTONKHO INT,
    @NGAYHETHAN DATE,
    @GIATIEN INT,
    @MANVQUANLY VARCHAR(5),
    @NGUOIUPDATE VARCHAR(5)
AS BEGIN TRAN
    IF NOT EXISTS (SELECT * FROM THUOC WHERE MATHUOC = @MATHUOC) BEGIN
        RAISERROR('INVALID MATHUOC', 16, 1)
        ROLLBACK TRAN
        RETURN -1
    END

    IF @DONVITINH != N'VIÊN' AND @DONVITINH != N'GÓI'
        AND @DONVITINH != N'HỘP' BEGIN
        RAISERROR(N'INVALID DONVITINH, MUST BE EITHER VIÊN, HỘP, OR GÓI', 16, 1)
        ROLLBACK TRAN
        RETURN -2
    END

    IF @SOLUONGTONKHO < 0 BEGIN
        RAISERROR('INVALID SOLUONGTONKHO', 16, 1)
        ROLLBACK TRAN
        RETURN -3
    END

    IF @GIATIEN < 0 BEGIN
        RAISERROR('INVALID GIATIEN', 16, 1)
        ROLLBACK TRAN
        RETURN -4
    END

    IF @TENTHUOC IS NULL OR @CHIDINH IS NULL OR @NGAYHETHAN IS NULL
        OR @NGUOIUPDATE IS NULL BEGIN
        RAISERROR('INVALID DATA', 16, 1)
        ROLLBACK TRAN
        RETURN -5
    END

    IF @NGUOIUPDATE NOT LIKE 'AD%' OR @NGUOIUPDATE != @MANVQUANLY BEGIN
        RAISERROR('ONLY ADMIN MANAGING THIS THUOC CAN UPDATE IT', 16, 1)
        ROLLBACK TRAN
        RETURN -6
    END

    UPDATE THUOC SET TENTHUOC = @TENTHUOC, DONVITINH = @DONVITINH,
        CHIDINH = @CHIDINH, SOLUONGTONKHO = @SOLUONGTONKHO,
        NGAYHETHAN = @NGAYHETHAN, GIATIEN = @GIATIEN,
        MANVQUANLY = @MANVQUANLY
    WHERE MATHUOC = @MATHUOC
COMMIT TRAN
RETURN 0
GO