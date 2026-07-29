using System;
using System.Collections.Generic;
using System.IO;
using LibraryManagementSystem.Interfaces;
using LibraryManagementSystem.Models;
using LibraryManagementSystem.Models.LibraryItems;

namespace LibraryManagementSystem.IO_Operations.AddItem;

public class ViewItem
{
    string pathFile = Path.Combine(Directory.GetCurrentDirectory(), "Items.txt");

    public List<ILibraryItem> GetItems()
    {
        List<ILibraryItem> items = new List<ILibraryItem>();

        if (!File.Exists(pathFile))
        {
            Console.WriteLine("Items.txt not exist(call from View items)");
            return items;
        }

        using (StreamReader ViewReader = new StreamReader(pathFile))
        {
            string line;

            while ((line = ViewReader.ReadLine()) != null)
            {
                string[] data = line.Split(',');

                if (data.Length < 7)
                {
                    Console.WriteLine("Invalid line");
                    continue;
                }

                string type = data[0];
                string title = data[1];
                string author = data[2];
                string srNo = data[3];

                switch (type)
                {
                    case "Book":
                        items.Add(new Book(title, author, srNo));
                        break;

                    case "DVD":
                        if (float.TryParse(data[4], out float hours))
                        {
                            items.Add(new DVD(title, hours * 60, srNo));
                        }
                        break;

                    case "Magazine":
                        if (int.TryParse(data[5], out int pages))
                        {
                            items.Add(new Magzines(pages, title, srNo));
                        }
                        break;

                    case "Newspaper":
                        items.Add(new NewsPapers(data[6], title, srNo));
                        break;

                    case "ResearchPaper":
                        items.Add(new ResearchPaper(data[6], title, srNo));
                        break;

                    default:
                        Console.WriteLine($"Unknown item type: {type}");
                        break;
                }
            }
        }

        return items;
    }
}
