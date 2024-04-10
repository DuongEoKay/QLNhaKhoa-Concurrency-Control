/* 21HTTT1 - Nhóm 3
 * 21127004 - Trần Nguyễn An Phong
 * 21127135 - Diệp Hữu Phúc
 * 21127149 - Huỳnh Minh Quang
 * 21127296 - Đặng Hà Huy
 */
USE [Nhom3_QLNhaKhoa]
GO

SELECT * FROM THUOC WHERE MATHUOC = 'TH009'

DECLARE @ERR INT

EXEC @ERR = USP_THUOC_UPD 'TH009', N'Daflon', N'Viên',
    N'Không dành cho phụ nữ có thai', 100, '2025/04/20',
    3000, 'AD006', 'AD006'

IF @ERR != 0 PRINT('UPDATE FAILED!')
ELSE PRINT('UPDATE SUCCESSFUL!')

SELECT * FROM THUOC WHERE MATHUOC = 'TH009'