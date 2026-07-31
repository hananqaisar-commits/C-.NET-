using System;
using System.Collections.Generic;
using System.Linq;
using Models.Person;

namespace Queries.Filter;

public class Filter
{
    public List<Person> ByAge(List<Person> list) =>

        list.Where(p => p.Age >= 18).ToList();


    public List<Person> BySalary(List<Person> list) =>
     list.Where(p => p.Salary >= 90000).ToList();

}