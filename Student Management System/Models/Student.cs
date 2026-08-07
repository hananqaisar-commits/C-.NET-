namespace Models.Student;

using Models.Person;
public class Student : Person
{
    public double Marks { get; set; }
    public Student() //default constructor
    {
        this.Marks = 0.0;
    }
    public Student(string Id, string Name, string Email, double Marks) : base(Id, Name, Email)//parameterized constructor
    {
        this.Marks = Marks;
    }
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Marks: {Marks}");
    }
    public string ToFile()//use to write into file
    {
        return $"Student,{Id},{Name},{Email},{Marks}";
    }
    public override string ToString()//overriding the ToString method for student objects
    {
        return $"{Id,-12} {Name,-30} {Email,-30} {Marks,-6}";
    }
}