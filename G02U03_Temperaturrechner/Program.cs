int eingabe;

do
{
    Console.WriteLine("1) Celsius -> Fahrenheit 2) Fahrenheit -> Celsius 3) Tabelle 0) End");
    eingabe = LeseInt("Auswahl treffen: ");

    switch (eingabe)
    {
        case 1:
            double Celsius = LeseDouble("Temperatur in Celsius eingeben:");
            Console.WriteLine($"{Celsius:F2}°C sind {CelsiusFahrenheit(Celsius):F2}°F");
            Console.WriteLine(new string('-', 45));
            break;
        case 2:
            double Fahrenheit = LeseDouble("Temperatur in Fahrenheit eingeben:");
            Console.WriteLine($"{Fahrenheit:F2}°F sind {FahrenheitCelsius(Fahrenheit):F2}°C");
            Console.WriteLine(new string('-', 45));
            break;
        case 3:
            ZeigeTabelle();
            break;
        case 0:
            Console.WriteLine("Programm wird beendet.");
            break;
        default:
            Console.WriteLine("Unbekannte Eingabe");
            break;
    }
} while (eingabe != 0);


double LeseDouble(string prompt)
{
    Console.Write(prompt);
    return double.Parse(Console.ReadLine() ?? "");
}

int LeseInt(string prompt)
{
    Console.Write(prompt);
    return int.Parse(Console.ReadLine() ?? "");
}

double CelsiusFahrenheit(double celsius)
{
    return celsius * 1.8 + 32;
}

double FahrenheitCelsius(double fahrenheit)
{
    return (fahrenheit - 32) / 1.8;
}

void ZeigeTabelle()
{
    Console.WriteLine($"{"°C", 5} {"°F", 7}");
    for (int Celsius = -20; Celsius <= 40; Celsius += 10)
    {
        double Fahrenheit = CelsiusFahrenheit(Celsius);
        Console.WriteLine($"{Celsius, 7:F2} {Fahrenheit, 7:F2}");
    }
    Console.WriteLine(new string('-', 45));
}