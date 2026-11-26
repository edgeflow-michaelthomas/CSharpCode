public class Rechteck
{
    private double _breite;
    private double _hoehe;

    // Property Breite. Ist public und prüft Änderungen auf seine Gültigkeit.
    public double Breite
    {
        get
        {
            return _breite;
        }
        
        set
        {
            if (value > 0)
            {
                _breite = value;
            }
            else
            {
                Console.WriteLine("Zahl muss größer 0 sein");
            }
        }
    }
    
    public double Hoehe
    {
        get
        {
            return _hoehe;
        }
        
        set
        {
            if (value > 0)
            {
                _hoehe = value;
            }
            else
            {
                Console.WriteLine("Zahl muss größer 0 sein");
            }
        }
    }

    public Rechteck(double breite, double hoehe)
    {
        if (breite <= 0)
        {
            throw new ArgumentException("Breite muss größer sein als 0!");
        }
        
        if (hoehe <= 0)
        {
            throw new ArgumentException("Höhe muss größer sein als 0!");
        }
        
        _breite = breite;
        _hoehe = hoehe;
    }

    public double Flaeche
    {
        get
        {
            return _breite * _hoehe;
        }
    }
    
    public double Umfang
    {
        get { return (_breite + _hoehe) * 2; }
    }

    public bool IstQuadrat
    {
        get { return _breite == _hoehe; }
    }

    public string Beschreibung
    {
        get
        {
            string form = IstQuadrat ? "Quadrat" : "Rechteck";
            return $"{form} {_breite} x {_hoehe}: Fläche {Flaeche}, Umfang {Umfang}";
        }
    }

    public Rechteck Skaliere(double faktor)
    {
        return new Rechteck(_breite * faktor, _hoehe * faktor);
    }
}