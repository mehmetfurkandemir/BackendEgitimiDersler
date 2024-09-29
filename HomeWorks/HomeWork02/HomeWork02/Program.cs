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

        

        #endregion

    }
}
