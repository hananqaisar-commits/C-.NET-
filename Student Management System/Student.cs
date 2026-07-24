public class Student
{
    public string Name { get; set; }
    public string ID { get; set; }
    public string Marks { get; set; }

    public Student()//default constructor
    {
        this.Name = "Unknown";
        this.ID = "Unknown";
        this.Marks = "0";
    }
    public Student(string name, string id, string marks)//parameterized constructor
    {
        Name = name;
        ID = id;
        Marks = marks;
    }
    public override string ToString()//overriding the ToString method for student objects
    {
        return $"{ID,-8} {Name,-20} {Marks,-6}";
    }
    public string ToFile()//use to write into file
    {
        return $"{ID,-8} {Name,-20} {Marks,-6}";
    }
}