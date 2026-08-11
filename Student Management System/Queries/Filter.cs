namespace Queries.Filter;

using Models.Student;

public class Filter
{
    public static List<Student> SearchByMarksRange(
        List<Student> studentList,
        int min,
        int max) =>
        studentList
            .Where(s => s.Marks >= min && s.Marks <= max)
            .ToList();

    public static List<Student> GetByNameStartsWith(
        List<Student> studentList,
        string prefix) =>
        studentList
            .Where(s => s.Name.StartsWith(prefix))
            .ToList();

    public static Dictionary<string, Student> GetStudentById(
        Dictionary<string, Student> studentDictionary,
        string Id) =>
        studentDictionary
            .Where(s => s.Key == Id)
            .ToDictionary(s => s.Key, s => s.Value);

    public static Dictionary<string, Student> DelStudentById(
        Dictionary<string, Student> studentDictionary, string Id)
    {
        if (studentDictionary.ContainsKey(Id))
        {
            studentDictionary.Remove(Id);
        }
        else
            Console.WriteLine("ID not exist");

        return studentDictionary;
    }

    public static Dictionary<string, Student> UpdateStudentById(
        Dictionary<string, Student> studentDictionary,
        string Id)
    {
        if (studentDictionary.ContainsKey(Id))
        {
            Student student = studentDictionary[Id];

            Console.WriteLine("What do you want to update?");
            Console.WriteLine("1. Name");
            Console.WriteLine("2. Email");
            Console.WriteLine("3. Marks");
            Console.WriteLine("4. All");
            Console.Write("Enter choice: ");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter name: ");
                        string Name = Console.ReadLine()!;

                        student.Name = Name;
                        break;

                    case 2:
                        Console.Write("Enter Email: ");
                        string Email = Console.ReadLine()!;

                        student.Email = Email;
                        break;

                    case 3:
                        Console.Write("Enter marks: ");

                        if (double.TryParse(
                            Console.ReadLine(),
                            out double Marks))
                        {
                            Console.WriteLine($"Marks: {Marks}");
                            student.Marks = Marks;
                        }
                        else
                        {
                            Console.WriteLine("Invalid marks!");
                        }

                        break;

                    case 4:
                        Console.Write("Enter name: ");
                        string NameAll = Console.ReadLine()!;

                        Console.Write("Enter Email: ");
                        string EmailAll = Console.ReadLine()!;

                        Console.Write("Enter marks: ");

                        if (double.TryParse(
                            Console.ReadLine(),
                            out double MarksAll))
                        {
                            Console.WriteLine($"Marks: {MarksAll}");

                            student.Name = NameAll;
                            student.Email = EmailAll;
                            student.Marks = MarksAll;
                        }
                        else
                        {
                            Console.WriteLine("Invalid marks!");
                        }

                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
        else
        {
            Console.WriteLine("ID not exist");
        }

        return studentDictionary;
    }
}