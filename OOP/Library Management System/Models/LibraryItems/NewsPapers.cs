using LibraryManagementSystem.Interfaces;
using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.Models.LibraryItems
{
    public class NewsPapers : Items, ILibraryItem
    {
        public string Language { get; set; }

        public NewsPapers(string language, string title, string SrNo) : base(title, SrNo)
        {
            Language = language;
        }

        public void IssueItem(Borrower user)
        {
            if (base.IsAvailable)
            {
                Console.WriteLine($"{title} newspaper is issued to {user.name}");
                base.IsAvailable = false;
            }
            else
            {
                Console.WriteLine($"Temporary Message: {title} is temporary not available");
            }
        }

        public void ReturnItem(Borrower user)
        {
            base.IsAvailable = true;
            Console.WriteLine($"{title} with {SrNo} is returned by {user.name}");
        }

        public string ToFile()
        {
            return $"{title},null,{SrNo},null,null,{Language}";
        }

        public override string ToString()
        {
            return $"Type: Newspaper | Title: {title,-25} | SrNo: {SrNo,-8} | Language: {Language,-10} | Available: {IsAvailable}";
        }
    }
}
