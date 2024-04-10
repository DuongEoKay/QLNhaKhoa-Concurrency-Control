USE NHAKHOA
GO 

--select * from thuoc
--DEADLOCK
EXEC SP_UPDATE_MEDICINE_CD  'TH04', N'Paracetamol', N'MLÍT', N'Khi nhức đầu', 150, '2025/05/16', 3000, 'AD01'

--FIX
EXEC SP_UPDATE_MEDICINE_CD_FIX  'TH04', N'Paracetamol', N'MLÍT', N'Khi nhức đầu', 150, '2025/05/16', 3000, 'AD01'
