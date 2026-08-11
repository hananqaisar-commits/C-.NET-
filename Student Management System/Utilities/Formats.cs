using System;
namespace Utilities.Formats;

public class Formats
{
    public static void Header(String name)// It will print the header for the given name with proper formatting.
    {
        Console.WriteLine("\n================================ " + name + " ================================");
    }
    public static void HeaderLine()
    {
        Console.WriteLine("\n-------------------------------------------------------------------------------");
    }
    public static void Loading(String loadingContext)
    {
        Console.WriteLine($"{loadingContext}...");
    }

    public static void Exit()// It will print the exit message when the user chooses to exit the program.
    {
        Console.WriteLine("\nThank you for using");
        Console.WriteLine("School Management System");
        Console.WriteLine("Good Bye!");
    }


    public static void HeaderTexts()
    {
        Console.WriteLine($"{"ID",-8} {"Name",-20} {"Marks",-6}");
    }


    public static void ShowMainMenu()
    {

        Console.WriteLine("1. Add Student");
        Console.WriteLine("2. Delete Student by ID");
        Console.WriteLine("3. Update Student by ID");
        Console.WriteLine("4. Search Student by ID");
        Console.WriteLine("5. Search Student by Starting Letter(s)");
        Console.WriteLine("6. Search Students by Marks Range");
        Console.WriteLine("7. View All Students");
        Console.WriteLine("8. Sort Students by Name");
        Console.WriteLine("9. Sort Students by Marks");
        Console.WriteLine("10. Sort Students by ID");
        Console.WriteLine();

        Console.WriteLine("Reports");
        Console.WriteLine("11. Class Statistics");
        Console.WriteLine("12. Reflection Inspection");
        Console.WriteLine();

        Console.WriteLine("0. Exit");

        Console.Write("\nEnter your choice: ");
    }


    public static void continuePrompt()// It will prompt the user to press any key to continue after performing an action.
    {
        Console.WriteLine("=================================================================");
        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey();// Wait for the user to press a key before continuing
    }
}
