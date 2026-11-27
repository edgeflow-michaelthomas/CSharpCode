namespace LagerAufgabe;

public class Artikel
{
    public string Name { get; }
    public decimal Preis { get; private set; }
    public int Bestand { get; private set; }

    public Artikel(string name, decimal preis, int bestand)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("Artikelname darf nicht leer sein.");
        }

        if (preis <= 0)
        {
            throw new ArgumentException("Preis muss größer 0 sein.");
        }

        if (bestand < 0)
        {
            throw new ArgumentException("Bestand darf nicht negativ sein.");
        }
        
        Name = name;
        Preis = preis;
        Bestand = bestand;
    }

    public void BestandErhoehen(int menge)
    {
        if (menge <= 0)
        {
            throw new ArgumentException("Menge muss größer 0 sein.");
        }

        Bestand += menge;
    }

    public void BestandVerringern(int menge)
    {
        if (menge <= 0)
        {
            throw new ArgumentException("Menge muss größer 0 sein.");
        }

        if (menge > Bestand)
        {
            throw new InvalidOperationException("Bestand ist zu gering");
        }

        Bestand -= menge;
    }
}