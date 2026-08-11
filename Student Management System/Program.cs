using Models.Person;
using Models.Student;
using Utilities.Formats;
using Services.StudentOperations;
using Interfaces.IOperations;
using Reflection.Inspection;
using System.Reflection;
using System.ComponentModel.DataAnnotations;
using Queries.Filter;

namespace Program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IOperations<Student> studentOperations = new StudentOperations();
            List<Student> studentList = studentOperations.ReadFile();
            Dictionary<string, Student> studentsDictionary = new Dictionary<string, Student>();

            foreach (var student in studentList)
            {
                studentsDictionary.Add(student.Id, student);
            }
            Formats.Header("Student Management System");
            Formats.HeaderLine();

            while (true)
            {
                Formats.ShowMainMenu();

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Invalid input.");
                    continue;
                }

                switch (choice)
                {
                    case 0:
                        Formats.Exit();
                        return;

                    case 1:
                        {
                            Student student = (Student)studentOperations.Add();
                            // First validate it
                            Validator.ValidateObject(student, new ValidationContext(student), validateAllProperties: true);

                            // Add student to list
                            studentList.Add(student);

                            // Add student to dictionary
                            studentsDictionary.Add(student.Id, student);

                            // Save to file successfully
                            studentOperations.SaveToFile(studentsDictionary.Values.ToList());

                            Console.WriteLine("Student added successfully.");
                            Formats.continuePrompt();

                            break;
                        }
                    case 2:
                        studentsDictionary.Clear();
                        studentList = studentOperations.ReadFile();
                        foreach (var student in studentList)
                        {
                            studentsDictionary.Add(student.Id, student);
                        }
                        Console.Write("Enter ID to Delete: ");
                        string IdToDel = Console.ReadLine()!;
                        var resultAfterDel = Filter.DelStudentById(studentsDictionary, IdToDel);
                        studentList.Clear();
                        foreach (var student in resultAfterDel.Values)
                        {
                            studentList.Add(student);
                        }
                        studentOperations.SaveToFile(studentList);
                        break;
                    case 3:
                        studentList.Clear();
                        studentList = studentOperations.ReadFile();

                        studentsDictionary.Clear();

                        foreach (var student in studentList)
                        {
                            studentsDictionary.Add(student.Id, student);
                        }

                        Console.Write("Enter ID to Update: ");
                        string IdToUpdate = Console.ReadLine()!;
                        if (IdToUpdate != null)
                        {
                            var resultUpdated = Filter.UpdateStudentById(studentsDictionary, IdToUpdate);
                            studentList.Clear();

                            foreach (var student in resultUpdated)
                            {
                                studentList.Add(student.Value);
                            }

                            studentOperations.SaveToFile(studentList);
                        }
                        else
                        {
                            Console.WriteLine("Invalid");
                        }
                        break;

                    case 4:
                        studentsDictionary.Clear();
                        studentList = studentOperations.ReadFile();
                        foreach (var student in studentList)
                        {
                            studentsDictionary.Add(student.Id, student);
                        }
                        Console.Write("Enter ID to Search: ");
                        string Id = Console.ReadLine()!;
                        if (Id != null)
                        {
                            var result = Filter.GetStudentById(studentsDictionary, Id);
                            foreach (var student in result.Values)
                            {
                                Console.WriteLine(student);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid");
                        }
                        break;
                    case 5:
                        studentList.Clear();
                        studentList = studentOperations.ReadFile();
                        Console.Write("Enter Starting Letter(s): ");
                        string prefix = Console.ReadLine()!;
                        if (prefix != null)
                        {
                            var resultStartingPrefix = Filter.GetByNameStartsWith(studentList, prefix);

                            foreach (var student in resultStartingPrefix)
                            {
                                Console.WriteLine(student);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid");
                        }
                        break;

                    case 6:
                        studentList.Clear();
                        studentList = studentOperations.ReadFile();
                        Console.Write("Enter Minimum Age: ");

                        if (!int.TryParse(Console.ReadLine(), out int minAge))
                        {
                            Console.WriteLine("Invalid minimum age.");
                            break;
                        }

                        Console.Write("Enter Maximum Age: ");

                        if (!int.TryParse(Console.ReadLine(), out int maxAge))
                        {
                            Console.WriteLine("Invalid maximum age.");
                            break;
                        }

                        {
                            var resultAge = Filter.SearchByMarksRange(studentList, minAge, maxAge);
                            foreach (var student in resultAge)
                            {
                                Console.WriteLine(student.ToString());
                            }
                        }
                        break;
                    case 7:
                        {
                            Formats.Header("Student List");
                            Console.WriteLine($"{"ID",-12} {"Name",-30} {"Email",-30} {"Marks",-8}");
                            Formats.HeaderLine();
                            studentsDictionary.Clear();//clean the dictionary and again read from file
                            List<Student> students = studentOperations.ReadFile();//read fresh from file into list

                            foreach (var student in students)//store in dictionary from that updated lsit
                            {
                                studentsDictionary.Add(student.Id, student);
                            }
                            foreach (var StudentData in studentsDictionary.Values)//now print from dictionary
                            {
                                Console.WriteLine(StudentData.ToString());
                            }
                            Formats.continuePrompt();
                            break;
                        }

                    case 8:
                        {
                            StudentOperations StudentOP = new StudentOperations();
                            Formats.Header("Class Statistics");

                            StudentOP.ClassStatistics(studentsDictionary.Values.ToList());
                            Formats.continuePrompt();
                            break;
                        }

                    case 9:
                        {
                            Assembly assembly = Assembly.GetExecutingAssembly();
                            var classType = assembly
                                .GetTypes()
                                .Where(t => t.IsClass && !t.Name.StartsWith("<>"))
                                .ToArray();

                            Console.WriteLine("All classes available for Inspection (select by name only):-\n");
                            int count = 0;
                            int selectedOption = -1;

                            while (selectedOption != 0)
                            {
                                foreach (Type type in classType)
                                {
                                    Console.WriteLine($"\t{count += 1} -> {type.Name}");
                                }

                                Console.WriteLine("0 -> Exit");

                                Console.Write("\nEnter class number to inspect relevant class: ");

                                if (int.TryParse(Console.ReadLine(), out selectedOption))
                                {
                                    if (selectedOption == 0)
                                        break;

                                    if (selectedOption >= 1 && selectedOption <= classType.Length)
                                    {
                                        Type type = classType[selectedOption - 1];
                                        Inspection.ToBeInspected(type);
                                        count = 0;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid class selection.");
                                        count = 0;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Invalid input.");
                                    count = 0;
                                }
                            }

                            break;
                        }
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        Formats.continuePrompt();
                        break;
                }
            }
        }
    }
}