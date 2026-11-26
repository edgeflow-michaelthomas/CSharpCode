using System.Text;

public class Konto
{
    private static int _naechsteNummer = 1001;
    
    public string Inhaber { get; }
    public int Nummer { get; }
    public decimal Stand { get; private set; }

    private List<string> _buchung = new List<string>();
    
    public Konto(string inhaber)
    {
        if (string.IsNullOrWhiteSpace(inhaber))
        {
            throw new ArgumentNullException("Inhaber darf nicht leer sein");
        }
        Inhaber = inhaber;
        Nummer = _naechsteNummer;
        _naechsteNummer++;
        Stand = 0m;
    }

    public void Einzahlen(decimal betrag)
    {
        if (betrag <= 0)
        {
            throw new ArgumentException("Betrag darf nicht negativ sein");
        }
        else
        {
            Stand += betrag;
            _buchung.Add($"Einzahlung {betrag} €");
        }
    }

    public bool Abheben(decimal betrag)
    {
        if (betrag <= 0)
        {
            throw new ArgumentException("Betrag darf nicht negativ sein");
        }

        if (betrag <= Stand)
        {
            Stand -= betrag;
            _buchung.Add($"Auszahlung -{betrag} €");
            return true;
        }
        else
        {
            _buchung.Add($"Abgelehnt {betrag} €");
            return false;
        }
        
    }

    public bool Ueberweise(Konto ziel, decimal betrag)
    {
        if (ziel == null)
        {
            throw new ArgumentNullException(nameof(ziel));
        }

        if (Abheben(betrag))
        {
            ziel.Einzahlen(betrag);
            return true;
        }
        
        return false;
    }

    public string Kontoauszug()
    {
        var sb = new StringBuilder();

        sb.AppendLine($"Kontonummer {Nummer} ({Inhaber})");

        foreach (string buchung in _buchung)
        {
            sb.AppendLine(buchung);
        }
        sb.AppendLine($"Stand {Stand} €");
        return sb.ToString();
    }
}