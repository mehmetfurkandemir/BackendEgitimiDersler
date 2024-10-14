namespace Game;

using System;

public class Karakter
{
    public string Isim { get; set; }
    public int Saglik { get; set; }

    public Karakter(string isim, int saglik)
    {
        Isim = isim;
        Saglik = saglik;
    }

    public virtual void Saldir()
    {
        Console.WriteLine($"{Isim} saldırı yapıyor.");
    }
}

public class Savascı : Karakter
{
    public Savascı(string isim, int saglik)
        : base(isim, saglik)
    {
    }

    public void KilicSaldirisi()
    {
        Console.WriteLine($"{Isim} kılıç ile saldırıyor.");
    }
}

public class Buyucu : Karakter
{
    public Buyucu(string isim, int saglik)
        : base(isim, saglik)
    {
    }

    public void BuyuAtma()
    {
        Console.WriteLine($"{Isim} büyü atıyor.");
    }
}

public class Okcu : Karakter
{
    public Okcu(string isim, int saglik)
        : base(isim, saglik)
    {
    }

    public void OkAtma()
    {
        Console.WriteLine($"{Isim} ok atıyor.");
    }
}

class Program
{
    static void Main()
    {
        Savascı savascı = new Savascı("Ali", 100);
        Buyucu buyucu = new Buyucu("Ayşe", 80);
        Okcu okcu = new Okcu("Mehmet", 90);

        savascı.Saldir();
        savascı.KilicSaldirisi();

        buyucu.Saldir();
        buyucu.BuyuAtma();

        okcu.Saldir();
        okcu.OkAtma();
    }
}
