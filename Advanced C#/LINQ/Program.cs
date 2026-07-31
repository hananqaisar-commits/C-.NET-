using Models.Person;
using Queries.Filter;
using Queries.Sort;

List<Person> allPersons = new()
{
    new Person
    {
        Name = "Hanan Qaisar",
        Age = 18,
        Salary = 120100.9
    },
    new Person
    {
        Name = "Ahmad",
        Age = 12,
        Salary = 12000
    },
    new Person
    {
        Name = "Hassan",
        Age = 16,
        Salary = 130000.9
    },
    new Person
    {
        Name = "Ali Hamza",
        Age = 19,
        Salary = 110000
    }
};

Filter filter = new();
Sort sort = new();

Console.WriteLine("\n========== PERSON ANALYZER ==========\n");

Console.WriteLine("All Persons:");
foreach (var person in allPersons)
    Console.WriteLine(person);

Console.WriteLine("\n--- Salary >= 90,000 ---");
foreach (var person in filter.BySalary(allPersons))
    Console.WriteLine(person);

Console.WriteLine("\n--- Age >= 18 ---");
foreach (var person in filter.ByAge(allPersons))
    Console.WriteLine(person);

Console.WriteLine("\n--- Age: Low → High ---");
foreach (var person in sort.ByAgeAccending(allPersons))
    Console.WriteLine(person);

Console.WriteLine("\n--- Age: High → Low ---");
foreach (var person in sort.ByAgeDecending(allPersons))
    Console.WriteLine(person);

Console.WriteLine("\n--- Salary: Low → High ---");
foreach (var person in sort.BySalaryAccending(allPersons))
    Console.WriteLine(person);

Console.WriteLine("\n--- Salary: High → Low ---");
foreach (var person in sort.BySalaryDecending(allPersons))
    Console.WriteLine(person);

Console.WriteLine("\n=====================================");

Statistics statistics = new();

Console.WriteLine("\n--- Statistics ---");
Console.WriteLine($"Total Persons : {statistics.Count(allPersons)}");
Console.WriteLine($"Highest Salary: {statistics.HighestSalary(allPersons):F2}");
Console.WriteLine($"Lowest Salary : {statistics.LowestSalary(allPersons):F2}");

