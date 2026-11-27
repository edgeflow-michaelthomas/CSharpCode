Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal Einzelpreis = 0.1m;
decimal Summe = 0.0m;

for (int i = 0; i < 10; i++)
{
    Summe += Einzelpreis;
}

Console.WriteLine($"Summe:     {Summe:F2} €");

decimal Rabatt = 0m;

if (Summe >= 1.0m)
{
    Rabatt = Math.Round(Summe * 0.05m, 2);
    Console.WriteLine("5% Rabatt");
}
else
{
    Console.WriteLine("Kein Rabatt");
}

decimal Endbetrag = Summe - Rabatt;

Console.WriteLine($"Rabatt:    {Rabatt:F2} €");
Console.WriteLine($"Endbetrag: {Endbetrag:F2} €");