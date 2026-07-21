using System;
using System.Reflection.Metadata.Ecma335;
using ILibraryItemName;
namespace BorrowerName
{
    public class Borrower
    {
        public string id { get; set; }
        public string name { get; set; }
        private ILibraryItem BorrowedItem;

        string preFix = "Br";
        int count = 1;
        public Borrower(string name)
        {
            this.name = name;
            this.id = preFix + count.ToString();

        }
        public void IssueItem(ILibraryItem item)
        {
            BorrowedItem = item;
            item.IssueItem();
        }
        public void ReturnItem(ILibraryItem item)
        {
            BorrowedItem = item;
            item.ReturnItem();
        }
        public override string ToString()
        {
            return $"Borrower ID: {id} | Name: {name}";
        }
    }
}