--Bolumler Tablosuna Veri Ekleniyor

INSERT INTO Bolumler(BolumAdi)
VALUES
    ('Bilgisayar Mühendisliği'),
    ('Elektrik Mühendisliği'),
    ('Makine Mühendisliği')
--Dersler Tablosuna Veri Ekleniyor
INSERT INTO Dersler(BolumID, DersAdi, Kredi)
VALUES
    (1, 'Programlama Dilleri', 5),
    (1, 'Veri Tabanı Yönetimi', 4),
    (1, 'Web Geliştirme', 8),
    (1, 'Algoritmalar', 3),
    
    (2, 'Devre Teorisi', 3),
    (2, 'Elektrik Makineleri', 4),
    (2, 'Otomatik Kontrol Sistemleri', 6),
    (2, 'Temel Elektronik', 5),

    (3, 'Mak Müh Temelleri', 4),
    (3, 'Termodinamik', 6),
    (3, 'Akışkanlar Mekaniği', 7),
    (3, 'Malzeme Bilimi', 8)
    
--Ogrenciler Tablosuna Veri Ekleniyor
    INSERT INTO Ogrenciler(Ad, Soyad, BolumID)
    VALUES 

        ('Ali','Yılmaz',1),
        ('Ayşe','Kara',1),
        ('Mehmet','Çelik',1),
        ('Fatma','Demir',1),
        ('Ahmet','Öztürk',2),
        ('Elif','Aydın',2),
        ('Mustafa','Koç',2),
        ('Zeynep','Arslan',2),
        ('Emre','Yalçın',2),
        ('Seda','Tekin',3),
        ('Burak','Polat',3),
        ('Cem','Güler',3),
        ('Derya','Uçar',3),
        ('Aliye','Sönmez',3),
        ('Oğuz','Çetin',3)

--Ogrenciler Tablosuna Doğum tarihi Veri Ekleniyor

INSERT INTO Ogrenciler(Ad, Soyad, BolumID, DogumTarihi)
VALUES 
        ('Sinem', 'Koçak', 3, '2000-10-19')

--Bilg Müh (BolumID=1) öğrencilerine ders ataması yapılıyor

INSERT INTO DersOgrenciler(OgrenciID, DersID)
VALUES
    (1,1),
    (1,2),
    (1,3),
    (1,4),
    (2,1),
    (2,2),
    (2,3),
    (3,1),
    (3,2),
    (3,3),
    (3,4),
    (4,1),
    (4,2)

    
INSERT INTO DersOgrenciler(OgrenciID, DersID)
VALUES
    (2,4)

--Elektrik müh (BolumID=2) öğr. ders atama
--5,6,7,8,9 öğr
--5,6,7,8 dersler

INSERT INTO DersOgrenciler(OgrenciID, DersID)
VALUES
    (5,5),(5,6),(5,7),
    (6,5),(6,6),(6,8),
    (7,7),(7,8),(7,6),
    (8,5),(8,7),(8,8),
    (9,7),(9,8)
--MAk Müh (DERSID=3)Ders Atanacak
--10,11,12,13,14,15 Öğrenciler
--9,10,11,12 Dersler
INSERT INTO DersOgrenciler(OgrenciID, DersID)
VALUES
    (10,9),(10,10),(10,11),(10,12),
    (11,9),(11,10),(11,11),(11,12),
    (12,9),(12,10),(12,11),(12,12),
    (13,9),(13,10),(13,11),
    (14,10),(14,11),
    (15,11),(15,12)