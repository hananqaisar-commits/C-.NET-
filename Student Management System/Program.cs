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
                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Invalid input.");
                    continue;
                }
                switch (choice)
                {
                    case 1:
                        {
                            Student student = studentOperations.AddStudent();

                            students_list.Add(student);// Add the new student to the list of students
                            studentOperations.SaveToFile(students_list);// Save the updated list of students to the file
                            Console.WriteLine("Student added successfully.");
                            format.continuePrompt();
                            break;
                        }
                    case 2:
                        format.Header("Student List");
                        Console.WriteLine($"{"ID",-8} {"Name",-20} {"Marks",-6}");// Print the header for the student list with proper formatting
                        format.HeaderLine();// Print a line to separate the header from the student data
                        students_list.Clear();// it prevent ambiguity of data.
                        students_list = studentOperations.ReadFile();// it will assign returned data to student_list
                        foreach (var StudentData in students_list)// Loop through the list of students and print their details
                        {
                            Console.WriteLine(StudentData.ToString());// Print the details of each student using the ToString() method of the Student class
                        }
                        format.continuePrompt();
                        break;
                    case 3:
                        format.Header("Class Statistics");
                        studentOperations.classStatistics(students_list);// Call the classStatistics method to display statistics about the class based on the list of students
                        format.continuePrompt();
                        break;
                    case 4:
                        format.Exit();// Call the Exit method to exit the program
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");// Print an error message for invalid menu choices
                        format.continuePrompt();
                        break;
                }
            }
        }
    }
}