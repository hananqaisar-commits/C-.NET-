using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.Interfaces
{
    public interface ILibraryItem
    {
        string Title { get; set; }
        string SrNo { get; set; }
        bool IsAvailable { get; set; }
        void IssueItem(Borrower user);
        void ReturnItem(Borrower user);
    }
}
