namespace Fahrschule2;

public class Schüler : Person
{
    private List<Fahrstunde> Fahrstunden { get; set; }

    public Schüler(string name, string adresse) : base(name, adresse)
    {
        Fahrstunden = new List<Fahrstunde>();
    }

    private void AddFahrstunde(DateOnly datum, TimeOnly zeit, int dauer, Fahrlehrer fahrlehrer, Fahrzeug fahrzeug)
    {
        fahrzeug.reservieren();
        if (fahrzeug.Verfügbar)
        {
            Fahrstunde fahrstunde = new Fahrstunde(datum, zeit, dauer, fahrlehrer, this, fahrzeug);
            Fahrstunden.Add(fahrstunde);
        }
    }
}