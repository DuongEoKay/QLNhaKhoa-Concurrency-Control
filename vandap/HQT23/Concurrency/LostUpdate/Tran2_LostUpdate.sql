USE NHAKHOA
GO

--LOST UPDATE
select * from thuoc where mathuoc = 'TH02'

EXEC SP_UPDATE_MEDICINE_GIAM_SLTK 'TH02', 30

select * from thuoc where mathuoc = 'TH02'


--FIX
select * from thuoc where mathuoc = 'TH02'

EXEC SP_UPDATE_MEDICINE_GIAM_SLTK_FIX 'TH02', 20

select * from thuoc where mathuoc = 'TH02'