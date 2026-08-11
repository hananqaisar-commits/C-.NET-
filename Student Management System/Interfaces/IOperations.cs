using Models.Person;
using Models.Student;

namespace Interfaces.IOperations;

public interface IOperations<T>//generic
{

    Person Add();
    void SaveToFile(List<Student> persons);
    List<Student> ReadFile();
}