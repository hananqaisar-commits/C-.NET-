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

        public string ToFile()
        {
            return $"{Title},null,{SrNo},null,{Pages},null";
        }

        public override string ToString()
        {
            return $"Type: Magazine | Title: {Title,-25} | SrNo: {SrNo,-8} | Pages: {Pages,-4} | Available: {IsAvailable}";
        }
    }
}
