using Models.Person;
using Models.Teacher;
using Models.Student;
using Utilities.Formats;
using Services.StudentOperations;
using Services.TeacherOperations;
using Interfaces.IOperations;
using System.Net.Http.Headers;
namespace Program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Formats format = new Formats();
            IOperations<Student> studentOperations = new StudentOperations();
            IOperations<Teacher> teacherOperations = new TeacherOperations();

            List<Student> students_list = studentOperations.ReadFile();
            List<Teacher> teachers_list = teacherOperations.ReadFile();
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
                            Student student = (Student)studentOperations.Add();

                            students_list.Add(student);// Add the new student to the list of students
                            studentOperations.SaveToFile(students_list);// Save the updated list of students to the file
                            Console.WriteLine("Student added successfully.");
                            format.continuePrompt();
                            break;
                        }
                    case 2:
                        {
                            Teacher teacher = (Teacher)teacherOperations.Add();

                            teachers_list.Add(teacher);// Add the new student to the list of students
                            teacherOperations.SaveToFile(teachers_list);// Save the updated list of students to the file
                            Console.WriteLine("Teacher added successfully.");
                            format.continuePrompt();
                            break;
                        }
                    case 3:
                        format.Header("Student List");
                        Console.WriteLine($"{"ID",-12} {"Name",-30} {"Email",-30}{"Marks",-8}");// Print the header for the student list with proper formatting
                        format.HeaderLine();// Print a line to separate the header from the student data
                        students_list.Clear();// it prevent ambiguity of data.
                        students_list = studentOperations.ReadFile();// it will assign returned data to student_list
                        foreach (var StudentData in students_list)// Loop through the list of students and print their details
                        {
                            Console.WriteLine(StudentData.ToString());// Print the details of each student using the ToString() method of the Student class
                        }
                        format.continuePrompt();
                        break;
                    case 4:
                        format.Header("Teacher List");
                        Console.WriteLine($"{"ID",-12} {"Name",-30} {"Email",-30} {"Grade",-8}");// Print the header for the student list with proper formatting
                        format.HeaderLine();// Print a line to separate the header from the student data
                        teachers_list.Clear();// it prevent ambiguity of data.
                        teachers_list = teacherOperations.ReadFile();// it will assign returned data to student_list
                        foreach (var TeacherData in teachers_list)// Loop through the list of students and print their details
                        {
                            Console.WriteLine(TeacherData.ToString());// Print the details of each student using the ToString() method of the Student class
                        }
                        format.continuePrompt();
                        break;
                    case 5:
                        StudentOperations sOp = new StudentOperations();
                        format.Header("Class Statistics");
                        sOp.ClassStatistics(students_list);// Call the classStatistics method to display statistics about the class based on the list of students
                        format.continuePrompt();
                        break;
                    case 6:
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