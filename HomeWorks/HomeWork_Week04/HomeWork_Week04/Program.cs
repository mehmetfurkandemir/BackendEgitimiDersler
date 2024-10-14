namespace HomeWork_Week04;

class Program
{
    static void Main(string[] args)
    {
        #region 1- Kıyaslama Algoritma...
        //10 elemanlı rastgele değerlerden oluşan bir tam sayı dizisi içinde, dizinin her bir elemanının yalnızca bir önceki ve bir sonraki elemanı ile kıyaslandığı bir algoritma yazın. Bu algoritma, yalnızca kendinden önceki sayı ve kendinden sonraki sayı büyük olan elemanları bulmalı ve bunları ekrana yazdırmalıdır.

        /* int[] tamSayi = {10, 25, 24, 17, 2, 90, 102, 3, 80, 15};
        Console.WriteLine("Değerler: " + string.Join(", ", tamSayi));
        Console.WriteLine("Kıyaslamalar: ");
        for (int i = 1; i < tamSayi.Length -1; i++)
        {
            if (tamSayi[i] > tamSayi[i - 1] && tamSayi[i] > tamSayi[i + 1])
            {
                Console.WriteLine($"tamSayi[{i}] = {tamSayi[i]}");
            }
        } */

        /* int [] sayilar = new int[10];
        Random random = new Random();

        for(int i = 0; i< sayilar.Length; i++)
        {
            sayilar[i] = random.Next(1, 101);
        }

        foreach(int i in sayilar)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
        for(int k = 1; k < sayilar.Length; k++)
        {
            if(sayilar[k] > sayilar[k + 1] && sayilar[k] > sayilar[k -1])
            {
                Console.WriteLine();
            }
        } */

        #endregion
        #region 2- Çift sayıları ayrı diziye aktarma...
        //Klavyeden girilen 10 sayıyı bir diziye atayın. Bu sayılardan çift olanları for döngüsü kullanarak ayrı bir diziye aktarın. Ardından bu çift sayı dizisini küçükten büyüğe sıralayın.            

        /* int[] tamSayi = new int[10];
        int[] ciftSayi;
        int ciftSayac = 0;

        Console.WriteLine("10 sayı giriniz:");
        for(int i = 0; i < 10; i++)
        {
            Console.Write($"Sayı {i + 1}: ");
            tamSayi[i] = int.Parse(Console.ReadLine());
        }

        
        for (int i = 0; i < 10; i++) //çift sayı adedi
        {
            if (tamSayi[i] % 2 == 0)
            {
                ciftSayac++;
            }
        }
        
        ciftSayi = new int[ciftSayac]; //Çiftlerin dizisi
        int j = 0;
        for (int i = 0; i < 10; i++)
        {
            if (tamSayi[i] % 2 == 0)
            {
                ciftSayi[j++] = tamSayi[i];
            }
        }
        

        Array.Sort(ciftSayi); //Array.Sort();

        Console.WriteLine("Küçükten büyüğe çift sayılar: " + string.Join(", ", ciftSayi)); */

        #endregion
        #region 3- While ile pozitif / negatif ?

        //10 elemanlı rastgele değerlerden oluşan bir dizideki tüm pozitif sayıları ve negatif sayıları ayrı dizilere ayıran ve her iki diziyi de ekrana yazdıran bir program yazın. İşlemi gerçekleştirmek için while döngüsü kullanın.

        /*  int[] sayilar=new int[10];
        int negatifSayiAdeti=0;
        int pozitifSayiAdeti=0;
        Random random = new Random();
        for(int i=0;i<sayilar.Length;i++){
        sayilar[i]=random.Next(-5,6);
        if(sayilar[i]<0)
        negatifSayiAdeti++;
        if(sayilar[i]>=0)
        pozitifSayiAdeti++;

        }
        int[] pozitifSayilar = new int[pozitifSayiAdeti];
        int[] negatifSayilar= new int[negatifSayiAdeti];
        negatifSayiAdeti=0;
        pozitifSayiAdeti=0;
        for(int j=0;j<sayilar.Length;j++)
        {

            if(sayilar[j]<0){
            negatifSayilar[negatifSayiAdeti]=sayilar[j];
            negatifSayiAdeti++;
            }else{
                pozitifSayilar[pozitifSayiAdeti]=sayilar[j];
                pozitifSayiAdeti++;
            }

            }

            Console.Write("Tüm Sayılar");

            foreach (int i in sayilar){
            Console.Write(i+",");
            }
            Console.WriteLine();
            Console.Write("Negatif Sayılar");

            foreach (int i in negatifSayilar){
            Console.Write(i+",");
            }
            Console.WriteLine();
            Console.Write("Pozitif Sayılar");

            Array.ForEach(pozitifSayilar,i=>Console.Write(i+","));
            Console.WriteLine();

            */


        #endregion
        #region 4- 100 elemanlı dizi

        //100 elemanlı rastgele değerlerden oluşan bir tam sayı dizisinde tekrar eden elemanları bulan bir program yazın. Diziyi tararken, elemanların hangi pozisyonlarda(kaçıncı indexte) tekrarlandığını ekrana yazdırın. Bu işlemi hem for hem de foreach döngüleri ile gerçekleştirin.


        /* int[] sayilar=new int[100];
        string[] cıktı = new string[100];
        int counter = 0;
        string mesaj = "Tekrar eden indexler";
        Random random = new Random();

        for(int i = 0; i < sayilar.Length; i++)
        {
            sayilar[i] = random.Next(1, 101);
        }

        for(int i = 0;i < sayilar.Length; i++)
        {
            string indexMesajı = $"{sayilar[i]} sayısı tekrar eden indexleri: ";
            for(int j = 0; j<sayilar.Length; j++)
            {
                if (sayilar[i] == sayilar[j]) {
                    indexMesajı += j + ",";
                }
            }
               cıktı[i]=indexMesajı;

        }
        foreach (var item in cıktı.Distinct())
        {
            Console.WriteLine(item);
        }; */

        #endregion
        #region 5- Var mı Yok mu

        //Klavyeden girilen bir sayının, 100 elemanlı rastgele değerlerden oluşan bir tam sayı dizisinde olup olmadığını kontrol eden bir algoritma yazın. Eğer sayı dizide varsa, sayının dizideki yerini ve tekrar sayısını ekrana yazdırın.



        /* Random rnd = new Random();

        int[] tamSayi = new int[100];

        for(int i = 0; i < tamSayi.Length; i++)
        {
            tamSayi[i] = rnd.Next(0, 100);
        }

        Console.WriteLine("Bir sayı giriniz: ");
        int kullaniciSayi = int.Parse(Console.ReadLine()); */





        #endregion
        #region 6- 100 sayıda en büyük en küçük

        //100 elemanlı rastgele değerlerden oluşan bir tam sayı dizisinde en büyük ve en küçük sayıyı bulan programı yazın.


        /* Random rnd = new Random();
        int[] numbers = new int[100];

        for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = rnd.Next(100);
        }
        Console.WriteLine("Rastgele 100 sayı: ");

        for(int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i] + " ");
        }

        for  */

        #endregion
        #region 7- 50 eleman

        //50 elemanlı rastgele değerlerden oluşan bir tam sayı dizisindeki tüm çift sayıları toplayan ve bu toplamı ekrana yazdıran bir program yazın. foreach döngüsü kullanarak bu işlemi gerçekleştirin.

        /* Random rnd = new Random();

       int[] sayi = new int[50];

       for(int i = 0; i < sayi.Length; i++)
       {
           sayi[i] = rnd.Next(0, 50);
       }

       int toplam = 0;

       foreach (int j in sayi)
       {
           if(j % 2 == 0)
           {
               toplam += j;
           }
       }
       Console.WriteLine($"Dizideki çift sayıların toplamı: {toplam}"); */



        #endregion
        #region 8- 10 elemanlı 

        //Klavyeden girilen bir sayıyı, 10 elemanlı rastgele değerlerden oluşan bir tam sayı dizisinde aratın. Eğer sayı dizide yoksa, diziyi sıralayın ve sayıyı dizinin doğru(olması gereken sıra) yerine ekleyin. Ekledikten sonra yeni diziyi ekrana yazdırın.

        /* Random rnd = new Random();
        int[] number = new int[10];

        for(int i = 0; i < number.Length; i++)
        {
            number[i] = rnd.Next(0, 10);
        }
        
        Console.WriteLine("Dizi: " + string.Join(", ", number));

        //Kullanıcı sayı girişi

        Console.WriteLine("Sayı giriniz: ");
        int kullaniciSayi = int.Parse(Console.ReadLine());

        bool varMi = Array.Exists(number, var => var == kullaniciSayi);

        if(varMi)
        {
             Console.WriteLine($"Girmiş olduğunuz {kullaniciSayi} mevcut.");
        }
        else
        {

        } */


        #endregion
        #region 9- Pozitif yer değiştirme
        //Verilen bir dizinin yalnızca pozitif sayılarını ters çeviren bir algoritma yazın. Diziyi tararken, sadece pozitif sayıların yerini değiştirmelisiniz, diğer elemanlar aynı kalmalı.

        /* int[] sayi = {-12, -2, -45, -75, -34, 24, 82, 80, 1, 10};
        Console.WriteLine("Sayılar: " + string.Join(", ", sayi));
        int[] pozitifSayi = Array.FindAll(sayi, j => j > 0);
        Array.Reverse(pozitifSayi);

        int pozitifTers = 0;
        for(int i= 0; i < sayi.Length; i++)
        {
            if (sayi[i] > 0)
            {
                sayi[i] = pozitifSayi[pozitifTers];
                pozitifTers++;
            }
        }
        Console.WriteLine("Yeni Dizi: " + string.Join(", ", sayi)); */

        #endregion
        #region 10- sıralama
        //10 elemanlı bir dizi oluşturun ve bu dizinin elemanlarını bir başka diziye ters sırada kopyalayın. İlk dizideki sıralama değişmeyecek, sadece ikinci dizideki sıralama ters olacak.

        /* int[] ilkDizi = {1, 2, 3, 4, 5, 6, 7, 8, 9};
        int[] ikinciDizi = new int[ilkDizi.Length];

        for (int i = 0; i < ilkDizi.Length; i++)
        {
            ikinciDizi[i] = ilkDizi[ilkDizi.Length - 1 - i];
        }

        Console.WriteLine("İlk Dizi: " + string.Join(", ", ilkDizi));
        Console.WriteLine("Ters Dizi: " + string.Join(", ", ikinciDizi));    */

        #endregion
        #region 11- Ters cumle
        //Klavyeden girilen bir cümlenin kelimelerini bir diziye aktarın. while döngüsü ile bu kelimeleri tersten ekrana yazdırın.

        /* Console.WriteLine("Bir cümle giriniz: ");
        string cumle = Console.ReadLine();

        string[] kelime = cumle.Split(' ');

        int i = kelime.Length -1;
        while (i >= 0)
        {
            Console.Write(kelime[i] + ' ');
            i--;            
        } */

        #endregion
        #region 12- en sık tekrar
        //100 elemanlı rastgele değerlerden oluşan bir tam sayı dizisinde en sık tekrar eden elemanı bulan ve kaç defa tekrarlandığını ekrana yazdıran bir program yazın. Bu işlemi bir foreach döngüsü ile gerçekleştirin.

        /* Random rnd = new Random();

        int[] sayi = new int[100];
        for (int i = 0; i < sayi.Length; i++)
        {
            sayi[i] = rnd.Next(1, 101); 
        }

        Console.WriteLine("Dizi: " + string.Join(", ", sayi)); */
        #endregion
        #region 13- toplam tek mi çift mi
        //Bir dizideki tek sayıları toplayan ve bu toplamın çift mi, tek mi olduğunu kontrol eden bir program yazın. Toplamla birlikte eğer toplam tek ise, "Toplam tek sayı" mesajı, çift ise "Toplam çift sayı" mesajı ekrana yazdırılmalı.

        /* int[] sayi = {1, 2, 3, 4, 5, 6, 7, 8};
        int x = 0;

         foreach (int num in sayi)
        {
            if (num % 2 != 0) // Tek sayı kontrolü
            {
                x += num;
            }
        }

        // Toplamın çift mi tek mi olduğunu kontrol et
        if (x % 2 == 0)
        {
            Console.WriteLine("Toplam çift sayı");
        }
        else
        {
            Console.WriteLine("Toplam tek sayı");
        }

        // Toplamı ekrana yazdır
        Console.WriteLine("Toplam: " + x); */

        #endregion
        #region 14- 3 e bölünen
        //20 elemanlı bir dizi oluşturun. Bu dizideki elemanların 3’e bölünebilenlerin toplamını bulan bir algoritma yazın. Sonucu ekrana yazdırırken her 5. elemandan sonra bir boşluk bırakın.

        /* int[] numbers = new int[20];
        Random random = new Random();

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(1, 101); 
        }

        int x = 0;

        foreach (int numara in numbers)
        {
            if (numara % 3 == 0)
            {
                x += numara;
            }
        }
        string result = x.ToString();
        for (int i = 0; i < result.Length; i++)
        {
            Console.Write(result[i]);
            if ((i + 1) % 5 == 0 && i != result.Length - 1)
            {
                Console.Write(' ');
            }
        }
        Console.WriteLine(); */



        #endregion
        #region 15- çift sıralama
        //Bir dizideki elemanları küçükten büyüğe sıralayan bir algoritma yazın. Ancak sıralama sırasında sadece tek sayılar sıralanmalı, çift sayılar yerlerinde kalmalıdır.

        /* int[] numbers = {1, 2, 93, 14, 23, 140, 12, 1, 34,};

    int[] sirali = numbers.Where(number => number % 2 != 0).OrderBy(number => number).ToArray();

    int oddIndex = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 != 0)
        {
            numbers[i] = sirali[oddIndex++];
        }
    }

    Console.WriteLine("Tek sayılar şu şekilde sıralanmıştır:");
    foreach (int number in numbers)
    {
        Console.Write(number + " ");
    } */

        #endregion
        #region 16- do while
        //do-while döngüsü kullanarak, klavyeden girilen sayıları bir diziye ekleyin. Kullanıcı sıfır girdiğinde döngüden çıkın ve dizideki tüm sayılarla birlikte ortalamayı ekrana yazdırın.

        // List<int> numbers = new List<int>();
        // int number;
        // do
        // {
        //     Console.Write("Bir sayı girin (Çıkmak için 0 yazınız): ");
        //     number = Convert.ToInt32(Console.ReadLine());

        //     if (number != 0)
        //     {
        //         numbers.Add(number);
        //     }
        // }
        // while (number != 0);

        // if (numbers.Count > 0)
        // {
        //     Console.WriteLine("Kullanıcının girdiği sayılar: " + string.Join(", ", numbers));

        //     double average = numbers.Average();
        //     Console.WriteLine("Sayıların ortalaması: " + average);
        // }
        // else
        // {
        //     Console.WriteLine("Lütfen bir sayı giriniz.");
        // }

        #endregion
    }
}
