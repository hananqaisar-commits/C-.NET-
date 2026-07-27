using LibraryManagementSystem.Interfaces;
using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.Models.LibraryItems
{
    public class DVD : Items
    {
        public float duration { get; set; }

        public DVD(string title, float min, string SrNo) : base(title, SrNo)
        {
            this.duration = (float)min / 60;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Title: {Title} | Duration: {duration} hours | Availability: {(IsAvailable ? "yes" : "No")}\n");
        }
        public override string ToFile()
        {
            return $"DVD,{Title},null,{SrNo},{duration},null,null";
        }
        public override string ToString()
        {
            return $"Title: {Title,-40} | SrNo: {SrNo,-10} | Duration: {duration:F2} hrs | Available: {IsAvailable}";
        }
    }
}
