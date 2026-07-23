using ILibraryItemName;
using ItemsName;
using BorrowerName;
namespace BookName
{
    public class Book : Items, ILibraryItem
    {
        public string author { get; set; }

        public Book(string title, string author, string SrNo) : base(title, SrNo)
        {
            this.author = author;
        }
        public Book() : base("Unknown", "Unknown")//overloaded constructor
        {

        }
        public void IssueItem(Borrower user)
        {
            if (base.IsAvailable)
            {
                Console.WriteLine($"{title} book by {author} is issued to {user.name}");
                base.IsAvailable = false;
            }
            else
            {
                Console.WriteLine($"Temporary message: {title} book by {author} is not available for issue.");
            }
        }
        public void ReturnItem(Borrower user)
        {
            Console.WriteLine($"{title} book by {author} is returned by {user.name}.");
            base.IsAvailable = true;
        }
        public override string ToString()
        {
            return $"Title: {title} | Author: {author} \n";
        }
    }
}