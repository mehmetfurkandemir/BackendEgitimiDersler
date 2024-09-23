namespace Project10_Conditions_TernaryIf_Switch;

class Program
{
    static void Main(string[] args)
    {
        #region Ternary If
        // System.Console.WriteLine("Bir sayı girin: ");

        // int number = int.Parse(Console.ReadLine());

        // string result = number > 50
        //         : "İndirim yok";

        // System.Console.WriteLine(result);


        // if (number > 50)
        // {
        //     result = "İndirim var";
        // }
        // else
        // {
        //     result = "İndirim yok";
        // }
        // System.Console.WriteLine(result);

        // System.Console.WriteLine("Bir sayı giriniz: ");

        // int number = int.Parse(Console.ReadLine());

        // string result = number > 50
        //                 : "İndirim yok";
        // System.Console.WriteLine(result);

        // System.Console.Write("Adınızı Giriniz: ");
        // string name = Console.ReadLine();
        // int uzunluk = name.Length;
        // string result = uzunluk > 15 ? "Çok uzun"
        //             : "Uygun";
        // System.Console.WriteLine(result);

        // Console.Write("1-12 ay bilgisi giriniz:");
        // byte ayBilgisi = byte.Parse(Console.ReadLine());

        // string result = ayBilgisi == 12 || ayBilgisi < 3
        //             ? "Kış"
        //             : ayBilgisi < 6
        //             ? "İlkbahar"
        //             : ayBilgisi < 9
        //             ? "Yaz"
        //             : "Sonbahar";
        // System.Console.WriteLine(result);

        #endregion
        #region Switch
        //Kullanıcıdan alınan 0-100 arasındaki puanın geçer not olup olmadığına bakıp ekrana "Geçti" ya da "Kaldı" yazdıran kodu hazırlayalım.

        // System.Console.WriteLine("1-100 arasında puan giriniz:");
        // byte point = byte.Parse(Console.ReadLine());
        // string resultMessage;
        // switch (point)
        // {
        //     case >= 50:
        //         resultMessage = "Geçti";
        //         break;
        //     case < 50:
        //         resultMessage = "Kaldı";
        //         break;
        // }
        // System.Console.WriteLine(resultMessage);

        // System.Console.Write("Bir sayı giriniz: ");
        // byte point = byte.Parse(Console.ReadLine());
        // string resultMessage;

        // switch (point)
        // {
        //     case >= 50:
        //         resultMessage = "Geçti";
        //         break;
        //     default:
        //         resultMessage = "Kaldı";
        //         break;
        // }
        // System.Console.WriteLine(resultMessage);



        //Puanlama sistemi
        // System.Console.Write("0 ile 100 arasında puan gir: ");
        // byte point = byte.Parse(Console.ReadLine());
        // string resultMessage;
        // if (byte.TryParse())
        // {

        // }
        // else
        // {

        // }
        // switch (point)
        // {
        //     case < 0 or > 100:
        //         resultMessage = "Lütfen 0-100 aralığında giriniz";
        //         break;
        //     case < 45:
        //         resultMessage = "1";
        //         break;
        //     case < 55:
        //         resultMessage = "2";
        //         break;
        //     case < 70:
        //         resultMessage = "3";
        //         break;
        //     case < 85:
        //         resultMessage = "4";
        //         break;
        //     default:
        //         resultMessage = "5";
        //         break;
        // }
        // System.Console.WriteLine(resultMessage);
        #endregion
    }
}
