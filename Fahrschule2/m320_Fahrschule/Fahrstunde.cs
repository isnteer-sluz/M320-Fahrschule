namespace Fahrschule2;

public class Fahrstunde
{
    private DateOnly Datum { get; set; }
    private TimeOnly Zeit { get; set; }
    private int Dauer { get; set; }
    private string Status
    {
        get => (Datum < new DateOnly() && Zeit < (new TimeOnly().Add(new TimeSpan(Dauer, 0, 0))))
            ? "Absolviert" : "Ausstehend";
    }
    private Fahrlehrer Fahrlehrer;
    private Schüler Schüler;
    private Fahrzeug Fahrzeug;

    public Fahrstunde(DateOnly datum, TimeOnly zeit, int dauer, Fahrlehrer fahrlehrer, Schüler schüler, Fahrzeug fahrzeug)
    {
        Datum = datum;
        Zeit = zeit;
        Dauer = dauer;
        Fahrlehrer = fahrlehrer;
        Schüler = schüler;
        Fahrzeug = fahrzeug;
    }
}