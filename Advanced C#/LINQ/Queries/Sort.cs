using System;
using System.Linq;
using Models.Person;
namespace Queries.Sort;

public class Sort
{
    public List<Person> ByAgeAccending(List<Person> list)
    {
        var result = list.OrderBy(s => s.Age).ToList();
        return result;
    }
    public List<Person> ByAgeDecending(List<Person> list)
    {
        var result = list.OrderByDescending(s => s.Age).ToList();
        return result;
    }
    public List<Person> BySalaryAccending(List<Person> list)
    {
        var result = list.OrderBy(s => s.Salary).ToList();
        return result;
    }
    public List<Person> BySalaryDecending(List<Person> list)
    {
        var result = list.OrderByDescending(s => s.Salary).ToList();
        return result;
    }

}