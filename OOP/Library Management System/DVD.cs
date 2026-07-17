using LibraryItemName;
namespace DVDName
{
    public class DVD : LibraryItemName.LibraryItem
    {
        public float duration { get; set; }
        public DVD(string title, int min) : base(title)
        {
            this.duration = (float)min / 60;
        }
        public override void CheckOut()
        {
            Console.WriteLine($"DVD: {title} , {duration} hours");

        }
        public void checkOut()
        {
            base.CheckOut();
        }

    }
}