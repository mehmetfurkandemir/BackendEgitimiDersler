namespace Project13_While_Loops;

class Program
{
    static void Main(string[] args)
    {
        //While Loops: Kullanıcının gireceği kadar. exit de bitecek.
        //Bir koşula bağlı çalışacak, koşulu kontrol edecek, kullanıcı klavyeden exit yazana kadar gibi.

        // int i = 1;
        // while (i <= 5)
        // {
        //     Console.WriteLine("Merhaba Dünya!");
        //     i++;
        // }

        //kullanıcı sayı giricek istediği kadar. toplam ekrana, exit yazınca çıkacak.

        // int total = 0;
        // string input = "input!="exit"";
        // while (true)
        // {
        //     System.Console.WriteLine("çıkış için exit");
        //     input = Console.ReadLine();
        //     if (int.TryParse(input, ount int inputNumber))
        //     {
        //         total += inputNumber;
        //     }
        //     else if(input!="exit")
        //     {
        //         Console.Write("geçerli değer gir")
        //     }
        // }
        // System.Console.WriteLine(total);

        #region do while
        //En az bir kez döngü çalışır!!!!
        do
        {
            System.Console.WriteLine("wow");
        } while (1 == 2);
        #endregion
    }
}
