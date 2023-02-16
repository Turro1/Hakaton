namespace Hakaton.Domain.Entities;

public class Dialogue
{
    public int Id { get; set; }
    public Character Speaker { get; set; }
    public string Text { get; set; }

    public Dialogue(int id, Character speaker, string text)
    {
        Id = id;
        Speaker = speaker;
        Text = text;
    }
}