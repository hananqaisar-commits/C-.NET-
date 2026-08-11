namespace Queries.Filter;

using Models.Student;

public class Filter
{
    public static List<Student> SearchByMarksRange(List<Student> studentList, int min, int max) =>

      studentList.Where
      (s => s.Marks >= min && s.Marks <= max).ToList();
    public static List<Student> GetByNameStartsWith(List<Student> studentList, string prefix) =>
           studentList.Where(s => s.Name.StartsWith(prefix)).ToList();
    public static Dictionary<string, Student> GetStudentById(Dictionary<string, Student> studentDictionary, string Id) =>
    studentDictionary
        .Where(s => s.Key == Id)
        .ToDictionary(s => s.Key, s => s.Value);//return dictonary whose key is the studentId and value id the student obj

    public static Dictionary<string, Student> DelStudentById(Dictionary<string, Student> studentDictionary, string Id)
    {
        if (studentDictionary.ContainsKey(Id))
        {
            studentDictionary.Remove(Id);
        }
        else
            Console.WriteLine("ID not exist");
        return studentDictionary;
    }
    public static Dictionary<string, Student> UpdateStudentById(Dictionary<string, Student> studentDictionary, string Id)
    {
        if (studentDictionary.ContainsKey(Id))
        {
            Student student = studentDictionary[Id];//ab dictionary mei is key pr student jo hai usy student onj mei assign kro or value change krna pr dictionary update ho jaye gi
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
            student.Name = Name;
            student.Email = Email;
            student.Marks = Marks;
        }

        else
            Console.WriteLine("ID not exist");
        return studentDictionary;
    }
}