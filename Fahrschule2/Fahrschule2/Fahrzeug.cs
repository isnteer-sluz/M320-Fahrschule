namespace Fahrschule2;

public class Fahrzeug
{
    public string Modell { get; set; }
    public string Kennzeichen { get; set; }
    public bool Verfügbar { get; set; }

    public Fahrzeug(string modell, string kennzeichen, bool verfügbar)
    {
        Modell = modell;
        Kennzeichen = kennzeichen;
        Verfügbar = verfügbar;
    }
}