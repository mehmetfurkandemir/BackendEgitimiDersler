--Tabloları Oluşturma

CREATE TABLE Personel(
    PersonelID INT PRIMARY KEY IDENTITY(1,1),
    Ad NVARCHAR(50) NOT NULL,
    Soyad NVARCHAR(50) NOT NULL,
    Pozisyon NVARCHAR(50) NOT NULL,
    BaslangicTarihi DATE NOT NULL
)

CREATE TABLE Maaslar(
    MaasID INT PRIMARY KEY IDENTITY(1,1),
    PersonelID INT NOT NULL,
    MaasMiktari DECIMAL(10,2) NOT NULL,
    GuncellemeTarihi DATE NOT NULL,
    FOREIGN KEY (PersonelID) REFERENCES Personel(PersonelID)
)

--10 personel ekleme

INSERT INTO Personel (Ad, Soyad, Pozisyon, BaslangicTarihi)
VALUES
('Arda', 'Yılmaz', 'Okul Müdürü', '2022-10-10'),
('Recep', 'Sefercik', 'Öğretmen', '2023-10-12'),
('Emre', 'Durlanık', 'Öğretmen', '2023-09-10'),
('Furkan', 'Demir', 'Öğretmen', '2023-10-04'),
('Ali', 'Veli', 'Öğretmen', '2023-10-05'),
('Ayşe', 'Fatma', 'Öğretmen', '2023-10-12'),
('Meryem', 'Demir', 'Sekreter', '2023-10-01'),
('Elif', 'Koç', 'Öğretmen', '2023-10-06'),
('Cem', 'Yavuz', 'Sekreter', '2023-10-08'),
('Seda', 'Öztürk', 'Öğretmen', '2023-09-04')


--Maaş ekleme

INSERT INTO Maaslar (PersonelID, MaasMiktari, GuncellemeTarihi)
VALUES
(1, 20000, '2023-01-01'),
(2, 12000, '2023-01-01'),
(3, 13000, '2023-01-01'),
(4, 14000, '2023-01-01'),
(5, 14000, '2023-01-01'),
(6, 13000, '2023-01-01'),
(7, 12000, '2023-01-01'),
(8, 11000, '2023-01-01'),
(9, 13000, '2023-01-01'),
(10, 12000, '2023-01-01')

--Maaş Güncelleme

INSERT INTO Maaslar (PersonelID, MaasMiktari, GuncellemeTarihi)
VALUES
(1, 30000, '2023-01-01'),
(2, 22000, '2023-01-01'),
(3, 23000, '2023-01-01'),
(4, 24000, '2023-01-01'),
(5, 24000, '2023-01-01'),
(6, 23000, '2023-01-01'),
(7, 22000, '2023-01-01'),
(8, 21000, '2023-01-01'),
(9, 23000, '2023-01-01'),
(10, 22000, '2023-01-01')

-- Güncel Maaş Listeleme

SELECT p.PersonelID, p.Ad, p.Soyad, p.Pozisyon, m.MaasMiktari, m.GuncellemeTarihi
FROM Personel p
JOIN Maaslar m ON p.PersonelID = m.PersonelID
WHERE m.GuncellemeTarihi = (
    SELECT MAX(GuncellemeTarihi)
    FROM Maaslar
    WHERE PersonelID = p.PersonelID
)

ORDER BY p.PersonelID

-- ortalama maaş

SELECT 
    AVG(MaasMiktari) AS OrtalamaMaas
FROM 
    Maaslar m

--3

SELECT P.Pozisyon,
    MAX(M.MaasMiktari) AS EnYüksekMaaş,
    MIN(M.MaasMiktari) AS EnDüşükMaaş
FROM Personel p
JOIN Maaslar m ON p.PersonelID = m.PersonelID
GROUP BY p.Pozisyon

--4

SELECT 
    Ad, 
    Soyad, 
    Pozisyon
FROM 
    Personel p

--5

SELECT Pozisyon, COUNT(*) AS PersonelSayısı
FROM Personel
GROUP BY Pozisyon

--6

SELECT 
    p.PersonelID,
    p.Ad,
    p.Soyad,
    p.Pozisyon,
    m.MaasMiktari,
    m.GuncellemeTarihi
FROM 
    Personel p
JOIN 
    Maaslar m ON p.PersonelID = m.PersonelID
WHERE 
    m.GuncellemeTarihi = (
        SELECT MAX(GuncellemeTarihi) 
        FROM Maaslar 
        WHERE PersonelID = p.PersonelID
    )
ORDER BY 
    p.PersonelID

--7

SELECT PersonelID, Ad, Soyad, Pozisyon,BaslangicTarihi
FROM Personel p
WHERE 
Pozisyon = 'Öğretmen'

--8

SELECT AVG(MaasMiktari) AS OrtalamaMaaş
FROM Maaslar

--9 LIMIT SORGUSU ÇALIŞMIYOR, TOP SORGUSU İLE ÇALIŞTIRDIM

SELECT TOP 1 p.Ad, p.Soyad, m.MaasMiktari
FROM Personel p
JOIN Maaslar m ON p.PersonelID = m.PersonelID
ORDER BY m.MaasMiktari DESC

--10
SELECT m.MaasID, m.MaasMiktari, m.GuncellemeTarihi
FROM Maaslar m
WHERE m.PersonelID = 3
ORDER BY m.GuncellemeTarihi ASC

--11

SELECT p.Pozisyon,
MAX(m.MaasMiktari) AS EnYüksekMaaş,
MIN(m.MaasMiktari) AS EnDüşükMaaş
FROM Personel p
JOIN Maaslar m ON p.PersonelID=m.PersonelID
GROUP BY p.Pozisyon
HAVING COUNT(p.PersonelID) >1

--12

SELECT 
    P.PersonelID,
    P.Ad,
    P.Soyad,
    M.MaasMiktari,
    M.GuncellemeTarihi
FROM 
    Personel P
JOIN 
    Maaslar M ON P.PersonelID = M.PersonelID
WHERE 
    M.GuncellemeTarihi >= DATEADD(MONTH, -22, GETDATE());

--13

SELECT 
    p.PersonelID,
    p.Ad,
    p.Soyad,
    COUNT(M.MaasID) AS MaasGuncellemeSayisi
FROM 
    Personel p
JOIN 
    Maaslar m ON p.PersonelID = m.PersonelID
GROUP BY 
    p.PersonelID, p.Ad, p.Soyad
HAVING 
    COUNT(m.MaasID) >= 2