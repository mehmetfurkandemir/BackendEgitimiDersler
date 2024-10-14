namespace HomeWork_Week05;

class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Species { get; set; }

    public Animal(string Name, int Age, string Species)
    {
        Name = name;
        Age = age;
        Species = species;
    }
    public virtual void MakeSound()
    {
        Console.WriteLine("Hayvan ses çıkarıyor.");
    }
}

//Aslan sınıfı için class yapısı

class Lion : Animal
{
    public Lion(string name, int age) : base(name, age, "Lion")
    {

    }
    public override void MakeSound()
    {
        System.Console.WriteLine("Lion: Kükreme!");
    }
}

//Fil sınıfı için class yapısı

class Elephant : Animal
{
    public Elephant(string name, int age) : base(name, age, "Elephant")
    {

    }

    public override void MakeSound()
    {
        System.Console.WriteLine("Elephant: Boru Sesi!");
    }
}

//Zürafa için class yapısı

class Giraffe : Animal
{
    public Giraffe(string name, int age) : base(name, age, "Giraffe")
    {

    }

    public override void MakeSound()
    {
        System.Console.WriteLine("Giraffe: Zürafa Sesi!");
    }
}


class Program
{
    static void Main(string[] args)
    {
        Lion lion = new Lion("Aslan", 3);
        Elephant elephant = new Elephant("Fil", 6);
        Giraffe giraffe = new Giraffe("Zürafa", 13);

        Console.WriteLine($"Aslan: {lion.Name}, Yaşı: {lion.Age}, Türü: {lion.Species}");
        Console.WriteLine($"Fil: {elephant.Name}, Yaşı: {elephant.Age}, Türü: {elephant.Species}");
        Console.WriteLine($"Zürafa: {giraffe.Name}, Yaşı: {giraffe.Age}, Türü: {giraffe.Species}");

        lion.MakeSound();
        elephant.MakeSound();
        giraffe.MakeSound();


    }
}
