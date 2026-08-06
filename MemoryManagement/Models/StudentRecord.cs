public record StudentRecord(string name, int age);
// //It automatically create constructor, override ToStrign & no need to override the equals method & gethashcode Also create Deconstructor

// // exampel:
// public class StudentRecord
// {
//     public string Name { get; init; }
//     public int Age { get; init; }

//     public StudentRecord(string name, int age)
//     {
//         Name = name;
//         Age = age;
//     }

//     public override string ToString()
//     {
//         return $"StudentRecord {{ Name = {Name}, Age = {Age} }}";
//     }

//     public override bool Equals(object obj)
//     {
//         // Value-based equality
//     }

//     public override int GetHashCode()
//     {
//         // Hash code
//     }

//     public void Deconstruct(out string name, out int age)
//     {
//         name = Name;
//         age = Age;
//     }
// }