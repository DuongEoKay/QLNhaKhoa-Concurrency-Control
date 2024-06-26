﻿USE NHAKHOA
GO 

CREATE OR ALTER PROC SP_INSERT_DICHVU
	@IDDICHVU VARCHAR(5) = NULL,
    @TENDICHVU NVARCHAR(100),
    @PHIDICHVU INT    
AS BEGIN TRAN
    IF @PHIDICHVU < 0 
	BEGIN
        RAISERROR('INVALID PHI DICH VU', 16, 1)
        ROLLBACK TRAN
        RETURN -1
    END

    SELECT @IDDICHVU = IDDICHVU FROM DichVu
    WHERE IDDICHVU = (SELECT MAX(IDDICHVU) FROM DichVu)

    SET @IDDICHVU = dbo.F_GenerateID('DV', @IDDICHVU)

    INSERT INTO DichVu
    VALUES (@IDDICHVU, @TENDICHVU, @PHIDICHVU)
COMMIT TRAN
RETURN 0
GO

SELECT * FROM DichVu
--DELETE FROM DichVu WHERE IDDichVu = 'DV01'
EXEC SP_INSERT_DICHVU NULL, N'KHÁM TỔNG QUÁT', 100000