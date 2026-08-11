using System;
using System.IO;
using Models.Student;
using Utilities.Formats;
using Interfaces.IOperations;
using Models.Person;

namespace Services.StudentOperations;

public class StudentOperations : IOperations<Student>
{
    string filePath = Path.Combine(
        Directory.GetCurrentDirectory(),
        "students.txt"
    );

    Formats format = new Formats();

    static int uniqueNumber = 1000;

    Dictionary<int, Student> studentsDictionary =
        new Dictionary<int, Student>();

    private string GenerateStudentId()
    {
        string prefix = "STU";

        while (File.Exists(filePath))
        {
            List<Student> students = ReadFile();

            string id = prefix + uniqueNumber;

            if (!students.Any(s => s.Id == id))
            {
                uniqueNumber++;
                return id;
            }

            uniqueNumber++;
        }

        return prefix + uniqueNumber++;
    }

    public Person Add()
    {
        string id = GenerateStudentId();

        Console.Write("Enter name: ");
        string Name = Console.ReadLine()!;

        Console.Write("Enter Email: ");
        string Email = Console.ReadLine()!;

        Console.Write("Enter marks: ");

        if (double.TryParse(Console.ReadLine(), out double Marks))
        {
            Console.WriteLine($"Marks: {Marks}");
        }
        else
        {
            Console.WriteLine("Invalid marks!");
            Marks = 0;
        }

        return new Student(id, Name, Email, Marks);
    }

    public void SaveToFile(List<Student> students)
    {
        List<string> lines = new List<string>();

        foreach (var student in students)
        {
            lines.Add(student.ToFile());
        }

        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (var line in lines)
            {
                writer.WriteLine(line);
            }
        }

        Console.WriteLine("Students saved to file successfully.");
    }

    public List<Student> ReadFile()
    {
        List<Student> students = new List<Student>();

        if (!File.Exists(filePath))
        {
            Console.WriteLine("No students.txt found. No students exist.");
            return students;
        }

        using (StreamReader reader = new StreamReader(filePath))
        {
            string? line;

            while ((line = reader.ReadLine()) != null)
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                string[] parts = line.Split(',');

                if (parts.Length != 5)
                {
                    Console.WriteLine($"Invalid line format: {line}");
                    continue;
                }

                string type = parts[0];
                string id = parts[1];
                string name = parts[2];
                string email = parts[3];

                double.TryParse(parts[4], out double marks);

                students.Add(
                    new Student(id, name, email, marks)
                );
            }
        }

        return students;
    }

    public void ClassStatistics(List<Student> students)
    {
        if (students.Count == 0)
        {
            Console.WriteLine("No students found.");
            return;
        }

        double highestMarks = double.MinValue;
        double lowestMarks = double.MaxValue;
        double totalMarks = 0;

        foreach (var student in students)
        {
            double marks = student.Marks;

            if (marks > highestMarks)
                highestMarks = marks;

            if (marks < lowestMarks)
                lowestMarks = marks;

            totalMarks += marks;
        }

        double averageMarks = totalMarks / students.Count;

        Console.WriteLine($"Highest Marks : {highestMarks:F1}");
        Console.WriteLine($"Lowest Marks  : {lowestMarks:F1}");
        Console.WriteLine($"Average Marks : {averageMarks:F2}");
    }
}