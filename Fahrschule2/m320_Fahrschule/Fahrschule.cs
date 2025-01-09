namespace Fahrschule2;

public class Fahrschule
{
    private List<Fahrlehrer> FahrlehrerListe { get; set; }
    private List<Schüler> SchülerListe { get; set; }
    private List<Fahrzeug> FahrzeugListe { get; set; }

    public Fahrschule()
    {
        FahrlehrerListe = new List<Fahrlehrer>();
        SchülerListe = new List<Schüler>();
        FahrzeugListe = new List<Fahrzeug>();
    }

    public void AddFahrlehrer(Fahrlehrer fahrlehrer)
    {
        FahrlehrerListe.Add(fahrlehrer);
    }

    public void AddSchüler(Schüler schüler)
    {
        SchülerListe.Add(schüler);
    }

    public void AddFahrzeug(Fahrzeug fahrzeug)
    {
        FahrzeugListe.Add(fahrzeug);
    }
}