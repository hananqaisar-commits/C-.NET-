using System;
using System.IO;
using Names;
namespace Name

{

    public class StudentOperations
    {
        string filePath = Path.Combine(Directory.GetCurrentDirectory(), "students.txt");//it will detect the absolute filePath
        Formats format = new Formats();//format is obj of Formats class
        static int uniqueNumber = 1000;//unique number assigned to prefix and auto_incremented
        List<Student> students = new List<Student>();//list of students to save data read from file
        public String genereateID()//to generate auto incremented id for each student
        {
            String prefix = "STU";
            Random random = new Random();
            return $"{prefix + (++uniqueNumber)}";
        }
        public Student AddStudent()
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine()!;

            string id = genereateID();

            Console.Write("Enter marks: ");
            string marks = Console.ReadLine()!;

            return new Student(name, id, marks);
        }
        public void SaveToFile(List<Student> students)
        {
            List<string> lines = new List<string>();

            foreach (var student in students)
            {
                lines.Add($"{student.ID},{student.Name},{student.Marks}");
            }

            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (var line in lines)
                    {
                        writer.WriteLine(line);
                    }
                }
                Console.WriteLine("Students saved to file successfully.");
            }
            catch (FileNotFoundException exp)
            {
                Console.WriteLine($"Error writing file: {exp.Message}");
            }
        }

        public List<Student> ReadFile()
        {

            if (!File.Exists("students.txt"))
            {
                Console.WriteLine("No students.txt found. No students exist.");
                return new List<Student>();
            }

            try
            {
                string content = File.ReadAllText(filePath);
                if (content == "")
                {
                    Console.WriteLine("No student data found.");
                    return new List<Student>();
                }

                using (StreamReader reader = new StreamReader(filePath))
                {
                    string? line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (string.IsNullOrWhiteSpace(line)) continue;

                        string[] parts = line.Split(',');
                        if (parts.Length != 3)
                        {
                            Console.WriteLine($"Invalid line format: {line}");
                            continue;
                        }

                        string id = parts[0];
                        string name = parts[1];
                        string marks = parts[2];

                        students.Add(new Student(name, id, marks));
                    }
                }
            }
            catch (IOException exp)
            {
                Console.WriteLine($"Error reading file: {exp.Message}");
            }

            return students;
        }
        public void classStatistics(List<Student> students)
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
                if (!int.TryParse(student.Marks, out int marks))
                {
                    continue;//check if marks is not a number
                }
                if (marks > highestMarks) highestMarks = marks;
                if (marks < lowestMarks) lowestMarks = marks;
                totalMarks += marks;
            }

            double averageMarks = totalMarks / students.Count;

            Console.WriteLine($"Highest Marks : {highestMarks:F1}");
            Console.WriteLine($"Lowest Marks  : {lowestMarks:F1}");
            Console.WriteLine($"Average Marks : {averageMarks:F2}");
        }
    }
}