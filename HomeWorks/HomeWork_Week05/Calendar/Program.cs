namespace Calendar;

using System;

public class Event
{
    public string Name { get; set; }
    public DateTime Date { get; set; }
    public string Location { get; set; }

    public Event(string name, DateTime date, string location)
    {
        Name = name;
        Date = date;
        Location = location;
    }

    public virtual void GetEventDetails()
    {
        Console.WriteLine($"Event: {Name}, Date: {Date}, Location: {Location}");
    }
}

public class Meeting : Event
{
    public string Agenda { get; set; }

    public Meeting(string name, DateTime date, string location, string agenda)
        : base(name, date, location)
    {
        Agenda = agenda;
    }

    public void StartMeeting()
    {
        Console.WriteLine($"Meeting '{Name}' is starting. Agenda: {Agenda}");
    }

    public override void GetEventDetails()
    {
        base.GetEventDetails();
        Console.WriteLine($"Agenda: {Agenda}");
    }
}

public class Birthday : Event
{
    public string BirthdayPerson { get; set; }

    public Birthday(string name, DateTime date, string location, string birthdayPerson)
        : base(name, date, location)
    {
        BirthdayPerson = birthdayPerson;
    }

    public void CelebrateBirthday()
    {
        Console.WriteLine($"Doğum Günün Kutlu Olsun, {BirthdayPerson}! Kutlayalım!");
    }

    public override void GetEventDetails()
    {
        base.GetEventDetails();
        Console.WriteLine($"Doğum Günü: {BirthdayPerson}");
    }
}

public class Task : Event
{
    public bool IsCompleted { get; private set; }

    public Task(string name, DateTime date, string location)
        : base(name, date, location)
    {
        IsCompleted = false;
    }

    public void MarkAsComplete()
    {
        IsCompleted = true;
        Console.WriteLine($"Görev '{Name}' Tamamlandı.");
    }

    public override void GetEventDetails()
    {
        base.GetEventDetails();
        Console.WriteLine($"Tamamlandı: {IsCompleted}");
    }
}

// Kullanım Örneği
class Program
{
    static void Main(string[] args)
    {
        Meeting meeting = new Meeting("Proje Başlangıcı", DateTime.Now, "Konferans Odası 1", "Proje Planı");
        meeting.GetEventDetails();
        meeting.StartMeeting();

        Console.WriteLine();

        Birthday birthday = new Birthday("Ayşe Hanım'ın Doğum Günü", DateTime.Now.AddDays(5), "Cafe", "Ayşe");
        birthday.GetEventDetails();
        birthday.CelebrateBirthday();

        Console.WriteLine();

        Task task = new Task("Tamamla", DateTime.Now.AddDays(2), "Ofis");
        task.GetEventDetails();
        task.MarkAsComplete();
        task.GetEventDetails();
    }
}

