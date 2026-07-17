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

        public override string GetDetails()
        {
            return $"Title: {title} | Author: {author} | Availability: {(IsAvailable ? "yes" : "No")}\n";
        }

        public override void CheckOut()
        {
            Console.WriteLine($"Don't forget to return in 14 days.");

        }
    }
}
