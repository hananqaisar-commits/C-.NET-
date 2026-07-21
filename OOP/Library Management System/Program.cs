using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using BookName;
using DVDName;
using BorrowerName;
using ILibraryItemName;
using LibraryItemName;
using MagzinesItem;
namespace Name
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Book Python = new Book("Automate boring stuff with python", "Hanan Qaisar", "1234");
            DVD Gta = new DVD("GTA IV", 690, "4573");// 690 is min it will convert in hours
            Magzines Magzine = new Magzines(32, "National Geographic", "7890");

            Borrower user = new Borrower("Hanan Qaisar");
            LibraryService service = new LibraryService();

            service.AddItem(Python);
            service.AddItem(Gta);
            // Concepts used in this program are: Inheritance, Polymorphism, Encapsulation, and Ternary Operator.
            // Inheritance: Book and DVD classes inherit from the LibraryItem class, allowing them to share common properties and methods.
            // Polymorphism: The GetDetails and CheckOut methods are overridden in the Book and
            // DVD classes, allowing them to provide their own implementations while still being treated as LibraryItem objects.
            // Encapsulation: The IsAvailable property is encapsulated within the LibraryItem class, providing controlled access to the availability status of library items.
            Console.WriteLine("-------------------Library Management System-------------------");
            user.IssueItem(Python);
            user.IssueItem(Gta);
            user.IssueItem(Magzine);
            user.ReturnItem(Python);
        }
    }
}