
using ILibraryItemName;
using ItemsName;
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
        public void IssueItem()
        {
            if (base.IsAvailable)
            {
                Console.WriteLine($"{title} DVD is issued");
                base.IsAvailable = false;
            }

        }
        public void ReturnItem()
        {
            Console.WriteLine($"{title} DVD is returned");
            base.IsAvailable = true;

        }
        public override string ToString()
        {
            return $"Title: {title} | Duration: {duration} hours | Availability: {(IsAvailable ? "yes" : "No")}\n";
        }
    }
}