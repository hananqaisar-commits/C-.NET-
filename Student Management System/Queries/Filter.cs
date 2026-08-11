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
        return studentDictionary;
    }
}