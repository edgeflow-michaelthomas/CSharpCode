Console.Write("Name: ");
string name = Console.ReadLine() ?? "";
Console.Write("Alter: ");
int age = int.Parse(Console.ReadLine() ?? "");
Console.Write("Größe in Metern: ");
double height = double.Parse(Console.ReadLine() ?? "");
Console.Write("Lieblingsbuchstabe: ");
char letter =  char.Parse(Console.ReadLine() ?? "");

Console.WriteLine("\n=== Steckbrief ===");
Console.WriteLine($"Name: {name}");
Console.WriteLine($"Alter: {age}");
Console.WriteLine($"Größe: {height}");
Console.WriteLine($"Buchstabe: {letter}");
Console.WriteLine($"Volljährig: {age >= 18}");