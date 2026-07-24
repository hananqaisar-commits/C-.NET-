using System;
using System.Collections.Generic;
using System.IO;
using LibraryManagementSystem.Interfaces;
using LibraryManagementSystem.Models;
using LibraryManagementSystem.Models.LibraryItems;

namespace LibraryManagementSystem.Services.LibraryServices.AddItem;

public class ViewItem
{
    string pathFile = Path.Combine(Directory.GetCurrentDirectory(), "Items.txt");

    public List<ILibraryItem> GetItems()
    {
        List<ILibraryItem> items = new List<ILibraryItem>();
        if (!File.Exists(pathFile))
        {
            Console.WriteLine("Items.txt not exist(call from View items)");
        }
        else
        {
            using (StreamReader ViewReader = new StreamReader(pathFile))
            {
                string line;

                while ((line = ViewReader.ReadLine()) != null)
                {
                    string[] data = line.Split(',');
                    if (data.Length < 6)
                    {
                        Console.WriteLine("Invalid line");
                        continue;
                    }

                    string title = data[0];
                    string author = data[1];
                    string srNo = data[2];

                    if (author != "null")
                    {
                        items.Add(new Book(title, author, srNo));
                    }
                    else if (data[3] != "null")
                    {
                        if (float.TryParse(data[3], out float minutes))
                            items.Add(new DVD(title, minutes, srNo));
                    }
                    else if (data[4] != "null")
                    {
                        int pages = int.Parse(data[4]);
                        items.Add(new Magzines(pages, title, srNo));
                    }
                    else if (data[5] != "null")
                    {
                        string language = data[5];
                        items.Add(new NewsPapers(language, title, srNo));
                    }

                }
            }

        }
        return items;
    }
}