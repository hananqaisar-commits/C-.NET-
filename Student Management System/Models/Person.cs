namespace Models.Person;

public abstract class Person
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }

    protected Person(string Id, string Name, string Email)//protected only give access to it's parental class
    {
        this.Id = Id;
        this.Name = Name;
        this.Email = Email;
    }
    protected Person()
    {
        Name = "Unknown";
        Id = "Unknown";
        Email = "0";
    }
    public abstract void DisplayInfo();
}