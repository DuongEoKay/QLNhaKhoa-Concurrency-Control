/* 21HTTT1 - Nhóm 3
 * 21127004 - Trần Nguyễn An Phong
 * 21127135 - Diệp Hữu Phúc
 * 21127149 - Huỳnh Minh Quang
 * 21127296 - Đặng Hà Huy
 */
USE [Nhom3_QLNhaKhoa]
GO

CREATE OR ALTER PROC USP_DICHVUKHAM_INS
    @TENDICHVU NVARCHAR(100),
    @GIATIEN INT,
    @MADICHVU VARCHAR(5) = NULL OUTPUT
AS BEGIN TRAN
    IF @GIATIEN < 0 BEGIN
        RAISERROR('INVALID GIATIEN', 16, 1)
        ROLLBACK TRAN
        RETURN -1
    END

    SELECT @MADICHVU = MADICHVU FROM DICHVUKHAM
    WHERE MADICHVU = (SELECT MAX(MADICHVU) FROM DICHVUKHAM)

    SET @MADICHVU = dbo.F_MAKE_ID('DV', @MADICHVU)

    INSERT INTO DICHVUKHAM
    VALUES (@MADICHVU, @TENDICHVU, @GIATIEN)
COMMIT TRAN
RETURN 0
GO