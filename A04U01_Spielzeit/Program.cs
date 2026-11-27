const long SitzungMs = 3 * 60 * 60 * 1000;

long gesamtMs = 0;

for (int sitzung = 1; sitzung <= 250; sitzung++)
{
    try
    {
        gesamtMs = checked(gesamtMs + SitzungMs);
    }
    catch (OverflowException)
    {
        Console.WriteLine("Überlauf in " + sitzung + ".");
        break;
    }
    
    if (sitzung >= 196 && sitzung <= 202)
    {
        Console.WriteLine($"Sitzung {sitzung,3}: {gesamtMs,14:N0} ms");
    }
}

Console.WriteLine($"Gesamtdauer {gesamtMs:N0} ms");

int maxLoopsInt = int.MaxValue / (int)SitzungMs;
long maxLoops = long.MaxValue / SitzungMs;

Console.WriteLine($"Max Sitzungen Int:   {maxLoopsInt:N0}");
Console.WriteLine($"Max Sitzungen Long:  {maxLoops:N0}");


var SitzungsDauer = TimeSpan.FromHours(3);
var GesamtZeit = TimeSpan.Zero;

int AnzahlSitzungen = 20_000;

for (int Sitzung = 1; Sitzung <= AnzahlSitzungen; Sitzung++)
{
    GesamtZeit += SitzungsDauer;
}

Console.WriteLine($"Gesamtzeit: {GesamtZeit.TotalHours:N0} Stunden");
Console.WriteLine($"Gesamtzeit: {GesamtZeit.Days} Tage {GesamtZeit.Hours} Stunden");
Console.WriteLine($"{GesamtZeit.TotalMilliseconds:N0}");