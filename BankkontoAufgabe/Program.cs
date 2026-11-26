Console.OutputEncoding = System.Text.Encoding.UTF8;

var kim = new Konto("Kim");
var sam = new Konto("Sam");
kim.Einzahlen(500);
kim.Abheben(120.50m);
bool geklappt = kim.Abheben(1000);
Console.WriteLine($"Abheben von 1000 möglich? {geklappt}");
kim.Ueberweise(sam, 100);  // Zusatzaufgabe
Console.WriteLine(kim.Kontoauszug());
Console.WriteLine(sam.Kontoauszug());


// Erwartet:
// Abheben von 1000 möglich? False
// Konto 1001 (Kim)
// Einzahlung 500,00 €
// Auszahlung -120,50 €
// abgelehnt 1.000,00 €
// Auszahlung -100,00 €
// Stand 279,50 €

// Konto 1002 (Sam)
// Einzahlung 100,00 €
// Stand 100,00 €