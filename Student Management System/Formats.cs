using System;
namespace Names
{

    public class Formats
    {

        public void Header(String name)// It will print the header for the given name with proper formatting.
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

        public void Exit()// It will print the exit message when the user chooses to exit the program.
        {
            Console.WriteLine("\nThank you for using");
            Console.WriteLine("Student Management System");
            Console.WriteLine("Good Bye!");
        }
        public void HeaderTexts()
        {
            Console.WriteLine($"{"ID",-8} {"Name",-20} {"Marks",-6}");
        }
        public void menu()// It will print the menu options for the user to choose from it.
        {
            Console.WriteLine("\n1. Add Student");
            Console.WriteLine("2. View Students");
            Console.WriteLine("3. Class Statistics");
            Console.WriteLine("5. Exit");
            HeaderLine();//function used here to print a line after the menu
            Console.WriteLine("Enter your choice: ");

        }

        public void continuePrompt()// It will prompt the user to press any key to continue after performing an action.
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}