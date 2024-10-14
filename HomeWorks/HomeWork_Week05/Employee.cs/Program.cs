namespace Employee.cs;

class Employee
{
    public string Name { get; set; }
    public int Id { get; set; }
    public decimal Salary { get; set; }
    public Employee(string name, int id, decimal salary)
    {
        Name = name;
        Id = id;
        Salary = salary;
    }
    public virtual void DisplayInfo()
    {
        System.Console.WriteLine($"İsim: {Name}, Kimlik Numarası: {Id}, Maaş: {Salary} TRY");
    }
}

class Manager : Employee
{
    public int NumberOfTeams { get; set; }

    public Manager(string name, int id, decimal salary, int numberOfTeams)
    : base(name, id, salary)
    {
        NumberOfTeams = numberOfTeams;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        System.Console.WriteLine($"Takım sayısı: {NumberOfTeams}");
    }
}

class Developer : Employee
{
    public string ProgrammingLanguage { get; set; }

    public Developer(string name, int id, decimal salary, string programmingLanguage)
        : base(name, id, salary)
    {
        ProgrammingLanguage = programmingLanguage;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Programlama Dili: {ProgrammingLanguage}");
    }
}

class Intern : Employee
{
    public string University { get; set; }

    public Intern(string name, int id, decimal salary, string university)
        : base(name, id, salary)
    {
        University = university;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Üniversite: {University}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Manager manager = new Manager("Furkan Demir", 466, 15000, 3);
        Developer developer = new Developer("Arda Ünver", 236, 12000, "C#");
        Intern intern = new Intern("Merve Kara", 1003, 315, "Bahçeşehir Üniversitesi");

        Console.WriteLine("Yönetici Bilgileri:");
        manager.DisplayInfo();
        Console.WriteLine();

        Console.WriteLine("Geliştirici Bilgileri:");
        developer.DisplayInfo();
        Console.WriteLine();

        Console.WriteLine("Stajyer Bilgileri:");
        intern.DisplayInfo();
    }
}
