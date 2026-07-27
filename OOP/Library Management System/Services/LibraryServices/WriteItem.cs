using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.Services.LibraryServices;

public class WriteFile
{
    string _filePath;

    public void WriteItem(Items item)
    {
        _filePath = Path.Combine(Directory.GetCurrentDirectory(), "Items.txt");

        using (StreamWriter writer = new StreamWriter(_filePath, true))
        {
            writer.WriteLine(item.ToFile());
        }
    }
}
