using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using BookName;
using DVDName;
using BorrowerName;
using ILibraryItemName;
using LibraryItemName;
using MagzinesItem;
using ItemsName;
namespace Name
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Borrower user = new Borrower("Hanan Qaisar");
            LibraryService service = new LibraryService();
            ILibraryItem item = new Book("Automate boring stuff with python", "Hanan Qaisar", "1234");
            ILibraryItem item1 = new DVD("GTA IV", 690, "4573");// 690 is min it will convert in hours
            ILibraryItem item2 = new Magzines(32, "National Geographic", "7890");

            // Concepts used in this program are: Inheritance, Polymorphism, Encapsulation, and Ternary Operator.
            // Inheritance: Book and DVD classes inherit from the LibraryItem class, allowing them to share common properties and methods.
            // Polymorphism: The GetDetails and CheckOut methods are overridden in the Book and
            // DVD classes, allowing them to provide their own implementations while still being treated as LibraryItem objects.
            // Encapsulation: The IsAvailable property is encapsulated within the LibraryItem class, providing controlled access to the availability status of library items.
            Console.Write("-------------------Library Management System-------------------\n");

            //Now real object of classes are created and methods are called to demonstrate the functionality of the library management system.
            // The output will show the details of the library items, their availability status, and the actions performed by the borrower.
            Console.Write(item.ToString());
            item.IssueItem(user);
            Console.Write(item1.ToString());
            item1.IssueItem(user);
            Console.Write(item2.ToString());
            item2.IssueItem(user);
            Console.Write("-------------------After Issuing the items-------------------\n");
            // Returning the items
            Console.Write(item.ToString());
            item.ReturnItem(user);
            Console.Write(item1.ToString());
            item1.ReturnItem(user);
            Console.Write(item2.ToString());
            item2.ReturnItem(user);

        }
    }
}