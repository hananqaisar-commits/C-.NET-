using System;

namespace Models.Person;

public class Person
{
    public string? Name { get; set; }
    public double Salary { get; set; }
    public int Age { get; set; }

    public override string ToString()
    {
        return $"{Name,-40} | {Salary:F2} | {Age,-10}";
    }
}