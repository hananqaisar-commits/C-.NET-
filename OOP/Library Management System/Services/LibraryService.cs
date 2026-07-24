using LibraryManagementSystem.Interfaces;

namespace LibraryManagementSystem.Services
{
    public class LibraryService
    {
        private readonly List<ILibraryItem> items = new();

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
