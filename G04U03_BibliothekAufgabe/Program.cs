using G04U03_BibliothekAufgabe;

Bibliothek bibliothek = new Bibliothek();
Buch buch1 = new Buch("Der Hobbit", "J. R. R. Tolkien");
Buch buch2 = new Buch("Der Herr der Ringe", "J. R. R. Tolkien");
Buch buch3 = new Buch("Clean Code", "Robert C. Martin");
Buch buch4 = new Buch("Momo", "Michael Ende");
Buch buch5 = new Buch("Momo", "Michael Ende");

bibliothek.Hinzufügen(buch1);
bibliothek.Hinzufügen(buch2);
bibliothek.Hinzufügen(buch3);
bibliothek.Hinzufügen(buch4);
bibliothek.Hinzufügen(buch5);

// Erwartete Ausgabe:

// Verfügbar: 4 von 4
Console.WriteLine($"Verfügbar: {bibliothek.AnzahlVerfuegbar()} von {bibliothek.Anzahl}");

// Suche nach "tolkien":
Console.WriteLine("Suche nach \"tolkien\"");

// Der Hobbit (J. R. R. Tolkien) - verfügbar
// Der Herr der Ringe (J. R. R. Tolkien) - verfügbar
List<Buch> treffer = bibliothek.Suche("tolkien");
foreach (Buch buch in treffer)
{
    Console.WriteLine($"  {buch.Beschreibung()}");
}

// Ausleihen "momo": True
Console.WriteLine($"Ausleihen \"momo\": {bibliothek.Ausleihen("momo")}");

// Ausleihen "Momo" noch einmal: False
Console.WriteLine($"Ausleihen \"Momo\": {bibliothek.Ausleihen("Momo")}");

// Ausleihen "Faust": False
Console.WriteLine($"Ausleihen \"Faust\": {bibliothek.Ausleihen("Faust")}");

// Verfügbar: 3 von 4
Console.WriteLine($"Verfügbar: {bibliothek.AnzahlVerfuegbar()} von {bibliothek.Anzahl}");

// Bestand:
// Der Hobbit (J. R. R. Tolkien) - verfügbar
// Clean Code (Robert C. Martin) - verfügbar
// Der Herr der Ringe (J. R. R. Tolkien) - verfügbar
// Momo (Michael Ende) - ausgeliehen