// Legen Sie in Program.cs eine List<Rechteck> mit drei Rechtecken an (4 × 2,5, 3 × 3 und 0,5 × 12) und geben Sie alle in einer Schleife aus:

List<Rechteck> rechtecke = new List<Rechteck>();
rechtecke.Add(new Rechteck(4, 2.5));
rechtecke.Add(new Rechteck(3, 3));
rechtecke.Add(new Rechteck(0.5, 12));

foreach (Rechteck item in rechtecke)
{
    Console.WriteLine($"{item.Beschreibung}");
    Console.WriteLine($"{item.Skaliere(2).Beschreibung}");
}

Rechteck r = new Rechteck(2 ,4);
Console.WriteLine(r.Umfang);