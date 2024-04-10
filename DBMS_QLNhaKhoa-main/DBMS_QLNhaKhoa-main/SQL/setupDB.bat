
@echo off
cls
chcp 65001

@echo ---- Creating Nhom3_QLNhaKhoa...
SQLCMD -E -dmaster -f65001 -i".\createDB.sql"

@echo ---- Creating Functions...
for %%G in (.\funcs\*.sql) do SQLCMD -E -dmaster -f65001 -i"%%G"

@echo ---- Creating Stored Procedures...
for %%G in (.\storedProcs\*.sql) do SQLCMD -E -dmaster -f65001 -i"%%G"

@echo ---- Populating Data...

@echo ---- Populating Data KHACHHANG
SQLCMD -E -dmaster -f65001 -i".\populateData\data_KhachHang.sql"

@echo ---- Populating Data NHANVIEN
SQLCMD -E -dmaster -f65001 -i".\populateData\data_NhanVien.sql"

@echo ---- Populating Data NHASI
SQLCMD -E -dmaster -f65001 -i".\populateData\data_NhaSi.sql"

@echo ---- Populating Data QUANTRIVIEN
SQLCMD -E -dmaster -f65001 -i".\populateData\data_QuanTriVien.sql"

@echo ---- Populating Data LICHHEN
SQLCMD -E -dmaster -f65001 -i".\populateData\data_LichHen.sql"

@echo ---- Populating Data HOSOBENHAN
SQLCMD -E -dmaster -f65001 -i".\populateData\data_HoSoBenhAn.sql"

@echo ---- Populating Data GIAYKHAMBENH
SQLCMD -E -dmaster -f65001 -i".\populateData\data_GiayKhamBenh.sql"

@echo ---- Populating Data DICHVUKHAM
SQLCMD -E -dmaster -f65001 -i".\populateData\data_DichVuKham.sql"

@echo ---- Populating Data DICHVUSUDUNG
SQLCMD -E -dmaster -f65001 -i".\populateData\data_DichVuSuDung.sql"

@echo ---- Populating Data THUOC
SQLCMD -E -dmaster -f65001 -i".\populateData\data_Thuoc.sql"

@echo ---- Populating Data TOATHUOC
SQLCMD -E -dmaster -f65001 -i".\populateData\data_ToaThuoc.sql"

@echo ---- Populating Data HOADON
SQLCMD -E -dmaster -f65001 -i".\populateData\data_HoaDon.sql"

@echo ---- Granting Permissions...
SQLCMD -E -dmaster -f65001 -i".\permissions.sql"

PAUSE