namespace Project12_Loops;

class Program
{
    static void Main(string[] args)
    {
        #region for
        // for (int i = 1; i <= 524; i++)
        // {
        //     System.Console.WriteLine($"Sayaç {i}. kez çalışıyor.");
        // }
        // System.Console.WriteLine("döngü sona erdi.");

        // for (int i = 2; i <= 10; i++)
        // {
        //     if (i % 2 == 0)
        //     {
        //         System.Console.WriteLine($"Ekrandaki {i}. sayı");
        //     }
        // }

        System.Console.Write("Fakt sayısı giriniz: ");
        string numberString = Console.ReadLine();
        int factorial = 1;

        if (int.TryParse(numberString, out int number))
        {
            for (int i = 1; i <= number; i++)
            {
                //factorial = factorial * i;
                factorial *= i;
            }
            Console.WriteLine(factorial);
        }
        else
        {
            System.Console.WriteLine("Geçerli bir değer giriniz: ");
        }
        int i = 1;


        #endregion
    }
}
