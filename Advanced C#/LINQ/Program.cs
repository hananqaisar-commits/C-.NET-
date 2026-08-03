using System.Collections;
using Interface.IHasPersonInfo;
using Models.Person;
using Queries.Filter;
using Queries.Sort;

List<Person> allPersons = new()
{
    new Person
    {
        Name = "Hanan Qaisar",
        Age = 18,
    },
    new Person
    {
        Name = "Ahmad",
        Age = 12,
    },
    new Person
    {
        Name = "Hassan",
        Age = 16,
    },
    new Person
    {
        Name = "Ali Hamza",
        Age = 19,
    }
};

Filter filter = new();
Sort sort = new();

Console.WriteLine("==========================================");
Console.WriteLine("          PERSON ANALYZER");
Console.WriteLine("==========================================");

Console.WriteLine("\nAll Persons:");
Console.WriteLine("------------------------------------------");
foreach (var person in allPersons)
    Console.WriteLine(person);

Console.WriteLine("\n==========================================");
Console.WriteLine("             PERSON FILTER");
Console.WriteLine("==========================================");

Console.Write("\nEnter Regex Pattern: ");
string pattern = Console.ReadLine()!;

Console.Write("Enter Minimum Age: ");
int minAge = int.Parse(Console.ReadLine()!);

Console.Write("Enter Maximum Age: ");
int maxAge = int.Parse(Console.ReadLine()!);

Console.Write("Enter Name to Search: ");
string containsText = Console.ReadLine()!;

Console.Write("Enter Starting Letter(s): ");
string prefix = Console.ReadLine()!;

Console.WriteLine("\nFilter by Regex Pattern");
Console.WriteLine("------------------------------------------");
foreach (var person in filter.GetByNamePattern(allPersons, pattern))
    Console.WriteLine(person);

Console.WriteLine("\nAdults (Age >= 18)");
Console.WriteLine("------------------------------------------");
foreach (var person in filter.GetAdults(allPersons))
    Console.WriteLine(person);

Console.WriteLine($"\nPersons Between {minAge} and {maxAge}");
Console.WriteLine("------------------------------------------");
foreach (var person in filter.GetByAgeRange(allPersons, minAge, maxAge))
    Console.WriteLine(person);

Console.WriteLine($"\nNames Containing \"{containsText}\"");
Console.WriteLine("------------------------------------------");
foreach (var person in filter.GetByNameContains(allPersons, containsText))
    Console.WriteLine(person);

Console.WriteLine($"\nNames Starting With \"{prefix}\"");
Console.WriteLine("------------------------------------------");
foreach (var person in filter.GetByNameStartsWith(allPersons, prefix))
    Console.WriteLine(person);

Console.WriteLine("\n==========================================");
Console.WriteLine("             PERSON SORT");
Console.WriteLine("==========================================");

Console.WriteLine("\nAge (Ascending)");
Console.WriteLine("------------------------------------------");
foreach (var person in sort.ByAgeAccending(allPersons))
    Console.WriteLine(person);

Console.WriteLine("\nAge (Descending)");
Console.WriteLine("------------------------------------------");
foreach (var person in sort.ByAgeDecending(allPersons))
    Console.WriteLine(person);

Console.WriteLine("\nName (Ascending)");
Console.WriteLine("------------------------------------------");
foreach (var person in sort.ByNameAccending(allPersons))
    Console.WriteLine(person);

Console.WriteLine("\n==========================================");
Console.WriteLine("              STATISTICS");
Console.WriteLine("==========================================");

Statistics statistics = new();

Console.WriteLine($"Total Persons : {statistics.CountAllPersons(allPersons)}");
Console.WriteLine($"Average Age   : {statistics.AverageAge(allPersons):F2}");
Console.WriteLine($"Maximum Age   : {statistics.MaxAge(allPersons)}");
Console.WriteLine($"Minimum Age   : {statistics.MinAge(allPersons)}");

Console.WriteLine("\n==========================================");
Console.WriteLine("        PROGRAM COMPLETED SUCCESSFULLY");
Console.WriteLine("==========================================");