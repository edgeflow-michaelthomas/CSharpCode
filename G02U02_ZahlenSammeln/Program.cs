var zahlen = new List<int>();

int zahl;

do
{
    Console.Write("Zahl (0 = fertig): ");
    zahl = int.Parse(Console.ReadLine() ?? "");

    if (zahl != 0)
    {
        zahlen.Add(zahl);
    } 
        
} while(zahl != 0);

if (zahlen.Count == 0)
{
    Console.WriteLine("Keine Zahl eingegeben");
}
else
{
    Console.WriteLine($"Anzahl: {zahlen.Count}");
    Console.WriteLine($"Summe: {Summe(zahlen)}");
    Console.WriteLine($"Minimum: {Minimum(zahlen)}");
    Console.WriteLine($"Maximum: {Maximum(zahlen)}");
    Console.WriteLine($"Durchschnitt: {Durchschnitt(zahlen):F2}");
}


int Summe(List<int> werte)
{
    var summe = 0;
    foreach (var w in werte )
    {
        summe += w;
    }

    return summe;
}

int Minimum(List<int> werte)
{
    var min = werte[0];
    foreach (var w in werte)
    {
        if (w < min)
        {
            min = w;
        }
    }
    return min;
}

int Maximum(List<int> werte)
{
    var max = int.MinValue;
    foreach (var w in werte) if (w > max) max = w;
    return max;
}

double Durchschnitt(List<int> werte)
{
    return (double)Summe(werte) / werte.Count;
}