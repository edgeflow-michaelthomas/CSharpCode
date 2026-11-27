namespace LagerAufgabe;

public class Lager
{
    public List<Artikel> ArtikelListe { get; } = new();

    public int Gesamtbestand
    {
        get
        {
            int gesamtAnzahl = 0;
            foreach (Artikel a in ArtikelListe)
            {
                gesamtAnzahl += a.Bestand;
            }

            return gesamtAnzahl;
        }
    }

    public decimal LagerWert
    {
        get
        {
            decimal summe = 0m;
            foreach (var artikel in ArtikelListe)
            {
                summe += artikel.Preis * artikel.Bestand;
            }

            return summe;
        }
    }

    private Artikel FindeArtikel(string name)
    {
        foreach (var artikel in ArtikelListe)
        {
            if (artikel.Name == name)
            {
                return artikel;
            }
        }

        return null;
    }

    public void Hinzufuegen(Artikel neuerArtikel)
    {
        if (neuerArtikel is null)
        {
            throw new ArgumentNullException("Artikel darf nicht null sein");
        }
        
        Artikel gefundenerArtikel = FindeArtikel(neuerArtikel.Name);
        if (gefundenerArtikel != null)
        {
            gefundenerArtikel.BestandErhoehen(neuerArtikel.Bestand);
        }
        else
        {
            ArtikelListe.Add(neuerArtikel);
        }
    }

    public void Verkaufen(string name, int menge)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException("Artikelname darf nicht leer sein.");
        }
        
        Artikel artikel = FindeArtikel(name);
        if (artikel == null)
        {
            throw new InvalidOperationException("Artikel nicht gefunden");
        }
        artikel.BestandVerringern(menge);
    }
}