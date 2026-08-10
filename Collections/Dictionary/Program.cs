countCharacters();
countWords();
static void countCharacters()
{
    Dictionary<char, int> dict = new Dictionary<char, int>();
    using StreamReader reader = new StreamReader("/home/hanan/Desktop/C#(.NET)/Collections/Dictionary/text.txt");
    string? line;

    while ((line = reader.ReadLine()) != null)
    {
        foreach (char ch in line)
        {
            dict[ch] = dict.GetValueOrDefault(ch) + 1;
        }
    }
    foreach (var item in dict)
    {
        Console.WriteLine($"{item.Key} : {item.Value}");
    }
}

static void countWords()
{
    Dictionary<string, int> dict = new Dictionary<string, int>();
    using StreamReader reader = new StreamReader("/home/hanan/Desktop/C#(.NET)/Collections/Dictionary/text.txt");
    string? line;
    while ((line = reader.ReadLine()) != null)
    {
        foreach (string word in line.Split())
        {
            dict[word] = dict.GetValueOrDefault(word) + 1;
        }
    }
    foreach (var item in dict)
    {
        Console.WriteLine($"{item.Key} : {item.Value}");
    }
}