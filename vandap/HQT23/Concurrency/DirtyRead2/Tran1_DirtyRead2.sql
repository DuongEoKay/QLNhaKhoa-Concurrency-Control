﻿use NHAKHOA
go

SELECT * FROM LichHen WHERE IDKhachHang = 'KH01' AND NguoiKham = 'NS01'

DECLARE @RS INT
EXEC @RS = SP_INSERT_LICHHEN_DR null, N'2025/02/14',  'KH01', 'NS01', NULL
IF @RS = -1
	PRINT N'CẬP NHẬT THẤT BẠI'
ELSE
	PRINT N'CẬP NHẬT THÀNH CÔNG'