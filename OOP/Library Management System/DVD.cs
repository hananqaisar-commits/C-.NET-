
using ILibraryItemName;
using ItemsName;
using BorrowerName;
namespace DVDName
{
    public class DVD : Items, ILibraryItem
    {
        public float duration { get; set; }
        public DVD(string title, int min, string SrNo) : base(title, SrNo)
        {
            this.duration = (float)min / 60;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Title: {title} | Duration: {duration} hours | Availability: {(IsAvailable ? "yes" : "No")}\n");
        }
        public void IssueItem(Borrower name)
        {
            if (base.IsAvailable)
            {
                Console.WriteLine($"{title} DVD is issued to {name.name}");
                base.IsAvailable = false;
            }

        }
        public void ReturnItem(Borrower user)
        {
            Console.WriteLine($"{title} DVD is returned by {user.name}");
            base.IsAvailable = true;

        }
        public override string ToString()
        {
            return $"Title: {title} | Duration: {duration} hours | Availability: {(IsAvailable ? "yes" : "No")}\n";
        }
    }
}