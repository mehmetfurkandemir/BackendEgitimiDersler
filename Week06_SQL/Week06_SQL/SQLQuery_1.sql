-- SELECT *
-- FROM Dersler d
-- (WHERE d.Kredi>=3 AND d.Kredi<6)
-- WHERE d.Kredi BETWEEN 3 AND 6
-- INSERT INTO Ogrenciler(Ad, Soyad, DogumTarihi,BolumID)
-- VALUES
--     ('Cemal','Deniz','1998-05-06',3)

CREATE PROCEDURE OgrenciEkle
    @Ad NVARCHAR(50),
    @Soyad NVARCHAR(50),
    @DogumTarihi DATE,
    @BolumID INT
AS
BEGIN
    --Öğrenciyi Ekliyoruz
    INSERT INTO Ogrenciler(Ad,Soyad,DogumTarihi,BolumID)
    VALUES(@Ad,@Soyad,@DogumTarihi,@BolumID)
END