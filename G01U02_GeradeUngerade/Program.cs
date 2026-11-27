Console.Write("Zahl: ");
int num = int.Parse(Console.ReadLine() ?? "");

if (num % 2 == 0)
{
    Console.WriteLine($"{num} ist gerade.");
}
else
{
    Console.WriteLine($"{num} ist ungerade.");
}