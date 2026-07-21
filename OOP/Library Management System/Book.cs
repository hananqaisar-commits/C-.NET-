using ILibraryItemName;
using ItemsName;
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
        public void IssueItem()
        {
            if (base.IsAvailable)
            {
                Console.WriteLine($"{title} book by {author} is issued");
                base.IsAvailable = false;
            }
            else
            {
                Console.WriteLine($"Temporary message: {title} book by {author} is not available for issue.");
            }
        }
        public void ReturnItem()
        {
            Console.WriteLine($"{title} book by {author} is returned.");
            base.IsAvailable = true;
        }
        public override string ToString()
        {
            return $"Title: {title} | Author: {author} \n";
        }
    }
}