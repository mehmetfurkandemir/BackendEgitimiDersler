namespace VariablesSamples;

class Program
{
    static void Main(string[] args)
    {
        #region Sample1
        // int number1 = 10;
        // int number2 = 5;
        // //4 işlem
        // System.Console.WriteLine(number1 + number2);
        // System.Console.WriteLine(number1 - number2);
        // System.Console.WriteLine(number1 * number2);
        // System.Console.WriteLine(number1 / number2);
        // System.Console.WriteLine(number1 % number2);

        #endregion
        #region Sample2
        // string word1 = "Bugün";
        // string word2 = "Hava";
        // string word3 = "Çok";
        // string word4 = "Güzel";

        // System.Console.WriteLine(word1 + " " + word2 + " " + word3 + " " + word4 + ".");
        #endregion
        #region Sample3
        // System.Console.WriteLine($"int minimum değer: {int.MinValue} \nint max değer: {int.MaxValue}");

        // byte maxByte = byte.MaxValue;
        // System.Console.WriteLine(maxByte);
        #endregion
        #region Sample4
        // float f = 0.1f + 0.2f;
        // System.Console.WriteLine(f);
        // double d = 0.1d + 0.2d;
        // System.Console.WriteLine(d);
        // decimal m = 0.1m + 0.2m;
        // System.Console.WriteLine(m);
        #endregion
        #region Sample5

        // double number1 = 10.5;
        // double number2 = 20.3;
        // char op = '*';

        // double result = op switch
        // {
        //     '+' => number1 + number2,
        //     '-' => number1 - number2,
        //     '*' => number1 * number2,
        //     '/' => number1 / number2,
        //     _ => throw new ArgumentException("Geçersiz işlem")
        // };

        // System.Console.WriteLine($"{number1} {op} {number2} = {result}");

        #endregion
        #region Sample6

        System.Console.Write("İlk Sayı: ");
        int number1 = int.Parse(Console.ReadLine());
        System.Console.Write("İkinci Sayı: ");
        int number2 = int.Parse(Console.ReadLine());

        System.Console.Write("İşleminizi Giriniz:");

        char op = char.Parse(Console.ReadLine());

        double result = op switch
        {
            '+' => number1 + number2,
            '-' => number1 - number2,
            '*' => number1 * number2,
            '/' => number1 / number2,
            _ => throw new ArgumentException("Geçersiz işlem")
        };

        System.Console.WriteLine($"{number1} {op} {number2} = {result}");
        #endregion
    }
}
