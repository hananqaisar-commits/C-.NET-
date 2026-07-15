public class Student
{
    public string Name { get; set; }
    public string ID { get; set; }
    public string Marks { get; set; }

    public Student() { }

    public Student(string name, string id, string marks)
    {
        Name = name;
        ID = id;
        Marks = marks;
    }
    public override string ToString()
    {
        return $"{ID,-8} {Name,-20} {Marks,-6}";
    }
    public string ToFile()
    {
        return $"{ID,-8} {Name,-20} {Marks,-6}";
    }
}