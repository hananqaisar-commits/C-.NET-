using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.Interfaces
{
    public interface ILibraryItem
    {
        void IssueItem(Borrower user);
        void ReturnItem(Borrower user);
    }
}