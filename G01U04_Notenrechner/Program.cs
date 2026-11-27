Console.Write("Punkte (0 bis 100): ");
int score =  int.Parse(Console.ReadLine() ?? "");

if (score < 0 || score > 100)
{
    Console.WriteLine("Bitte einen Punktzahl von 0 bis 100 eingeben");
    return;
}

int grade = 6;

if (score >= 92)
{
    grade = 1;
} else if (score >= 81) {
    grade = 2;
} else if (score >= 67) {
    grade = 3;
} else if (score >= 50) {
    grade = 4;
} else if (score >= 30) {
    grade = 5;
} 

string text;

switch (grade)
{
    case 1: text = "sehr gut"; break;
    case 2: text = "gut"; break;
    case 3: text = "befriedigend"; break;
    case 4: text = "ausreichend"; break;
    case 5: text = "mangelhaft"; break;
    case 6: text = "ungenügend"; break;
    default: text = ""; break;
}

Console.WriteLine($"{score} Punkte: Note {grade} ({text})");
if (grade >= 5)
{
    Console.WriteLine("Leider nicht bestanden.");
}