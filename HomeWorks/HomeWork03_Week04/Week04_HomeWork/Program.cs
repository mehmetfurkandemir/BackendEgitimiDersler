namespace Week04_HomeWork;

class Program
{
    static void Main(string[] args)
    {
        #region Split method
        //1. Kullanıcıdan alınan bir cümledeki kelime sayısını bulan bir program yazın. (Split metodunu araştırınız.)
        //Console.Write("Bir cümle giriniz: ");
        //string cumle = Console.ReadLine();
        //string[] stringArr = cumle.Split(" ");
        //Console.Write($"girmiş olduğunuz cümlede {stringArr.length} adet kelime bulunmaktadır.")
        #endregion
        #region Büyük harf Küçük harf
        //2. Kullanıcıdan alınan bir metni tüm harfleri büyük olacak şekilde ve tüm harfleri küçük olacak şekilde alt alta tek bir Console.Write ile ekrana yazdıran bir program yazın.

        //Console.Write("Cümleniz: ");
        //string cumle = Console.ReadLine();

        //string buyukHarfCumle = cumle.ToUpper();
        //string kucukHarfCumle = cumle.ToLower();
        //Console.WriteLine(buyukHarfCumle + "\n" + kucukHarfCumle); // "\n" methodu ile alt alta yazdırdım.

        #endregion
        #region split kaç kez kelime geçti
        //3. Kullanıcıdan alınan bir cümlede belirli bir kelimenin kaç kez geçtiğini bulan bir program yazın. (Split metodunu araştırınız.)

        /* Console.WriteLine("Cümle giriniz: ");
        string cumle = Console.ReadLine();
        Console.WriteLine("Aranacak kelime giriniz: ");
        string aranacakKelime = Console.ReadLine();
        string[] stringArr = cumle.Split(" ");
        int sayac = 0;
        for (int i = 0; i < stringArr.Length; i++)
        {
            if(stringArr[i]==aranacakKelime){
                sayac++;
            }
        }

        Console.WriteLine($"Aramış olduğunuz kelime cümlede {sayac} kez geçmektedir."); */

        #endregion
        #region trim method
        //4. Kullanıcıdan alınan bir cümlenin başındaki ve sonundaki boşlukları kaldıran bir program yazın. (Trim metotlarını araştırınız.)

        //Console.Write("Cümlenizi giriniz: ");
        //string cumle = Console.ReadLine();

        //string boslukTrim = cumle.Trim();

        //Console.WriteLine(boslukTrim);

        #endregion
        #region Metin arama
        /* Console.Write("Bir cümle giriniz: ");
        string cumle = Console.ReadLine();
        Console.Write("Aranacak kelimeyi giriniz: ");
        string aranacak = Console.ReadLine();

        cumle.IndexOf(aranacak);
        Console.WriteLine(cumle.IndexOf(aranacak)); */

        #endregion

        //************************************************************************

        #region ondalıklı yuvarlama
        //1. Kullanıcıdan alınan bir ondalıklı sayıyı en yakın tam sayıya yuvarlayan bir program yazın.

        //Console.Write("Ondalıklı sayınızı giriniz: ");

        //double number = double.Parse(Console.ReadLine());
        //number = Math.Round(number);

        //Console.WriteLine(number);

        #endregion
        #region hangisi daha büyük
        //2. Kullanıcıdan alınan iki sayıdan hangisinin daha büyük olduğunu bulan bir program yazın.

        //Console.Write("İlk sayınızı giriniz: ");

        //int number1 = int.Parse(Console.ReadLine());

        //Console.Write("İkinci sayınızı giriniz: ");
        //int number2 = int.Parse(Console.ReadLine());

        //Console.WriteLine(number1 > number2
        //        ? "Birinci sayı daha büyüktür." 
        //        : number1 < number2 
        //        ? "İkinci sayı daha büyüktür." 
        //        : "İki sayı eşittir.");

        // burak hoca
        // math.Max(number1,number2)

        #endregion
        #region mutlak değer
        //Console.Write("Sayınızı giriniz: ");
        //double number = double.Parse(Console.ReadLine());

        //double mutlakDeger = Math.Abs(number);

        //Console.WriteLine("Sayının mutlak değeri: " + mutlakDeger);


        #endregion
        #region Karekök
        //Console.Write("Sayınızı giriniz: ");
        //double number = double.Parse(Console.ReadLine());

        //double karekok = Math.Sqrt(number);

        //Console.WriteLine("Karekök: " + karekok );


        //Burak hoca
        //int number = 5;
        //Console.Write(Math.Sqrt(number));

        #endregion
        #region üs alma

        //Console.Write("Alt sayınızı giriniz: ");
        //double alt = double.Parse(Console.ReadLine());

        //Console.Write("Üst sayınızı giriniz: ");
        //double ust = double.Parse(Console.ReadLine());

        //double sayininUssu = Math.Pow(alt, ust);

        //Console.WriteLine("Sonuç: " + sayininUssu);

        //Burak Hoca
        //int number = 4;
        //Console.Write(Math.Pow(number,3));


        #endregion
        #region Trigonometrik sinüs
        // Math.Sin() yöntemi

        //Console.WriteLine("Bir sayı giriniz: ");
        //double aci = double.Parse(Console.ReadLine());

        //double sinus = Math.Sin(aci);
        //Console.WriteLine("Sonuç: " + sinus);
        #endregion
        #region Radyan cinsinden sayı

        //(Math.PI / 180); methodu
        //Console.WriteLine("Bir sayı giriniz: ");

        //double derece = double.Parse(Console.ReadLine());

        //double radyan = derece * (Math.PI / 180);

        //Console.WriteLine("Açının radyan cinsinden değeri: " + radyan);

        #endregion
        #region logaritma
        //Math.Log(); methodu
        //Console.WriteLine("Bir sayı giriniz:");
        //double sayi = double.Parse(Console.ReadLine());
        //double logaritma = Math.Log(sayi);
        //Console.WriteLine("Sayının logaritması: " + logaritma);


        #endregion
        #region küçük sayı bulma

        //Console.Write("İlk sayıyı giriniz:");
        //double sayi1 = double.Parse(Console.ReadLine());

        //Console.WriteLine("İkinci sayıyı giriniz:");
        //double sayi2 = double.Parse(Console.ReadLine());

        //double kucukSayi = Math.Min(sayi1, sayi2);
        //Console.WriteLine("Küçük olan sayı: " + kucukSayi);

        #endregion
        #region ondalıklı sayıyı yuvarlama

        //Console.WriteLine("Bir ondalıklı sayı giriniz:");
        //double sayi = double.Parse(Console.ReadLine());

        //Console.WriteLine("Ondalık basamak sayısını giriniz:");
        //int ondalikBasamak = int.Parse(Console.ReadLine());
        //double sonucSayi = Math.Round(sayi, ondalikBasamak);
        //Console.WriteLine($"Sonuç: {sonucSayi}");


        #endregion

        //******************************************************************************

        #region 1) haftanın hangi günü
        //Console.WriteLine("Tarih giriniz: ");

        /* DateTime time = DateTime.Now;
        Console.WriteLine(time.DayOfWeek); */


        #endregion
        #region 2) datetime now

        //DateTime zaman = DateTime.Now;
        //Console.WriteLine(zaman);

        #endregion
        #region 3) tarih ekleme timespan
        //Console.WriteLine("Tarih giriniz: ");

        //DateTime kullanicininTarihi = DateTime.Parse(Console.ReadLine());
        //DateTime toplamTarih = kullanicininTarihi.AddDays(5);
        //Console.WriteLine($"5 gün eklenmiş hâli: {toplamTarih}");

        #endregion
        #region 4) tarih farkı

        //Console.WriteLine("İlk tarihi giriniz :");
        //DateTime ilkTarih = DateTime.Parse(Console.ReadLine());

        //Console.WriteLine("İkinci tarihi giriniz (gün/ay/yıl formatında):");
        //DateTime ikinciTarih = DateTime.Parse(Console.ReadLine());

        //int gunFarki = Math.Abs((ikinciTarih - ilkTarih).Days);

        //Console.WriteLine("İki tarih arasındaki gün farkı: " + gunFarki);

        #endregion
        #region 5) yılın kaçıncı günü

        /* 
                DateTime time = DateTime.Now;
                Console.WriteLine(time.DayOfYear); */

        #endregion
        #region 6) kontrol

        /* DateTime time = DateTime.Now;
        bool leap = DateTime.IsLeapYear(time.Year);
        string a=leap ? "artık yıl":"artık yıl değildir";
        Console.WriteLine(a); */


        #endregion
        #region 7) datetime object (try catch)

        /* try {
            Console.Write("Tarih giriniz");
        DateTime time = DateTime.Parse(Console.ReadLine());
        Console.WriteLine(time.ToString("dd/MM/yyyy"));
        
        }catch(Exception ex){
            Console.WriteLine($"girmiş olduğunuz tarih geçerli değildir. {ex.Message}" );
        }finally{
            Console.WriteLine("Ne olursa olsun çalışacak blok");
        } */


        #endregion
        #region 8) Ay adını yazdırmak

        //DateTime day = DateTime.Now;

        //string ayAdi = day.ToString("MMMM");

        //Console.WriteLine(ayAdi);

        #endregion
        #region 9) Compare

        /* DateTime time = new DateTime(2000,12,15);
        DateTime time2 = new DateTime(2020,12,15);

        int a = DateTime.Compare(time, time2);
        Console.WriteLine(a); */



        #endregion
        #region 10) 12 - 24 formatı
        //DateTime time = new DateTime(2021,12,15,12,00,00,00);
        //time.AddMilliseconds(1);
        //Console.WriteLine(time.ToString("dd/MM/yyyy HH:mm tt"));
        #endregion

        //*************************************************************************

        #region 1 pozitif - negatif - sıfır kontrolü
        /* Console.Write("Bir sayı giriniz: ");
        int number = int.Parse(Console.ReadLine());

        if (number > 0)
        {
            Console.WriteLine("Sayınız pozitif bir sayıdır.");
        }
        else if (number == 0)
        {
            Console.WriteLine("Sayınız sıfırdır.");
        }
        else
            Console.WriteLine("Sayınız negatif bir sayıdır"); */

        #endregion
        #region 2 üç sayı büyükten küçüğe

        /*  Console.Write("ilk sayı: ");
         int number1 = int.Parse(Console.ReadLine());
         Console.Write("ikinci sayı: ");
         int number2 = int.Parse(Console.ReadLine());
         Console.Write("üçüncü sayı: ");       
         int number3 = int.Parse(Console.ReadLine());

         if (number1 > number2 && number1 > number3)
         {
             //number1 en büyük number2 orta
             if (number2 > number3)
             {
                 Console.WriteLine($"{number1} {number2} {number3}");
             } 
         }

         if (number2 > number1 && number2 > number3)
         {
             //number2 en büyük number3 orta
             if (number3 > number1)
             {
                 Console.WriteLine($"{number2} {number3} {number1}");
             }
         }

         if (number3 > number2 && number3 > number1)
         {
             //number3 en büyük number2 orta
             if (number2 > number1)
             {
                 Console.WriteLine($"{number3} {number2} {number1}" );
             }
         }

         if (number1 > number2 && number1 > number3)
         {
             //number1 en büyük number2 orta
             if (number3 > number2)
             {
                 Console.WriteLine($"{number1} {number3} {number2}");
             } 
         }

         if (number2 > number1 && number2 > number3)
         {
             //number2 en büyük number3 orta
             if (number1 > number3)
             {
                 Console.WriteLine($"{number2} {number1} {number3}");
             }
         }

         if (number3 > number2 && number3 > number1)
         {
             //number3 en büyük number2 orta
             if (number1 > number2)
             {
                 Console.WriteLine($"{number3} {number1} {number2}" );
             }
         } */


        #endregion
        #region 3 sesli harf kontrolü
        /* Console.WriteLine("Yazınız: ");
        char karakter = Console.ReadLine()[0];

        bool sesliHarf = (karakter == 'a' || karakter == 'e' || karakter == 'ı' || karakter == 'i' || karakter == 'o' || karakter == 'ö' || karakter == 'u' || karakter == 'ü');
        if (sesliHarf)
        {
            System.Console.WriteLine($"{karakter} sesli harfir.");
        }
        else
        {
            System.Console.WriteLine($"{karakter} sessiz harftir.");
        } */

        #endregion
        #region 4 artık yıl
        /* Console.Write("Yıl giriniz: ");
            int yil = int.Parse(Console.ReadLine());
            bool artikYil = (yil % 4 == 0 && yil % 100 != 0) || (yil % 400 == 0);
        

            Console.WriteLine(artikYil  ? $"{yil} artık yıldır." 
                                        : $"{yil} artık yıl değildir."); */

        #endregion
        #region 5 geometri üçgen
        /* Console.Write("İlk kenar uzunluğu giriniz: ");
        int aci1 = int.Parse(Console.ReadLine());
        Console.Write("İkinci kenar uzunluğu giriniz: ");
        int aci2 = int.Parse(Console.ReadLine());
        Console.Write("Üçüncü kenar uzunluğu giriniz: ");
        int aci3 = int.Parse(Console.ReadLine());

        if (aci1 + aci2 > aci3 && aci2 + aci3 > aci1 && aci1 + aci3 > aci2)
        {
            Console.WriteLine("Bu açılar ile üçgen oluşturulabilir!");
        }
        else
        {
            Console.WriteLine("Bu açılar ile üçgen oluşturulamaz!");
        } */
        #endregion
        #region 6 harf karşılığı not
        /* Console.Write("Notunuzu giriniz: ");
        int not = int.Parse(Console.ReadLine());

        if (not >= 90 && not <= 100)
        {
            Console.WriteLine("Harf notunuz = AA'dır.");
        }
        if (not >= 85 && not <= 89)
        {
            Console.WriteLine("Harf notunuz = BA'dır.");
        }
        if (not >= 80 && not <=84)
        {
            Console.WriteLine("Harf notunuz = BB'dir.");
        }
        if (not >=70 && not <= 79)
        {
            Console.WriteLine("Harf notunuz = CB'dir.");
        }
        if (not >= 60 && not <= 69)
        {
            Console.WriteLine("Harf notunuz = CC'dir.");
        }
        if (not >= 55 && not <= 59)
        {
            Console.WriteLine("Harf notunuz = DC'dir.");
        }
        if (not >= 50 && not <= 54)
        {
            Console.WriteLine("Harf notunuz = DD'dir.");
        }
        if (not >= 40 && not <= 49)
        {
            Console.WriteLine("Harf notunuz = FD'dir.");
        }
        if (not >= 0 && not <= 39)
        {
            Console.WriteLine("Harf notunuz = FF'dir.");
        } */
        #endregion
        #region 7 en büyük sayı

        /*  Console.WriteLine("Bir sayı giriniz: ");
         int number1 = int.Parse(Console.ReadLine());
         Console.WriteLine("İkinci sayıyı giriniz: ");
         int number2 = int.Parse(Console.ReadLine());
         Console.WriteLine("Üçüncü sayıyı giriniz: ");
         int number3 = int.Parse(Console.ReadLine());

         int enBuyuk = number1;

         if (number2 > enBuyuk)
         {
             enBuyuk = number2;
         }

         if (number3 > enBuyuk)
         {
             enBuyuk = number3;
         }

         Console.WriteLine("En büyük sayı: " + enBuyuk); */


        #endregion
        #region 8 3 ve 5 e tam bölünen (mod alma %)
        /* Console.WriteLine("Sayı giriniz: ");
        int number = int.Parse(Console.ReadLine());

        if(number % 3 == 0 && number % 5 == 0)
        {
            Console.WriteLine("Sayınız 3 ve 5'e tam bölünür.");
        }
        else
        {
            Console.WriteLine("Sayınız 3 ve 5'e tam bölünmez.");
        } */
        #endregion
        #region 9 4 işlem

        /* Console.WriteLine("ilk sayı: ");
        double sayi1 = double.Parse(Console.ReadLine());

        Console.WriteLine("ikinci sayı: ");
        double sayi2 = double.Parse(Console.ReadLine());

        Console.WriteLine("işlem girin (+,-,*,/): ");
        char islem = Console.ReadLine()[0];

        double sonuc = 0;
        bool islemGecerli = true;

        switch (islem)
        {
            case '+':
            sonuc = sayi1 + sayi2;
            break;
            case '-':
            sonuc = sayi1 - sayi2;
            break;
            case '*':
            sonuc = sayi1 * sayi2;
            break;
            case '/':
            sonuc = sayi1 / sayi2;
            break;
            default:
            System.Console.WriteLine("İşlem geçersiz");
            islemGecerli = false;
            break;

        }
 */

        #endregion
        #region 10 asal kontrol ?

        /* Console.WriteLine("Sayı: ");
        int asalSayi = int.Parse(Console.ReadLine());

        if (asalSayi == 0 && asalSayi == 1)
        {
            Console.WriteLine("Girmiş olduğunuz sayı asal sayıdır");
        }

        if (asalSayi < 0)
        {
            Console.WriteLine("Girmiş olduğunuz sayı asal sayı değildir");
        }


        if (asalSayi % asalSayi == 1 && asalSayi % 1 == asalSayi) */


        #endregion

        //*******************************************************************

        #region 1 KDV
        /* Console.WriteLine("Para değerini giriniz:");
        decimal tutar = decimal.Parse(Console.ReadLine());

        decimal kdvOran;
        decimal kdvTutar;
        decimal kdvFiyat;

        if (tutar <= 1000)
        {
            kdvOran = 0.20m;
        }
        else
        {
            kdvOran = 0.08m;
        }

        kdvTutar = tutar * kdvOran;
        kdvFiyat = tutar + kdvTutar;

        Console.WriteLine($"KDV Oranı: {kdvOran * 100}"); */

        #endregion
        #region 2 Heron formülü ?

        #endregion
        #region 3 Taksimetre

        /* const decimal acilisUcreti = 30m;
        const decimal kmBasinaUcret = 20m;
        const decimal minTutar = 100m;

        Console.Write("Gidilen mesafeyi km cinsinden giriniz: ");
        decimal mesafe = decimal.Parse(Console.ReadLine());

        decimal toplam = acilisUcreti + (mesafe * kmBasinaUcret);

        if (toplam < minTutar)
        {
            toplam = minTutar;
        }

        Console.WriteLine($"Ödeme: {toplam} TL"); */

        #endregion
        #region 4 Daire hesap

        /*         Console.Write("Yarıçap değerini giriniz: ");
                int yaricap = int.Parse(Console.ReadLine());

                //Alan için

                Console.WriteLine($"Alan: {yaricap * yaricap * 3,14}");

                //Çevre için

                Console.WriteLine($"Çevre: {2 * yaricap * 3,14}"); */


        #endregion
        #region 5 Vücut Kitle indeksi

        /* Console.Write("Kilonuzu giriniz: ");
        int kilo = int.Parse(Console.ReadLine());
        Console.Write("Boyunuzu giriniz: ");
        int boy = int.Parse(Console.ReadLine());

        Console.WriteLine($"Kitle Endeksiniz: {kilo / boy * boy}"); */

        #endregion
        #region 6 Manav

        /* double armutFiyat = 45.50;
        double bamyaFiyat = 81.40;
        double domatesFiyat = 45.00;
        double muzFiyat = 65.00;
        double patlicanFiyat = 45.00;

        Console.Write("Armut: ");
        double armutKg = Convert.ToDouble(Console.ReadLine());
        Console.Write("Bamya: ");
        double bamyaKg = Convert.ToDouble(Console.ReadLine());
        Console.Write("Domates: ");
        double domatesKg = Convert.ToDouble(Console.ReadLine());
        Console.Write("Muz: ");
        double muzKg = Convert.ToDouble(Console.ReadLine());
        Console.Write("Patlıcan: ");
        double patlicanKg = Convert.ToDouble(Console.ReadLine());

        double toplam = armutFiyat + armutKg + bamyaFiyat + bamyaKg + domatesFiyat + domatesKg + muzFiyat + muzKg + patlicanFiyat + patlicanKg;

        Console.WriteLine($"Toplam tutar: {toplam} TL"); */


        #endregion
        #region 7 Switch Case Hesap makinesi

        /*  double sayi1,sayi2, sonuc = 0;
         char islem;
         Console.Write("1. Sayıyı Giriniz: ");
         sayi1 = Convert.ToDouble(Console.ReadLine());
         Console.Write("2. Sayıyı Giriniz: ");
         sayi2 = Convert.ToDouble(Console.ReadLine());

         Console.WriteLine("İşleminizi Seçin: \n + \n - \n * \n /");

         islem = Convert.ToChar(Console.ReadLine());

         switch(islem)
         {
             case '+':
                 sonuc = sayi1 + sayi2;
                 Console.WriteLine("Sonuç = " + sonuc);
                 break;
             case '-':
                 sonuc = sayi1 - sayi2;
                 Console.WriteLine("Sonuç = " + sonuc);
                 break;
             case '*':
                 sonuc = sayi1 * sayi2;
                 Console.WriteLine("Sonuç = " + sonuc);
                 break;
             case '/':
                 sonuc = sayi1 / sayi2;
                 Console.WriteLine("Sonuç = " + sonuc);
                 break;
             default:
             Console.WriteLine("Hatalı işlem!");
             break;
         } */




        #endregion
        #region 8 Çin Zodyağı

        /* Console.WriteLine("Doğum yılınızı giriniz: ");
        int dogum = int.Parse(Console.ReadLine());

        if (dogum % 12 == 0){
            Console.WriteLine("Çin Zodyağınız: Maymun");
        }
        else if (dogum % 12 == 1){
            Console.WriteLine("Çin Zodyağınız: Horoz");
        }
        else if (dogum % 12 == 2){
            Console.WriteLine("Çin Zodyağınız: Köpek");
        }
        else if (dogum % 12 == 3){
            Console.WriteLine("Çin Zodyağınız: Domuz");
        }
        else if (dogum % 12 == 4){
            Console.WriteLine("Çin Zodyağınız: Fare");
        }
        else if (dogum % 12 == 5){
            Console.WriteLine("Çin Zodyağınız: Öküz");
        }
        else if (dogum % 12 == 6){
            Console.WriteLine("Çin Zodyağınız: Kaplan");
        }
        else if (dogum % 12 == 7){
            Console.WriteLine("Çin Zodyağınız: Tavşan");
        }
        else if (dogum % 12 == 8){
            Console.WriteLine("Çin Zodyağınız: Ejderha");
        }
        else if (dogum % 12 == 9){
            Console.WriteLine("Çin Zodyağınız: Fare");
        } */

        #endregion
        #region 9 Artık Yıl

        /* Console.Write("Yıl giriniz: ");
        int yil = int.Parse(Console.ReadLine());
        bool artikYil = (yil % 4 == 0 && yil % 100 != 0) || (yil % 400 == 0);


        Console.WriteLine(artikYil  ? $"{yil} artık yıldır." 
                                    : $"{yil} artık yıl değildir."); */


        #endregion

        //*********************************************************************

        #region 1 Ortalamasını Alma ??
        //??
        #endregion
        #region 2 Çarpım Tablosu (for loop ile yaptım)

        /* int girilenSayi, i, sonuc;
        Console.Write("Bir sayı giriniz: ");
        girilenSayi = int.Parse(Console.ReadLine());

        for(i=0; i<=10; i++)
        {
            sonuc = girilenSayi * i;
            Console.WriteLine("{0}x{1}={2}", girilenSayi, i, sonuc);
        } */

        #endregion
        #region 3 Sıralama ??

        //??

        #endregion
        #region 4 Çarpanlarını bulma
        /* Console.WriteLine("Çarpanını bulmak istediğiniz bir sayı giriniz");
        int number = 0;
        int carpan = int.Parse(Console.ReadLine());

        Console.Write("Çarpanlar: ");

        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                Console.Write(i + " ");
                carpan += i;
            }
        } */

        #endregion
        #region 5 Sayıyı tersine çevirme

        //https://www.yazilimkodlama.com/programlama/c-klavyeden-girilen-sayiyi-ters-cevirme/
        //while loop ile yaptım.

        /* Console.WriteLine("Terse çevirmek istediğiniz sayıyı giriniz: ");
        int sayi;
        int yazilacakRakam;
        sayi = int.Parse(Console.ReadLine());

        while (sayi > 10)
        {
            yazilacakRakam = sayi % 10;
            Console.Write(yazilacakRakam);
            sayi /= 10;
        }
        Console.WriteLine(sayi); */

        #endregion
        #region 6 Pozitif bölen

        /* int sayi, sayac = 0;
        Console.Write("Sayınızı giriniz: ");
        sayi = int.Parse(Console.ReadLine());
        for(int i = 1; i <= sayi; i++){
            if(sayi % i == 0){
                Console.WriteLine(i);
                sayac++;
            }
        }
        Console.WriteLine("Sayının bölenleri: " + sayac); */

        #endregion
        #region 7 Mükemmel sayı

        /* Console.Write("Sayınızı giriniz: ");
        int sayi;
        sayi = int.Parse(Console.ReadLine());
        int toplam = 0;

        for (int i = 1; i < sayi; i++)
        {
            if (sayi % i == 0)
            {
                toplam = toplam + i;
            }
        }
        if (toplam == sayi)
        {
            Console.WriteLine($"Girmiş olduğunuz {sayi} sayısı mükemmel sayıdır.");
        }
        else
        {
            Console.WriteLine($"Girmiş olduğunuz {sayi} sayısı mükemmel sayı değildir.");
        } */

        #endregion
        #region 8 Fibonacci

        /* Console.Write("Bir sayı girin: ");
        int n = int.Parse(Console.ReadLine());

        int a = 0, b = 1, c;

        Console.Write("Fibonacci Serisi: ");
        Console.Write($"{a} {b}");

        for (int i = 2; i < n; i++)
        {
            c = a + b;
            Console.Write($" {c}");
            a = b;
            b = c;
        } */

        #endregion

        //****************************************************************************

        #region 1) haftanın günü
        /* Console.Write("Bir sayı giriniz: ");
        int sayi;
        sayi = int.Parse(Console.ReadLine());

        switch (sayi)
        {
            case 1:
                Console.WriteLine("Pazartesi");
                break;
            case 2:
                Console.WriteLine("Salı");
                break;
            case 3:
                Console.WriteLine("Çarşamba");
                break;
            case 4:
                Console.WriteLine("Perşembe");
                break;
            case 5:
                Console.WriteLine("Cuma");
                break;
            case 6:
                Console.WriteLine("Cumartesi");
                break;
            case 7:
                Console.WriteLine("Pazar");
                break;
            default:
            Console.WriteLine("Lütfen 1 ile 7 arasında bir sayı giriniz!");
            break;
        } */
        #endregion
        #region 2) ay adı yazdırmak

        /* Console.WriteLine("Bir sayı giriniz (1-12): ");

        int ayAdi;
        ayAdi = int.Parse(Console.ReadLine());  
        switch (ayAdi)
        {
            case 1:
                Console.WriteLine("Ocak");
                break;
            case 2:
                Console.WriteLine("Şubat");
                break;
            case 3:
                Console.WriteLine("Mart");
                break;
            case 4:
                Console.WriteLine("Nisan");
                break;
            case 5:
                Console.WriteLine("Mayıs");
                break;
            case 6:
                Console.WriteLine("Haziran");
                break;
            case 7:
                Console.WriteLine("Temmuz");
                break;
            case 8:
                Console.WriteLine("Ağustos");
                break;
            case 9:
                Console.WriteLine("Eylül");
                break;
            case 10:
                Console.WriteLine("Ekim");
                break;
            case 11:
                Console.WriteLine("Kasım");
                break;
            case 12:
                Console.WriteLine("Aralık");
                break;
            default:
                Console.WriteLine("Lütfen 1 ile 12 arasında bir sayı giriniz!");
                break;
        }    */
        #endregion
        #region 3) hesap mak.
        /* double sayi1,sayi2, sonuc = 0;
        char islem;
        Console.Write("1. Sayıyı Giriniz: ");
        sayi1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("2. Sayıyı Giriniz: ");
        sayi2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("İşleminizi Seçin: \n + \n - \n * \n /");

        islem = Convert.ToChar(Console.ReadLine());

        switch(islem)
        {
            case '+':
                sonuc = sayi1 + sayi2;
                Console.WriteLine("Sonuç = " + sonuc);
                break;
            case '-':
                sonuc = sayi1 - sayi2;
                Console.WriteLine("Sonuç = " + sonuc);
                break;
            case '*':
                sonuc = sayi1 * sayi2;
                Console.WriteLine("Sonuç = " + sonuc);
                break;
            case '/':
                sonuc = sayi1 / sayi2;
                Console.WriteLine("Sonuç = " + sonuc);
                break;
            default:
            Console.WriteLine("Hatalı işlem!");
            break;
        } */

        #endregion
        #region 4) sesli sessiz harf

        /* Console.Write("Bir harf giriniz: ");
        char harf;
        harf = char.Parse(Console.ReadLine());

        switch (harf)
        {
            case 'a':
            case 'e':
            case 'ı':
            case 'i':
            case 'o':
            case 'ö':
            case 'u':
            case 'ü':
                Console.WriteLine($"{harf} sesli bir harftir");
            break;
            default:
                Console.WriteLine($"{harf} sessiz bir harftir.");
            break;
        } */

        #endregion
        #region 5) mevsim adı
        // Kullanıcıdan alınan bir sayıya göre (1-4 arası) mevsim adını yazdıran bir program yazın.

        /* Console.WriteLine("1 ile 4 arasında bir sayı giriniz: ");
        int sayi;
        sayi = int.Parse(Console.ReadLine());

        switch (sayi)
        {
            case 1:
                Console.WriteLine("İlkbahar");
                break;
            case 2:
                Console.WriteLine("Yaz");
                break;
            case 3:
                Console.WriteLine("Sonbahar");
                break;
            case 4:
                Console.WriteLine("Kış");
                break;
            default:
                Console.WriteLine("Lütfen 1 ile 4 arasında bir sayı giriniz.");
                break;
        }  */

        #endregion
        #region 6) geçme kalma A B C D F
        //6. Kullanıcıdan alınan bir nota göre (A, B, C, D, F) geçme veya kalma durumunu belirleyen bir program yazın.
        /* Console.WriteLine();
            Console.WriteLine("Harf notunuzu giriniz (A, B, C, D, F)");
            char not;
            not = char.Parse(Console.ReadLine());

            switch (not)
            {
                case 'A':
                    Console.WriteLine("Geçtiniz!");
                    break;
                case 'B':
                    Console.WriteLine("Geçtiniz!");
                    break;
                case 'C':
                    Console.WriteLine("Geçtiniz!");
                    break;
                case 'D':
                    Console.WriteLine("Geçtiniz!");
                    break;
                case 'F':
                    Console.WriteLine("Kaldınız!");
                    break;
                default:
                    Console.WriteLine("Lütfen A ile F arasında bir harf notu giriniz!");
                    break;
            } */
        #endregion
        #region 7) Türk Para Birimi

        //Kullanıcıdan alınan bir sayıya göre (1-5 arası) Türk para biriminin adını yazdıran bir program yazın (1 Kr, 5 Kr, 10 Kr, 25 Kr, 50 Kr).

        /* Console.WriteLine("1 ile 5 arasında bir sayı giriniz: ");
        int sayi;
        sayi = int.Parse(Console.ReadLine());

        switch (sayi)
        {
            case 1:
                Console.WriteLine("1 Kr");
                break;
            case 2:
                Console.WriteLine("5 Kr");
                break;
            case 3:
                Console.WriteLine("10 Kr");
                break;
            case 4:
                Console.WriteLine("25 Kr");
                break;
            case 5:
                Console.WriteLine("50 Kr");
                break;
            default:
                Console.WriteLine("Lütfen 1 ile 5 arasında bir sayı giriniz!");
                break;
        } */

        #endregion
        #region 8) Geometrik Şekil

        //Kullanıcıdan alınan bir sayıya göre (0-6 arası) bir geometrik şeklin adını yazdıran bir program yazın (0: Nokta, 1: Çizgi, 2: Açı, 3: Üçgen, 4: Kare, 5: Beşgen, 6: Altıgen).

        /* Console.WriteLine("Bir sayı giriniz (1-6): ");
        int sayi;
        sayi = int.Parse(Console.ReadLine());

        switch (sayi)
        {
            case 0:
                Console.WriteLine("Nokta");
                break;
            case 1:
                Console.WriteLine("Çizgi");
                break;
            case 2:
                Console.WriteLine("Açı");
                break;
            case 3:
                Console.WriteLine("Üçgen");
                break;
            case 4:
                Console.WriteLine("Kare");
                break;
            case 5:
                Console.WriteLine("Beşgen");
                break;
            case 6:
                Console.WriteLine("Altıgen");
                break;

            default:
                Console.WriteLine("Lütfen 1 ile 6 arasında bir sayı giriniz!");
                break;
        } */
        #endregion
        #region 9) Sayı Sıfatı
        // Kullanıcıdan alınan bir sayıya göre (1-5 arası) Türkçe sayı sıfatını yazdıran bir program yazın (1:

        /* Console.WriteLine("1-5 arasında bir sayı giriniz: ");
        int sayi;
        sayi = int.Parse(Console.ReadLine());

        switch (sayi)
        {
            case 1:
                Console.WriteLine("Birinci");
                break;
            case 2:
                Console.WriteLine("İkinci");
                break;
            case 3:
                Console.WriteLine("Üçüncü");
                break;
            case 4:
                Console.WriteLine("Dördüncü");
                break;
            case 5:
                Console.WriteLine("Beşinci");
                break;
            default:
                Console.WriteLine("Lütfen 1 ile 5 arasında bir sayı giriniz!");
                break;
        } */


        #endregion
        #region 10) Matematiksel İşlem

        //Kullanıcıdan alınan bir karaktere göre (+, -, *, /, %) matematiksel işlemin adını yazdıran bir program yazın

        /* Console.WriteLine("Bir karakter giriniz (+, -, *, /, %)");
        char islem;
        islem = char.Parse(Console.ReadLine());

        switch (islem)
        {
            case '+':
                Console.WriteLine("Toplama İşlemi");
                break;
            case '-':
                Console.WriteLine("Çıkarma İşlemi");
                break;
            case '*':
                Console.WriteLine("Çarpma İşlemi");
                break;
            case '/':
                Console.WriteLine("Bölme İşlemi");
                break;
            case '%':
                Console.WriteLine("Mod İşlemi");
                break;

            default:
                Console.WriteLine("Lütfen geçerli bir karakter");
                break;
        }    */

        #endregion
    }
