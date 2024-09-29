// namespace RandomPassword;

// class Program
// {
//     static void Main(string[] args)
//     {
//         //Random Password Generator

//         Random rnd = new Random();
//         const string letters = "ABCDEFGHIJKLMNOPRSTUVWXYZabcdefghijklmnoprstuvwxyz";
//         const string numbers = "0123456789";
//         const string specialChars = ".,-+*";


//         int passwordLength = 8;
//         char[] password = new char[passwordLength];
//         password[0] = numbers[rnd.Next(numbers.Length)];
//         password[1] = specialChars[rnd.Next(specialChars.Length)];
//         for (int i = 2; i < passwordLength; i++)
//         {
//             int type = rnd.Next(3)
//             if (type == 0)
//             {
//                 password[i] = letters[rnd.Next(letters.Length)];
//             }
//             else if (type == 1)
//             {
//                 password[i] = numbers[rnd.Next(numbers.Length)];
//             }
//             else
//             {
//                 password[i] = specialChars[rnd.Next(specialChars.Length)];
//             }

//         }
//         System.Console.WriteLine(password);


//     }
// }
