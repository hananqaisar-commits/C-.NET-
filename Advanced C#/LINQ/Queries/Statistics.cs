using System;
using Models.Person;
namespace Queries.Filter;

public class Statistics
{
    public int Count(List<Person> list)
    {
        return list.Count();
    }
    public double HighestSalary(List<Person> list)
    {
        var result = list.Max(s => s.Salary);
        return result;
    }
    public double LowestSalary(List<Person> list)
    {
        var result = list.Min(s => s.Salary);
        return result;
    }
}