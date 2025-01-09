namespace Fahrschule2;

public class Schüler : Person
{
    public List<string> Lektionen { get; set; }

    public Schüler(string name, string adresse) : base(name, adresse)
    {
        Lektionen = new List<string>();
    }

    public void AddLektion(string lektion)
    {
        Lektionen.Add(lektion);
    }
}