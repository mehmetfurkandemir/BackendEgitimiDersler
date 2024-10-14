namespace Education;

using System;

public class Kisi
{
    public string Isim { get; set; }
    public int Yas { get; set; }

    public Kisi(string isim, int yas)
    {
        Isim = isim;
        Yas = yas;
    }

    public virtual void DerseKatıl()
    {
        Console.WriteLine($"{Isim} derse katılıyor.");
    }
}

public class Ogretmen : Kisi
{
    public string OgrettigiKonu { get; set; }

    public Ogretmen(string isim, int yas, string ogrettigiKonu)
        : base(isim, yas)
    {
        OgrettigiKonu = ogrettigiKonu;
    }

    public override void DerseKatıl()
    {
        Console.WriteLine($"{Isim} {OgrettigiKonu} dersi veriyor.");
    }
}

public class Ogrenci : Kisi
{
    public string SinifSeviyesi { get; set; }

    public Ogrenci(string isim, int yas, string sinifSeviyesi)
        : base(isim, yas)
    {
        SinifSeviyesi = sinifSeviyesi;
    }

    public override void DerseKatıl()
    {
        Console.WriteLine($"{Isim} {SinifSeviyesi} dersine katılıyor.");
    }
}

class Program
{
    static void Main()
    {
        Ogretmen ogretmen = new Ogretmen("Ali", 35, "Matematik");
        Ogrenci ogrenci = new Ogrenci("Ayşe", 15, "9. Sınıf");

        ogretmen.DerseKatıl();
        ogrenci.DerseKatıl();  
    }
}

