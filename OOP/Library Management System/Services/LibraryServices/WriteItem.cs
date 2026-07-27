using LibraryManagementSystem.Interfaces;

namespace LibraryManagementSystem.Services.LibraryServices;

public class WriteFile
{
    string _filePath;//global variable
    public void WriteItem(ILibraryItem item)
    {
        _filePath = Path.Combine(Directory.GetCurrentDirectory(), "Items.txt");
        using (StreamWriter writer = new StreamWriter(_filePath, true))
        {
            writer.WriteLine(item.ToFile());
        }
    }
}