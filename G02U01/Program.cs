int spalte = 0;
int zeile = 0;
 
Console.Write("Gib an, wie viele Spalten die Tabelle haben soll: ");
spalte = int.Parse(Console.ReadLine() ?? "");
 
Console.Write("Gib an, wie viele Zeilen die Tabelle haben soll: ");
zeile = int.Parse(Console.ReadLine() ?? "");
 
Console.WriteLine("");
 
Console.Write("     |");
for (int i = 1; i <= spalte; i++)
{
    Console.Write($"{i, 4}");
}
 
Console.WriteLine();
 
Console.WriteLine(new string('-', 6 + spalte * 4));
 
for (int i = 1; i <= zeile; i++)
{
    Console.Write($"{i, 4} |");
    for (int j = 1; j <= spalte; j++)
    {
        Console.Write($"{i * j, 4}");
    }
 
    Console.WriteLine();
}