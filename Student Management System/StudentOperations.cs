using System;
using System.IO;
using Names;
namespace Name

{

    public class StudentOperations
    {
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
            foreach (var student in students)//var decide the data type at runtime
            {
                lines.Add($"{student.ID},{student.Name},{student.Marks}");
            }
            if (!File.Exists("students.txt"))
            {
                File.Create("students.txt").Close();
                Console.WriteLine("File not found. Creating new file...");
            }
            using (StreamWriter writer = new StreamWriter("students.txt"))
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
            string content = File.ReadAllText("students.txt");

            if (content == "")
            {
                Console.WriteLine("No students found.");
                return new List<Student>();
            }

            using (StreamReader reader = new StreamReader("students.txt"))
            {
                string? line;
                while ((line = reader.ReadLine()) != null)
                {                                          //var decide the data type at runtime and at last it will be returened
                    if (string.IsNullOrWhiteSpace(line))
                    {
                        continue;
                    }//if line is not empty then go to next step
                    string[] parts = line.Split(',');
                    if (parts.Length != 3)
                    {
                        Console.WriteLine($"Invalid line format: {line}");
                        continue;
                    }

                    string id = parts[0];
                    string name = parts[1];
                    string marks = parts[2];

                    Student student = new Student(name, id, marks);

                    students.Add(student);
                }
                return students;
            }
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