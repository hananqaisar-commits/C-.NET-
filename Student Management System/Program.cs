using Names;
namespace Name
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Formats format = new Formats();
            StudentOperations studentOperations = new StudentOperations();
            List<Student> students_list = studentOperations.ReadFile();
            format.HeaderLine();
            format.Header("Student Management System");
            format.HeaderLine();
            while (true)
            {
                format.menu();
                int choice = int.Parse(Console.ReadLine()!);
                switch (choice)
                {
                    case 1:
                        Student student = new Student();
                        student.AddStudent();
                        students_list.Add(student);
                        break;
                    case 2:
                        format.Header("Student List");
                        Console.WriteLine("\n");
                        Console.WriteLine($"{"ID",-8} {"Name",-20} {"Marks",-6}");
                        format.HeaderLine();
                        foreach (var StudentData in students_list)
                        {
                            Console.WriteLine(StudentData.ToString());
                        }

                        break;
                    case 3:
                        format.Header("Class Statistics");
                        studentOperations.classStatistics(students_list);
                        break;
                    case 4:
                        format.Exit();
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        format.continuePrompt();
                        break;
                }
            }
        }
    }
}