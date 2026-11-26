# Lagerverwaltung

Betrachten Sie den Code aus der Vorgabe und überlegen Sie, wie Sie ihn geeignet objektorientiert umbauen können:

```cs
var namen = new List<string>();
var preise = new List<decimal>();
var bestaende = new List<int>();

Anlegen(namen, preise, bestaende, "Schraube", 0.10m, 500);
Anlegen(namen, preise, bestaende, "Dübel", 0.05m, 300);
Anlegen(namen, preise, bestaende, "Hammer", 12.90m, 4);
Verkaufen(namen, bestaende, "Hammer", 2);

bestaende[2] -= 10;
namen.RemoveAt(0);

Console.WriteLine($"{namen[0]}: {preise[0]} €");
Console.WriteLine($"Bestand: {bestaende[0]}");
Console.WriteLine(Lagerwert(preise, bestaende));

void Anlegen(List<string> namensListe, List<decimal> preiseListe, List<int> bestaendeList, string name, decimal preis, int bestand)
{
    namensListe.Add(name);
    preiseListe.Add(preis);
    bestaende.Add(bestand);
}

void Verkaufen(List<string> namensList, List<int> bestandsListe, string name, int anzahl)
{
    for (int i = 0; i < namensList.Count; i++)
    {
        if (namensList[i] == name)
        {
            bestandsListe[i] -= anzahl;
        }
    }
}

decimal Lagerwert(List<decimal> preisListe, List<int> bestandsListe)
{
    decimal summe = 0m;
    
    for(int i = 0; i < preisListe.Count; i++)
    {
        summe += preisListe[i] * bestandsListe[i];
    }

    return summe;
}
```

## Klassen

Wie eben besprochen, brauchen Sie zwei Klassen:

1. Artikel: Repräsentiert den Artikel mit seinen Eigenschaften "Name", "Preis" und "Bestand". Nutzen Sie Properties und wählen Sie geeignete Datentypen. (siehe Vorgabe)
2. Lager: Repräsentiert den gesamten Bestand an Artikeln. Speichern Sie die Artikel in einer Liste und stellen Sie Methoden zum Hinzufügen von Artikeln und Verkaufen bereit, und eine Methode zum berechnen des gesamten Lagerwerts. Sie dürfen für den Lagerwert auch eine berechnete Property benutzen. 

Testen Sie Ihren Code mit geeigneten Werten, um auch Randfälle und Fehlerfälle zu testen. 

Erstellen Sie die Klassen in getrennten Dateien.