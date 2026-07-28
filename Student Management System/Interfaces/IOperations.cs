using Models.Person;
using Models.Student;

namespace Interfaces.IOperations;

public interface IOperations<T>//generic
{
    string GenerateID();

    Person Add();

    void SaveToFile(List<T> persons);

    List<T> ReadFile();


}