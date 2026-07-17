using LibraryItemName;
namespace BookName
{
    public class Book : LibraryItem
    {
        public string author { get; set; }

        public Book(string title, string author) : base(title)
        {
            this.author = author;

        }
        public Book(string author)// overloaded constructor to handle the case when no title is provided
        {
            this.author = author;
            base.title = "Unknown";
        }

        public override string GetDetails()
        {
            return $"Title: {title} | Author: {author} | Availability: {(IsAvailable ? "yes" : "No")}\n";
        }

        public override void CheckOut()
        {
            Console.WriteLine($"Don't forget to return in 14 days.");

        }

        public override string ToString()
        {
            return $"Title: {title} | Author: {author} | Availability: {(IsAvailable ? "yes" : "No")}\n";
        }
    }
}
