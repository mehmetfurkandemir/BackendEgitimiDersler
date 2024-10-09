-- Join: Tek parça olarak tasarlanmış verinin farklı tablolardaki parçalarını SELECT sorgusu ile birleştirerek elde etmeke JOIN denir.

-- Join Türleri:
-- (inner) join: Her iki tablodaki eşleşen değerlere sahip kayıtları döndürür
-- left join: Sol taraftaki tablodaki tüm kayıtları ve sağ taraftaki tablodan sadece eşleşen kayıtlar
-- right join: Sağ taraftaki tablodaki tüm kayıtları ve sol taraftaki tablodan sadece eşleşen kayıtlar
-- outer join: Sol ve Sağ taraftaki tablolarda yer alan tüm kayıtları

-- ÖRNEK: ProductName İLE BİRLİKTE CategoryName leri GETİREN SORGUYU HAZIRLAYALIM

-- SELECT *
-- FROM Categories c JOIN Products p ON c.CategoryID=p.CategoryID

-- ÖRNEK: YENİ BİR KATEGORİ EKLEMEK

-- INSERT INTO Categories(CategoryName, Description)
-- VALUES
--     ('Televizyon', 'Son teknoloji')

-- ÖRNEK: ProductName İLE Supplier Company Name SONUCUNU GETİREN SORGU

-- SELECT 
--     p.ProductName,
--     s.CompanyName
-- FROM Products p JOIN Suppliers s ON p.SupplierID=s.SupplierID

-- ÖRNEK: HANGİ SİPARİŞ, HANGİ ÇALIŞAN TARAFINDAN HANGİ MÜŞTERİYE GETİRİLMİŞTİR?

-- SELECT 
--     o.OrderID AS 'Sipariş ID',
--     o.OrderDate AS 'Tarih',
--     (e.FirstName + ' ' + e.LastName) AS 'Ad Soyad',
--     c.CompanyName AS 'Müşteri'
-- FROM Orders o JOIN Employees e ON o.EmployeeID=e.EmployeeID
--         JOIN Customers c ON o.CustomerID=c.CustomerID

--ÖRNEK: ÜRÜNLERİN KATEGORİLERİNE GÖRE TOPLAM STOK MİKTARI (LEFT JOIN yaparsak Televizyon gelecek)

-- SELECT 
--     c.CategoryName AS 'Kategori',
--     SUM(p.UnitsInStock) AS 'Toplam Stok'
-- FROM Categories c LEFT JOIN Products p ON c.CategoryID=p.CategoryID
-- GROUP BY c.CategoryName
-- ORDER BY 'Toplam Stok' DESC

-- ÖRNEK: BUGÜNE KADAR HANGİ ÜLKELERE KARGO GÖNDERDİK?

-- SELECT DISTINCT  
--     o.ShipCountry
-- FROM Orders o
-- ORDER BY o.ShipCountry

-- SELECT 
--     o.ShipCountry AS 'ÜLke',
--     SUM(od.UnitPrice*od.Quantity*(1-od.Discount)) AS 'Tutar'
-- FROM Orders o JOIN OrderDetails od ON o.OrderID=od.OrderID
-- GROUP BY o.ShipCountry 
-- ORDER BY 'Tutar' DESC

--ÖRNEK: STOKTAKİ ALMANYADAN TEDARİK EDİLEN ÜRÜNLERİN TOPLAMI

-- SELECT 
--     SUM(p.UnitPrice*UnitsInStock) AS 'Tutar'
-- FROM Products p JOIN Suppliers s ON p.SupplierID=s.SupplierID
-- WHERE s.Country = 'USA'

--ÖRNEK: TEDARİK YAPILAN ÜLKELERE GÖRE STOKTAKİ ÜRÜNLERİN TOPLAM TUTARLARI

-- SELECT 
--     s.Country AS 'Ülke',
--     SUM(p.UnitPrice*p.UnitsInStock) AS 'Tutar'
-- FROM Products p JOIN Suppliers s ON p.SupplierID=s.SupplierID
-- GROUP BY s.Country 
-- ORDER BY 'Tutar' DESC

--ÖRNEK: ALMANYADAN TEDARİK EDİLEN ÜRÜNLERİN SİPARİŞ TOPLAMLARI

-- SELECT 
--     SUM(od.UnitPrice*od.Quantity*(1-od.Discount)) AS 'Tutar'
-- FROM Products p JOIN Suppliers s ON p.SupplierID=s.SupplierID JOIN OrderDetails od ON p.ProductID=od.ProductID 
-- WHERE s.Country = 'Germany' 

--ÖRNEK: TOPLAM TUTARI 9000-10000 ARASINDA OLAN SİPARİŞLERİ LİSTELEYELİM

-- SELECT 
--     od.OrderID,
--     SUM(od.UnitPrice*od.Quantity*(1-od.Discount)) AS 'Tutar'
-- FROM Orders o JOIN OrderDetails od ON o.OrderID=od.OrderID
-- GROUP BY od.OrderID
-- HAVING SUM(od.UnitPrice*od.Quantity*(1-od.Discount)) BETWEEN 9000 AND 10000
-- ORDER BY 'Tutar' DESC