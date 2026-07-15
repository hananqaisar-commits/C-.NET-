using System;
using System.IO;
using Names;
namespace Name

{

    public class StudentOperations
    {
        Formats format = new Formats();
        static int uniqueNumber = 1000;
        public String genereateID()
        {
            String prefix = "STU";
            Random random = new Random();
            return $"{prefix + (++uniqueNumber)}";
        }

        public void SaveToFile(List<Student> students)
        {
            List<string> lines = new List<string>();

            foreach (var student in students)//var decide the data type at runtime
            {
                lines.Add($"{student.ID},{student.Name},{student.Marks}");
            }

            if (!File.Exists("students.txt"))
            {
                Console.WriteLine("File not found. Creating new file...");
                File.Create("students.txt").Close();
            }
            File.AppendAllLines("students.txt", lines);

            Console.WriteLine("Students saved to file successfully.");
        }
        public List<Student> ReadFile()
        {
            string content = File.ReadAllText("students.txt");

            if (content == "")
            {
                Console.WriteLine("No students found.");
                return new List<Student>();
            }

            var students = File.ReadAllLines("students.txt")//var decide the data type at runtime and at last it will be returened
                .Where(line => !string.IsNullOrWhiteSpace(line))//if line is not empty then go to next step
                .Select(line =>
                {
                    var parts = line.Split(',');

                    return new Student(
                        parts[1],//name
                        parts[0],//id
                        parts[2]//marks
                    );
                })
                .ToList();

            return students;
        }
        public void classStatistics(List<Student> students)
        {

            if (students.Count == 0)
            {
                Console.WriteLine("No students found.");
                return;
            }

            int highestMarks = int.MinValue;
            int lowestMarks = int.MaxValue;
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

            Console.WriteLine($"Highest Marks : {highestMarks}");
            Console.WriteLine($"Lowest Marks  : {lowestMarks}");
            Console.WriteLine($"Average Marks : {averageMarks}");
        }
    }
}