using LibraryManagementSystem.Interfaces;
using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.Models.LibraryItems
{
    public class NewsPapers : Items
    {
        public string Language { get; set; }

        public NewsPapers(string language, string title, string SrNo) : base(title, SrNo)
        {
            Language = language;
        }

        public string ToFile()
        {
            return $"{Title},null,{SrNo},null,null,{Language}";
        }

        public override string ToString()
        {
            return $"Type: Newspaper | Title: {Title,-25} | SrNo: {SrNo,-8} | Language: {Language,-10} | Available: {IsAvailable}";
        }
    }
}
