/* 21HTTT1 - Nhóm 3
 * 21127004 - Trần Nguyễn An Phong
 * 21127135 - Diệp Hữu Phúc
 * 21127149 - Huỳnh Minh Quang
 * 21127296 - Đặng Hà Huy
 */
USE [Nhom3_QLNhaKhoa]
GO

CREATE OR ALTER FUNCTION F_MAKE_ID
    (@TYPE CHAR(2), @ID VARCHAR(5))
RETURNS VARCHAR(5) AS BEGIN
    IF (@ID IS NULL) SET @ID = @TYPE + '001'
    ELSE BEGIN
        SET @ID = CAST(RIGHT(@ID, 3) AS INT) + 1
        SET @ID = @TYPE + RIGHT('000'
            + CAST(@ID AS VARCHAR(3)), 3)
    END
    RETURN @ID
END
GO