using LibraryManagementSystem.Interfaces;

namespace LibraryManagementSystem.Models
{
    public abstract class Items : ILibraryItem
    {
        public string Title { get; set; }
        public string SrNo { get; set; }
        public bool IsAvailable { get; set; }
        public Items(string Title, string SrNo)
        {
            this.Title = Title;
            this.SrNo = SrNo;
            this.IsAvailable = true;
        }
        public abstract string ToFile();//it will implemented in all classes

        public void ReturnItem(Borrower user)
        {
            this.IsAvailable = true;
            Console.WriteLine($"{Title} with {SrNo} is returned by {user.name}");
        }
        public void IssueItem(Borrower user)
        {
            if (this.IsAvailable)
            {
                Console.WriteLine($"{Title} Magzine is issued to {user.name}");
                this.IsAvailable = false;
            }
            else
            {
                Console.WriteLine($"Temporary Message: {Title} is temporary not available");
            }
        }
    }
}