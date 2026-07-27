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
        public override string ToFile()
        {
            return $"Newspaper,{Title},null,{SrNo},null,null,{Language}";
        }

        public override string ToString()
        {
            return $"Title: {Title,-40} | SrNo: {SrNo,-10} | Language: {Language,-20} | Available: {IsAvailable}";
        }
    }
}
