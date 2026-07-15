using System;
namespace Names
{

    public class Formats
    {

        public void Header(String name)
        {
            Console.WriteLine("\n============ " + name + " ============");
        }
        public void HeaderLine()
        {
            Console.WriteLine("\n---------------------------------------");
        }
        public void Loading(String loadingContext)
        {
            Console.WriteLine($"{loadingContext}...");
        }

        public void Exit()
        {
            Console.WriteLine("\nThank you for using");
            Console.WriteLine("Student Management System");
            Console.WriteLine("Good Bye!");
        }


        public void HeaderTexts()
        {
            Console.WriteLine($"{"ID",-8} {"Name",-20} {"Marks",-6}");
        }
        public void menu()
        {
            Console.WriteLine("\n1. Add Student");
            Console.WriteLine("2. View Students");
            Console.WriteLine("3. Class Statistics");
            Console.WriteLine("5. Exit");
            HeaderLine();//function used here to print a line after the menu
            Console.WriteLine("Enter your choice: ");

        }

        public void continuePrompt()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}