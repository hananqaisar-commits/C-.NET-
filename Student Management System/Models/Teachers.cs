namespace Models.Teachers;

using Models.Person;
public class Teachers : Person
{
    public int Grade { get; set; }
    public Teachers(string Name, string Id, string Email, int Grade) : base(Id, Name, Email)
    {
        this.Grade = Grade;//like 17,18,19 grades
    }
    public override void DisplayInfo()
    {
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Email: {Email}");
        Console.WriteLine($"Grade: {Grade}");
    }
    public string ToFile()//use to write into file
    {
        return $"Teachers,{Id},{Name},{Email},{Grade}";
    }
    public override string ToString()//overriding the ToString method for student objects
    {
        return $"{Id,-8} {Name,-30} {Email,-30} {Grade,-6}";
    }
}