namespace HomeWork02;

class Program
{
    static void Main(string[] args)
    {
        #region String Methods
        //1: 1. Kullanıcıdan alınan bir cümledeki kelime sayısını bulan bir program yazın. (Split metodunu araştırınız.)

        // Console.Write("Bir cümle giriniz: ");
        // string sentence = Console.ReadLine(); 
        // string[] sentenceSplit = sentence.Split(' '); 

        // Console.WriteLine($"Girmiş olduğunuz cümlede {sentenceSplit.Length} adet kelime vardır."); 

        //2: 2. Kullanıcıdan alınan bir metni tüm harfleri büyük olacak şekilde ve tüm harfleri küçük olacak şekilde alt alta tek bir Console.Write ile ekrana yazdıran bir program yazın.

        // Console.Write("Bir cümle giriniz: ");
        // string sentence = Console.ReadLine();
        // string upperSentence = sentence.ToUpper();
        // string lowerSentence = sentence.ToLower();
        // System.Console.WriteLine($"Büyük cümle: {upperSentence} \n Küçük cümle: {lowerSentence}");

        //3: Kullanıcıdan alınan bir cümlede belirli bir kelimenin kaç kez geçtiğini bulan bir program yazın. (Split metodunu araştırınız.)

        // Console.Write("Bir cümle giriniz: ");
        // string sentence = Console.ReadLine();

        // Console.Write("Aranacak kelimeyi giriniz: ");
        // string arananKelime = Console.ReadLine();
        // string[] words = sentence.Split(' ');
        // int count = 0;
        // Console.WriteLine($"'{arananKelime}' kelimesi cümlede {count} kez geçiyor.");

        //4: Kullanıcıdan alınan bir cümlenin başındaki ve sonundaki boşlukları kaldıran bir program yazın.

        // Console.WriteLine("Cümle giriniz: ");
        // string sentence = Console.ReadLine();

        // string bosluksuzSentence = sentence.Trim();

        // Console.WriteLine($"Boşluksuz cümle = {bosluksuzSentence}");






        #endregion
        #region Number Methods
        //1: Kullanıcıdan alınan bir ondalıklı sayıyı en yakın tam sayıya yuvarlayan bir program yazın.

        // System.Console.WriteLine("Ondalıklı sayı giriniz: ");
        // double number = Convert.ToDouble(Console.ReadLine());

        // int newNumber = (int)Math.Round(number);
        // System.Console.WriteLine($"Yuvarlanmış sayınız: {newNumber}");

        //2: Kullanıcıdan alınan iki sayıdan hangisinin daha büyük olduğunu bulan bir program yazın.

        // System.Console.WriteLine("ilk sayı: ");
        // double firstNumber = Convert.ToDouble(Console.ReadLine());

        // System.Console.WriteLine("İkinci sayı: ");
        // double secondNumber = Convert.ToDouble(Console.ReadLine());

        // if(firstNumber > secondNumber)
        // {
        //     System.Console.WriteLine($"{firstNumber} daha büyük.");
        // }else{
        //     System.Console.WriteLine($"{secondNumber} daha büyük");
        // }

        //3: Kullanıcıdan alınan bir sayının mutlak değerini hesaplayan bir program yazın.
        // System.Console.WriteLine("Mutlak değer alınacak sayıyı giriniz: ");

        // int number = Convert.ToInt32(Console.ReadLine());

        // int mutlakDeger = Math.Abs(number);

        // System.Console.WriteLine(mutlakDeger);

        //4: Kullanıcıdan alınan bir sayının karekökünü hesaplayan bir program yazın.

        // System.Console.WriteLine("Karekök alınacak sayıyı giriniz: ");
        // int number = Convert.ToInt32(Console.ReadLine());

        // double mutlakDeger = Math.Sqrt(number);

        // System.Console.WriteLine(mutlakDeger);

        //5: Kullanıcıdan alınan iki sayı için üs alma işlemi yapan bir program yazın (örneğin, 2^3).

        // System.Console.WriteLine("Üssü alınacak ilk sayı: ");
        // int number = Convert.ToInt32(Console.ReadLine());

        // System.Console.WriteLine("Üssü alınacak ikinci sayı: ");
        // int secondNumber = Convert.ToInt32(Console.ReadLine());

        // double result = Math.Pow(number, secondNumber);

        // System.Console.WriteLine($"Üssü: {result}");

        //6: Kullanıcıdan alınan bir sayının trigonometrik sinüs değerini hesaplayan bir program yazın.

        // System.Console.WriteLine("bir sayı: ");
        // int number = int.Parse(Console.ReadLine());

        // double newNumber = Math.Sin(number);
        // System.Console.WriteLine(newNumber);

        //7: Kullanıcıdan alınan bir açının (derece cinsinden) radyan cinsinden değerini hesaplayan bir program yazın.
        //(Math.PI / 180); methodu
        //Console.WriteLine("Bir sayı giriniz: ");

        //double derece = double.Parse(Console.ReadLine());

        //double radyan = derece * (Math.PI / 180);

        //Console.WriteLine("Açının radyan cinsinden değeri: " + radyan);

        //8: Kullanıcıdan alınan bir sayının logaritmasını (doğal logaritma) hesaplayan bir program yazın.

        // Console.Write("Logaritma sayı: ");
        // double number = double.Parse(Console.ReadLine());
        // double newNumber = Math.Log(number);
        // System.Console.WriteLine(newNumber);

        //9: Kullanıcıdan alınan iki sayı arasındaki küçük olanı bulan bir program yazın.

        // Console.Write("İlk sayı: ");
        // int number1 = int.Parse(Console.ReadLine());

        // Console.Write("İkinci sayı: ");
        // int number2 = int.Parse(Console.ReadLine());

        // if (number1 > number2)
        // {
        //     System.Console.WriteLine($"Büyük olan sayı: " + number1);
        // }
        // else
        // {
        //     System.Console.WriteLine($"Büyük olan sayı: " + number2);
        // }

        //10: Kullanıcıdan alınan bir ondalıklı sayıyı, yine kullanıcıdan alınan ondalık basamak sayısına göre yuvarlayan bir program yazın.
        // Console.WriteLine("Bir ondalıklı sayı giriniz:");
        // double sayi = double.Parse(Console.ReadLine());

        // Console.WriteLine("Ondalık basamak sayısını giriniz:");
        // int ondalikBasamak = int.Parse(Console.ReadLine());
        // double sonucSayi = Math.Round(sayi, ondalikBasamak);
        // Console.WriteLine($"Sonuç: {sonucSayi}");



        #endregion
        #region DateTime
        //1) haftanın hangi günü
        //Console.WriteLine("Tarih giriniz: ");

        /* DateTime time = DateTime.Now;
        Console.WriteLine(time.DayOfWeek); */

        //2) datetime now

        //DateTime zaman = DateTime.Now;
        //Console.WriteLine(zaman);

        //3) tarih ekleme timespan
        //Console.WriteLine("Tarih giriniz: ");

        //DateTime kullanicininTarihi = DateTime.Parse(Console.ReadLine());
        //DateTime toplamTarih = kullanicininTarihi.AddDays(5);
        //Console.WriteLine($"5 gün eklenmiş hâli: {toplamTarih}");

        //4) tarih farkı

        //Console.WriteLine("İlk tarihi giriniz :");
        //DateTime ilkTarih = DateTime.Parse(Console.ReadLine());

        //Console.WriteLine("İkinci tarihi giriniz (gün/ay/yıl formatında):");
        //DateTime ikinciTarih = DateTime.Parse(Console.ReadLine());

        //int gunFarki = Math.Abs((ikinciTarih - ilkTarih).Days);

        //Console.WriteLine("İki tarih arasındaki gün farkı: " + gunFarki);

        //5) yılın kaçıncı günü

        //DateTime time = DateTime.Now;
        //Console.WriteLine(time.DayOfYear);

        //6) Kontrol
        // DateTime time = DateTime.Now;
        // bool leap = DateTime.IsLeapYear(time.Year);
        // string a=leap ? "artık yıl":"artık yıl değildir";
        // Console.WriteLine(a);

        //7) try {
        //     Console.Write("Tarih giriniz");
        // DateTime time = DateTime.Parse(Console.ReadLine());
        // Console.WriteLine(time.ToString("dd/MM/yyyy"));

        // }catch(Exception ex){
        //     Console.WriteLine($"girmiş olduğunuz tarih geçerli değildir. {ex.Message}" );
        // }finally{
        //     Console.WriteLine("Ne olursa olsun çalışacak blok");
        // } 

        //8) Ay adını yazdırmak

        //DateTime day = DateTime.Now;

        //string ayAdi = day.ToString("MMMM");

        //Console.WriteLine(ayAdi);

        //9) Comparing
        // DateTime time = new DateTime(2000, 12, 15);
        // DateTime time2 = new DateTime(2020, 12, 15);

        // int a = DateTime.Compare(time, time2);
        // Console.WriteLine(a);

        //10) 12-24 Formatı
        //DateTime time = new DateTime(2021,12,15,12,00,00,00);
        //time.AddMilliseconds(1);
        //Console.WriteLine(time.ToString("dd/MM/yyyy HH:mm tt"));
        #endregion
        #region If Else
        //1) Kullanıcıdan alınan bir sayının pozitif, negatif veya sıfır olduğunu kontrol eden bir program yazın.
        // System.Console.WriteLine("Bir sayı giriniz: ");
        // int number = int.Parse(Console.ReadLine());
        // if (number < 0)
        // {
        //     System.Console.WriteLine("Sayınız negatiftir.");
        // }
        // else if (number == 0)
        // {
        //     System.Console.WriteLine("Sayınız 0'a eşittir.");
        // }
        // else
        // {
        //     System.Console.WriteLine("Sayınız pozitiftir.");
        // }

        //2) Kullanıcıdan alınan üç sayıyı büyükten küçüğe sıralayan bir program yazın.

        // System.Console.WriteLine("İlk sayıyı giriniz: ");
        // int number1 = int.Parse(Console.ReadLine());
        // System.Console.WriteLine("İkinci sayıyı giriniz: ");
        // int number2 = int.Parse(Console.ReadLine());
        // System.Console.WriteLine("Üçüncü sayıyı giriniz: ");
        // int number3 = int.Parse(Console.ReadLine());

        // int maxNumber = number1;

        // if (number2 > maxNumber)
        // {
        //     maxNumber = number2;
        // }

        // if (number3 > maxNumber)
        // {
        //     maxNumber = number3;
        // }

        // System.Console.WriteLine($"{maxNumber} en büyük sayıdır!");

        //3) Kullanıcıdan alınan bir karakterin sesli harf olup olmadığını kontrol eden bir program yazın. (Veya (||) operatörünü araştırınız.)

        // System.Console.WriteLine("Bir karakter giriniz: ");
        // char karakter = Console.ReadLine()[0];

        // bool sesliHarf = (karakter == 'a' || karakter == 'e' || karakter == 'ı' || karakter == 'i' || karakter == 'o' || karakter == 'ö' || karakter == 'u' || karakter == 'ü');
        // if (sesliHarf)
        // {
        //     System.Console.WriteLine($"{karakter} sesli harfir.");
        // }
        // else
        // {
        //     System.Console.WriteLine($"{karakter} sessiz harftir.");
        // }

        //4) Kullanıcıdan alınan bir yılın artık yıl olup olmadığını kontrol eden bir program yazın.
        // Console.Write("Yıl giriniz: ");
        // int yil = int.Parse(Console.ReadLine());
        // bool artikYil = (yil % 4 == 0 && yil % 100 != 0) || (yil % 400 == 0);


        // Console.WriteLine(artikYil ? $"{yil} artık yıldır."
        //                             : $"{yil} artık yıl değildir."); */

        //5) Kullanıcıdan alınan üç sayının bir üçgen oluşturup oluşturamayacağını kontrol eden bir program yazın. (Geometride üçgen teorisini araştırınız.)

        // Console.Write("İlk kenar uzunluğu giriniz: ");
        // int aci1 = int.Parse(Console.ReadLine());
        // Console.Write("İkinci kenar uzunluğu giriniz: ");
        // int aci2 = int.Parse(Console.ReadLine());
        // Console.Write("Üçüncü kenar uzunluğu giriniz: ");
        // int aci3 = int.Parse(Console.ReadLine());

        // if (aci1 + aci2 > aci3 && aci2 + aci3 > aci1 && aci1 + aci3 > aci2)
        // {
        //     Console.WriteLine("Bu açılar ile üçgen oluşturulabilir!");
        // }
        // else
        // {
        //     Console.WriteLine("Bu açılar ile üçgen oluşturulamaz!");
        // }

        //6) Kullanıcıdan alınan bir notun aşağıdaki tabloya göre harf karşılığını veren bir program yazın.

        // Console.Write("Notunuzu giriniz: ");
        //     int not = int.Parse(Console.ReadLine());

        //     if (not >= 90 && not <= 100)
        //     {
        //         Console.WriteLine("Harf notunuz = AA'dır.");
        //     }
        //     if (not >= 85 && not <= 89)
        //     {
        //         Console.WriteLine("Harf notunuz = BA'dır.");
        //     }
        //     if (not >= 80 && not <=84)
        //     {
        //         Console.WriteLine("Harf notunuz = BB'dir.");
        //     }
        //     if (not >=70 && not <= 79)
        //     {
        //         Console.WriteLine("Harf notunuz = CB'dir.");
        //     }
        //     if (not >= 60 && not <= 69)
        //     {
        //         Console.WriteLine("Harf notunuz = CC'dir.");
        //     }
        //     if (not >= 55 && not <= 59)
        //     {
        //         Console.WriteLine("Harf notunuz = DC'dir.");
        //     }
        //     if (not >= 50 && not <= 54)
        //     {
        //         Console.WriteLine("Harf notunuz = DD'dir.");
        //     }
        //     if (not >= 40 && not <= 49)
        //     {
        //         Console.WriteLine("Harf notunuz = FD'dir.");
        //     }
        //     if (not >= 0 && not <= 39)
        //     {
        //         Console.WriteLine("Harf notunuz = FF'dir.");
        //     }

        //7) Kullanıcıdan alınan üç sayıdan en büyüğünü bulan bir program yazın.

        // Console.Write("ilk sayı: ");
        // int number1 = int.Parse(Console.ReadLine());
        // Console.Write("ikinci sayı: ");
        // int number2 = int.Parse(Console.ReadLine());
        // Console.Write("üçüncü sayı: ");
        // int number3 = int.Parse(Console.ReadLine());

        // int maxNumber = number1;

        // if(number2 > maxNumber)
        // {
        //     maxNumber = number2;
        // }
        // if(number3 > maxNumber)
        // {
        //     maxNumber = number3;
        // }
        // System.Console.WriteLine($"{maxNumber} en büyük sayıdır.");

        //8) Kullanıcıdan alınan bir sayının 3'e ve 5'e tam bölünüp bölünmediğini kontrol eden ve uygun mesajı veren bir program yazın.

        // System.Console.WriteLine("bir sayı giriniz: ");
        // int number = int.Parse(Console.ReadLine());

        // if(number % 3 == 0 && number % 5 == 0)
        // {
        //     System.Console.WriteLine($"{number}, 3 ve 5'e tam bölünebilir.");
        // }
        // else
        // {
        //     System.Console.WriteLine($"{number}, 3 ve 5'e tam bölünemez.");
        // }

        //9) Kullanıcıdan alınan iki sayı ve bir işlem (+, -, *, /) için basit bir hesap makinesi yapın.
        // System.Console.WriteLine("İlk sayı: ");
        // int number1 = int.Parse(Console.ReadLine());
        // System.Console.WriteLine("İkinci sayı: ");
        // int number2 = int.Parse(Console.ReadLine());
        // System.Console.WriteLine("İşlem giriniz: (+ - / *)");
        // char islem = Console.ReadLine();
        // double sonuc = 0;
        // bool islemGecerli = true;

        // switch (islem)
        // {
        //     case '+':
        //     sonuc = number1 + number2;
        //     break;
        //     case '-':
        //     sonuc = number1 - number2;
        //     break;
        //     case '*':
        //     sonuc = number1 * number2;
        //     break;
        //     case '/':
        //     sonuc = number1 / number2;
        //     break;
        //     default:
        //     System.Console.WriteLine("İşlem geçersiz!");
        //     islemGecerli = false;
        //     break;
        // }

        //10) Kullanıcıdan alınan bir sayının asal olup olmadığını kontrol eden bir program yazın.

        // Console.WriteLine("Sayı: ");
        // int asalSayi = int.Parse(Console.ReadLine());

        // if (asalSayi == 0 && asalSayi == 1)
        // {
        //     Console.WriteLine("Girmiş olduğunuz sayı asal sayıdır");
        // }

        // if (asalSayi < 0)
        // {
        //     Console.WriteLine("Girmiş olduğunuz sayı asal sayı değildir");
        // }


        // if (asalSayi % asalSayi == 1 && asalSayi % 1 == asalSayi)


        #endregion
        #region If Else2
        //1) Kullanıcıdan alınan para değerinin KDV'li fiyatını ve KDV tutarını hesaplayıp ekrana bastıran programı yazın. Eğer girilen tutar 0 ve 1000 TL arasında ise KDV oranı %20 , tutar 1000 TL'den büyük ise KDV oranı %8 olarak kullanılacaktır.

        // System.Console.WriteLine("para girişi: ");
        // int money = int.Parse(Console.ReadLine());

        // if (money > 0 && money <= 1000)
        // {
        //     System.Console.WriteLine($"KDV dahil: {money * 1.2}");
        // }
        // else if (money > 1000)
        // {
        //     System.Console.WriteLine($"KDV dahil: {money * 0.8}");
        // }
        // else
        // {
        //     System.Console.WriteLine("Geçersiz");
        // }

        //3) Gidilen mesafeye (KM) göre taksimetre tutarını ekrana yazdıran programı yazın.

        // const decimal acilisUcreti = 30m;
        // const decimal kmBasinaUcret = 20m;
        // const decimal minTutar = 100m;

        // Console.Write("Gidilen mesafeyi km cinsinden giriniz: ");
        // decimal mesafe = decimal.Parse(Console.ReadLine());

        // decimal toplam = acilisUcreti + (mesafe * kmBasinaUcret);

        // if (toplam < minTutar)
        // {
        //     toplam = minTutar;
        // }

        // Console.WriteLine($"Ödeme: {toplam} TL");

        //4) Yarı çapını kullanıcıdan aldığınız dairenin alanını ve çevresini hesaplayan programı yazın.

        // Console.Write("Yarıçap değerini giriniz: ");
        // int yaricap = int.Parse(Console.ReadLine());

        // Console.WriteLine($"Alan: {yaricap * yaricap * 3,14}");

        // Console.WriteLine($"Çevre: {2 * yaricap * 3,14}");

        //5) Kullanıcıdan alınan boy ve kilo değerlerine göre aşağıdaki formülü kullanarak kullanıcının "Vücut Kitle İndeks" değerini hesaplayıp ekrana yazdırın.
        // Console.Write("Kilonuzu giriniz (kg): ");
        // int kilo = int.Parse(Console.ReadLine());
        // Console.Write("Boyunuzu giriniz (cm): ");
        // int boy = int.Parse(Console.ReadLine());

        // double boy2 = boy / 100;

        // double bmi = kilo / (boy2 * boy2);

        // Console.WriteLine($"Kitle Endeksiniz: {bmi:F2}");

        //6) Kullanıcıların manavdan almış oldukları ürünlerin kilogram değerlerine göre toplam tutarını ekrana yazdıran programı yazın.

        // double armutFiyat = 45.50;
        // double bamyaFiyat = 81.40;
        // double domatesFiyat = 45.00;
        // double muzFiyat = 65.00;
        // double patlicanFiyat = 45.00;

        // Console.Write("Armut: ");
        // double armutKg = Convert.ToDouble(Console.ReadLine());
        // Console.Write("Bamya: ");
        // double bamyaKg = Convert.ToDouble(Console.ReadLine());
        // Console.Write("Domates: ");
        // double domatesKg = Convert.ToDouble(Console.ReadLine());
        // Console.Write("Muz: ");
        // double muzKg = Convert.ToDouble(Console.ReadLine());
        // Console.Write("Patlıcan: ");
        // double patlicanKg = Convert.ToDouble(Console.ReadLine());

        // double toplam = armutFiyat + armutKg + bamyaFiyat + bamyaKg + domatesFiyat + domatesKg + muzFiyat + muzKg + patlicanFiyat + patlicanKg;

        // Console.WriteLine($"Toplam tutar: {toplam} TL");

        //7) switch-case kullanarak 4 işlem yapabilen bir hesap makinesi yapınız.

        // double sayi1,sayi2, sonuc = 0;
        // char islem;
        // Console.Write("1. Sayıyı Giriniz: ");
        // sayi1 = Convert.ToDouble(Console.ReadLine());
        // Console.Write("2. Sayıyı Giriniz: ");
        // sayi2 = Convert.ToDouble(Console.ReadLine());

        // Console.WriteLine("İşleminizi Seçin: \n + \n - \n * \n /");

        // islem = Convert.ToChar(Console.ReadLine());

        // switch(islem)
        // {
        //     case '+':
        //         sonuc = sayi1 + sayi2;
        //         Console.WriteLine("Sonuç = " + sonuc);
        //         break;
        //     case '-':
        //         sonuc = sayi1 - sayi2;
        //         Console.WriteLine("Sonuç = " + sonuc);
        //         break;
        //     case '*':
        //         sonuc = sayi1 * sayi2;
        //         Console.WriteLine("Sonuç = " + sonuc);
        //         break;
        //     case '/':
        //         sonuc = sayi1 / sayi2;
        //         Console.WriteLine("Sonuç = " + sonuc);
        //         break;
        //     default:
        //     Console.WriteLine("Hatalı işlem!");
        //     break;
        // } 

        //8) Kullanıcıdan alından doğum tarihine göre kişinin Çin Zodyağını hesaplayan programı yazınız.

        // Console.WriteLine("Doğum yılınızı giriniz: ");
        // int dogum = int.Parse(Console.ReadLine());

        // if (dogum % 12 == 0)
        // {
        //     Console.WriteLine("Çin Zodyağınız: Maymun");
        // }
        // else if (dogum % 12 == 1)
        // {
        //     Console.WriteLine("Çin Zodyağınız: Horoz");
        // }
        // else if (dogum % 12 == 2)
        // {
        //     Console.WriteLine("Çin Zodyağınız: Köpek");
        // }
        // else if (dogum % 12 == 3)
        // {
        //     Console.WriteLine("Çin Zodyağınız: Domuz");
        // }
        // else if (dogum % 12 == 4)
        // {
        //     Console.WriteLine("Çin Zodyağınız: Fare");
        // }
        // else if (dogum % 12 == 5)
        // {
        //     Console.WriteLine("Çin Zodyağınız: Öküz");
        // }
        // else if (dogum % 12 == 6)
        // {
        //     Console.WriteLine("Çin Zodyağınız: Kaplan");
        // }
        // else if (dogum % 12 == 7)
        // {
        //     Console.WriteLine("Çin Zodyağınız: Tavşan");
        // }
        // else if (dogum % 12 == 8)
        // {
        //     Console.WriteLine("Çin Zodyağınız: Ejderha");
        // }
        // else if (dogum % 12 == 9)
        // {
        //     Console.WriteLine("Çin Zodyağınız: Fare");
        // }

        //9) Kullanıcının girdiği yılın artık yıl olup olmadığını tespit edip ekrana yazdıran programı hazırlayınız.

        // Console.Write("Yıl giriniz: ");
        // int yil = int.Parse(Console.ReadLine());
        // bool artikYil = (yil % 4 == 0 && yil % 100 != 0) || (yil % 400 == 0);


        // Console.WriteLine(artikYil ? $"{yil} artık yıldır."
        //                             : $"{yil} artık yıl değildir.");


        #endregion
        #region HomeWork for MD
        //2) Çarpım tablosunu aşağıdaki gibi ekrana yazdıran programı hazırlayınız:

        // int girilenSayi, i, sonuc;
        // Console.Write("Bir sayı giriniz: ");
        // girilenSayi = int.Parse(Console.ReadLine());

        // for(i=0; i<=10; i++)
        // {
        //     sonuc = girilenSayi * i;
        //     Console.WriteLine("{0}x{1}={2}", girilenSayi, i, sonuc);
        // }

        //4) Kullanıcıdan alınan sayının çarpanlarını bulup bu çarpanların toplamını hesaplayan bir program yazın.

        // Console.WriteLine("Çarpanını bulmak istediğiniz bir sayı giriniz");
        // int number = 0;
        // int carpan = int.Parse(Console.ReadLine());

        // Console.Write("Çarpanlar: ");

        // for (int i = 1; i <= number; i++)
        // {
        //     if (number % i == 0)
        //     {
        //         Console.Write(i + " ");
        //         carpan += i;
        //     }
        // }

        // 5) Sayıyı tersine çevirme
        //https://www.yazilimkodlama.com/programlama/c-klavyeden-girilen-sayiyi-ters-cevirme/
        //while loop ile yaptım.

        // Console.WriteLine("Terse çevirmek istediğiniz sayıyı giriniz: ");
        // int sayi;
        // int yazilacakRakam;
        // sayi = int.Parse(Console.ReadLine());

        // while (sayi > 10)
        // {
        //     yazilacakRakam = sayi % 10;
        //     Console.Write(yazilacakRakam);
        //     sayi /= 10;
        // }
        // Console.WriteLine(sayi);

        //6) Kullanıcıdan alınan sayının kaç tane pozitif böleni olduğunu bulan bir program yazın.

        // int sayi, sayac = 0;
        // Console.Write("Sayınızı giriniz: ");
        // sayi = int.Parse(Console.ReadLine());
        // for (int i = 1; i <= sayi; i++)
        // {
        //     if (sayi % i == 0)
        //     {
        //         Console.WriteLine(i);
        //         sayac++;
        //     }
        // }
        // Console.WriteLine("Sayının bölenleri: " + sayac);

        //7) Bir sayının mükemmel olup olmadığını bulan bir program yazın.

        // Console.Write("Sayınızı giriniz: ");
        // int sayi;
        // sayi = int.Parse(Console.ReadLine());
        // int toplam = 0;

        // for (int i = 1; i < sayi; i++)
        // {
        //     if (sayi % i == 0)
        //     {
        //         toplam = toplam + i;
        //     }
        // }
        // if (toplam == sayi)
        // {
        //     Console.WriteLine($"Girmiş olduğunuz {sayi} sayısı mükemmel sayıdır.");
        // }
        // else
        // {
        //     Console.WriteLine($"Girmiş olduğunuz {sayi} sayısı mükemmel sayı değildir.");
        // }

        //8) Kullanıcıdan bir sayı alarak, bu sayıya kadar olan Fibonacci serisini hesaplayan bir program yazın.

        // Console.Write("Bir sayı girin: ");
        // int n = int.Parse(Console.ReadLine());

        // int a = 0, b = 1, c;

        // Console.Write("Fibonacci Serisi: ");
        // Console.Write($"{a} {b}");

        // for (int i = 2; i < n; i++)
        // {
        //     c = a + b;
        //     Console.Write($" {c}");
        //     a = b;
        //     b = c;
        // }



        #endregion
        #region Switch
        //1) Kullanıcıdan alınan bir sayıya göre (1-7 arası) haftanın gününü yazdıran bir program yazın.

        // Console.Write("Bir sayı giriniz: ");
        // int sayi;
        // sayi = int.Parse(Console.ReadLine());

        // switch (sayi)
        // {
        //     case 1:
        //         Console.WriteLine("Pazartesi");
        //         break;
        //     case 2:
        //         Console.WriteLine("Salı");
        //         break;
        //     case 3:
        //         Console.WriteLine("Çarşamba");
        //         break;
        //     case 4:
        //         Console.WriteLine("Perşembe");
        //         break;
        //     case 5:
        //         Console.WriteLine("Cuma");
        //         break;
        //     case 6:
        //         Console.WriteLine("Cumartesi");
        //         break;
        //     case 7:
        //         Console.WriteLine("Pazar");
        //         break;
        //     default:
        //         Console.WriteLine("Lütfen 1 ile 7 arasında bir sayı giriniz!");
        //         break;
        // }

        //2) Kullanıcıdan alınan bir sayıya göre (1-12 arası) ayın adını yazdıran bir program yazın.

        // Console.WriteLine("Bir sayı giriniz (1-12): ");

        // int ayAdi;
        // ayAdi = int.Parse(Console.ReadLine());
        // switch (ayAdi)
        // {
        //     case 1:
        //         Console.WriteLine("Ocak");
        //         break;
        //     case 2:
        //         Console.WriteLine("Şubat");
        //         break;
        //     case 3:
        //         Console.WriteLine("Mart");
        //         break;
        //     case 4:
        //         Console.WriteLine("Nisan");
        //         break;
        //     case 5:
        //         Console.WriteLine("Mayıs");
        //         break;
        //     case 6:
        //         Console.WriteLine("Haziran");
        //         break;
        //     case 7:
        //         Console.WriteLine("Temmuz");
        //         break;
        //     case 8:
        //         Console.WriteLine("Ağustos");
        //         break;
        //     case 9:
        //         Console.WriteLine("Eylül");
        //         break;
        //     case 10:
        //         Console.WriteLine("Ekim");
        //         break;
        //     case 11:
        //         Console.WriteLine("Kasım");
        //         break;
        //     case 12:
        //         Console.WriteLine("Aralık");
        //         break;
        //     default:
        //         Console.WriteLine("Lütfen 1 ile 12 arasında bir sayı giriniz!");
        //         break;
        // }

        //3) Kullanıcıdan alınan iki sayı ve bir işlem (+, -, *, /) için basit bir hesap makinesi yapın (switch kullanarak).

        // double sayi1, sayi2, sonuc = 0;
        // char islem;
        // Console.Write("1. Sayıyı Giriniz: ");
        // sayi1 = Convert.ToDouble(Console.ReadLine());
        // Console.Write("2. Sayıyı Giriniz: ");
        // sayi2 = Convert.ToDouble(Console.ReadLine());

        // Console.WriteLine("İşleminizi Seçin: \n + \n - \n * \n /");

        // islem = Convert.ToChar(Console.ReadLine());

        // switch (islem)
        // {
        //     case '+':
        //         sonuc = sayi1 + sayi2;
        //         Console.WriteLine("Sonuç = " + sonuc);
        //         break;
        //     case '-':
        //         sonuc = sayi1 - sayi2;
        //         Console.WriteLine("Sonuç = " + sonuc);
        //         break;
        //     case '*':
        //         sonuc = sayi1 * sayi2;
        //         Console.WriteLine("Sonuç = " + sonuc);
        //         break;
        //     case '/':
        //         sonuc = sayi1 / sayi2;
        //         Console.WriteLine("Sonuç = " + sonuc);
        //         break;
        //     default:
        //         Console.WriteLine("Hatalı işlem!");
        //         break;
        // }

        //4) Kullanıcıdan alınan bir harfe göre sesli veya sessiz harf olduğunu belirleyen bir program yazın.

        // Console.Write("Bir harf giriniz: ");
        // char harf;
        // harf = char.Parse(Console.ReadLine());

        // switch (harf)
        // {
        //     case 'a':
        //     case 'e':
        //     case 'ı':
        //     case 'i':
        //     case 'o':
        //     case 'ö':
        //     case 'u':
        //     case 'ü':
        //         Console.WriteLine($"{harf} sesli bir harftir");
        //         break;
        //     default:
        //         Console.WriteLine($"{harf} sessiz bir harftir.");
        //         break;
        // }

        //5) Kullanıcıdan alınan bir sayıya göre (1-4 arası) mevsim adını yazdıran bir program yazın.


        // Console.WriteLine("1 ile 4 arasında bir sayı giriniz: ");
        // int sayi;
        // sayi = int.Parse(Console.ReadLine());

        // switch (sayi)
        // {
        //     case 1:
        //         Console.WriteLine("İlkbahar");
        //         break;
        //     case 2:
        //         Console.WriteLine("Yaz");
        //         break;
        //     case 3:
        //         Console.WriteLine("Sonbahar");
        //         break;
        //     case 4:
        //         Console.WriteLine("Kış");
        //         break;
        //     default:
        //         Console.WriteLine("Lütfen 1 ile 4 arasında bir sayı giriniz.");
        //         break;
        // }

        //6) Kullanıcıdan alınan bir nota göre (A, B, C, D, F) geçme veya kalma durumunu belirleyen bir program yazın.

        // Console.WriteLine();
        // Console.WriteLine("Harf notunuzu giriniz (A, B, C, D, F)");
        // char not;
        // not = char.Parse(Console.ReadLine());

        // switch (not)
        // {
        //     case 'A':
        //         Console.WriteLine("Geçtiniz!");
        //         break;
        //     case 'B':
        //         Console.WriteLine("Geçtiniz!");
        //         break;
        //     case 'C':
        //         Console.WriteLine("Geçtiniz!");
        //         break;
        //     case 'D':
        //         Console.WriteLine("Geçtiniz!");
        //         break;
        //     case 'F':
        //         Console.WriteLine("Kaldınız!");
        //         break;
        //     default:
        //         Console.WriteLine("Lütfen A ile F arasında bir harf notu giriniz!");
        //         break;
        // }

        //7) Kullanıcıdan alınan bir sayıya göre (1-5 arası) Türk para biriminin adını yazdıran bir program yazın (1 Kr, 5 Kr, 10 Kr, 25 Kr, 50 Kr).
        // Console.WriteLine("1 ile 5 arasında bir sayı giriniz: ");
        // int sayi;
        // sayi = int.Parse(Console.ReadLine());

        // switch (sayi)
        // {
        //     case 1:
        //         Console.WriteLine("1 Kr");
        //         break;
        //     case 2:
        //         Console.WriteLine("5 Kr");
        //         break;
        //     case 3:
        //         Console.WriteLine("10 Kr");
        //         break;
        //     case 4:
        //         Console.WriteLine("25 Kr");
        //         break;
        //     case 5:
        //         Console.WriteLine("50 Kr");
        //         break;
        //     default:
        //         Console.WriteLine("Lütfen 1 ile 5 arasında bir sayı giriniz!");
        //         break;
        // }

        //8) Kullanıcıdan alınan bir sayıya göre (0-6 arası) bir geometrik şeklin adını yazdıran bir program yazın (0: Nokta, 1: Çizgi, 2: Açı, 3: Üçgen, 4: Kare, 5: Beşgen, 6: Altıgen).

        // Console.WriteLine("Bir sayı giriniz (1-6): ");
        // int sayi;
        // sayi = int.Parse(Console.ReadLine());

        // switch (sayi)
        // {
        //     case 0:
        //         Console.WriteLine("Nokta");
        //         break;
        //     case 1:
        //         Console.WriteLine("Çizgi");
        //         break;
        //     case 2:
        //         Console.WriteLine("Açı");
        //         break;
        //     case 3:
        //         Console.WriteLine("Üçgen");
        //         break;
        //     case 4:
        //         Console.WriteLine("Kare");
        //         break;
        //     case 5:
        //         Console.WriteLine("Beşgen");
        //         break;
        //     case 6:
        //         Console.WriteLine("Altıgen");
        //         break;

        //     default:
        //         Console.WriteLine("Lütfen 1 ile 6 arasında bir sayı giriniz!");
        //         break;
        // }

        //9) Kullanıcıdan alınan bir sayıya göre (1-5 arası) Türkçe sayı sıfatını yazdıran bir program yazın (1: Birinci, 2: İkinci, vb.).

        // Console.WriteLine("1-5 arasında bir sayı giriniz: ");
        // int sayi;
        // sayi = int.Parse(Console.ReadLine());

        // switch (sayi)
        // {
        //     case 1:
        //         Console.WriteLine("Birinci");
        //         break;
        //     case 2:
        //         Console.WriteLine("İkinci");
        //         break;
        //     case 3:
        //         Console.WriteLine("Üçüncü");
        //         break;
        //     case 4:
        //         Console.WriteLine("Dördüncü");
        //         break;
        //     case 5:
        //         Console.WriteLine("Beşinci");
        //         break;
        //     default:
        //         Console.WriteLine("Lütfen 1 ile 5 arasında bir sayı giriniz!");
        //         break;
        // }

        //10) Kullanıcıdan alınan bir karaktere göre (+, -, *, /, %) matematiksel işlemin adını yazdıran bir program yazın.

        // Console.WriteLine("Bir karakter giriniz (+, -, *, /, %)");
        // char islem;
        // islem = char.Parse(Console.ReadLine());

        // switch (islem)
        // {
        //     case '+':
        //         Console.WriteLine("Toplama İşlemi");
        //         break;
        //     case '-':
        //         Console.WriteLine("Çıkarma İşlemi");
        //         break;
        //     case '*':
        //         Console.WriteLine("Çarpma İşlemi");
        //         break;
        //     case '/':
        //         Console.WriteLine("Bölme İşlemi");
        //         break;
        //     case '%':
        //         Console.WriteLine("Mod İşlemi");
        //         break;

        //     default:
        //         Console.WriteLine("Lütfen geçerli bir karakter");
        //         break;
        // }

        #endregion
    }
}
