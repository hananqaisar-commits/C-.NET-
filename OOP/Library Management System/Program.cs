using System;
using System.Collections.Generic;
using BookName;
using DVDName;
using LibraryItemName;
namespace Name
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Book Python = new Book("Automate boring stuff with python", "Hanan Qaisar");
            DVD Gta = new DVD("GTA IV", 690);// 690 is min it will convert in hours

            List<LibraryItem> libraryItems = new List<LibraryItem>();
            libraryItems.Add(Python);
            libraryItems.Add(Gta);


            // Concepts used in this program are: Inheritance, Polymorphism, Encapsulation, and Ternary Operator.
            // Inheritance: Book and DVD classes inherit from the LibraryItem class, allowing them to share common properties and methods.
            // Polymorphism: The GetDetails and CheckOut methods are overridden in the Book and
            // DVD classes, allowing them to provide their own implementations while still being treated as LibraryItem objects.
            // Encapsulation: The IsAvailable property is encapsulated within the LibraryItem class, providing controlled access to the availability status of library items.

            Console.WriteLine("-------------------Library Management System-------------------");
            Console.WriteLine("Library Items Details:\n");


            foreach (LibraryItem item in libraryItems)// Iterate through each LibraryItem in the libraryItems list
            {
                if (item is Book)// Check if the item is of type Book
                {
                    Book book = (Book)item;// Cast the LibraryItem to Book
                    book.GetDetails();// Call the overridden GetDetails method for Book
                    book.CheckOut();// Call the overridden CheckOut method for Book
                    book.ShowStatus();// Call the ShowStatus method from the base class
                    Console.Write("-----------------------------------------------------\n");
                }
                else if (item is DVD)
                {
                    DVD dvd = (DVD)item;// Call the overridden GetDetails method for DVD
                    dvd.GetDetails();// Call the overridden CheckOut method for DVD
                    dvd.CheckOut();// Call the overridden CheckOut method for DVD
                    dvd.ShowStatus();// Call the ShowStatus method from the base class
                    Console.Write("-----------------------------------------------------\n");
                }
            }
        }
    }
}