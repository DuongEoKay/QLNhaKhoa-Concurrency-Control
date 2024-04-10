use NHAKHOA
go

CREATE OR ALTER FUNCTION F_GenerateID (@Loai VARCHAR(10), @ID_max VARCHAR(5))
RETURNS VARCHAR(5) AS BEGIN
    IF (@ID_max IS NULL) SET @ID_max = @Loai + '01'
    ELSE BEGIN
        SET @ID_max = CAST(RIGHT(@ID_max, 2) AS INT) + 1
        SET @ID_max = @Loai + RIGHT('00' + CAST(@ID_max AS VARCHAR(2)), 2)
    END
    RETURN @ID_max
END
GO