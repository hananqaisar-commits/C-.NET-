namespace Models.Students;

using Models.Person;
public class Student : Person
{
    public double Marks { get; set; }
    public Student() //default constructor
    {
        this.Marks = 0.0;
    }
    public Student(string Name, string Id, string Email, double Marks) : base(Id, Name, Email)//parameterized constructor
    {
        this.Marks = Marks;
    }
    public override void DisplayInfo()
    {
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Email: {Email}");
        Console.WriteLine($"Marks: {Marks}");
    }
    public string ToFile()//use to write into file
    {
        return $"Students,{Id},{Name},{Email},{Marks}";
    }
    public override string ToString()//overriding the ToString method for student objects
    {
        return $"{Id,-8} {Name,-30} {Email,-30} {Marks,-6}";
    }
}