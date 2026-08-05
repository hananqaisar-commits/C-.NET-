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
        Console.WriteLine("Student Management System");
        Console.WriteLine("Good Bye!");
    }


    public static void HeaderTexts()
    {
        Console.WriteLine($"{"ID",-8} {"Name",-20} {"Marks",-6}");
    }
    public static void menu()// It will print the menu options for the user to choose from it.
    {
        Console.WriteLine("\n1. Add Student");
        Console.WriteLine("2. Add Teacher");
        Console.WriteLine("3. View Students");
        Console.WriteLine("4. View Teachers");
        Console.WriteLine("5. Class Statistics");
        Console.WriteLine("6. Inspection");
        Console.WriteLine("7. Exit");
        HeaderLine();//function used here to print a line after the menu
        Console.WriteLine("Enter your choice: ");

    }

    public static void continuePrompt()// It will prompt the user to press any key to continue after performing an action.
    {
        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey();// Wait for the user to press a key before continuing
    }
}
