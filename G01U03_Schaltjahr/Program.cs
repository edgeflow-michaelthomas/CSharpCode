Console.Write("Jahr: ");
int year = int.Parse(Console.ReadLine() ?? "");

bool leapYear = year % 4 == 0 && year % 100 != 0 || year % 400 == 0;
    
if (leapYear)
{
    Console.WriteLine($"{year} ist ein Schaltjahr. Der Februar hat 29 Tage");
}
else
{
    Console.WriteLine($"{year} ist kein Schaltjahr. Der Februar hat 28 Tage");
}