--SELECT * FROM Bolumler
--SELECT BolumAdi AS 'Bölüm adı' FROM Bolumler

-- SELECT * 
-- FROM Dersler

-- SELECT
--     DersID as Id, 
--     DersAdi as Ders, 
--     Kredi as Kredi,
--     Bolumler.BolumAdi as Bölüm
-- FROM Dersler JOIN Bolumler on Dersler.BolumID=Dersler.BolumID

-- SELECT 
--     d.DersID as ID,
--     d.DersAdi as Ders,
--     d.Kredi as Kredi,
--     b.BolumAdi as Bölüm
-- FROM Dersler d JOIN Bolumler b
--     ON d.BolumID=b.BolumID

-- SELECT 
--     d.DersID as ID,
--     d.DersAdi as Ders,
--     d.Kredi as Kredi,
--     b.BolumAdi as Bölüm

-- FROM Dersler d JOIN Bolumler b 
--     ON d.BolumID=b.BolumID
-- WHERE b.BolumAdi='Bilgisayar Mühendisliği' AND d.Kredi>=5 --WHERE = Filtreleme --AND = 5 ten büyük krediler

-- SELECT *
-- FROM Ogrenciler o JOIN Bolumler b
--     ON o.BolumID = b.BolumID
-- WHERE b.BolumAdi='Makine Mühendisliği'

--Termodinamik dersini alan öğrencileri listelemek ve kolonların arasında öğrencinin bölümü de yazsın

-- SELECT 
--     o.Ad + ' ' + o.Soyad AS 'Öğrenci',
--     b.BolumAdi AS Bölüm,
--     d.DersAdi AS Ders,
--     d.Kredi
-- FROM Ogrenciler o JOIN DersOgrenciler do
--     ON o.OgrenciID = do.OgrenciID JOIN Dersler d
--         ON do.DersID = d.DersID JOIN Bolumler b 
--             ON d.BolumID= b.BolumID
-- WHERE o.Ad = 'Fatma' AND o.Soyad = 'Demir'

SELECT *
FROM Dersler d
ORDER BY d.Kredi, d.DersAdi