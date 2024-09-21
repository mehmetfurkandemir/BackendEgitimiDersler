namespace Project08_NumberMethods;

class Program
{
    static void Main(string[] args)
    {
        //Math sınıfı
        //Math.Abs(-5); Mutlak Değer = 5
        //Math.Pow(2, 4); Üssünü alma = 16
        //Math.Sqrt(16); Karekök = 4
        //Math.Round(7.25); Yuvarlama = 7
        //Math.Ceiling(); Üste Yuvarlar
        //Mat.Floor(); Alta Yuvarlar

        //Rastgele sayı üretmek
        // Random rnd = new Random();
        // int randomNumber = rnd.Next();
        // randomNumber = rnd.Next(0, 3);
        // randomNumber = rnd.Next(5, 20);
        // randomNumber = rnd.Next(0,)

        Random rnd = new Random();
        int randomNumber = rnd.Next(0, 100);
        System.Console.WriteLine(randomNumber);
    }
}
