using System;
using Interface.IHasPersonInfo;
namespace Models.Person;

public class Person : IHasPersonInfo
{
    public string? Name { get; set; }
    public int Age { get; set; }
    public override string ToString()
    {
        return $"{Name,-40} |{Age,-10}";
    }
}