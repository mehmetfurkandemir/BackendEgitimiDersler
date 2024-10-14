namespace Tasit.cs;
class Vehicle
{
    public string Make { get; set; }
    public int Model { get; set; }
    public int Year { get; set; }

    public Vehicle(string make, int model, int year)
    {
        Make = make;
        Model = model;
        Year = year;
    }

    public virtual void DisplayInfo()
    {
        System.Console.WriteLine($"Marka: {Make}, Model: {Model}, Yıl: {Year}");
    }
}

class Car : Vehicle
{
    public int NumberOfDoors { get; set; }
    public Car(string make, string model, int year, int numberOfDoors)
           : base(make, model, year)
    {
        NumberOfDoors = numberOfDoors;
    }
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        System.Console.WriteLine($"Kapı Sayısı: {NumberOfDoors}");
    }
}

class Bicycle : Vehicle
{
    public bool HasGears { get; set; }

    public Bicycle(string make, string model, int year, bool hasGears)
        : base(make, model, year)
    {
        HasGears = hasGears;
    }
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        System.Console.WriteLine($"Vites: {(HasGears ? "Mevcut" : "Mevcut Değil")}");
    }
}

class Motorcycle : Vehicle
{
    public bool HasSidecar { get; set; }
    public Motorcycle(string make, string model, int year, bool hasSidecar)
        : base(make, model, year)
    {
        HasSidecar = hasSidecar;
    }
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        System.Console.WriteLine($"Yan Sepet Mevcut Mu: {(HasSidecar ? "Mevcut" : "Mevcut Değil")}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Car car = new Car("Toyota", "Corolla", 2022, 4);
        Bicycle bicycle = new Bicycle("Giant", "Defy", 2021, true);
        Motorcycle motorcycle = new Motorcycle("Harley-Davidson", "Sportster", 2019, false);

        Console.WriteLine("Araba Bilgileri:");
        car.DisplayInfo();
        Console.WriteLine();

        Console.WriteLine("Bisiklet Bilgileri:");
        bicycle.DisplayInfo();
        Console.WriteLine();

        Console.WriteLine("Motosiklet Bilgileri:");
        motorcycle.DisplayInfo();
    }
}
