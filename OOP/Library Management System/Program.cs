using System;
using LibraryManagementSystem.Interfaces;
using LibraryManagementSystem.Models;
using LibraryManagementSystem.Models.LibraryItems;
using LibraryManagementSystem.Services;
using LibraryManagementSystem.Services.LibraryServices;
using LibraryManagementSystem.Services.LibraryServices.AddItem;

namespace Name
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Header("1) INHERITANCE DEMO");
            Console.WriteLine("\n Items is Parent class and their properties are inherited by Book, DVD, Magzines:\n");
            Console.WriteLine($"  - Book inherits: title, SrNo, IsAvailable from base 'Items' class");
            Console.WriteLine($"  - DVD inherits: title, SrNo, IsAvailable from base 'Items' class");
            Console.WriteLine($"  - Magzines inherits: title, SrNo, IsAvailable from base 'Items' class");


            Header("2) INTERFACE DEMO");
            Console.WriteLine("\nAll classes implement ILibraryItem interface:\n");
            ILibraryItem book = new Book("Automate boring stuff with python", "Hanan Qaisar", "1234");
            Console.WriteLine($"  - Book implements ILibraryItem (now it has IssueItem & ReturnItem methods)");
            ILibraryItem dvd = new DVD("GTA IV", 690, "4573");
            Console.WriteLine($"  - DVD implements ILibraryItem (now it has also IssueItem & ReturnItem methods)");
            ILibraryItem magzine = new Magzines(32, "National Geographic", "7890");
            Console.WriteLine($"  - Magzines implements ILibraryItem (now it has IssueItem & ReturnItem methods)");

            Header("POLYMORPHISM DEMO");
            Console.WriteLine("\n Same method call behaves differently for each class:\n");

            // Create objects again for polymorphism demo
            ILibraryItem bookPly = new Book("C# Basics", "John Doe", "B001");
            ILibraryItem dvdPly = new DVD("Python Course", 120, "D001");
            ILibraryItem magPly = new Magzines(45, "Tech Today", "M001");

            // Polymorphic array - treating different classes as same interface type
            ILibraryItem[] allItems = { bookPly, dvdPly, magPly };

            Borrower user = new Borrower("Hanan Qaisar");

            // Same method call - different output for each type
            Console.WriteLine("Same method call on whole array but, different output's show's polymorphism\n\n");
            foreach (ILibraryItem libItem in allItems)
            {
                libItem.IssueItem(user);
            }


            Header("DEPENDENCY INJECTION DEMO");
            Console.WriteLine("\n LibraryService accepts any ILibraryItem:");

            var service = new LibraryService();

            // Injecting Book
            service.AddItem(new Book("Clean Code", "Robert Martin", "B002"));
            Console.WriteLine($" - Added Book to LibraryService (injected via ILibraryItem interface)");

            // Injecting DVD
            service.AddItem(new DVD("C++ Tutorial", 90, "D002"));
            Console.WriteLine($" - Added DVD to LibraryService (injected via ILibraryItem interface)");

            // Injecting Magzines
            service.AddItem(new Magzines(50, "Science Weekly", "M002"));
            Console.WriteLine($" - Added Magzines to LibraryService (injected via ILibraryItem interface)");

            // Injecting ResearchPaper
            service.AddItem(new ResearchPaper(50, "Artificial Intelligence Research", "RP001"));
            Console.WriteLine($" - Added ResearchPaper to LibraryService (injected via ILibraryItem interface)");

            Header("WRITE DEMO");
            var writer = new WriteFile();
            writer.WriteItem(new Book("The Pragmatic Programmer", "Andrew Hunt", "B003"));
            writer.WriteItem(new DVD("C# Essentials", 95, "D003"));
            writer.WriteItem(new Magzines(42, "Science Monthly", "M003"));
            writer.WriteItem(new NewsPapers("English", "Daily News", "N001"));

            Console.WriteLine("All data written to file");

            Header("READ DEMO");
            List<ILibraryItem> Items = new List<ILibraryItem>();
            Items.Clear();
            var View = new ViewItem();
            Items = View.GetItems();
            foreach (var item in Items)
            {
                Console.WriteLine(item); //called tostring method
            }
        }
        static void Header(string name)
        {
            Console.WriteLine("\t\t____________________________________________________");
            Console.WriteLine($"\t\t|                     {name,-30}|");
            Console.WriteLine("\t\t|___________________________________________________|");
            Console.WriteLine("\n\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}
