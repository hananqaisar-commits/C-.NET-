namespace LibraryItemName
{
    public class LibraryItem
    {
        public string title { get; set; }
        public bool IsAvailable { get; private set; }

        public LibraryItem(string title)
        {
            this.title = title;
            IsAvailable = true;
        }
        public LibraryItem()// overloaded constructor to handle the case when no title is provided
        {
            title = "Unknown";
            IsAvailable = true;
        }

        public virtual string GetDetails()
        {
            return $"Title: {title} | Availability: {(IsAvailable ? "yes" : "No")}\n";//used ternory operator in this line
        }

        public virtual void CheckOut()
        {
            IsAvailable = false;
            Console.WriteLine($"You have checked out {title}.");
        }
        public void ShowStatus()
        {
            Console.WriteLine($"{title} Availability: {(IsAvailable ? "yes" : "No")}");
        }
    }
}