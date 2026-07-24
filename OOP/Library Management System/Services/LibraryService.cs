using LibraryManagementSystem.Interfaces;

namespace LibraryManagementSystem.Services
{
    public class LibraryService
    {
        private List<ILibraryItem> items = new List<ILibraryItem>();

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