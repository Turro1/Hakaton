namespace Hakaton.Domain.Entities;

public class Character
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Description { get; set; }
    public Uri ImageUrl { get; set; }

    public Character(int id, string name, int age, string description, Uri imageUrl)
    {
        Id = id;
        Name = name;
        Age = age;
        Description = description;
        ImageUrl = imageUrl;
    }
}