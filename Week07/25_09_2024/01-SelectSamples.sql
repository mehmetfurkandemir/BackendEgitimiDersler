--Products Tablosundaki Tüm Kayıtlar

-- SELECT *
-- FROM Products p

-- SELECT 
--     p.ProductID,
--     p.ProductName,
--     p.QuantityPerUnit
-- FROM Products p

--EN YÜKSEK FİYATLI PRODUCTın FİYATI

-- SELECT 
--     MAX(p.UnitPrice) AS 'Maximum Price',
--     MIN(p.UnitPrice) AS 'Minimum Price',
--     AVG(p.UnitPrice) AS 'Average Price',
--     COUNT(*) AS 'Adet'
-- FROM Products p

--ELİMİZDEKİ PROD TOPLAM DEĞERİ

-- SELECT 
--     SUM(p.UnitPrice*p.UnitsInStock) AS 'Total Değer'
-- FROM Products p

-- ELİMİZDEKİ PROD TOPLAM DEĞERİ + PROD İSMİ

-- SELECT 
--     p.ProductName,
--     SUM(p.UnitPrice*p.UnitsInStock) AS 'Toplam Değer'
-- FROM Products p
-- GROUP BY p.ProductName

--TEMEL FONKSİYON ÖRNEKLERİ

SELECT 
    p.ProductName AS 'Default',
    UPPER(p.ProductName) AS 'Büyük Harf',
    LOWER(p.ProductName) AS 'Küçük Harf',
    REPLACE (LOWER(p.ProductName), ' ', '_') AS 'Url'
FROM Products p
