using LibraryManagementSystem.Interfaces;
using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.Models.LibraryItems
{
    public class DVD : Items, ILibraryItem
    {
        public float duration { get; set; }

        public DVD(string title, float min, string SrNo) : base(title, SrNo)
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

        public string ToFile()
        {
            return $"{title},null,{SrNo},{duration},null,null";
        }
        public override string ToString()
        {
            return $"Type: DVD | Title: {title,-25} | SrNo: {SrNo,-8} | Duration: {duration:F2} hrs | Available: {IsAvailable}";
        }
    }
}
