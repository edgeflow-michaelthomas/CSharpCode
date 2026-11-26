using SpielerAufgabe;

Spieler spieler1 = new Spieler("Tom", 5);
Console.WriteLine(spieler1.Beschreibung());

Spieler spieler2 = new Spieler("Tom", 5);
Console.WriteLine(spieler2.Beschreibung());


Team team = new Team("Bayern");
team.SpielerHinzufügen("Kim");
team.SpielerHinzufügen("Sam");
team.SpielerHinzufügen("Tom");
team.SpielerHinzufügen(spieler1);
team.SpielerHinzufügen(spieler2);

spieler1.Gewinne(5);

Console.WriteLine(team.Punkte);