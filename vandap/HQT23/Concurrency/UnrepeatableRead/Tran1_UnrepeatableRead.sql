﻿use NHAKHOA
go 
 SELECT *
 FROM Thuoc
--UNREPEATABLE RAED 
EXEC SP_VIEW_THUOC_UNR 'TH03'

--FIX
EXEC SP_VIEW_THUOC_UNR_FIX 'TH03'
