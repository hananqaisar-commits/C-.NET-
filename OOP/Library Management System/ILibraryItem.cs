using System;
using BorrowerName;
namespace ILibraryItemName
{
    public interface ILibraryItem
    {
        public void IssueItem(Borrower user);
        public void ReturnItem(Borrower user);
    }
}