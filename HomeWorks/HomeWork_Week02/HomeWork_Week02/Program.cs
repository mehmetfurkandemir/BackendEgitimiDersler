namespace HomeWork_Week02;

class Program
{
    static void Main(string[] args)
    {
        #region 1 
        //int tipinde iki değişken oluşturun ve bu değişkenlere değerler atayın. Sonra bu değişkenleri toplayıp sonucu yeni bir değişkene atayın ve ekrana yazdırın.

        // int a = 12;
        // int b = 5;
        // int sonuc;
        // sonuc = a + b;
        // System.Console.WriteLine(sonuc);
        #endregion
        #region 2
        //double tipinde bir değişken oluşturun ve bu değişkene bir ondalıklı sayı atayın. Bu sayının karesini hesaplayıp yeni bir double değişkene atayın ve sonucu ekrana yazdırın.
        // double number = 12.7;
        // System.Console.WriteLine(Math.Pow(number, 2));
        #endregion
        #region 3
        //string tipinde bir değişken oluşturun ve içine adınızı atayın. Sonra int tipinde bir değişken oluşturup yaşınızı atayın. Bu iki değişkeni kullanarak "Benim adım [ad] ve ben [yaş] yaşındayım." şeklinde bir cümle oluşturup ekrana yazdırın.
        // string name = "Furkan";
        // int age = 26;
        // System.Console.WriteLine($"Benim adım {name} ve ben {age} yaşındayım.");
        #endregion
        #region 4
        //char tipinde bir değişken oluşturun ve içine bir harf atayın. Bu harfin ASCII değerini int tipinde bir değişkene atayıp ekrana yazdırın.
        // char harf = 'a';
        // System.Console.WriteLine($"{harf} ASCII Değeri: {(int)harf}");
        #endregion
        #region 5
        //bool tipinde iki değişken oluşturun ve bunlara true ve false değerlerini atayın. Bu değişkenleri ekrana yazdırın.
        // bool dogruMu = true;
        // bool yanlisMi = false;
        // System.Console.WriteLine(dogruMu);
        // System.Console.WriteLine(yanlisMi);
        #endregion
        #region 6
        //byte tipinde bir değişken oluşturun ve içine 255 değerini atayın. Sonra bu değeri int tipine dönüştürüp yeni bir değişkene atayın ve ekrana yazdırın.
        // byte deger = 255;
        // int yeniDeger = deger;
        // System.Console.WriteLine(yeniDeger);
        #endregion
        #region 7
        //int tipinde bir değişken oluşturun ve içine büyük bir sayı (örneğin 1000000) atayın. Bu değeri byte tipine dönüştürmeye çalışın. Sonucu ekrana yazdırın ve ne olduğunu açıklayın.
        // int buyukSayi = 43423457;
        // byte yeniSayi = buyukSayi;
        // System.Console.WriteLine(yeniSayi);
        //Derleme hatası oldu çünkü byte ın alabileceği değerden büyük bir değer girdik ve dönüştürme başarısız oldu.
        #endregion
        #region 8
        //double tipinde bir değişken oluşturun ve içine 3.14 değerini atayın. Bu değeri int tipine dönüştürüp yeni bir değişkene atayın ve sonucu ekrana yazdırın. Sonucu yorumlayın.
        // double number = 3.14;
        // int newNumber = (int)number;
        // System.Console.WriteLine(newNumber);
        //Ondalıklı sayı, tam sayıya dönüştürüldü. ',' sonrası 5 ten küçük olduğu için 3'e yuvarlandı.
        #endregion
        #region 9
        //string tipinde bir değişken oluşturun ve içine bir sayı yazın (örneğin "42"). Bu string'i int tipine dönüştürüp yeni bir değişkene atayın ve ekrana yazdırın.
        // string number = "22";
        // int newNumber = int.Parse(number);
        // System.Console.WriteLine(newNumber);
        #endregion
        #region 10
        //int tipinde üç değişken oluşturun ve bunlara sırasıyla 5, 10 ve 15 değerlerini atayın. Bu değişkenlerin ortalamasını hesaplayıp double tipinde bir değişkene atayın ve sonucu ekrana yazdırın.
        // int a = 5;
        // int b = 10;
        // int c = 15;
        // double result = (a + b + c);
        // System.Console.WriteLine(result / 3);
        #endregion
        #region 11
        //decimal tipinde iki değişken oluşturun ve bunlara para miktarları atayın (örneğin 10.25m ve 5.75m). Bu değerleri toplayıp sonucu yeni bir decimal değişkene atayın ve ekrana yazdırın.
        // decimal firstRevenue = 10.5m;
        // decimal secondRevenue = 15.2m;
        // decimal totalRevenue = firstRevenue + secondRevenue;
        // System.Console.WriteLine(totalRevenue);
        #endregion
        #region 12
        //float tipinde bir değişken oluşturun ve içine 1.23f değerini atayın. Bu değeri double tipine dönüştürüp yeni bir değişkene atayın. İki değeri de ekrana yazdırıp karşılaştırın.
        // float number = 1.23f;
        // double doubleNumber = (double)number;
        // System.Console.WriteLine(number);
        // System.Console.WriteLine(doubleNumber);
        #endregion
        #region 13
        //long tipinde bir değişken oluşturun ve içine çok büyük bir sayı atayın, örneğin 500000000000 gibi. Bu değeri int tipine dönüştürmeye çalışın. Sonucu ekrana yazdırın ve ne olduğunu açıklayın.
        // long longNumber = 32423432649684;
        // int newNumber = (int)longNumber;
        // System.Console.WriteLine(newNumber);
        #endregion
        #region 14
        //string tipinde iki değişken oluşturun ve bunlara adınızı ve soyadınızı atayın. Bu iki değişkeni birleştirip yeni bir string değişkene atayın ve ekrana yazdırın.
        // string name = "Furkan";
        // string surname = "Demir";
        // string fullName = name + " " + surname;
        // System.Console.WriteLine(fullName);
        #endregion
        #region 15
        //string tipinde bir değişken oluşturun ve içine "True" yazın. Bu string'i bool tipine dönüştürüp yeni bir değişkene atayın ve ekrana yazdırın.
        // string value = "True";
        // bool newValue = bool.Parse(value);
        // System.Console.WriteLine(newValue);
        #endregion
        #region 16
        //double tipinde pi sayısını temsil eden bir değişken oluşturun (3.14159). Bu değeri float tipine dönüştürüp yeni bir değişkene atayın. Her iki değeri de ekrana yazdırıp hassasiyet farkını gözlemleyin.
        // double pi = 3.14159;
        // float newPi = (float)pi;
        // System.Console.WriteLine($"double pi: {pi}");
        // System.Console.WriteLine($"float pi: {newPi}");

        #endregion
        #region 17
        //byte, short, int, ve long tiplerinde değişkenler oluşturun ve her birine aynı sayısal değeri (örneğin 42) atayın. Bu değişkenlerin bellekte kapladıkları alanı sizeof() operatörünü kullanarak ekrana yazdırın.sizeof() nasıl kullanılır, araştırın.
        // byte number1 = 12;
        // short number2 = 12;
        // int number3 = 12;
        // long number4 = 12;

        // System.Console.WriteLine(sizeof(byte));
        // System.Console.WriteLine(sizeof(short));
        // System.Console.WriteLine(sizeof(int));
        // System.Console.WriteLine(sizeof(long));




        #endregion
        #region 18
        //string tipinde bir değişken oluşturun ve içine bir cümle yazın. Bu cümlenin karakter sayısını int tipinde bir değişkene atayıp ekrana yazdırın. (İpucu: .Length özelliğini kullanabilirsiniz, araştırın.)
        // string sentence = "Back-End Yazılım öğreniyorum";
        // int charNumber = sentence.Length;
        // System.Console.WriteLine(charNumber);
        #endregion
    }
}
