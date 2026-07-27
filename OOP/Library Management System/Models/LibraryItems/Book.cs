using LibraryManagementSystem.Interfaces;
using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.Models.LibraryItems
{
    public class Book : Items
    {
        public string author { get; set; }

        public Book(string Title, string author, string SrNo) : base(Title, SrNo)
        {
            this.author = author;
        }

        public Book() : base("Unknown", "Unknown")
        {
            this.author = "Unknown";
        }

        public override string ToFile()
        {
            return $"Book,{Title},{author},{SrNo},null,null,null";
        }

        public override string ToString()
        {
            return $"Title:  {Title,-40}| ID: {SrNo,-10} | Author: {author,-20} | Available: {IsAvailable}";
        }
    }
}
