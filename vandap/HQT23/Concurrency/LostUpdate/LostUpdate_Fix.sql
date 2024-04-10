﻿USE NHAKHOA
GO

--TRAN1
CREATE OR ALTER PROC SP_UPDATE_MEDICINE_THEM_SLTK_FIX
	@MATHUOC VARCHAR(10), 
    @SOLUONGTHEM INT -- SỐ LƯỢNG 
AS 
BEGIN TRAN
	IF NOT EXISTS (SELECT * FROM THUOC 
							WHERE MATHUOC = @MATHUOC) 
	BEGIN
        RAISERROR('INVALID MATHUOC', 16, 1)
        ROLLBACK TRAN
        RETURN -1
    END

	IF @SOLUONGTHEM <= 0 
	BEGIN
		RAISERROR('SO LUONG THEM PHAI LON HON 0', 16, 1)
        ROLLBACK TRAN
        RETURN -1
	END

	DECLARE @SOLUONGTON INT
	SET @SOLUONGTON = (SELECT SOLUONGTON FROM THUOC WITH (XLOCK) 
										WHERE MATHUOC = @MATHUOC)

	WAITFOR DELAY '00:00:05'

    UPDATE THUOC SET SOLUONGTON = @SOLUONGTON + @SOLUONGTHEM  WHERE MATHUOC = @MATHUOC
    SET @SOLUONGTON = (SELECT SOLUONGTON FROM THUOC  
										WHERE MATHUOC = @MATHUOC)
	PRINT(@SOLUONGTON)
COMMIT TRAN
RETURN 0
GO

--TRAN2
CREATE OR ALTER PROC SP_UPDATE_MEDICINE_GIAM_SLTK_FIX
	@MATHUOC VARCHAR(10), 
    @SOLUONGGIAM INT -- SỐ LƯỢNG  
AS
BEGIN TRAN
	IF NOT EXISTS (SELECT * FROM THUOC WHERE MATHUOC = @MATHUOC) 
	BEGIN
        RAISERROR('INVALID MATHUOC', 16, 1)
        ROLLBACK TRAN
        RETURN -1
    END

	IF @SOLUONGGIAM <= 0 
	BEGIN
		RAISERROR('SO LUONG GIAM PHAI LON HON 0', 16, 1)
        ROLLBACK TRAN
        RETURN -1
	END
	
	DECLARE @SOLUONGTON INT
	SET @SOLUONGTON = (SELECT SOLUONGTON FROM THUOC  WITH (XLOCK) WHERE MATHUOC = @MATHUOC)
	PRINT(@SOLUONGTON)

	IF @SOLUONGTON - @SOLUONGGIAM <= 0 
	BEGIN
		RAISERROR('SO LUONG TON KHONG DU', 16, 1)
        ROLLBACK TRAN
        RETURN -1
	END

	WAITFOR DELAY '00:00:05'

    UPDATE THUOC SET SOLUONGTON = @SOLUONGTON - @SOLUONGGIAM  WHERE MATHUOC = @MATHUOC
    
COMMIT TRAN
RETURN 0
GO