using System;
using System.IO;
using Models.Teacher;
using Utilities.Formats;
using Interfaces.IOperations;
using Models.Person;
namespace Services.TeacherOperations;

public class TeacherOperations : IOperations<Teacher>
{
    string filePath = Path.Combine(Directory.GetCurrentDirectory(), "teachers.txt");//it will detect the absolute filePath
    Formats format = new Formats();//format is obj of Formats class
    static int uniqueNumber = 1000;//unique number assigned to prefix and auto_incremented
    List<Teacher> teachers = new List<Teacher>();//list of teachers to save data read from file

    public string GenerateID()//to generate auto incremented id for each teacher
    {
        string prefix = "PRF";
        return $"{prefix + (++uniqueNumber)}";
    }

    public Person Add()
    {
        string Id = GenerateID();

        Console.Write("Enter name: ");
        string Name = Console.ReadLine()!;

        Console.Write("Enter Email: ");
        string Email = Console.ReadLine()!;

        Console.Write("Enter Grade: ");

        if (int.TryParse(Console.ReadLine(), out int Grade))
        {
            Console.WriteLine($"Marks: {Grade}");
        }
        else
        {
            Console.WriteLine("Invalid marks!");
        }

        return new Teacher(Id, Name, Email, Grade);
    }

    public void SaveToFile(List<Teacher> teachers)
    {
        List<string> lines = new List<string>();

        foreach (var teacher in teachers)
        {
            lines.Add(teacher.ToFile());
        }

        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (var line in lines)
            {
                writer.WriteLine(line);
            }
        }

        Console.WriteLine("Teachers saved to file successfully.");
    }

    public List<Teacher> ReadFile()
    {
        if (!File.Exists(filePath))
        {
            Console.WriteLine("No Teachers.txt found. No Teachers exist.");
            return new List<Teacher>();
        }

        string content = File.ReadAllText(filePath);

        if (content == "")
        {
            Console.WriteLine("No teacher data found.");
            return new List<Teacher>();
        }

        using (StreamReader reader = new StreamReader(filePath))
        {
            string? line;

            while ((line = reader.ReadLine()) != null)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;

                string[] parts = line.Split(',');

                if (parts.Length != 5)
                {
                    Console.WriteLine($"Invalid line format: {line}");
                    continue;
                }

                string Type = parts[0];
                string id = parts[1];
                string name = parts[2];
                string email = parts[3];

                int.TryParse(parts[4], out int grade);

                teachers.Add(new Teacher(name, id, email, grade));
            }
        }
        return teachers;
    }
}