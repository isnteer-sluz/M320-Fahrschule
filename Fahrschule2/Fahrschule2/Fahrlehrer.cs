namespace Fahrschule2;

public class Fahrlehrer : Person
{
    public List<Schüler> SchülerListe { get; set; }
    public string Spezialgebiet { get; set; }

    public Fahrlehrer(string name, string adresse, string spezialgebiet) : base(name, adresse)
    {
        Spezialgebiet = spezialgebiet;
        SchülerListe = new List<Schüler>();
    }

    public void AddSchüler(Schüler schüler)
    {
        SchülerListe.Add(schüler);
    }
}