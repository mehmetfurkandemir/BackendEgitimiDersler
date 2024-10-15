--Tablo Oluşturma

CREATE TABLE Kitaplar(
    KitapID INT PRIMARY KEY IDENTITY(1,1),
    KitapAdi NVARCHAR(50) NOT NULL,
    Yazar NVARCHAR(50),
    YayinYili INT,
    SayfaSayisi INT,
    ISBN NVARCHAR(13)
)

CREATE TABLE Dergiler(
    DergiID INT PRIMARY KEY IDENTITY(1,1),
    DergiAdi NVARCHAR(50) NOT NULL,
    Yayinci NVARCHAR(50),
    YayinTarihi DATE,
    Sayi INT
)

CREATE TABLE DVDler(
    DVDID INT PRIMARY KEY IDENTITY(1,1),
    DVDAdi NVARCHAR(50) NOT NULL,
    Yonetmen NVARCHAR(50),
    YayinYili INT,
    Sure INT
)

CREATE TABLE Ogrenciler(
    OgrenciID INT PRIMARY KEY IDENTITY(1,1),
    Ad NVARCHAR(50) NOT NULL,
    Soyad NVARCHAR(50) NOT NULL,
    DogumTarihi DATE NULL,
    BolumID INT
)

INSERT INTO Ogrenciler (OgrenciID, Ad, Soyad, DogumTarihi, BolumID)
SELECT OgrenciID, Ad, Soyad, DogumTarihi, BolumID
FROM Okul.dbo.Ogrenciler

SET IDENTITY_INSERT Ogrenciler OFF;

--VERİ EKLEME

--Kitaplara Veri Ekleme

INSERT INTO Kitaplar (KitapAdi, Yazar, YayinYili, SayfaSayisi, ISBN)
VALUES
('İnce Memed', 'Yazar', '1955', 200, '3066152'),
('Tutunamayanlar', 'Oğuz Atay', '1990', 190, '3064157'),
('Saatleri Ayarlama Enstitüsü', 'Ahmet Hamdi Tanpınar', '1961', 250, '475712'),
('Memleketimden İnsan Manzaraları', 'Nazım Hikmet', '1960', 180, '12212'),
('Kürk Mantolu Madonna', 'Sabahattin Ali', '1920', 240, '11202'),
('Anayurt Oteli', 'Yusuf Atılgan', '1950', 180, '10121'),
('Huzur', 'Ahmet Hamdi Tanpınar', '1952', 170, '109412'),
('Alemdağda Var Bir Yılan', 'Sait Faik Abasıyanık', '1954', 80, '1335921'),
('Yunus Emre Divanı', 'Yunus Emre', '1540', 100, '4598459'),
('Aşkı Memnu', 'Halit Ziya', '1901', 190, '1045986'),
('Kara Kitap', 'Orhan Pamuk', '1985', 210, '494654594'),
('Çalıkuşu', 'Reşat Nuri Güntekin', '1922', 150, '88994'),
('Bereketli Topraklar Üzerinde', 'Orhan Kemal', '1954', 80, '185494'),
('Kuyucaklı Yusuf', 'Sabahattin Ali', '1937', 190, '16786034'),
('Aylak Adam', 'Yusuf Atılgan', '1959', 180, '158694'),
('Yaban', 'Yakup Kadri', '1930', 60, '13: 978485934'),
('Dede Korkut Kitabı', 'Korkut Ata', '1409', 126, '3384384'),
('Kendi Gök Kubbemiz', 'Yahya Kemal', '1961', 86, '107053'),
('Seyahatname', 'Evliya Çelebi', '1610', 120, '4932839'),
('Eylül', 'Mehmet Rauf', '1901', 80, '148686')

--Dergilere Veri Ekleme

INSERT INTO Dergiler(DergiAdi,Yayinci,YayinTarihi,Sayi)
VALUES
('Doğa ve Bilim', 'Doğa Yayınları', '2024-01-10', 88),
('Edebiyat Dünyası', 'Edebiyat Yayıncılık', '2024-02-15', 57),
('Tarih ve Toplum', 'Tarihsel Yayınlar', '2024-03-22', 134),
('Teknoloji Trendleri', 'Teknoloji Gazetesi', '2024-04-05', 42),
('Sanat ve Hayat', 'Sanat Yayınları', '2024-05-18', 66)

--DVDlere Veri Ekleme

INSERT INTO DVDler(DVDAdi, Yonetmen, YayinYili, Sure)
VALUES
('Dondurma', 'Derviş Zaim', 2009, 110),
('Süt', 'Umut Dağ', 2014, 85),
('Kayıp Şehir', 'Kıvanç Sezer', 2019, 102),
('Aşk Tesadüfleri Sever', 'Ömer Faruk Sorak', 2010, 104),
('Kış', 'Sırrı Süreyya Önder', 2017, 97)

--Ödünç İşlemleri

CREATE TABLE OduncAlmalar(
    OduncID INT PRIMARY KEY IDENTITY(1,1),
    OgrenciID INT NOT NULL,
    KitapID INT,
    DergiID INT,
    DVDID INT,
    OduncTarihi DATE NOT NULL,
    FOREIGN KEY (OgrenciID) REFERENCES Ogrenciler(OgrenciID),
    FOREIGN KEY (KitapID) REFERENCES Kitaplar(KitapID),
    FOREIGN KEY (DergiID) REFERENCES Dergiler(DergiID),
    FOREIGN KEY (DVDID) REFERENCES DVDler(DVDID)
)

--Ödünç Almak (20 kitap 5 dergi 5 dvd)

INSERT INTO OduncAlmalar (OgrenciID, KitapID, DergiID, DVDID, OduncTarihi)
VALUES
(1, 4, NULL, NULL, '2024-05-14'),
(3, NULL, 2, NULL, '2024-05-04'),
(6, NULL, NULL, 1, '2024-04-19'),
(4, 15, NULL, NULL, '2024-05-15'),
(7, NULL, 1, NULL, '2024-04-20'),
(12, NULL, NULL, 5, '2024-05-21'),
(14, 19, NULL, NULL, '2024-05-22'),
(17, NULL, 3, NULL, '2024-05-23'),
(8, NULL, NULL, 4, '2024-05-24'),
(9, 2, NULL, NULL, '2024-05-25')

--SORGULAR

--1
SELECT KitapAdi,Yazar,YayinYili
FROM Kitaplar k

--2
--2000'DEN SONRA KİTAP MEVCUT OLMADIĞI İÇİN 1950 OLARAK DEĞİŞTİRİYORUM
SELECT KitapAdi, Yazar
FROM Kitaplar k
WHERE YayinYili > 1950

--3
SELECT 
    Ogrenciler.OgrenciID,
    Ogrenciler.Ad,
    Kitaplar.KitapAdi,
    Kitaplar.Yazar,
    OduncAlmalar.OduncTarihi
FROM 
    OduncAlmalar
JOIN 
    Ogrenciler ON OduncAlmalar.OgrenciID = Ogrenciler.OgrenciID
JOIN 
    Kitaplar ON OduncAlmalar.KitapID = Kitaplar.KitapID
WHERE 
    OduncAlmalar.KitapID IS NOT NULL;

--4
SELECT TOP 5
    KitapID,
    KitapAdi,
    Yazar,
    YayinYili,
    SayfaSayisi,
    ISBN
FROM Kitaplar 
ORDER BY SayfaSayisi DESC

--5

SELECT *
FROM Kitaplar k
WHERE Yazar='Orhan Pamuk'

--6

SELECT 
    Ogrenciler.OgrenciID,
    Ogrenciler.Ad,
    Dergiler.DergiAdi,
    Dergiler.Yayinci,
    OduncAlmalar.OduncTarihi
FROM 
    OduncAlmalar
JOIN 
    Ogrenciler ON OduncAlmalar.OgrenciID = Ogrenciler.OgrenciID
JOIN 
    Dergiler ON OduncAlmalar.DergiID = Dergiler.DergiID
WHERE 
    OduncAlmalar.DergiID IS NOT NULL;

--7

SELECT 
    Ogrenciler.OgrenciID,
    Ogrenciler.Ad
FROM 
    Ogrenciler
LEFT JOIN 
    OduncAlmalar ON Ogrenciler.OgrenciID = OduncAlmalar.OgrenciID
WHERE 
    OduncAlmalar.OgrenciID IS NULL;

--8

SELECT 
    Kitaplar.KitapID,
    Kitaplar.KitapAdi,
    COUNT(OduncAlmalar.KitapID) AS OduncSayisi
FROM 
    Kitaplar
LEFT JOIN 
    OduncAlmalar ON Kitaplar.KitapID = OduncAlmalar.KitapID
GROUP BY 
    Kitaplar.KitapID, Kitaplar.KitapAdi;

--
SELECT 
    Dergiler.DergiID,
    Dergiler.DergiAdi,
    COUNT(OduncAlmalar.DergiID) AS OduncSayisi
FROM 
    Dergiler
LEFT JOIN 
    OduncAlmalar ON Dergiler.DergiID = OduncAlmalar.DergiID
GROUP BY 
    Dergiler.DergiID, Dergiler.DergiAdi;

--
SELECT 
    DVDler.DVDID,
    DVDler.DVDAdi,
    COUNT(OduncAlmalar.DVDID) AS OduncSayisi
FROM 
    DVDler
LEFT JOIN 
    OduncAlmalar ON DVDler.DVDID = OduncAlmalar.DVDID
GROUP BY 
    DVDler.DVDID, DVDler.DVDAdi;


--9

SELECT TOP 3 
    KitapID,
    KitapAdi,
    Yazar,
    YayinYili,
    SayfaSayisi,
    ISBN
FROM 
    Kitaplar
ORDER BY 
    YayinYili ASC;
