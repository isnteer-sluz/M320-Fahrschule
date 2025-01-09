namespace Fahrschule2;

public class Fahrzeug
{
    private string Modell { get; set; }
    private string Kennzeichen { get; set; }
    private bool _Verfügbar = true;
    public bool Verfügbar
    {
        get => _Verfügbar;
    }

    public Fahrzeug(string modell, string kennzeichen)
    {
        Modell = modell;
        Kennzeichen = kennzeichen;
    }

    public void reservieren()
    {
        if (_Verfügbar)
        {
            _Verfügbar = false;
        }
        else
        {
            Console.WriteLine("Fahrzeug ist nicht verfügbar");
        }
    }

    public void freigeben()
    {
        _Verfügbar = true;
    }
}