namespace Account;

using System;

public class Hesap
{
    public string HesapNumarasi { get; set; }
    public decimal Bakiye { get; set; }

    public Hesap(string hesapNumarasi, decimal bakiye)
    {
        HesapNumarasi = hesapNumarasi;
        Bakiye = bakiye;
    }

    public virtual void ParaYatir(decimal miktar)
    {
        Bakiye += miktar;
        Console.WriteLine($"{miktar} TL yatırıldı. Yeni bakiye: {Bakiye} TL.");
    }

    public virtual void ParaCek(decimal miktar)
    {
        if (miktar > Bakiye)
        {
            Console.WriteLine("Yetersiz bakiye.");
        }
        else
        {
            Bakiye -= miktar;
            Console.WriteLine($"{miktar} TL çekildi. Yeni bakiye: {Bakiye} TL.");
        }
    }
}

public class TasarrufHesabi : Hesap
{
    public TasarrufHesabi(string hesapNumarasi, decimal bakiye)
        : base(hesapNumarasi, bakiye)
    {
    }

    public void FaizEkle(decimal faizOrani)
    {
        decimal faiz = Bakiye * faizOrani / 100;
        Bakiye += faiz;
        Console.WriteLine($"Faiz eklendi: {faiz} TL. Yeni bakiye: {Bakiye} TL.");
    }
}

public class VadesizHesap : Hesap
{
    public VadesizHesap(string hesapNumarasi, decimal bakiye)
        : base(hesapNumarasi, bakiye)
    {
    }

    public void CekYaz(decimal cekMiktari)
    {
        if (cekMiktari > Bakiye)
        {
            Console.WriteLine("Yetersiz bakiye, çek yazılamaz.");
        }
        else
        {
            Bakiye -= cekMiktari;
            Console.WriteLine($"{cekMiktari} TL'lik çek yazıldı. Yeni bakiye: {Bakiye} TL.");
        }
    }
}

class Program
{
    static void Main()
    {
        TasarrufHesabi tasarrufHesabi = new TasarrufHesabi("TR123456", 1000);
        VadesizHesap vadesizHesap = new VadesizHesap("TR654321", 500);

        tasarrufHesabi.ParaYatir(500);
        tasarrufHesabi.FaizEkle(5);

        vadesizHesap.ParaCek(200);
        vadesizHesap.CekYaz(100);

        vadesizHesap.CekYaz(500);
    }
}
