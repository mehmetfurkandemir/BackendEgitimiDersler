namespace Project18_Methods;

class Program
{
    //1- Erişim Belirleyici (public, private)
    //2- Geri dönüş tipi (int, void, sbyte)
    //3- Metot adı (parametre1_tipi parametre1_adı, parametre2_tipi parametre2_adı)
    //{
    //Bu metotta çalışması istenen tüm kodlar buraya yazılacak
    //}

    static void Greet()
    {
        Console.WriteLine("Merhaba Drogba");
    }

    static void GreetToNameWithGender(string name, bool gender)
    {
        if (gender)
        {
            System.Console.WriteLine($"Merhaba {name} hanım");
        }
        else
        {
            System.Console.WriteLine($"Merhaba {name} bey");
        }
    }
    static void GreetToName(string name)
    {
        Console.WriteLine($"Merhaba {name}");
    }

    static void CalculateAge(string name, bool gender, int year)
    {
        string resultMessage = "";
        int age = DateTime.Now.Year - year;
        if (gender)
        {
            resultMessage = $"Merhaba {name} hanım, {age} yaşındasınız.";
        }
        else
        {
            resultMessage = $"Merhaba {name} bey, {age} yaşındasınız.";
        }
        System.Console.WriteLine(resultMessage);
    }

    static byte Sum1()
    {
        byte result = 5 + 10;
        return result;
    }

    static DayOfWeek GetDayName()
    {
        DateTime today = DateTime.Now;
        DayOfWeek result = today.DayOfWeek;
        return result;
    }

    static int Sum2(int number1, int number2)
    {
        int result = number1 + number2;
        return result;
    }

    static double SumSqrt(double number1, double number2)
    {
        double total = number1 + number2;
        double sqrt = Math.Sqrt(total);
        return sqrt;
    }

    static void SampleValue(ref int x)
    {
        x += 3;
        System.Console.WriteLine($"SampleValue metodunun içindeki x değeri: {x}");
    }

    static bool Sum3(int number1, int number2, out int result)
    {
        result = number1 + number2;
        if (result > 0)
        {
            return true;
        }
        return false;
    }

    static int Divide(int bolunen, int bolen, out int kalan)
    {
        kalan = bolunen % bolen;
        int result = bolunen / bolen;
        return result;
    }

    static int[] GetArrayWithRandomValues(int length, int min = 1, int max = 100)
    {
        int[] array = new int[length];
        Random rnd = new Random();
        for (int i = 0; i < length; i++)
        {
            array[i] = rnd.Next(min, max + 1);
        }
        return array;
    }

    static int GetMaxValue(int[] array)
    {
        int max = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max) max = array[i];
        }
        return max;
    }

    static void Main(string[] args)
    {
        //10 elemanlı 50-100 arasında değer taşıyan bir dizi oluşan 
        int[numbers] = GetArrayWithRandomValues(10, 50, 100);
        System.Console.WriteLine($"Rastgele dizi: {String.Join(", ", numbers)}");

        // System.Console.WriteLine(Divide(25, 1, out int kalan));
        // if (kalan > 0) {
        //     Console.WriteLine(kalan);
        // }

        // int result;
        // bool isPositive = Sum3(4, 5, out result);
        // System.Console.WriteLine($"Sonuç: {result}\n{isPositive}");


        //SampleValue(5);
        // System.Console.WriteLine(SumSqrt(19, 6));
        // System.Console.WriteLine(SumSqrt(13, 68));  

        //Greet();
        //GreetToName("Furkan");
        //GreetToNameWithGender("Ahmet", false);
        //CalculateAge("Furkan", false, 1998);
        //byte a = Sum1();
        //System.Console.WriteLine(a);
        // System.Console.WriteLine(GetDayName());
        // System.Console.WriteLine(Sum2(6,4));
        // System.Console.WriteLine(Sum2(56,23));
        // System.Console.WriteLine(Sum2(123,4));
        // System.Console.WriteLine(Sum2(6782,1234));
    }
}
