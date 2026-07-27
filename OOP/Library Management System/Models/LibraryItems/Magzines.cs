using LibraryManagementSystem.Interfaces;
using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.Models.LibraryItems
{
    public class Magzines : Items
    {
        public int Pages { get; set; }

        public Magzines(int page, string title, string SrNo) : base(title, SrNo)
        {
            this.Pages = page;
        }

        public override string ToFile()
        {
            return $"Magazine,{Title},null,{SrNo},null,{Pages},null";
        }

        public override string ToString()
        {
            return $"Title: {Title,-40} | SrNo: {SrNo,-10} | Pages: {Pages,-20} | Available: {IsAvailable}";
        }
    }
}
