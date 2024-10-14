namespace Calculator;

using System;

public class Calculator
{
    public double Add(double a, double b)
    {
        return a + b;
    }

    public double Subtract(double a, double b)
    {
        return a - b;
    }

    public double Multiply(double a, double b)
    {
        return a * b;
    }

    public double Divide(double a, double b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Geçersiz İşlem!");
        }
        return a / b;
    }
}

public class Bilimsel : Calculator
{
    public double Sin(double angle)
    {
        return Math.Sin(angle);
    }

    public double Cos(double angle)
    {
        return Math.Cos(angle);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Calculator calc = new Calculator();
        Console.WriteLine("Toplama: " + calc.Add(5, 3));
        Console.WriteLine("Çıkarma: " + calc.Subtract(5, 3));
        Console.WriteLine("Çarpma: " + calc.Multiply(5, 3));
        Console.WriteLine("Bölme: " + calc.Divide(10, 2));

        Bilimsel bilimsel = new Bilimsel();
        Console.WriteLine("Sin(30): " + bilimsel.Sin(30 * Math.PI / 180));
        Console.WriteLine("Cos(30): " + bilimsel.Cos(30 * Math.PI / 180));
    }
}

