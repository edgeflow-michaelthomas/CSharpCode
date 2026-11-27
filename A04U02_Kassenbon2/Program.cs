using System.Globalization;

Console.OutputEncoding = System.Text.Encoding.UTF8;

CultureInfo de = CultureInfo.GetCultureInfo("de-DE");
CultureInfo inv = CultureInfo.InvariantCulture;


string[] zeilen = ["Kaffee;2.50", "Croissant;1.80", "Wasser;0.99"];

decimal summe = 0.0m;

foreach (string zeile in zeilen)
{
    string[] teile = zeile.Split(';');
    decimal preis = decimal.Parse(teile[1], inv);
    summe += preis;
    Console.WriteLine($"{teile[0],-12}{preis.ToString("C", de), 10}");
}

Console.WriteLine(new String('-', 22));
Console.WriteLine($"{"Summe",-12}{summe.ToString("C", de), 10}");