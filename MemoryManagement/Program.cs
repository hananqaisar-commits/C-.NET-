Console.WriteLine("=================Memory Management=======================");

PrintHeader("Created Variable and Struct in Stack");

int number = 12;
Point point = new Point(10, 20);

Console.WriteLine($"Number : {number}");
Console.WriteLine($"Point  : ({point.X}, {point.Y})");



PrintHeader("Created Record");

StudentRecord studentRecord = new StudentRecord("Hanan Qaisar", 28);
Console.WriteLine(studentRecord);

PrintHeader("Deconstruct StudentRecord");
var (name, age) = studentRecord;

Console.WriteLine($"Name : {name}");
Console.WriteLine($"Age  : {age}");


PrintHeader("Heap Example");
Console.WriteLine("person object is created in heap");
Person person = new Person("Hanan Qaisar", 18);
Console.WriteLine($"Created Person: {person.Name}");
Console.WriteLine($"Person Age : {person.Age}");


PrintHeader("Boxing && Unboxing");

object boxedAge = age;      // Boxing
int unboxedAge = (int)boxedAge; // Unboxing

Console.WriteLine($"Boxed Age   : {boxedAge}");
Console.WriteLine($"Unboxed Age : {unboxedAge}");


PrintHeader("using Statement && IDisposable");

FileLogger fileLogger = new FileLogger("/home/hanan/Desktop/C#(.NET)/MemoryManagement/log.txt");
fileLogger.Log($"Application Started. {person.Name} Logged in.");
Console.WriteLine("Logs written successfully.");
PrintHeader("Disposing FileWritter");
fileLogger.Dispose();


person = null;
GC.Collect();
Console.WriteLine("Object is now eligible for Garbage Collection.");


PrintHeader("Program Finished");

static void PrintHeader(string title)
{
    Console.WriteLine($"\n\t\t----------------- {title} ------------------");
}