using System;
using System.Collections.Generic;
using LibraryManagementSystem.Interfaces;
using LibraryManagementSystem.Models;
using LibraryManagementSystem.Models.LibraryItems;
using LibraryManagementSystem.Services;
using LibraryManagementSystem.IO_Operations.WriteItem;
using LibraryManagementSystem.IO_Operations.AddItem;
using Microsoft.VisualBasic;

namespace Name
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.Title = "Library Management System - OOP Demo";


            Header("1) INHERITANCE DEMO");

            Console.WriteLine("Creating Book...");
            Book book = new Book(
                "Automate boring stuff with python",
                "Hanan Qaisar",
                "B001"
            );

            Console.WriteLine("Book created!");
            Console.WriteLine($"Title: {book.Title}");
            Console.WriteLine($"SrNo: {book.SrNo}");
            Console.WriteLine($"Available: {book.IsAvailable}");

            Console.WriteLine("\nThese properties came from Items (Parent Class).");

            Pause();
            Header("2) INTERFACE DEMO");

            Console.WriteLine("Creating objects using ILibraryItem reference...\n");

            ILibraryItem bookItem =
                new Book("C# Basics", "John Doe", "B001");

            Console.WriteLine("Book object created.");
            Console.WriteLine("Reference type: ILibraryItem");
            Console.WriteLine("Available methods:");
            Console.WriteLine("  IssueItem()");
            Console.WriteLine("  ReturnItem()");

            Pause();
            ILibraryItem dvdItem =
                new DVD("GTA IV", 690, "D001");

            Console.WriteLine("DVD object created.");
            Console.WriteLine("Reference type: ILibraryItem");

            Pause();

            ILibraryItem magazineItem =
                new Magzines(32, "National Geographic", "M001");

            Console.WriteLine("Magzines object created.");
            Console.WriteLine("Reference type: ILibraryItem");

            Pause();

            Header("3) POLYMORPHISM DEMO");

            Console.WriteLine("Creating 3 different objects...\n");

            ILibraryItem bookPly =
                new Book("C# Basics", "John Doe", "B002");

            Console.WriteLine("Book created.");

            ILibraryItem dvdPly =
                new DVD("Python Course", 120, "D002");

            Console.WriteLine("DVD created.");

            ILibraryItem magPly =
                new Magzines(45, "Tech Today", "M002");

            Console.WriteLine("Magzines created.");

            Console.WriteLine("\nAll 3 objects are stored as ILibraryItem.");

            Pause();

            ILibraryItem[] allItems =
            {
                        bookPly,
                        dvdPly,
                        magPly
                    };

            Borrower user = new Borrower("Hanan Qaisar");

            Header("SAME METHOD - DIFFERENT BEHAVIOR");

            Console.WriteLine("The same method will be called for every object:");
            Console.WriteLine();
            Console.WriteLine("    item.IssueItem(user);");

            Pause();

            foreach (ILibraryItem item in allItems)
            {
                Console.Clear();

                Console.WriteLine("========================================");
                Console.WriteLine($"Object: {item.GetType().Name}");
                Console.WriteLine("========================================");

                Console.WriteLine("\nCalling:");
                Console.WriteLine("item.IssueItem(user);");

                Console.WriteLine("\nOutput:");

                // SAME METHOD CALL
                item.IssueItem(user);

                Pause();
            }
            Console.Clear();
            Console.WriteLine("========================================");
            Console.WriteLine("WHAT HAPPENED?");
            Console.WriteLine("========================================\n");

            Console.WriteLine("Book     -> Book's IssueItem()");
            Console.WriteLine("DVD      -> DVD's IssueItem()");
            Console.WriteLine("Magzines -> Magzines' IssueItem()");

            Console.WriteLine("\nSame method call.");
            Console.WriteLine("Different behavior.");
            Console.WriteLine("This is POLYMORPHISM.");

            Pause();
            Header("4) DEPENDENCY INJECTION DEMO");

            var service = new LibraryService();

            Console.WriteLine("LibraryService is ready.");
            Console.WriteLine("\nIt accepts ILibraryItem.\n");

            Console.WriteLine("Adding Book...");
            service.AddItem(
                new Book("Clean Code", "Robert Martin", "B003")
            );
            Console.WriteLine("Book added.");

            Pause();

            Console.Clear();
            Console.WriteLine("Adding DVD...");
            service.AddItem(
                new DVD("C++ Tutorial", 90, "D003")
            );
            Console.WriteLine("DVD added.");
            Pause();
            Console.Clear();
            Console.WriteLine("Adding Magzines...");
            service.AddItem(
                new Magzines(50, "Science Weekly", "M003")
            );
            Console.WriteLine("Magzines added.");
            Pause();
            Console.Clear();
            Console.WriteLine("Adding ResearchPaper...");
            service.AddItem(
                new ResearchPaper(
                    "English",
                    "Artificial Intelligence Research",
                    "RP001"
                )
            );
            Console.WriteLine("ResearchPaper added.");
            Console.WriteLine("\nDifferent objects injected into");
            Console.WriteLine("the same LibraryService.");
            Pause();
            Header("5) WRITE TO FILE");

            var writer = new WriteFile();

            Console.WriteLine("Writing Book...");
            writer.WriteItem(
                new Book(
                    "The Pragmatic Programmer",
                    "Andrew Hunt",
                    "B004"
                )
            );
            Console.WriteLine("Book written to file.");
            Pause();
            Console.Clear();

            Console.WriteLine("Writing DVD...");
            writer.WriteItem(
                new DVD("C# Essentials", 95, "D004")
            );
            Console.WriteLine("DVD written to file.");
            Pause();
            Console.Clear();

            Console.WriteLine("Writing Magzines...");
            writer.WriteItem(
                new Magzines(42, "Science Monthly", "M004")
            );
            Console.WriteLine("Magzines written to file.");
            Pause();
            Console.Clear();

            Console.WriteLine("Writing Newspaper...");
            writer.WriteItem(
                new NewsPapers("English", "Daily News", "N001")
            );
            Console.WriteLine("Newspaper written to file.");

            Console.WriteLine("\nAll objects have been written to file.");
            Pause();
            Header("6) READ FROM FILE");

            Console.WriteLine("Reading objects from file...\n");

            var View = new ViewItem();

            List<ILibraryItem> Items = View.GetItems();

            Console.WriteLine($"Objects found: {Items.Count}\n");

            Pause();

            foreach (var item in Items)
            {
                Console.Clear();

                Console.WriteLine("========================================");
                Console.WriteLine($"Type: {item.GetType().Name}");
                Console.WriteLine("========================================\n");

                Console.WriteLine(item);

                Pause();
            }
            Header("DEMO COMPLETE");

            Console.WriteLine("Inheritance       ");
            Console.WriteLine("Interface         ");
            Console.WriteLine("Polymorphism      ");
            Console.WriteLine("Dependency Inject ");
            Console.WriteLine("Write to File     ");
            Console.WriteLine("Read from File    ");
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
        static void Header(string name)
        {
            Console.Clear();

            Console.WriteLine();
            Console.WriteLine("========================================");
            Console.WriteLine($"        {name}");
            Console.WriteLine("========================================");
            Console.WriteLine();
        }
        static void Pause()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}