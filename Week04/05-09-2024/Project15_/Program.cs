﻿namespace Project15_;
//Arrays
class Program
{
    static void Main(string[] args)
    {
        // int[] numbers;
        // numbers = new int[5];
        // int[] numbers = new int[5];
        // numbers[0] = 45;
        // numbers[1] = 50;
        // System.Console.WriteLine(numbers[0]);

        // int[] numbers = { 10, 20, 30, 40, 50 };
        // for (int i = 0; i < 5; i++)
        // {
        //     System.Console.WriteLine($"{i}. item {numbers[i]}");
        // }
        // foreach (int number in numbers)
        // {
        //     System.Console.WriteLine($"Item: {number}");
        // }
        // for (int i = 0; i < numbers.Length; i++)
        // {
        //     numbers[i] = (int)(numbers[i] * 1.1);
        // }

        // foreach (int number in numebrs)
        // {
        //     number = (int)(number * 1.1);
        // }
        // foreach (var number in numbers)
        // {
        //     Console.WriteLine(number);
        // }

        // Üç sayıdan en büyüğünü bulup ekrana yazdıran kod:

        // int a = 4229;
        // int b = 87;
        // int c = 33;
        // int enb = int.MinValue;


        // if(a > enb)
        // {
        //     enb = a;
        // }
        // if(b > enb)
        // {
        //     enb = b;
        // }
        // if(c > enb)
        // {
        //     enb = c;
        // }
        // System.Console.WriteLine(enb);

        //10 elemanlı dizideki en büyük sayıyı bulup ekrana yaz:

        // int[] numbers = { 23, 32324, 34, 127, 76, 45648, 5675, 567, 1324, 8768 };

        // int enb = int.MinValue;

        // for (int i = 0; i < numbers.Length; i++)
        // {
        //     if(numbers[i] > enb) enb=numbers[i];
        // }
        // System.Console.WriteLine(enb);

        //Diziyi sıralamak
        // int[] numbers = { 23, 32324, 34, 127, 76, 45648, 5675, 567, 1324, 8768 };
        // Array.Sort(numbers);
        // foreach (var number in numbers)
        // {
        //     System.Console.WriteLine(number);
        // }

        // Diziyi ters çevirme Array.Reverse
        // int[] numbers = { 23, 32324, 34, 127, 76, 45648, 5675, 567, 1324, 8768 };
        // Array.Sort(numbers);
        // Array.Reverse(numbers);

        // foreach (var number in numbers)
        // {
        //     System.Console.WriteLine(number);
        // }

        //Dizinin belirli bir elemanının indexini bulmak Array.IndexOf(..,..);

        // int[] numbers = { 23, 32324, 34, 127, 76, 45648, 5675, 567, 1324, 8768 };

        // int index = Array.IndexOf(numbers, 76);
        // System.Console.WriteLine(index);

        // string firstName = "Osimhen";
        // char[] firstName2 = {'o', 's', 'i', 'm'};
        // System.Console.WriteLine(firstName[4]);
        // System.Console.WriteLine(firstName2);

        // string[] names = {'Ali', 'Veli', 'Ayşe'};
        // string[] newNames = new string[names.Length];
        // Array.Copy(names, newNames, 3);
        // foreach (var name1 in newNames)
        // {
        //     System.Console.WriteLine(name1);
        // }


        //Dizi içinde var yok kontrolü

        // int[] numbers = { 50, 300, 23, 9, 435, 66, 1, 23 };
        // bool exists = Array.Exists(numbers, x => x > 600);
        // System.Console.WriteLine(exists == true ? "600'den büyük sayı var":"600'den büyük sayı yok!");

        //Dizi içinde belirtilen koşula uygun ilk elemanı getir
        // int[] numbers = { 50, 300, 23, 9, 435, 66, 1, 23 };
        // int result = Array.Find(numbers, x => x > 60);
        // System.Console.WriteLine(result);

        //Dizi içinde belirtilen koşula uygun TÜM elemanları getir

        // int[] numbers = { 50, 300, 23, 9, 435, 66, 1, 23 };
        // int[] results = Array.FindAll(numbers, x => x > 60);
        // foreach (var number in results)
        // {
        //     System.Console.WriteLine(number);
        // }
    
        //dizinin boyutunu değiştirme

        // int[] numbers = {3, 6, 9};
        // Array.Resize(ref numbers, 4);
        // numbers[3] = 35;

    }
}
