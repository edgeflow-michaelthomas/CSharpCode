using LagerAufgabe;

Lager lager = new Lager();

var hammer = new Artikel("Hammer", 12.90m, 200);
var zange = new Artikel("Zange", 12.50m, 50);
var duebel = new Artikel("Dübel", 0.05m, 300);
var schraube = new Artikel("Schraube", 0.10m, 500);

lager.Hinzufuegen(hammer);
lager.Hinzufuegen(zange);
lager.Hinzufuegen(duebel);
lager.Hinzufuegen(schraube);

lager.Hinzufuegen(new Artikel("Hammer", 12.90m, 15));

Console.WriteLine($"Gesamtbestand vor Verkauf: {lager.Gesamtbestand}");
Console.WriteLine($"Lagerwert vor Verkauf: {lager.LagerWert}");
lager.Verkaufen("Hammer", 30);
Console.WriteLine($"Lagerwert vor Verkauf: {lager.LagerWert}");
