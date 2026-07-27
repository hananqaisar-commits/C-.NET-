using LibraryManagementSystem.Interfaces;
using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.Models.LibraryItems
{
    public class ResearchPaper : Items
    {
        public string Language { get; set; }

        public ResearchPaper(string language, string title, string SrNo) : base(title, SrNo)
        {
            Language = language;
        }
        public override string ToFile()
        {
            return $"ResearchPaper,{Title},null,{SrNo},null,null,{Language}";
        }

        public override string ToString()
        {
            return $"Title: {Title,-40} | SrNo: {SrNo,-10} | Language: {Language,-20} | Available: {IsAvailable}";
        }
    }
}
