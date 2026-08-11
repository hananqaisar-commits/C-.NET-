using Models.Student;

public class Sorting
{
    public static List<Student> SortByName(List<Student> studentList) =>
    studentList.OrderBy(s => s.Name).ToList();

    public static List<Student> SortByMarks(List<Student> studentList) =>
        studentList.OrderByDescending(s => s.Marks).ToList();

    public static List<Student> SortById(List<Student> studentList) =>
        studentList.OrderBy(s => s.Id).ToList();
}