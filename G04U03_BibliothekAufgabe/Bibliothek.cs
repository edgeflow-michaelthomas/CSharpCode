namespace G04U03_BibliothekAufgabe;

public class Bibliothek
{
    private List<Buch> _bestand = new();

    public int Anzahl
    {
        get { return _bestand.Count; }
    }

    public void Hinzufügen(Buch buch)
    {
        if (buch is null)
        {
            throw new ArgumentNullException(nameof(buch), "Buch nicht gefunden");
        }

        if (!_bestand.Contains(buch))
        {
            _bestand.Add(buch);
        }
    }
    
    // Contains(text, StringComparison.OrdinalIgnoreCase)
    public List<Buch> Suche(string text)
    {
        if (string.IsNullOrWhiteSpace(text))
        {
            throw new ArgumentNullException(nameof(text), "Buch darf nicht leer sein");
        }

        List<Buch> treffer = new List<Buch>();
        
        foreach (Buch buch in _bestand)
        {
            if (buch.Titel.Contains(text, StringComparison.OrdinalIgnoreCase) ||
                buch.Autor.Contains(text, StringComparison.OrdinalIgnoreCase))
            {
                treffer.Add(buch);
            }
        }
        
        return treffer;
    }
    
    // Contains(text, StringComparison.OrdinalIgnoreCase)
    public bool Ausleihen(string titel)
    {
        foreach (Buch buch in _bestand)
        {
            if (buch.Titel.Equals(titel, StringComparison.OrdinalIgnoreCase))
            {
                return buch.Ausleihen();
            }
        }
        
        return false;
    }

    public int AnzahlVerfuegbar()
    {
        int verfuegbar = Anzahl;
        foreach (Buch buch in _bestand)
        {
            if (buch.IstAusgeliehen)
            {
                verfuegbar--;
            }
        }
        return verfuegbar;
    }
}