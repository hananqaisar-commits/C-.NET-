using System;
using ItemsName;
using ILibraryItemName;
using BorrowerName;
namespace MagzinesItem
{
    public class Magzines : Items, ILibraryItem
    {
        public int Pages { get; set; }

        public Magzines(int page, string title, string SrNo) : base(title, SrNo)
        {
            this.Pages = page;
        }

        public void IssueItem(Borrower user)
        {
            if (base.IsAvailable)
            {
                Console.WriteLine($"{title} Magzine is issued to {user.name}");
                base.IsAvailable = false;
            }
            else
            {
                Console.WriteLine($"Temporary Message: {title} is temporary not availabale");
            }
        }
        public void ReturnItem(Borrower user)
        {
            base.IsAvailable = true;
            Console.WriteLine($"{title} with {SrNo} is returned by {user.name}");
        }
        public override string ToString()
        {
            return $"{title} | {SrNo} | pages: {Pages}\n";
        }
    }
}