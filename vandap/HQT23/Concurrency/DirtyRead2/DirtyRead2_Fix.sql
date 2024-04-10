﻿use NHAKHOA
go

--DIRTY READ 
CREATE OR ALTER PROC SP_INSERT_LICHHEN_DR
	@IDLICHHEN VARCHAR(10) = null output,
    @THOIGIANKHAM DATE,
    @IDKHACHHANG VARCHAR(5),
    @IDNHASI VARCHAR(5),
    @IDNVDATLICH VARCHAR(5) = NULL
AS BEGIN TRAN
	IF DATEDIFF(d, @THOIGIANKHAM, GETDATE()) > 0
	BEGIN
        RAISERROR('THOI GIAN KHONG HOP LE', 16, 1)
        ROLLBACK TRAN
        RETURN -1
    END

    IF NOT EXISTS (SELECT * FROM KHACHHANG
					WHERE IDKHACHHANG = @IDKHACHHANG) 
	BEGIN
        RAISERROR('INVALID IDKHACHHANG', 16, 1)
        ROLLBACK TRAN
        RETURN -1
    END

    IF NOT EXISTS (SELECT * FROM NhanSu
        WHERE IDNhanSu = @IDNHASI) 
	BEGIN
        RAISERROR('INVALID IDNHASI', 16, 1)
        ROLLBACK TRAN
        RETURN -1
    END

	IF EXISTS (SELECT * FROM LichHen 
				WHERE ThoiGianKham = @THOIGIANKHAM AND NguoiKham = @IDNHASI AND IDKhachHang = @IDKHACHHANG)
	BEGIN
        RAISERROR('LICH HEN DA TON TAI', 16, 1)
        ROLLBACK TRAN
        RETURN -1
    END

    IF @IDNVDATLICH IS NOT NULL AND NOT EXISTS
        (SELECT * FROM NhanSu WHERE IDNhanSu = @IDNVDATLICH) 
	BEGIN
        RAISERROR('INVALID IDNVDATLICH', 16, 1)
        ROLLBACK TRAN
        RETURN -1
    END

    SELECT @IDLICHHEN = IDLICHHEN FROM LICHHEN
    WHERE IDLICHHEN = (SELECT MAX(IDLICHHEN) FROM LICHHEN)

    SET @IDLICHHEN = dbo.F_GenerateID('LH', @IDLICHHEN)

    INSERT INTO LICHHEN
    VALUES (@IDLICHHEN, @THOIGIANKHAM, @IDKHACHHANG, @IDNHASI, @IDNVDATLICH)

	WAITFOR DELAY '00:00:10'
	IF NOT EXISTS (SELECT * FROM LichNhaSi 
					WHERE ThoiGianTrong = @THOIGIANKHAM AND IDNhaSi = @IDNHASI)
	BEGIN
        RAISERROR('NHASI IS NOT AVAILABLE AT THAT TIME', 16, 1)
        ROLLBACK TRAN
        RETURN -1
    END
COMMIT TRAN
GO

CREATE OR ALTER PROC SP_VIEW_LICHHEN_FIX
	@IDKHACHHANG VARCHAR(10),
	@IDNHASI VARCHAR(10)
AS
BEGIN TRAN
	IF NOT EXISTS (SELECT * FROM KhachHang WHERE IDKhachHang = @IDKHACHHANG) 
	BEGIN
        RAISERROR('INVALID IDKHACHHANG', 16, 1)
        ROLLBACK TRAN
        RETURN -1
    END

	IF NOT EXISTS (SELECT * FROM NhanSu WHERE IDNhanSu = @IDNHASI) 
	BEGIN
        RAISERROR('INVALID IDNHASI', 16, 1)
        ROLLBACK TRAN
        RETURN -1
    END

	select * from LichHen WHERE IDKhachHang = @IDKHACHHANG AND NguoiKham = @IDNHASI 
COMMIT TRAN
GO