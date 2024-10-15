--tablo oluşturma
CREATE TABLE Kulüpler (
    KulupID INT PRIMARY KEY IDENTITY(1,1),
    KulupAdi NVARCHAR(100) NOT NULL,
    KurulusYili INT NOT NULL
)


CREATE TABLE Ogrenciler (
    OgrenciID INT PRIMARY KEY IDENTITY(1,1),
    Ad NVARCHAR(50) NOT NULL,
    Soyad NVARCHAR(50) NOT NULL,
    DogumTarihi DATE NOT NULL
);


CREATE TABLE OgrenciKulup (
    OgrenciID INT,
    KulupID INT,
    Rol NVARCHAR(50) NOT NULL,
    KatilimTarihi DATE NOT NULL,
    PRIMARY KEY (OgrenciID, KulupID),
    FOREIGN KEY (OgrenciID) REFERENCES Ogrenciler(OgrenciID),  -- Ogrenciler tablosu ile ilişkilendirilir
    FOREIGN KEY (KulupID) REFERENCES Kulüpler(KulupID)        -- Kulüpler tablosu ile ilişkilendirilir
)

INSERT INTO Ogrenciler (Ad, Soyad, DogumTarihi) VALUES
('Ali', 'Yılmaz', '2005-05-15'),
('Ayşe', 'Demir', '2004-04-20'),
('Mehmet', 'Kara', '2003-03-30'),
('Fatma', 'Çelik', '2005-01-10'),
('Can', 'Aydın', '2006-06-25'),
('Zeynep', 'Öztürk', '2005-07-12'),
('Emre', 'Koç', '2004-08-18'),
('Selin', 'Tekin', '2003-09-04'),
('Burak', 'Yavuz', '2005-10-11'),
('Ece', 'Polat', '2006-11-22'),
('Ali', 'Şahin', '2004-12-01'),
('Berk', 'Kurt', '2005-03-05'),
('Derya', 'Sönmez', '2003-06-16'),
('Cem', 'Peker', '2006-02-23'),
('Merve', 'Sarı', '2005-09-08')



--kulüp oluşturma

INSERT INTO Kulüpler (KulupAdi, KurulusYili) VALUES
('Yüzme Kulübü', 2002),
('Robotik Kulübü', 2010),
('Fotoğrafçılık Kulübü', 2016),
('Tarih Kulübü', 2008),
('Oyun Geliştirme Kulübü', 2019)

INSERT INTO OgrenciKulup (OgrenciID, KulupID, Rol, KatilimTarihi) VALUES

(1, 1, 'Başkan', '2023-09-01'),
(2, 1, 'Üye', '2023-09-05'),
(3, 1, 'Sekreter', '2023-09-10'),

(4, 2, 'Başkan', '2023-09-02'),
(5, 2, 'Üye', '2023-09-06'),
(6, 2, 'Sekreter', '2023-09-11'),

(7, 3, 'Başkan', '2023-09-03'),
(8, 3, 'Üye', '2023-09-07'),
(9, 3, 'Sekreter', '2023-09-12'),

(10, 4, 'Başkan', '2023-09-04'),
(11, 4, 'Üye', '2023-09-08'),
(12, 4, 'Sekreter', '2023-09-13'),

(13, 5, 'Başkan', '2023-09-05'),
(14, 5, 'Üye', '2023-09-09'),
(15, 5, 'Sekreter', '2023-09-14')


SELECT 
    Ogrenciler.Ad, 
    Ogrenciler.Soyad, 
    Kulüpler.KulupAdi
FROM 
    OgrenciKulup
JOIN 
    Ogrenciler ON OgrenciKulup.OgrenciID = Ogrenciler.OgrenciID
JOIN 
    Kulüpler ON OgrenciKulup.KulupID = Kulüpler.KulupID


--Tiyatro

SELECT 
    Ogrenciler.Ad, 
    Ogrenciler.Soyad, 
    OgrenciKulup.Rol
FROM 
    OgrenciKulup
JOIN 
    Ogrenciler ON OgrenciKulup.OgrenciID = Ogrenciler.OgrenciID
JOIN 
    Kulüpler ON OgrenciKulup.KulupID = Kulüpler.KulupID
WHERE 
    Kulüpler.KulupAdi = 'Tiyatro Kulübü'

--Başkanları görüntüleme

SELECT 
    Ogrenciler.Ad, 
    Ogrenciler.Soyad, 
    Kulüpler.KulupAdi
FROM 
    OgrenciKulup
JOIN 
    Ogrenciler ON OgrenciKulup.OgrenciID = Ogrenciler.OgrenciID
JOIN 
    Kulüpler ON OgrenciKulup.KulupID = Kulüpler.KulupID
WHERE 
    OgrenciKulup.Rol = 'Başkan'

--Kaç Üye Var
SELECT 
Kulüpler.KulupAdi, 
COUNT(OgrenciKulup.OgrenciID) AS UyeSayisi
FROM 
    Kulüpler
LEFT JOIN 
    OgrenciKulup ON Kulüpler.KulupID = OgrenciKulup.KulupID
GROUP BY 
    Kulüpler.KulupAdi

--Öğrenciler hangi tarihte kulbüe katıldı

SELECT 
    Ogrenciler.Ad, 
    Ogrenciler.Soyad, 
    Kulüpler.KulupAdi, 
    OgrenciKulup.KatilimTarihi
FROM 
    OgrenciKulup
JOIN 
    Ogrenciler ON OgrenciKulup.OgrenciID = Ogrenciler.OgrenciID
JOIN 
    Kulüpler ON OgrenciKulup.KulupID = Kulüpler.KulupID


--Müzik kulübü roller
SELECT DISTINCT 
    OgrenciKulup.Rol
FROM 
    OgrenciKulup
JOIN 
    Kulüpler ON OgrenciKulup.KulupID = Kulüpler.KulupID
WHERE 
    Kulüpler.KulupAdi = 'Müzik Kulübü'

--Kaç Başkan Var

SELECT 
    Kulüpler.KulupAdi, 
    COUNT(OgrenciKulup.OgrenciID) AS BaşkanSayisi
FROM 
    OgrenciKulup
JOIN 
    Kulüpler ON OgrenciKulup.KulupID = Kulüpler.KulupID
WHERE 
    OgrenciKulup.Rol = 'Başkan'
GROUP BY 
    Kulüpler.KulupAdi

--Hangi öğrenci kaç kez katılmış

SELECT 
    Ogrenciler.Ad, 
    Ogrenciler.Soyad, 
    Kulüpler.KulupAdi, 
    OgrenciKulup.KatilimTarihi
FROM 
    OgrenciKulup
JOIN 
    Ogrenciler ON OgrenciKulup.OgrenciID = Ogrenciler.OgrenciID
JOIN 
    Kulüpler ON OgrenciKulup.KulupID = Kulüpler.KulupID
ORDER BY 
    OgrenciKulup.KatilimTarihi DESC
OFFSET 0 ROWS FETCH NEXT 50 ROWS ONLY

--Birden fazla katılım (mevcut değil)

SELECT 
    Ogrenciler.Ad, 
    Ogrenciler.Soyad, 
    COUNT(OgrenciKulup.KulupID) AS KulupSayisi
FROM 
    OgrenciKulup
JOIN 
    Ogrenciler ON OgrenciKulup.OgrenciID = Ogrenciler.OgrenciID
GROUP BY 
    Ogrenciler.OgrenciID, Ogrenciler.Ad, Ogrenciler.Soyad
HAVING 
    COUNT(OgrenciKulup.KulupID) > 1