namespace Fahrschule2;

public class Fahrlehrer : Person
{
    private List<Schüler> SchülerListe { get; set; }

    public Fahrlehrer(string name, string adresse) : base(name, adresse)
    {
        SchülerListe = new List<Schüler>();
    }

    private void AddSchüler(Schüler schüler)
    {
        SchülerListe.Add(schüler);
    }
}