using ILibraryItemName;
namespace LibraryItemName
{
    public class LibraryService
    {
        List<ILibraryItem> items = new List<ILibraryItem>();

        public void AddItem(ILibraryItem item)
        {
            items.Add(item);
        }
        public void RemoveItem(ILibraryItem item)
        {
            items.Remove(item);
        }
    }
}