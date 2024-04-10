/* 21HTTT1 - Nhóm 3
 * 21127004 - Trần Nguyễn An Phong
 * 21127135 - Diệp Hữu Phúc
 * 21127149 - Huỳnh Minh Quang
 * 21127296 - Đặng Hà Huy
 */
USE [Nhom3_QLNhaKhoa]
GO

DECLARE @ERR INT

EXEC @ERR = USP_NHANVIEN_UPD 'AD001', N'Trần Hoàng Thư',
    N'468, Lê Hồng Phong, phường 1, quận 2, Thành phố Hồ',
    '92717053370', 2, '1234'

IF @ERR != 0 PRINT('UPDATE NHANVIEN FAILED!')
ELSE PRINT('UPDATE NHANVIEN SUCCESSFUL!')