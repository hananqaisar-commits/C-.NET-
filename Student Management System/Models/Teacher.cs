namespace Models.Teacher;

using Models.Person;
public class Teacher : Person
{
    public int Grade { get; set; }
    public Teacher(string Id, string Name, string Email, int Grade) : base(Id, Name, Email)
    {
        this.Grade = Grade;//like 17,18,19 grades
    }
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Grade: {Grade}");
    }
    public string ToFile()//use to write into file
    {
        return $"Teacher,{Id},{Name},{Email},{Grade}";
    }
    public override string ToString()//overriding the ToString method for student objects
    {
        return $"{Id,-12} {Name,-30} {Email,-30} {Grade,-6}";
    }
}