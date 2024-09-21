namespace Project05_ConvertTypes;

class Program
{
    static void Main(string[] args)
    {
        #region ImplicitConvert

        // byte number1 = 123;
        // int number2 = number1;

        // int number3 = 23423;
        // float number4 = number3;
        // System.Console.WriteLine(number3);

        #endregion

        #region ExplicitConvert

        // float number1 = 234, f;
        // int number2 = (int)number1;
        // System.Console.WriteLine(number2); //Casting

        // int number1 = 2526;
        // byte number2 = (byte)number1;
        // System.Console.WriteLine(number2);

        #endregion

        #region Convert
        // string number15String = "123";
        // int convertedNumber = Convert.ToInt32(number15String);
        // System.Console.WriteLine(convertedNumber + 12);

        // bool isDeleted = true;
        // string isDeletedString = Convert.ToString(isDeleted);

        // Parse - TryParse
        // string age = 45;
        // int parsedAge = int.Parse(age);

        string doubleString = "23.3";
        double parsedDouble;

        bool result = double.TryParse(doubleString, out parsedDouble);

        if (result == true)
        {
            Console.WriteLine(parsedDouble);
        }
        else
        {
            Console.WriteLine("hata");
        }

        #endregion
    }
}
