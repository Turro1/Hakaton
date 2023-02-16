namespace Hakaton.Domain.Entities;

public class Scene
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Dialogue> Dialogues { get; set; }
    public Uri BackgroundImage { get; set; }

    public Scene(int id, string name, List<Dialogue> dialogues, Uri backgroundImage)
    {
        Id = id;
        Name = name;
        Dialogues = dialogues;
        BackgroundImage = backgroundImage;
    }
}