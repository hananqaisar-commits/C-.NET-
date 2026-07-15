namespace Name
{
    public class Student
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public string Marks { get; set; }

        public Student()
        {
            Name = "";
            ID = "";
            Marks = "";
        }
        public Student(string Name, string ID, string Marks)
        {
            this.Name = Name;
            this.ID = ID;
            this.Marks = Marks;
        }

        List<Student> students = new List<Student>();
        StudentOperations SO = new StudentOperations();//SO mean studentOperation object


        public void AddStudent()
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine()!;
            String id = SO.genereateID();  // Generate random
            Console.Write("Enter marks: ");
            string marks = Console.ReadLine()!;
            Console.Write("Random ID genrated with prefix\n");

            Student student = new Student(name, id, marks);
            students.Add(student);
            SO.SaveToFile(students);

        }
        public override string ToString()
        {
            return $"{ID,-8} {Name,-20} {Marks,-6}";
        }
        public string ToFile()
        {
            return $"{ID,-8} {Name,-20} {Marks,-6}";
        }
    }
}
